Imports System.Net.Http
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.Json
Imports System.Text.Json.Nodes
Imports System.Linq

Friend NotInheritable Class FirebaseRealtimeDbClient
    Private Const DefaultDatabaseUrl As String = "https://animit-progdesk-default-rtdb.asia-southeast1.firebasedatabase.app"
    Private Const DatabaseUrlEnv As String = "ANIMIT_FIREBASE_DB_URL"
    Private Const DatabaseKeyEnv As String = "ANIMIT_FIREBASE_DB_KEY"

    Private Shared ReadOnly SharedHttp As New HttpClient()
    Private Shared _sharedInstance As FirebaseRealtimeDbClient

    Private ReadOnly _databaseUrl As String
    Private ReadOnly _databaseKey As String
    Private ReadOnly _jsonOptions As JsonSerializerOptions

    Private Sub New(databaseUrl As String, databaseKey As String)
        _databaseUrl = databaseUrl.Trim().TrimEnd("/"c)
        _databaseKey = databaseKey.Trim()
        _jsonOptions = New JsonSerializerOptions With {
            .PropertyNameCaseInsensitive = True
        }
    End Sub

    Public Shared Function TryGetSharedClient(ByRef client As FirebaseRealtimeDbClient, ByRef errorMessage As String) As Boolean
        If _sharedInstance IsNot Nothing Then
            client = _sharedInstance
            Return True
        End If

        Dim databaseUrl As String = ReadEnvValue(DatabaseUrlEnv)
        If String.IsNullOrWhiteSpace(databaseUrl) Then
            databaseUrl = DefaultDatabaseUrl
        End If

        Dim databaseKey As String = ReadEnvValue(DatabaseKeyEnv)
        If String.IsNullOrWhiteSpace(databaseKey) Then
            errorMessage = $"Firebase key belum diisi. Set environment variable {DatabaseKeyEnv} terlebih dulu."
            Return False
        End If

        _sharedInstance = New FirebaseRealtimeDbClient(databaseUrl, databaseKey)
        client = _sharedInstance
        Return True
    End Function

    Public Shared Function ComputePasswordHash(value As String) As String
        Dim raw As String = If(value, String.Empty)
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(raw)
        Dim hash As Byte() = SHA256.HashData(bytes)
        Return Convert.ToHexString(hash).ToLowerInvariant()
    End Function

    Public Shared Function CreateHardwareId() As String
        Dim rawMachineData As String = $"{Environment.MachineName}|{Environment.UserName}|{Environment.OSVersion.VersionString}"
        Dim hash As String = ComputePasswordHash(rawMachineData)
        Return hash.Substring(0, 24)
    End Function

    Public Async Function AuthenticateAsync(credential As String, plainPassword As String, currentHwid As String) As Task(Of FirebaseAuthResult)
        Dim users As JsonObject = Await GetUsersObjectAsync()
        If users.Count = 0 Then
            Return Nothing
        End If

        Dim passwordHash As String = ComputePasswordHash(plainPassword)

        For Each userEntry In users
            If userEntry.Value Is Nothing Then
                Continue For
            End If

            Dim userDoc As FirebaseUserDocument = DeserializeUser(userEntry.Value)
            If userDoc?.profile Is Nothing Then
                Continue For
            End If

            Dim identityMatched As Boolean =
                String.Equals(userDoc.profile.email, credential, StringComparison.OrdinalIgnoreCase) OrElse
                String.Equals(userDoc.profile.username, credential, StringComparison.OrdinalIgnoreCase)

            If Not identityMatched Then
                Continue For
            End If

            If Not String.Equals(userDoc.profile.password_hash, passwordHash, StringComparison.OrdinalIgnoreCase) Then
                Return Nothing
            End If

            If Not String.IsNullOrWhiteSpace(userDoc.profile.hwid) AndAlso
               Not String.Equals(userDoc.profile.hwid, currentHwid, StringComparison.OrdinalIgnoreCase) Then
                Throw New InvalidOperationException("Akun ini tidak terdaftar untuk perangkat ini. Hubungi admin jika ingin ganti perangkat.")
            End If

            Return New FirebaseAuthResult With {
                .UserId = userEntry.Key,
                .Username = userDoc.profile.username,
                .Email = userDoc.profile.email
            }
        Next

        Return Nothing
    End Function

    Public Async Function RegisterUserAsync(username As String, email As String, plainPassword As String, hwid As String, Optional bio As String = "Anime lover") As Task(Of String)
        Dim users As JsonObject = Await GetUsersObjectAsync()

        For Each userEntry In users
            If userEntry.Value Is Nothing Then
                Continue For
            End If

            Dim userDoc As FirebaseUserDocument = DeserializeUser(userEntry.Value)
            If userDoc?.profile Is Nothing Then
                Continue For
            End If

            If String.Equals(userDoc.profile.username, username, StringComparison.OrdinalIgnoreCase) Then
                Throw New InvalidOperationException("Username sudah dipakai.")
            End If

            If String.Equals(userDoc.profile.email, email, StringComparison.OrdinalIgnoreCase) Then
                Throw New InvalidOperationException("Email sudah terdaftar.")
            End If
        Next

        Dim userId As String = $"user_id_{Guid.NewGuid():N}"
        Dim newUser As New FirebaseUserDocument With {
            .profile = New FirebaseProfile With {
                .username = username,
                .email = email,
                .password_hash = ComputePasswordHash(plainPassword),
                .hwid = hwid,
                .bio = bio,
                .badges = New List(Of String)()
            },
            .limit_tracker = New FirebaseLimitTracker With {
                .daily_limit_minutes = 120,
                .last_watch_date = DateTime.UtcNow.ToString("yyyy-MM-dd"),
                .minutes_watched_today = 0,
                .compliance_score = 100.0
            }
        }

        Await PutNodeAsync($"users/{userId}", newUser)
        Return userId
    End Function

    Public Async Function GetUserProfileAsync(userId As String) As Task(Of FirebaseProfile)
        If String.IsNullOrWhiteSpace(userId) Then
            Return Nothing
        End If

        Dim node As JsonNode = Await GetNodeAsync($"users/{userId}/profile")
        If node Is Nothing Then
            Return Nothing
        End If

        Try
            Return JsonSerializer.Deserialize(Of FirebaseProfile)(node.ToJsonString(), _jsonOptions)
        Catch ex As JsonException
            Throw New InvalidOperationException("Format profil user di Firebase tidak valid.", ex)
        End Try
    End Function

    Public Async Function FindUserByUsernameAsync(username As String) As Task(Of FirebaseAuthResult)
        Dim lookup As String = If(username, String.Empty).Trim()
        If String.IsNullOrWhiteSpace(lookup) Then
            Return Nothing
        End If

        Dim users As JsonObject = Await GetUsersObjectAsync()
        For Each userEntry In users
            If userEntry.Value Is Nothing Then
                Continue For
            End If

            Dim userDoc As FirebaseUserDocument = DeserializeUser(userEntry.Value)
            If userDoc?.profile Is Nothing Then
                Continue For
            End If

            If String.Equals(userDoc.profile.username, lookup, StringComparison.OrdinalIgnoreCase) Then
                Return New FirebaseAuthResult With {
                    .UserId = userEntry.Key,
                    .Username = userDoc.profile.username,
                    .Email = userDoc.profile.email
                }
            End If
        Next

        Return Nothing
    End Function

    Public Async Function UpdateUserAvatarAsync(userId As String, avatarUrl As String) As Task
        If String.IsNullOrWhiteSpace(userId) Then
            Throw New InvalidOperationException("User ID tidak valid.")
        End If
        Await PutNodeAsync($"users/{userId}/profile/avatar_url", If(avatarUrl, String.Empty).Trim())
    End Function

    Public Async Function UpdateUserProfileAsync(userId As String, username As String, bio As String) As Task
        Dim targetUserId As String = If(userId, String.Empty).Trim()
        Dim targetUsername As String = If(username, String.Empty).Trim()

        If String.IsNullOrWhiteSpace(targetUserId) Then
            Throw New InvalidOperationException("User ID tidak valid.")
        End If

        If String.IsNullOrWhiteSpace(targetUsername) Then
            Throw New InvalidOperationException("Username tidak boleh kosong.")
        End If

        Dim users As JsonObject = Await GetUsersObjectAsync()
        Dim userFound As Boolean = False

        For Each userEntry In users
            If userEntry.Value Is Nothing Then
                Continue For
            End If

            Dim userDoc As FirebaseUserDocument = DeserializeUser(userEntry.Value)
            If userDoc?.profile Is Nothing Then
                Continue For
            End If

            If String.Equals(userEntry.Key, targetUserId, StringComparison.OrdinalIgnoreCase) Then
                userFound = True
                Continue For
            End If

            If String.Equals(userDoc.profile.username, targetUsername, StringComparison.OrdinalIgnoreCase) Then
                Throw New InvalidOperationException("Username sudah dipakai user lain.")
            End If
        Next

        If Not userFound Then
            Throw New InvalidOperationException("User tidak ditemukan.")
        End If

        Await PutNodeAsync($"users/{targetUserId}/profile/username", targetUsername)
        Await PutNodeAsync($"users/{targetUserId}/profile/bio", If(bio, String.Empty).Trim())
    End Function

    Public Async Function GetRecentMessagesAsync(Optional maxItems As Integer = 20) As Task(Of List(Of FirebaseChatMessagePreview))
        Dim result As New List(Of FirebaseChatMessagePreview)()
        Dim chatsNode As JsonNode = Await GetNodeAsync("social/chats")
        Dim chatsObject As JsonObject = TryCast(chatsNode, JsonObject)
        If chatsObject Is Nothing Then
            Return result
        End If

        For Each room In chatsObject
            Dim roomId As String = room.Key
            Dim messagesObject As JsonObject = TryCast(room.Value?("messages"), JsonObject)
            If messagesObject Is Nothing Then
                Continue For
            End If

            For Each messageEntry In messagesObject
                Dim messageObj As JsonObject = TryCast(messageEntry.Value, JsonObject)
                If messageObj Is Nothing Then
                    Continue For
                End If

                Dim preview As New FirebaseChatMessagePreview With {
                    .MessageId = messageEntry.Key,
                    .RoomId = roomId,
                    .Sender = If(messageObj("sender")?.ToString(), messageObj("username")?.ToString()),
                    .SenderUserId = messageObj("sender_user_id")?.ToString(),
                    .Text = messageObj("text")?.ToString(),
                    .Timestamp = ParseLong(messageObj("timestamp"))
                }
                result.Add(preview)
            Next
        Next

        Return result.OrderByDescending(Function(m) m.Timestamp).Take(Math.Max(1, maxItems)).ToList()
    End Function

    Public Async Function GetChatMessagesByRoomAsync(roomId As String, Optional maxItems As Integer = 30) As Task(Of List(Of FirebaseChatMessagePreview))
        Dim result As New List(Of FirebaseChatMessagePreview)()
        If String.IsNullOrWhiteSpace(roomId) Then
            Return result
        End If

        Dim messagesNode As JsonNode = Await GetNodeAsync($"social/chats/{roomId}/messages")
        Dim messagesObject As JsonObject = TryCast(messagesNode, JsonObject)
        If messagesObject Is Nothing Then
            Return result
        End If

        For Each messageEntry In messagesObject
            Dim messageObj As JsonObject = TryCast(messageEntry.Value, JsonObject)
            If messageObj Is Nothing Then
                Continue For
            End If

            Dim preview As New FirebaseChatMessagePreview With {
                .MessageId = messageEntry.Key,
                .RoomId = roomId,
                .Sender = If(messageObj("sender")?.ToString(), messageObj("username")?.ToString()),
                .SenderUserId = messageObj("sender_user_id")?.ToString(),
                .Text = messageObj("text")?.ToString(),
                .Timestamp = ParseLong(messageObj("timestamp"))
            }
            result.Add(preview)
        Next

        Return result.
            OrderByDescending(Function(m) m.Timestamp).
            Take(Math.Max(1, maxItems)).
            OrderBy(Function(m) m.Timestamp).
            ToList()
    End Function

    Public Async Function SendChatMessageAsync(roomId As String, sender As String, text As String, Optional senderUserId As String = "") As Task(Of String)
        If String.IsNullOrWhiteSpace(roomId) Then
            Throw New InvalidOperationException("Room ID chat tidak boleh kosong.")
        End If

        Dim cleanText As String = If(text, String.Empty).Trim()
        If String.IsNullOrWhiteSpace(cleanText) Then
            Throw New InvalidOperationException("Pesan chat tidak boleh kosong.")
        End If

        Dim messageId As String = $"msg_{Guid.NewGuid():N}"
        Dim payload As New JsonObject From {
            {"sender", If(String.IsNullOrWhiteSpace(sender), "guest", sender)},
            {"sender_user_id", If(senderUserId, String.Empty)},
            {"text", cleanText},
            {"timestamp", DateTimeOffset.UtcNow.ToUnixTimeSeconds()}
        }

        Await PutNodeAsync($"social/chats/{roomId}/messages/{messageId}", payload)
        Return messageId
    End Function

    Public Async Function FollowUserByUsernameAsync(followerUserId As String, targetUsername As String) As Task(Of FirebaseFollowEntry)
        Dim sourceUserId As String = If(followerUserId, String.Empty).Trim()
        If String.IsNullOrWhiteSpace(sourceUserId) Then
            Throw New InvalidOperationException("User ID follower tidak valid.")
        End If

        Dim targetUser As FirebaseAuthResult = Await FindUserByUsernameAsync(targetUsername)
        If targetUser Is Nothing Then
            Throw New InvalidOperationException("User tujuan tidak ditemukan.")
        End If

        If String.Equals(sourceUserId, targetUser.UserId, StringComparison.OrdinalIgnoreCase) Then
            Throw New InvalidOperationException("Tidak bisa follow diri sendiri.")
        End If

        Dim relationship As String = "following"
        Dim reverseNode As JsonNode = Await GetNodeAsync($"social/follows/{targetUser.UserId}/{sourceUserId}")
        If reverseNode IsNot Nothing Then
            relationship = "mutual"
        End If

        Await PutNodeAsync($"social/follows/{sourceUserId}/{targetUser.UserId}", relationship)
        If relationship = "mutual" Then
            Await PutNodeAsync($"social/follows/{targetUser.UserId}/{sourceUserId}", "mutual")
        End If

        Return New FirebaseFollowEntry With {
            .UserId = targetUser.UserId,
            .Username = targetUser.Username,
            .Relationship = relationship
        }
    End Function

    Public Async Function GetFollowingAsync(userId As String) As Task(Of List(Of FirebaseFollowEntry))
        Dim result As New List(Of FirebaseFollowEntry)()
        Dim sourceUserId As String = If(userId, String.Empty).Trim()
        If String.IsNullOrWhiteSpace(sourceUserId) Then
            Return result
        End If

        Dim followsNode As JsonNode = Await GetNodeAsync($"social/follows/{sourceUserId}")
        Dim followsObject As JsonObject = TryCast(followsNode, JsonObject)
        If followsObject Is Nothing Then
            Return result
        End If

        For Each followRow In followsObject
            Dim targetUserId As String = followRow.Key
            Dim relationship As String = If(followRow.Value?.ToString(), "following")
            Dim profile As FirebaseProfile = Await GetUserProfileAsync(targetUserId)

            result.Add(New FirebaseFollowEntry With {
                .UserId = targetUserId,
                .Username = If(profile?.username, targetUserId),
                .Relationship = relationship
            })
        Next

        Return result.OrderBy(Function(f) f.Username).ToList()
    End Function

    Public Async Function SendDirectMessageByUsernameAsync(senderUserId As String, senderUsername As String, targetUsername As String, text As String) As Task(Of String)
        Dim sourceUserId As String = If(senderUserId, String.Empty).Trim()
        If String.IsNullOrWhiteSpace(sourceUserId) Then
            Throw New InvalidOperationException("User ID pengirim tidak valid.")
        End If

        Dim targetUser As FirebaseAuthResult = Await FindUserByUsernameAsync(targetUsername)
        If targetUser Is Nothing Then
            Throw New InvalidOperationException("User tujuan tidak ditemukan.")
        End If

        If String.Equals(sourceUserId, targetUser.UserId, StringComparison.OrdinalIgnoreCase) Then
            Throw New InvalidOperationException("Tidak bisa kirim pesan ke diri sendiri.")
        End If

        Dim roomId As String = BuildDirectRoomId(sourceUserId, targetUser.UserId)
        Await SendChatMessageAsync(roomId, senderUsername, text, sourceUserId)
        Return roomId
    End Function

    Public Async Function GetDirectMessagesByUsernameAsync(sourceUserId As String, targetUsername As String, Optional maxItems As Integer = 50) As Task(Of List(Of FirebaseChatMessagePreview))
        Dim result As New List(Of FirebaseChatMessagePreview)()
        Dim currentUserId As String = If(sourceUserId, String.Empty).Trim()
        If String.IsNullOrWhiteSpace(currentUserId) Then
            Return result
        End If

        Dim targetUser As FirebaseAuthResult = Await FindUserByUsernameAsync(targetUsername)
        If targetUser Is Nothing Then
            Return result
        End If

        Dim roomId As String = BuildDirectRoomId(currentUserId, targetUser.UserId)
        Return Await GetChatMessagesByRoomAsync(roomId, maxItems)
    End Function

    Public Async Function GetLeaderboardEntriesAsync(Optional maxItems As Integer = 20) As Task(Of List(Of FirebaseLeaderboardEntry))
        Dim result As New List(Of FirebaseLeaderboardEntry)()
        Dim leaderboardsNode As JsonNode = Await GetNodeAsync("leaderboards")
        Dim leaderboardsObject As JsonObject = TryCast(leaderboardsNode, JsonObject)
        If leaderboardsObject Is Nothing OrElse leaderboardsObject.Count = 0 Then
            Return result
        End If

        Dim latestPeriodKey As String = leaderboardsObject.Select(Function(kvp) kvp.Key).OrderByDescending(Function(k) k).FirstOrDefault()
        If String.IsNullOrWhiteSpace(latestPeriodKey) Then
            Return result
        End If

        Dim periodObject As JsonObject = TryCast(leaderboardsObject(latestPeriodKey), JsonObject)
        If periodObject Is Nothing Then
            Return result
        End If

        For Each entry In periodObject
            Dim rowObj As JsonObject = TryCast(entry.Value, JsonObject)
            If rowObj Is Nothing Then
                Continue For
            End If

            Dim row As New FirebaseLeaderboardEntry With {
                .UserId = entry.Key,
                .Username = rowObj("username")?.ToString(),
                .ComplianceScore = ParseDouble(rowObj("compliance_score")),
                .Rank = CInt(ParseLong(rowObj("rank")))
            }
            result.Add(row)
        Next

        Dim normalized As IEnumerable(Of FirebaseLeaderboardEntry) = result.OrderByDescending(Function(r) r.ComplianceScore)
        Dim index As Integer = 1
        For Each row In normalized
            If row.Rank <= 0 Then
                row.Rank = index
            End If
            index += 1
        Next

        Return normalized.OrderBy(Function(r) r.Rank).ThenByDescending(Function(r) r.ComplianceScore).Take(Math.Max(1, maxItems)).ToList()
    End Function

    Private Async Function GetUsersObjectAsync() As Task(Of JsonObject)
        Dim usersNode As JsonNode = Await GetNodeAsync("users")
        If usersNode Is Nothing Then
            Return New JsonObject()
        End If

        Dim usersObject As JsonObject = TryCast(usersNode, JsonObject)
        If usersObject Is Nothing Then
            Throw New InvalidOperationException("Format data 'users' di Firebase tidak valid.")
        End If

        Return usersObject
    End Function

    Private Function DeserializeUser(node As JsonNode) As FirebaseUserDocument
        Try
            Return JsonSerializer.Deserialize(Of FirebaseUserDocument)(node.ToJsonString(), _jsonOptions)
        Catch ex As JsonException
            Throw New InvalidOperationException("Data user di Firebase tidak dapat dibaca.", ex)
        End Try
    End Function

    Private Async Function GetNodeAsync(path As String) As Task(Of JsonNode)
        Dim requestUrl As String = BuildUrl(path)

        Using response As HttpResponseMessage = Await SharedHttp.GetAsync(requestUrl)
            Dim responseText As String = Await response.Content.ReadAsStringAsync()

            If Not response.IsSuccessStatusCode Then
                Throw New InvalidOperationException($"Firebase GET '{path}' gagal: {CInt(response.StatusCode)} {response.ReasonPhrase}. {responseText}")
            End If

            If String.IsNullOrWhiteSpace(responseText) OrElse responseText = "null" Then
                Return Nothing
            End If

            Return JsonNode.Parse(responseText)
        End Using
    End Function

    Private Async Function PutNodeAsync(path As String, payload As Object) As Task
        Dim requestUrl As String = BuildUrl(path)
        Dim json As String = JsonSerializer.Serialize(payload)

        Using content As New StringContent(json, Encoding.UTF8, "application/json")
            Using response As HttpResponseMessage = Await SharedHttp.PutAsync(requestUrl, content)
                Dim responseText As String = Await response.Content.ReadAsStringAsync()

                If Not response.IsSuccessStatusCode Then
                    Throw New InvalidOperationException($"Firebase PUT '{path}' gagal: {CInt(response.StatusCode)} {response.ReasonPhrase}. {responseText}")
                End If
            End Using
        End Using
    End Function

    Private Shared Function ReadEnvValue(name As String) As String
        Dim value As String = Nothing
        For Each target In {EnvironmentVariableTarget.Process, EnvironmentVariableTarget.User, EnvironmentVariableTarget.Machine}
            value = Environment.GetEnvironmentVariable(name, target)
            If Not String.IsNullOrWhiteSpace(value) Then Exit For
        Next

        If String.IsNullOrWhiteSpace(value) Then
            Return value
        End If

        value = value.Trim()
        If value.Length >= 2 AndAlso value.StartsWith("""") AndAlso value.EndsWith("""") Then
            value = value.Substring(1, value.Length - 2)
        End If

        Return value
    End Function

    Private Shared Function ParseLong(node As JsonNode) As Long
        If node Is Nothing Then
            Return 0
        End If

        Dim raw As String = node.ToString()
        Dim value As Long
        If Long.TryParse(raw, value) Then
            Return value
        End If

        Return 0
    End Function

    Private Shared Function ParseDouble(node As JsonNode) As Double
        If node Is Nothing Then
            Return 0
        End If

        Dim raw As String = node.ToString()
        Dim value As Double
        If Double.TryParse(raw, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, value) Then
            Return value
        End If

        Return 0
    End Function

    Private Function BuildUrl(path As String) As String
        Dim cleanPath As String = If(path, String.Empty).Trim("/"c)
        Dim authValue As String = Uri.EscapeDataString(_databaseKey)

        If cleanPath.Length = 0 Then
            Return $"{_databaseUrl}/.json?auth={authValue}"
        End If

        Return $"{_databaseUrl}/{cleanPath}.json?auth={authValue}"
    End Function

    Private Shared Function BuildDirectRoomId(userIdA As String, userIdB As String) As String
        Dim ids As String() = {If(userIdA, String.Empty).Trim(), If(userIdB, String.Empty).Trim()}
        Array.Sort(ids, StringComparer.OrdinalIgnoreCase)
        Return $"chat_room_dm_{ids(0)}_{ids(1)}"
    End Function
End Class

Friend Class FirebaseAuthResult
    Public Property UserId As String
    Public Property Username As String
    Public Property Email As String
End Class

Friend Class FirebaseUserDocument
    Public Property profile As FirebaseProfile
    Public Property limit_tracker As FirebaseLimitTracker
End Class

Friend Class FirebaseProfile
    Public Property username As String
    Public Property email As String
    Public Property password_hash As String
    Public Property hwid As String
    Public Property bio As String
    Public Property badges As List(Of String)
    Public Property avatar_url As String
End Class

Friend Class FirebaseLimitTracker
    Public Property daily_limit_minutes As Integer
    Public Property last_watch_date As String
    Public Property minutes_watched_today As Integer
    Public Property compliance_score As Double
End Class

Friend Class FirebaseChatMessagePreview
    Public Property MessageId As String
    Public Property RoomId As String
    Public Property Sender As String
    Public Property SenderUserId As String
    Public Property Text As String
    Public Property Timestamp As Long
End Class

Friend Class FirebaseLeaderboardEntry
    Public Property UserId As String
    Public Property Username As String
    Public Property ComplianceScore As Double
    Public Property Rank As Integer
End Class

Friend Class FirebaseFollowEntry
    Public Property UserId As String
    Public Property Username As String
    Public Property Relationship As String
End Class
