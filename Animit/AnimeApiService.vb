Imports System.Net.Http
Imports System.Text.Json.Nodes
Imports System.Linq

Friend Class AnimeApiService
    Private ReadOnly _baseUrl As String
    Private ReadOnly _apiClient As HttpClient

    Public Sub New(baseUrl As String, apiClient As HttpClient)
        _baseUrl = If(baseUrl, String.Empty).TrimEnd("/"c)
        _apiClient = apiClient
    End Sub

    Public Async Function FetchAnimeListAsync(query As String, navLabel As String, Optional feedMaxPages As Integer = 12, Optional searchMaxPages As Integer = 4) As Task(Of List(Of AnimeCardItem))
        Dim isSearch As Boolean = Not String.IsNullOrWhiteSpace(query)
        Dim result As New List(Of AnimeCardItem)()
        Dim seenItems As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
        Dim seenPageSignatures As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
        Dim maxPages As Integer = If(isSearch, searchMaxPages, feedMaxPages)

        For page As Integer = 1 To Math.Max(1, maxPages)
            Dim requestUrl As String = BuildAnimeListRequestUrl(query, navLabel, page)
            Dim response As String = Await _apiClient.GetStringAsync(requestUrl)
            Dim root As JsonNode = JsonNode.Parse(response)
            Dim dataNode As JsonNode = root?("data")
            If dataNode Is Nothing Then
                Exit For
            End If

            Dim listNode As JsonNode = If(isSearch, dataNode("results"), dataNode("animeList"))
            Dim animeArray As JsonArray = TryCast(listNode, JsonArray)
            If animeArray Is Nothing OrElse animeArray.Count = 0 Then
                Exit For
            End If

            Dim pageItems As New List(Of AnimeCardItem)()
            For Each itemNode As JsonNode In animeArray
                If itemNode Is Nothing Then
                    Continue For
                End If

                Dim item As New AnimeCardItem With {
                    .Title = ReadString(itemNode, "title"),
                    .Slug = ReadString(itemNode, "slug"),
                    .Url = ReadString(itemNode, "url"),
                    .Thumbnail = ReadString(itemNode, "thumbnail"),
                    .Episode = ReadString(itemNode, "episode"),
                    .Type = ReadString(itemNode, "type"),
                    .Score = ReadString(itemNode, "score")
                }

                If String.IsNullOrWhiteSpace(item.Title) Then
                    Continue For
                End If

                Dim itemKey As String = BuildDashboardItemKey(item)
                If seenItems.Add(itemKey) Then
                    pageItems.Add(item)
                End If
            Next

            If pageItems.Count = 0 Then
                Exit For
            End If

            result.AddRange(pageItems)

            Dim pageSignature As String = BuildDashboardPageSignature(pageItems)
            If Not seenPageSignatures.Add(pageSignature) Then
                Exit For
            End If

            Dim hasNextPage As Boolean = ReadBoolean(dataNode, "hasNextPage")
            If isSearch AndAlso Not hasNextPage Then
                Exit For
            End If
        Next

        Return result
    End Function

    Public Async Function FetchAnimeDetailAsync(slug As String) As Task(Of AnimeDetailItem)
        If String.IsNullOrWhiteSpace(slug) Then
            Return Nothing
        End If

        Dim response As String = Await _apiClient.GetStringAsync($"{_baseUrl}/api/anime/{Uri.EscapeDataString(slug)}")
        Dim root As JsonNode = JsonNode.Parse(response)
        Dim dataNode As JsonNode = root?("data")
        If dataNode Is Nothing Then
            Return Nothing
        End If

        Dim detail As New AnimeDetailItem With {
            .Title = ReadString(dataNode, "title"),
            .Synopsis = ReadString(dataNode, "synopsis"),
            .Thumbnail = ReadString(dataNode, "thumbnail"),
            .Url = ReadString(dataNode, "url")
        }

        Dim episodesArray As JsonArray = TryCast(dataNode("episodes"), JsonArray)
        If episodesArray IsNot Nothing Then
            For Each episodeNode As JsonNode In episodesArray
                If episodeNode Is Nothing Then
                    Continue For
                End If

                Dim episode As New EpisodeItem With {
                    .Number = ReadString(episodeNode, "number"),
                    .Title = ReadString(episodeNode, "title"),
                    .Slug = ReadString(episodeNode, "slug"),
                    .Url = ReadString(episodeNode, "url"),
                    .EpisodeDate = ReadString(episodeNode, "date")
                }

                If String.IsNullOrWhiteSpace(episode.Title) AndAlso Not String.IsNullOrWhiteSpace(episode.Number) Then
                    episode.Title = $"Episode {episode.Number}"
                End If

                If Not String.IsNullOrWhiteSpace(episode.Slug) Then
                    detail.Episodes.Add(episode)
                End If
            Next
        End If

        Return detail
    End Function

    Public Async Function FetchEpisodeDetailAsync(slug As String) As Task(Of EpisodeDetailItem)
        If String.IsNullOrWhiteSpace(slug) Then
            Return Nothing
        End If

        Dim response As String = Await _apiClient.GetStringAsync($"{_baseUrl}/api/episode/{Uri.EscapeDataString(slug)}")
        Dim root As JsonNode = JsonNode.Parse(response)
        Dim dataNode As JsonNode = root?("data")
        If dataNode Is Nothing Then
            Return Nothing
        End If

        Dim detail As New EpisodeDetailItem With {
            .Title = ReadString(dataNode, "title"),
            .EpisodeNumber = ReadString(dataNode, "episodeNumber"),
            .ReleaseDate = ReadString(dataNode, "releaseDate"),
            .Url = ReadString(dataNode, "url")
        }

        Dim serverChoices As New List(Of ServerChoice)()
        Dim serversArray As JsonArray = TryCast(dataNode("servers"), JsonArray)
        If serversArray IsNot Nothing Then
            For Each serverNode As JsonNode In serversArray
                If serverNode Is Nothing Then
                    Continue For
                End If

                Dim qualityLabel As String = ReadString(serverNode, "quality")
                Dim qualityRank As Integer = ExtractQualityRank(qualityLabel)
                Dim optionsArray As JsonArray = TryCast(serverNode("options"), JsonArray)
                If optionsArray Is Nothing Then
                    Continue For
                End If

                For Each optionNode As JsonNode In optionsArray
                    If optionNode Is Nothing OrElse Not ReadBoolean(optionNode, "playable") Then
                        Continue For
                    End If

                    Dim autoplayUrl As String = ReadString(optionNode, "autoplayUrl")
                    Dim embedUrl As String = ReadString(optionNode, "embedUrl")
                    Dim serverName As String = ReadString(optionNode, "name")

                    Dim playUrl As String = If(Not String.IsNullOrWhiteSpace(autoplayUrl), autoplayUrl, embedUrl)
                    If String.IsNullOrWhiteSpace(playUrl) Then
                        Continue For
                    End If

                    serverChoices.Add(New ServerChoice With {
                        .Label = $"{If(String.IsNullOrWhiteSpace(qualityLabel), "Auto", qualityLabel)} - {If(String.IsNullOrWhiteSpace(serverName), "Server", serverName)}",
                        .AutoplayUrl = playUrl,
                        .EpisodePageUrl = If(String.IsNullOrWhiteSpace(detail.Url), playUrl, detail.Url),
                        .QualityRank = qualityRank
                    })
                Next
            Next
        End If

        detail.ServerChoices = serverChoices.OrderByDescending(Function(s) s.QualityRank).ThenBy(Function(s) s.Label).ToList()
        detail.HighestQualityLabel = detail.ServerChoices.FirstOrDefault()?.Label
        Return detail
    End Function

    Private Function BuildAnimeListRequestUrl(query As String, navLabel As String, page As Integer) As String
        Dim safePage As Integer = Math.Max(1, page)
        If Not String.IsNullOrWhiteSpace(query) Then
            Return $"{_baseUrl}/api/search?q={Uri.EscapeDataString(query)}&page={safePage}"
        End If

        Select Case navLabel
            Case "Simulcasts"
                Return $"{_baseUrl}/api/ongoing?page={safePage}"
            Case "Movies"
                Return $"{_baseUrl}/api/anime-list?page={safePage}"
            Case Else
                Return $"{_baseUrl}/api/home?page={safePage}"
        End Select
    End Function

    Private Shared Function BuildDashboardItemKey(item As AnimeCardItem) As String
        Dim primary As String = item?.Slug
        If String.IsNullOrWhiteSpace(primary) Then
            primary = item?.Url
        End If
        If String.IsNullOrWhiteSpace(primary) Then
            primary = item?.Title
        End If

        Return $"{primary?.Trim().ToLowerInvariant()}::{item?.Episode?.Trim().ToLowerInvariant()}::{item?.Type?.Trim().ToLowerInvariant()}"
    End Function

    Private Shared Function BuildDashboardPageSignature(items As List(Of AnimeCardItem)) As String
        If items Is Nothing OrElse items.Count = 0 Then
            Return String.Empty
        End If

        Dim parts As List(Of String) = items.Take(6).Select(Function(x) BuildDashboardItemKey(x)).ToList()
        Return $"{String.Join("|", parts)}#n{items.Count}"
    End Function

    Private Shared Function ReadString(node As JsonNode, key As String) As String
        If node Is Nothing Then
            Return String.Empty
        End If

        Dim valueNode As JsonNode = node(key)
        If valueNode Is Nothing Then
            Return String.Empty
        End If

        Return valueNode.ToString().Trim()
    End Function

    Private Shared Function ReadBoolean(node As JsonNode, key As String) As Boolean
        Dim valueNode As JsonNode = node(key)
        If valueNode Is Nothing Then
            Return False
        End If

        Dim raw As String = valueNode.ToString().Trim()
        Dim boolValue As Boolean
        If Boolean.TryParse(raw, boolValue) Then
            Return boolValue
        End If

        Return String.Equals(raw, "1", StringComparison.OrdinalIgnoreCase)
    End Function

    Private Shared Function ExtractQualityRank(value As String) As Integer
        If String.IsNullOrWhiteSpace(value) Then
            Return 0
        End If

        Dim digits As String = New String(value.Where(AddressOf Char.IsDigit).ToArray())
        Dim rank As Integer
        If Integer.TryParse(digits, rank) Then
            Return rank
        End If

        Return 0
    End Function
End Class
