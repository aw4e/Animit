Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing.Drawing2D
Imports System.Linq
Imports System.Net.Http
Imports Microsoft.Web.WebView2.Core
Imports ReaLTaiizor.Controls

Public Class MainPage
    Private Const SamehadakuBaseUrl As String = "https://samehadaku.aw4e.site"

    Private Shared ReadOnly ApiClient As New HttpClient With {
        .Timeout = TimeSpan.FromSeconds(20)
    }

    Private ReadOnly _animeApi As New AnimeApiService(SamehadakuBaseUrl, ApiClient)
    Private ReadOnly _dashboardItems As New List(Of AnimeCardItem)
    Private ReadOnly _serverChoices As New List(Of ServerChoice)
    Private ReadOnly _localChatMessages As New List(Of FirebaseChatMessagePreview)
    Private ReadOnly _animeThumbnailCache As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
    Private _firebase As FirebaseRealtimeDbClient
    Private _firebaseWarningShown As Boolean
    Private _activeNav As DashboardNav = DashboardNav.Browse
    Private _featuredItem As AnimeCardItem
    Private _currentAnime As AnimeCardItem
    Private _currentAnimeDetail As AnimeDetailItem
    Private _currentEpisode As EpisodeItem
    Private _chatRoomId As String = "chat_room_lobby"
    Private _isDashboardLoading As Boolean
    Private _isWatchLoading As Boolean
    Private _isBindingServers As Boolean
    Private _isInitializingWebView As Boolean
    Private _isWebViewReady As Boolean
    Private _isWebViewEventsAttached As Boolean
    Private _isWebContentFullscreen As Boolean
    Private _isApplyingFullscreenTransition As Boolean
    Private _savedWindowState As FormWindowState = FormWindowState.Normal
    Private _savedBounds As Rectangle
    Private _savedTopMost As Boolean
    Private _savedNightFormPadding As Padding
    Private _watchPlayerOriginalParent As Control
    Private _watchPlayerOriginalBounds As Rectangle
    Private _watchPlayerOriginalDock As DockStyle = DockStyle.None
    Private _watchPlayerOriginalPadding As Padding
    Private _episodeRowStartIndex As Integer
    Private _episodeRowPageSize As Integer = 1
    Private _isManualVideoFullscreen As Boolean
    Private ReadOnly _dragger As New FormDragger()

    Private Const CardWidth As Integer = 158
    Private Const CardHeight As Integer = 250
    Private Const PosterHeight As Integer = 198
    Private Const TitleTop As Integer = 205
    Private Const MetaTop As Integer = 229
    Private Const TextPadX As Integer = 8
    Private Const FeedFetchMaxPages As Integer = 12
    Private Const SearchFetchMaxPages As Integer = 4

    <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property CurrentUsername As String = "User"

    <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property CurrentUserId As String = String.Empty

    <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property CurrentUserEmail As String = String.Empty

    Private Async Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        NightForm1.Cursor = Cursors.Default
        lblFeaturedTitle.Cursor = Cursors.Default
        lblFeaturedMeta.Cursor = Cursors.Default
        pnlFeaturedOverlay.Cursor = Cursors.Default
        _savedBounds = Bounds
        _savedTopMost = TopMost
        _savedNightFormPadding = NightForm1.Padding
        _watchPlayerOriginalParent = pnlWatch
        _watchPlayerOriginalBounds = pnlWatchPlayer.Bounds
        _watchPlayerOriginalDock = pnlWatchPlayer.Dock
        _watchPlayerOriginalPadding = pnlWatchPlayer.Padding

        lblFeaturedTag.Text = $"ANIMIT PICK • {CurrentUsername.ToUpperInvariant()}"
        UpdateNavigationStyle()
        AlignMainLayout()

        Await EnterDashboardModeAsync(True)
    End Sub

    Private Sub MainPage_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        AlignMainLayout()
    End Sub

    Private Sub MainPage_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        AlignMainLayout()
    End Sub

    Private Sub NightForm1_SizeChanged(sender As Object, e As EventArgs) Handles NightForm1.SizeChanged
        AlignMainLayout()
    End Sub

    Private Sub AlignMainLayout()
        If NightForm1 Is Nothing Then
            Return
        End If

        If _isWebContentFullscreen Then
            If pnlWatchPlayer.Parent IsNot NightForm1 Then
                pnlWatchPlayer.Parent = NightForm1
            End If
            pnlWatchPlayer.Dock = DockStyle.Fill
            pnlWatchPlayer.BringToFront()
            Return
        End If

        If _watchPlayerOriginalParent IsNot Nothing AndAlso pnlWatchPlayer.Parent IsNot _watchPlayerOriginalParent Then
            pnlWatchPlayer.Parent = _watchPlayerOriginalParent
        End If
        pnlWatchPlayer.Dock = DockStyle.None

        Dim contentLeft As Integer = 24
        Dim contentWidth As Integer = Math.Max(760, NightForm1.ClientSize.Width - (contentLeft * 2))

        lblClose.Left = NightForm1.ClientSize.Width - lblClose.Width - 2

        lnkNavBrowse.Left = contentLeft
        lnkNavSimulcasts.Left = lnkNavBrowse.Right + 18
        lnkNavMovies.Left = lnkNavSimulcasts.Right + 18
        lnkSocial.Left = lnkNavMovies.Right + 18

        btnRefresh.Left = contentLeft + contentWidth - btnRefresh.Width
        btnSearch.Left = btnRefresh.Left - btnSearch.Width - 8

        Dim minSearchLeft As Integer = lnkSocial.Right + 18
        Dim searchWidth As Integer = Math.Max(220, btnSearch.Left - minSearchLeft - 8)
        searchWidth = Math.Min(360, searchWidth)
        pnlSearchInput.Left = btnSearch.Left - searchWidth - 8
        pnlSearchInput.Width = searchWidth
        txtSearch.Width = Math.Max(120, pnlSearchInput.Width - 44)

        lnkLogout.Left = pnlSearchInput.Left - lnkLogout.Width - 16

        pnlContentHost.Left = contentLeft
        pnlContentHost.Top = 98
        pnlContentHost.Width = contentWidth
        pnlContentHost.Height = Math.Max(520, NightForm1.ClientSize.Height - pnlContentHost.Top - 4)

        btnEpisodeNext.Left = pnlDashboard.ClientSize.Width - btnEpisodeNext.Width - 12
        btnEpisodePrev.Left = btnEpisodeNext.Left - btnEpisodePrev.Width - 8

        btnWatchExternal.Left = pnlWatchOverlay.Width - btnWatchExternal.Width - 16
        btnFullscreen.Left = btnWatchExternal.Left - btnFullscreen.Width - 8
        cmbServerQuality.Left = Math.Max(220, btnFullscreen.Left - cmbServerQuality.Width - 10)
        lblWatchTitle.Width = Math.Max(220, cmbServerQuality.Left - 24)
        lblWatchDesc.Width = pnlWatchOverlay.Width - 32

        ApplyRoundedCorners()

        Dim calculatedPageSize As Integer = GetEpisodeTargetCount()
        If _episodeRowPageSize <> calculatedPageSize Then
            _episodeRowPageSize = calculatedPageSize
            If _dashboardItems.Count > 0 Then
                Dim maxStart As Integer = Math.Max(0, _dashboardItems.Count - _episodeRowPageSize)
                _episodeRowStartIndex = Math.Min(_episodeRowStartIndex, maxStart)
                RenderDashboardCardsPage()
            End If
        Else
            UpdateEpisodePagerButtons()
        End If
    End Sub

    Private Sub EnterWebFullscreenMode(Optional isManual As Boolean = False)
        If _isWebContentFullscreen Then
            If isManual Then
                _isManualVideoFullscreen = True
                SetVideoOnlyWebMode(True)
            End If
            Return
        End If

        _isManualVideoFullscreen = isManual
        _isWebContentFullscreen = True
        _savedWindowState = WindowState
        _savedBounds = Bounds
        _savedTopMost = TopMost
        _savedNightFormPadding = NightForm1.Padding
        _watchPlayerOriginalParent = pnlWatchPlayer.Parent
        _watchPlayerOriginalBounds = pnlWatchPlayer.Bounds
        _watchPlayerOriginalDock = pnlWatchPlayer.Dock

        SetHeaderVisibility(False)
        pnlContentHost.Visible = False
        NightForm1.Padding = New Padding(0)

        pnlWatchPlayer.Parent = NightForm1
        pnlWatchPlayer.Dock = DockStyle.Fill
        pnlWatchPlayer.Padding = New Padding(0)
        pnlWatchPlayer.BringToFront()

        pnlWatchOverlay.Visible = False
        pnlLiveChat.Visible = False
        lblWatchEpisodesTitle.Visible = False
        flpWatchEpisodes.Visible = False
        btnBackToBrowse.Visible = False
        lblWatchHint.Visible = False
        If webEpisodePlayer.Visible Then
            picWatchBackdrop.Visible = False
        End If
        webEpisodePlayer.BringToFront()

        WindowState = FormWindowState.Maximized
        TopMost = True
        btnFullscreen.Text = "🗗"

        If _isManualVideoFullscreen Then
            SetVideoOnlyWebMode(True)
        End If
    End Sub

    Private Sub ExitWebFullscreenMode()
        If Not _isWebContentFullscreen Then
            Return
        End If

        SetVideoOnlyWebMode(False)
        _isManualVideoFullscreen = False
        _isWebContentFullscreen = False
        pnlWatchPlayer.Dock = DockStyle.None
        If _watchPlayerOriginalParent IsNot Nothing Then
            pnlWatchPlayer.Parent = _watchPlayerOriginalParent
        End If
        pnlWatchPlayer.Bounds = _watchPlayerOriginalBounds
        pnlWatchPlayer.Dock = _watchPlayerOriginalDock
        pnlWatchPlayer.Padding = _watchPlayerOriginalPadding

        NightForm1.Padding = _savedNightFormPadding
        pnlContentHost.Visible = True
        SetHeaderVisibility(True)

        pnlWatchOverlay.Visible = True
        pnlLiveChat.Visible = True
        lblWatchEpisodesTitle.Visible = True
        flpWatchEpisodes.Visible = True
        btnBackToBrowse.Visible = True
        lblWatchHint.Visible = True
        picWatchBackdrop.Visible = Not webEpisodePlayer.Visible

        TopMost = _savedTopMost

        If _savedWindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Normal
            If _savedBounds.Width > 0 AndAlso _savedBounds.Height > 0 Then
                Bounds = _savedBounds
            End If
        Else
            WindowState = _savedWindowState
        End If

        btnFullscreen.Text = "⛶"
        AlignMainLayout()
    End Sub

    Private Sub ToggleSimpleFullscreen()
        If _isWebContentFullscreen Then
            ExitWebFullscreenMode()
        Else
            EnterWebFullscreenMode(True)
        End If
    End Sub

    Private Sub SetHeaderVisibility(isVisible As Boolean)
        lnkNavBrowse.Visible = isVisible
        lnkNavSimulcasts.Visible = isVisible
        lnkNavMovies.Visible = isVisible
        lnkSocial.Visible = isVisible
        lnkLogout.Visible = isVisible
        pnlSearchInput.Visible = isVisible
        btnSearch.Visible = isVisible
        btnRefresh.Visible = isVisible
        lblClose.Visible = isVisible
    End Sub

    Private Sub ApplyRoundedCorners()
        AddRoundedCorners(pnlSearchInput, 8)
        AddRoundedCorners(pnlFeatured, 14)
        AddRoundedCorners(pnlWatchPlayer, 14)
        AddRoundedCorners(pnlLiveChat, 14)
        AddRoundedCorners(pnlChatInput, 8)
    End Sub

    Private Sub NightForm1_MouseDown(sender As Object, e As MouseEventArgs) Handles NightForm1.MouseDown
        If e.Y <= 92 Then _dragger.StartDrag(Me, NightForm1, e)
    End Sub

    Private Sub NightForm1_MouseMove(sender As Object, e As MouseEventArgs) Handles NightForm1.MouseMove
        _dragger.UpdateDrag(Me)
    End Sub

    Private Sub NightForm1_MouseUp(sender As Object, e As MouseEventArgs) Handles NightForm1.MouseUp
        _dragger.StopDrag(NightForm1)
    End Sub

    Private Sub MainPage_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape AndAlso _isWebContentFullscreen Then
            e.SuppressKeyPress = True
            ExitWebFullscreenMode()
        End If
    End Sub

    Private Async Sub lnkNavBrowse_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkNavBrowse.LinkClicked
        _activeNav = DashboardNav.Browse
        Await EnterDashboardModeAsync(True)
    End Sub

    Private Async Sub lnkNavSimulcasts_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkNavSimulcasts.LinkClicked
        _activeNav = DashboardNav.Simulcasts
        Await EnterDashboardModeAsync(True)
    End Sub

    Private Async Sub lnkNavMovies_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkNavMovies.LinkClicked
        _activeNav = DashboardNav.Movies
        Await EnterDashboardModeAsync(True)
    End Sub

    Private Sub lnkSocial_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSocial.LinkClicked
        If String.IsNullOrWhiteSpace(CurrentUserId) Then
            MessageBox.Show("User belum login dengan benar.", "Sosial", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Using page As New SocialHubPage With {
            .CurrentUserId = CurrentUserId,
            .CurrentUsername = CurrentUsername,
            .CurrentUserEmail = CurrentUserEmail
        }
            page.ShowDialog(Me)
            If Not String.IsNullOrWhiteSpace(page.UpdatedUsername) Then
                CurrentUsername = page.UpdatedUsername
                lblFeaturedTag.Text = $"ANIMIT PICK • {CurrentUsername.ToUpperInvariant()}"
            End If
        End Using
    End Sub

    Private Async Function EnterDashboardModeAsync(forceReload As Boolean) As Task
        ExitWebFullscreenMode()
        tmrLiveChat.Stop()
        StopEmbeddedPlayer()

        pnlWatch.Visible = False
        pnlDashboard.Visible = True
        UpdateNavigationStyle()

        If forceReload OrElse flpEpisodeRow.Controls.Count = 0 Then
            Await LoadDashboardAsync()
        End If
    End Function

    Private Sub UpdateNavigationStyle()
        SetNavLinkStyle(lnkNavBrowse, _activeNav = DashboardNav.Browse)
        SetNavLinkStyle(lnkNavSimulcasts, _activeNav = DashboardNav.Simulcasts)
        SetNavLinkStyle(lnkNavMovies, _activeNav = DashboardNav.Movies)
    End Sub

    Private Shared Sub SetNavLinkStyle(link As NightLinkLabel, isActive As Boolean)
        Dim activeColor As Color = Color.FromArgb(93, 228, 245)
        Dim idleColor As Color = Color.FromArgb(150, 158, 171)
        link.LinkColor = If(isActive, activeColor, idleColor)
        link.VisitedLinkColor = link.LinkColor
        link.ActiveLinkColor = activeColor
    End Sub

    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Await EnterDashboardModeAsync(False)
        Await LoadDashboardAsync()
    End Sub

    Private Async Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Await EnterDashboardModeAsync(False)
        Await LoadDashboardAsync()
    End Sub

    Private Async Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode <> Keys.Enter Then
            Return
        End If

        e.SuppressKeyPress = True
        Await EnterDashboardModeAsync(False)
        Await LoadDashboardAsync()
    End Sub

    Private Async Function LoadDashboardAsync() As Task
        If _isDashboardLoading Then
            Return
        End If

        _isDashboardLoading = True
        btnSearch.Enabled = False
        btnRefresh.Enabled = False
        lblDashboardHint.Text = "Mengambil data episode terbaru..."
        flpEpisodeRow.Controls.Clear()

        Try
            Dim query As String = txtSearch.Text.Trim()
            Dim items As List(Of AnimeCardItem) = Await _animeApi.FetchAnimeListAsync(query, _activeNav.ToString(), FeedFetchMaxPages, SearchFetchMaxPages)

            _dashboardItems.Clear()
            _dashboardItems.AddRange(items)
            _episodeRowStartIndex = 0
            _episodeRowPageSize = GetEpisodeTargetCount()
            Await EnsureCurrentPageThumbnailsAsync()
            _featuredItem = _dashboardItems.FirstOrDefault()

            UpdateFeaturedHero(_featuredItem, query)
            RenderDashboardCardsPage()

            Dim sectionLabel As String = If(String.IsNullOrWhiteSpace(query), GetNavLabel(_activeNav), $"Search: {query}")
            lblRowTitle.Text = $"{sectionLabel} • Episode Terbaru"
            UpdateDashboardRangeHint()
        Catch ex As Exception
            lblDashboardHint.Text = "Gagal memuat dashboard."
            MessageBox.Show($"Tidak bisa mengambil data anime: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            btnSearch.Enabled = True
            btnRefresh.Enabled = True
            _isDashboardLoading = False
        End Try
    End Function

    Private Shared Function GetNavLabel(nav As DashboardNav) As String
        Select Case nav
            Case DashboardNav.Simulcasts
                Return "Simulcasts"
            Case DashboardNav.Movies
                Return "Movies"
            Case Else
                Return "Browse"
        End Select
    End Function

    Private Sub UpdateFeaturedHero(item As AnimeCardItem, query As String)
        If item Is Nothing Then
            btnFeaturedPlay.Enabled = False
            btnFeaturedInfo.Enabled = False
            lblFeaturedTag.Text = "ANIMIT PICK"
            lblFeaturedTitle.Text = "Tidak ada data"
            lblFeaturedMeta.Text = "Coba kata kunci lain"
            lblFeaturedDesc.Text = "Data anime tidak ditemukan dari endpoint yang dipilih."
            picFeaturedBackdrop.Image = Nothing
            Return
        End If

        btnFeaturedPlay.Enabled = True
        btnFeaturedInfo.Enabled = True

        Dim episodeText As String = If(String.IsNullOrWhiteSpace(item.Episode), "-", item.Episode)
        lblFeaturedTag.Text = $"SEASON 1 • EPISODE {episodeText}"
        lblFeaturedTitle.Text = item.Title
        lblFeaturedMeta.Text = $"{GetNavLabel(_activeNav)} • Klik Play untuk mode nonton"

        If String.IsNullOrWhiteSpace(query) Then
            lblFeaturedDesc.Text = "Dashboard ala streaming: klik Play dan konten langsung berubah ke mode nonton plus live chat."
        Else
            lblFeaturedDesc.Text = $"Hasil pencarian '{query}'. Pilih judul untuk langsung autoplay server kualitas tertinggi."
        End If

        LoadPictureAsync(picFeaturedBackdrop, item.Thumbnail)
    End Sub

    Private Function GetEpisodeTargetCount() As Integer
        Dim width As Integer = Math.Max(1, flpEpisodeRow.ClientSize.Width)

        If width >= 1320 Then
            Return 7
        End If

        If width >= 1120 Then
            Return 6
        End If

        If width >= 920 Then
            Return 5
        End If

        Return 4
    End Function

    Private Sub RenderDashboardCardsPage()
        flpEpisodeRow.SuspendLayout()
        flpEpisodeRow.Controls.Clear()

        If _dashboardItems.Count = 0 Then
            flpEpisodeRow.ResumeLayout()
            UpdateEpisodePagerButtons()
            Return
        End If

        _episodeRowPageSize = GetEpisodeTargetCount()
        Dim maxStart As Integer = Math.Max(0, _dashboardItems.Count - _episodeRowPageSize)
        _episodeRowStartIndex = Math.Max(0, Math.Min(_episodeRowStartIndex, maxStart))

        For Each item In _dashboardItems.Skip(_episodeRowStartIndex).Take(_episodeRowPageSize)
            flpEpisodeRow.Controls.Add(CreateDashboardCard(item))
        Next

        flpEpisodeRow.ResumeLayout()
        UpdateEpisodePagerButtons()
        UpdateDashboardRangeHint()
    End Sub

    Private Sub UpdateEpisodePagerButtons()
        Dim hasData As Boolean = _dashboardItems.Count > 0
        Dim maxStart As Integer = Math.Max(0, _dashboardItems.Count - _episodeRowPageSize)
        btnEpisodePrev.Enabled = hasData AndAlso _episodeRowStartIndex > 0
        btnEpisodeNext.Enabled = hasData AndAlso _episodeRowStartIndex < maxStart
    End Sub

    Private Sub UpdateDashboardRangeHint()
        If _dashboardItems.Count = 0 Then
            lblDashboardHint.Text = "Tidak ada judul untuk ditampilkan."
            Return
        End If

        Dim startAt As Integer = _episodeRowStartIndex + 1
        Dim endAt As Integer = Math.Min(_dashboardItems.Count, _episodeRowStartIndex + _episodeRowPageSize)
        lblDashboardHint.Text = $"{_dashboardItems.Count} judul siap ditonton • Menampilkan {startAt}-{endAt}"
    End Sub

    Private Async Function EnsureCurrentPageThumbnailsAsync() As Task
        If _dashboardItems.Count = 0 Then
            Return
        End If

        _episodeRowPageSize = GetEpisodeTargetCount()
        Dim maxStart As Integer = Math.Max(0, _dashboardItems.Count - _episodeRowPageSize)
        _episodeRowStartIndex = Math.Max(0, Math.Min(_episodeRowStartIndex, maxStart))

        Dim pageItems As List(Of AnimeCardItem) = _dashboardItems.Skip(_episodeRowStartIndex).Take(_episodeRowPageSize).ToList()
        For Each item In pageItems
            If String.IsNullOrWhiteSpace(item.Slug) Then
                Continue For
            End If

            Dim cachedThumb As String = Nothing
            _animeThumbnailCache.TryGetValue(item.Slug, cachedThumb)

            If Not String.IsNullOrWhiteSpace(cachedThumb) Then
                item.Thumbnail = cachedThumb
                Continue For
            End If

            Try
                Dim detail As AnimeDetailItem = Await _animeApi.FetchAnimeDetailAsync(item.Slug)
                Dim detailThumb As String = If(String.IsNullOrWhiteSpace(detail?.Thumbnail), item.Thumbnail, detail.Thumbnail)
                item.Thumbnail = detailThumb
                _animeThumbnailCache(item.Slug) = detailThumb
            Catch ex As Exception
                Debug.WriteLine($"Thumbnail detail gagal ({item.Slug}): {ex.Message}")
            End Try
        Next
    End Function

    Private Async Sub btnEpisodePrev_Click(sender As Object, e As EventArgs) Handles btnEpisodePrev.Click
        If _dashboardItems.Count = 0 Then
            Return
        End If

        _episodeRowPageSize = GetEpisodeTargetCount()
        If _episodeRowStartIndex <= 0 Then
            Return
        End If

        _episodeRowStartIndex = Math.Max(0, _episodeRowStartIndex - _episodeRowPageSize)
        Await EnsureCurrentPageThumbnailsAsync()
        RenderDashboardCardsPage()
        UpdateDashboardRangeHint()
    End Sub

    Private Async Sub btnEpisodeNext_Click(sender As Object, e As EventArgs) Handles btnEpisodeNext.Click
        If _dashboardItems.Count = 0 Then
            Return
        End If

        _episodeRowPageSize = GetEpisodeTargetCount()
        Dim maxStart As Integer = Math.Max(0, _dashboardItems.Count - _episodeRowPageSize)
        If _episodeRowStartIndex >= maxStart Then
            Return
        End If

        _episodeRowStartIndex = Math.Min(maxStart, _episodeRowStartIndex + _episodeRowPageSize)
        Await EnsureCurrentPageThumbnailsAsync()
        RenderDashboardCardsPage()
        UpdateDashboardRangeHint()
    End Sub

    Private Function CreateDashboardCard(item As AnimeCardItem) As Control
        Dim card As New Panel With {
            .BackColor = Color.FromArgb(14, 19, 30),
            .Size = New Size(CardWidth, CardHeight),
            .Margin = New Padding(5, 5, 5, 5),
            .Cursor = Cursors.Hand
        }

        ' Image fills the top portion edge-to-edge
        Dim poster As New PictureBox With {
            .BackColor = Color.FromArgb(9, 13, 22),
            .Location = New Point(0, 0),
            .Size = New Size(CardWidth, PosterHeight),
            .SizeMode = PictureBoxSizeMode.Zoom
        }

        Dim title As New Label With {
            .ForeColor = Color.FromArgb(232, 238, 248),
            .Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold),
            .Location = New Point(TextPadX, TitleTop),
            .Size = New Size(CardWidth - TextPadX * 2, 22),
            .Text = item.Title,
            .AutoEllipsis = True
        }

        Dim metaParts As New List(Of String)
        metaParts.Add($"Ep {If(String.IsNullOrWhiteSpace(item.Episode), "-", item.Episode)}")
        If Not String.IsNullOrWhiteSpace(item.Score) Then metaParts.Add(item.Score)
        If Not String.IsNullOrWhiteSpace(item.Type) Then metaParts.Add(item.Type)

        Dim meta As New Label With {
            .ForeColor = Color.FromArgb(110, 118, 135),
            .Font = New Font("Segoe UI", 7.8F),
            .Location = New Point(TextPadX, MetaTop),
            .Size = New Size(CardWidth - TextPadX * 2, 14),
            .Text = String.Join(" · ", metaParts),
            .AutoEllipsis = True
        }

        card.Controls.Add(poster)
        card.Controls.Add(title)
        card.Controls.Add(meta)

        LoadPictureAsync(poster, item.Thumbnail)
        AddRoundedCorners(card, 8)
        BindAnimeCardClick(card, item)
        Return card
    End Function

    Private Sub BindAnimeCardClick(ctrl As Control, item As AnimeCardItem)
        ctrl.Tag = item
        AddHandler ctrl.Click, AddressOf AnimeCard_Click

        For Each child As Control In ctrl.Controls
            BindAnimeCardClick(child, item)
        Next
    End Sub

    Private Async Sub AnimeCard_Click(sender As Object, e As EventArgs)
        Dim item As AnimeCardItem = TryCast(TryCast(sender, Control)?.Tag, AnimeCardItem)
        If item Is Nothing Then
            Return
        End If

        Await EnterWatchModeAsync(item)
    End Sub

    Private Async Sub FeaturedAction_Click(sender As Object, e As EventArgs) Handles btnFeaturedPlay.Click, btnFeaturedInfo.Click
        If _featuredItem IsNot Nothing Then
            Await EnterWatchModeAsync(_featuredItem)
        End If
    End Sub

    Private Async Function EnterWatchModeAsync(item As AnimeCardItem) As Task
        If item Is Nothing Then
            Return
        End If

        _currentAnime = item
        _chatRoomId = BuildChatRoomId(item.Slug, item.Episode)

        pnlDashboard.Visible = False
        pnlWatch.Visible = True

        PrepareWatchSkeleton(item)
        Await LoadWatchContentAsync(item)
        Await LoadLiveChatAsync()

        tmrLiveChat.Start()
    End Function

    Private Sub PrepareWatchSkeleton(item As AnimeCardItem)
        lblWatchMeta.Text = $"EPISODE {If(String.IsNullOrWhiteSpace(item.Episode), "-", item.Episode)} • LOADING"
        lblWatchTitle.Text = item.Title
        lblWatchDesc.Text = "Menyiapkan mode nonton dan mengambil server terbaik..."
        lblWatchHint.Text = "Memuat detail episode..."
        lblWatchEpisodesTitle.Text = $"Daftar Episode • {item.Title}"
        btnWatchExternal.Enabled = False
        btnWatchExternal.Tag = item.Url

        cmbServerQuality.Items.Clear()
        cmbServerQuality.Items.Add("Memuat server...")
        cmbServerQuality.SelectedIndex = 0

        StopEmbeddedPlayer()
        LoadPictureAsync(picWatchBackdrop, item.Thumbnail)
    End Sub

    Private Async Function LoadWatchContentAsync(item As AnimeCardItem) As Task
        If _isWatchLoading Then
            Return
        End If

        _isWatchLoading = True
        Try
            _currentAnimeDetail = Await _animeApi.FetchAnimeDetailAsync(item.Slug)
            If _currentAnimeDetail IsNot Nothing Then
                If Not String.IsNullOrWhiteSpace(_currentAnimeDetail.Thumbnail) Then
                    LoadPictureAsync(picWatchBackdrop, _currentAnimeDetail.Thumbnail)
                End If

                lblWatchDesc.Text = TrimToLength(If(String.IsNullOrWhiteSpace(_currentAnimeDetail.Synopsis), "Sinopsis belum tersedia.", _currentAnimeDetail.Synopsis), 240)
                RenderWatchEpisodeSelector(_currentAnimeDetail.Episodes)
            Else
                flpWatchEpisodes.Controls.Clear()
                lblWatchDesc.Text = "Detail anime tidak tersedia di endpoint ini."
            End If

            Dim targetEpisode As EpisodeItem = SelectEpisodeToWatch(item, _currentAnimeDetail)
            If targetEpisode Is Nothing Then
                _currentEpisode = Nothing
                Await BindServerChoicesAsync(New List(Of ServerChoice)(), item.Url, False)
                lblWatchHint.Text = "Tidak ada episode yang bisa diputar."
                Return
            End If

            Await LoadEpisodeIntoWatchAsync(targetEpisode, True)
        Catch ex As Exception
            lblWatchHint.Text = "Gagal menyiapkan mode nonton."
            MessageBox.Show($"Tidak bisa memuat detail anime: {ex.Message}", "Watch Mode Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            _isWatchLoading = False
        End Try
    End Function

    Private Sub RenderWatchEpisodeSelector(episodes As List(Of EpisodeItem))
        flpWatchEpisodes.SuspendLayout()
        flpWatchEpisodes.Controls.Clear()

        For Each episode In episodes.Take(40)
            flpWatchEpisodes.Controls.Add(CreateWatchEpisodeCard(episode))
        Next

        flpWatchEpisodes.ResumeLayout()
    End Sub

    Private Function CreateWatchEpisodeCard(episode As EpisodeItem) As Control
        Dim card As New Panel With {
            .BackColor = Color.FromArgb(18, 24, 38),
            .Size = New Size(204, 62),
            .Margin = New Padding(6, 5, 6, 5),
            .Cursor = Cursors.Hand
        }

        Dim title As New Label With {
            .ForeColor = Color.FromArgb(232, 238, 248),
            .Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold),
            .Location = New Point(10, 8),
            .Size = New Size(184, 20),
            .Text = If(String.IsNullOrWhiteSpace(episode.Number), "Episode -", $"Episode {episode.Number}"),
            .AutoEllipsis = True
        }

        Dim subtitle As New Label With {
            .ForeColor = Color.FromArgb(110, 118, 135),
            .Font = New Font("Segoe UI", 8.5F),
            .Location = New Point(10, 32),
            .Size = New Size(184, 18),
            .Text = If(String.IsNullOrWhiteSpace(episode.EpisodeDate), episode.Title, episode.EpisodeDate),
            .AutoEllipsis = True
        }

        card.Controls.Add(title)
        card.Controls.Add(subtitle)
        AddRoundedCorners(card, 6)
        BindEpisodeSelectorClick(card, episode)
        Return card
    End Function

    Private Sub BindEpisodeSelectorClick(ctrl As Control, episode As EpisodeItem)
        ctrl.Tag = episode
        AddHandler ctrl.Click, AddressOf WatchEpisodeSelector_Click

        For Each child As Control In ctrl.Controls
            BindEpisodeSelectorClick(child, episode)
        Next
    End Sub

    Private Async Sub WatchEpisodeSelector_Click(sender As Object, e As EventArgs)
        Dim episode As EpisodeItem = TryCast(TryCast(sender, Control)?.Tag, EpisodeItem)
        If episode Is Nothing Then
            Return
        End If

        Await LoadEpisodeIntoWatchAsync(episode, True)
        Await LoadLiveChatAsync()
    End Sub

    Private Async Function LoadEpisodeIntoWatchAsync(episode As EpisodeItem, autoplayHighest As Boolean) As Task
        _currentEpisode = episode
        _chatRoomId = BuildChatRoomId(_currentAnime?.Slug, episode.Number)
        lblWatchHint.Text = $"Memuat server episode {If(String.IsNullOrWhiteSpace(episode.Number), "-", episode.Number)}..."

        Try
            Dim detail As EpisodeDetailItem = Await _animeApi.FetchEpisodeDetailAsync(episode.Slug)
            Dim episodeTitle As String = If(detail?.Title, If(String.IsNullOrWhiteSpace(episode.Title), _currentAnime?.Title, episode.Title))
            Dim releaseDate As String = If(detail?.ReleaseDate, episode.EpisodeDate)
            Dim episodeNumber As String = If(detail?.EpisodeNumber, episode.Number)
            Dim quality As String = If(detail?.HighestQualityLabel, "AUTO")

            lblWatchTitle.Text = episodeTitle
            lblWatchMeta.Text = $"EPISODE {If(String.IsNullOrWhiteSpace(episodeNumber), "-", episodeNumber)} • {quality} • {If(String.IsNullOrWhiteSpace(releaseDate), "LIVE", releaseDate)}"
            lblWatchDesc.Text = TrimToLength(If(_currentAnimeDetail?.Synopsis, lblWatchDesc.Text), 240)
            lblWatchHint.Text = $"Auto-play server tertinggi aktif untuk episode {If(String.IsNullOrWhiteSpace(episodeNumber), "-", episodeNumber)}."

            Await BindServerChoicesAsync(detail?.ServerChoices, If(detail?.Url, episode.Url), autoplayHighest)
            HighlightSelectedEpisode(episode.Slug)
        Catch ex As Exception
            lblWatchHint.Text = "Gagal memuat server episode."
            MessageBox.Show($"Tidak bisa memuat server episode: {ex.Message}", "Episode Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Function

    Private Sub HighlightSelectedEpisode(selectedSlug As String)
        For Each ctrl As Control In flpWatchEpisodes.Controls
            Dim episode As EpisodeItem = TryCast(ctrl.Tag, EpisodeItem)
            Dim active As Boolean = String.Equals(episode?.Slug, selectedSlug, StringComparison.OrdinalIgnoreCase)
            ctrl.BackColor = If(active, Color.FromArgb(35, 62, 84), Color.FromArgb(18, 24, 38))
        Next
    End Sub

    Private Async Function BindServerChoicesAsync(choices As List(Of ServerChoice), fallbackUrl As String, autoplayHighest As Boolean) As Task
        _isBindingServers = True
        cmbServerQuality.Items.Clear()
        _serverChoices.Clear()

        If choices IsNot Nothing Then
            For Each choice In choices.OrderByDescending(Function(c) c.QualityRank).ThenBy(Function(c) c.Label)
                _serverChoices.Add(choice)
            Next
        End If

        If _serverChoices.Count = 0 AndAlso Not String.IsNullOrWhiteSpace(fallbackUrl) Then
            _serverChoices.Add(New ServerChoice With {
                .Label = "Fallback Web",
                .AutoplayUrl = fallbackUrl,
                .EpisodePageUrl = fallbackUrl,
                .QualityRank = 0
            })
        End If

        If _serverChoices.Count = 0 Then
            cmbServerQuality.Items.Add("Server tidak tersedia")
            cmbServerQuality.SelectedIndex = 0
            btnWatchExternal.Enabled = False
            btnWatchExternal.Tag = Nothing
            StopEmbeddedPlayer()
            _isBindingServers = False
            Return
        End If

        For Each choice In _serverChoices
            cmbServerQuality.Items.Add(choice.Label)
        Next

        cmbServerQuality.SelectedIndex = 0
        btnWatchExternal.Enabled = True
        btnWatchExternal.Tag = _serverChoices(0).AutoplayUrl
        _isBindingServers = False

        If autoplayHighest Then
            Await PlayServerChoiceAsync(_serverChoices(0))
        End If
    End Function

    Private Async Function PlayServerChoiceAsync(choice As ServerChoice) As Task
        If choice Is Nothing Then
            StopEmbeddedPlayer()
            Return
        End If

        Dim autoplayUrl As String = choice.AutoplayUrl
        If String.IsNullOrWhiteSpace(autoplayUrl) Then
            autoplayUrl = choice.EpisodePageUrl
        End If

        btnWatchExternal.Tag = autoplayUrl
        btnWatchExternal.Enabled = Not String.IsNullOrWhiteSpace(autoplayUrl)

        If String.IsNullOrWhiteSpace(autoplayUrl) Then
            StopEmbeddedPlayer()
            lblWatchHint.Text = "Server ini tidak punya autoplay URL."
            Return
        End If

        If Not Await EnsureWebViewReadyAsync() Then
            StopEmbeddedPlayer()
            lblWatchHint.Text = "WebView2 belum siap. Pastikan WebView2 Runtime terpasang."
            Return
        End If

        Try
            If Not Uri.TryCreate(autoplayUrl, UriKind.Absolute, Nothing) Then
                StopEmbeddedPlayer()
                lblWatchHint.Text = "URL autoplay server tidak valid."
                Return
            End If

            picWatchBackdrop.Visible = False
            webEpisodePlayer.Visible = True
            ' Wrap the embed URL in our own full-size HTML so it fills the WebView2 viewport.
            ' Directly loading the URL lets the embed page use its own fixed CSS (e.g. 640x360),
            ' which leaves empty/black space around the video.
            webEpisodePlayer.CoreWebView2.NavigateToString(BuildPlayerHtml(autoplayUrl))
            lblWatchHint.Text = $"Memutar otomatis: {choice.Label}"
        Catch ex As Exception
            StopEmbeddedPlayer()
            lblWatchHint.Text = "Gagal autoplay embed. Coba pilih server lain."
            Debug.WriteLine($"Web player error: {ex.Message}")
        End Try
    End Function

    ' Builds a minimal HTML page that embeds any URL in a full-size iframe.
    ' The iframe fills 100% width/height, so the video always covers the WebView2 area.
    Private Shared Function BuildPlayerHtml(embedUrl As String) As String
        Return "<!DOCTYPE html><html><head>" &
               "<meta name='viewport' content='width=device-width,initial-scale=1'>" &
               "<style>" &
               "*{margin:0;padding:0;box-sizing:border-box}" &
               "html,body{width:100%;height:100%;background:#000;overflow:hidden}" &
               "iframe{width:100%;height:100%;border:none;display:block}" &
               "</style></head><body>" &
               $"<iframe src='{embedUrl}' allowfullscreen " &
               "allow='autoplay;encrypted-media;fullscreen;picture-in-picture' " &
               "referrerpolicy='no-referrer-when-downgrade'></iframe>" &
               "</body></html>"
    End Function

    Private Sub StopEmbeddedPlayer()
        If _isWebContentFullscreen Then
            ExitWebFullscreenMode()
        End If
        SetVideoOnlyWebMode(False)

        Try
            If webEpisodePlayer.CoreWebView2 IsNot Nothing Then
                webEpisodePlayer.CoreWebView2.Stop()
                webEpisodePlayer.CoreWebView2.Navigate("about:blank")
            Else
                webEpisodePlayer.Source = Nothing
            End If
        Catch ex As Exception
            Debug.WriteLine($"Stop web player error: {ex.Message}")
        End Try

        webEpisodePlayer.Visible = False
        picWatchBackdrop.Visible = True
    End Sub

    Private Async Sub cmbServerQuality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServerQuality.SelectedIndexChanged
        If _isBindingServers Then
            Return
        End If

        Dim index As Integer = cmbServerQuality.SelectedIndex
        If index < 0 OrElse index >= _serverChoices.Count Then
            Return
        End If

        Await PlayServerChoiceAsync(_serverChoices(index))
    End Sub

    Private Async Sub btnWatchExternal_Click(sender As Object, e As EventArgs) Handles btnWatchExternal.Click
        Dim index As Integer = cmbServerQuality.SelectedIndex
        If index < 0 OrElse index >= _serverChoices.Count Then
            Return
        End If

        Await PlayServerChoiceAsync(_serverChoices(index))
    End Sub

    Private Sub btnFullscreen_Click(sender As Object, e As EventArgs) Handles btnFullscreen.Click
        ' webEpisodePlayer.Visible is True only when a video has been loaded,
        ' so this is a reliable "is a video playing?" check.
        If Not _isWebContentFullscreen AndAlso Not webEpisodePlayer.Visible Then
            lblWatchHint.Text = "Putar video dulu, baru fullscreen."
            Return
        End If

        ToggleSimpleFullscreen()
    End Sub

    Private Async Sub btnBackToBrowse_Click(sender As Object, e As EventArgs) Handles btnBackToBrowse.Click
        Await EnterDashboardModeAsync(False)
    End Sub

    Private Function EnsureFirebaseClient() As Boolean
        If _firebase IsNot Nothing Then
            Return True
        End If

        Dim errorMessage As String = Nothing
        If FirebaseRealtimeDbClient.TryGetSharedClient(_firebase, errorMessage) Then
            Return True
        End If

        If Not _firebaseWarningShown Then
            _firebaseWarningShown = True
            lblWatchHint.Text = errorMessage
        End If

        Return False
    End Function

    Private Async Function LoadLiveChatAsync() As Task
        If Not pnlWatch.Visible Then
            Return
        End If

        flpLiveChat.SuspendLayout()
        flpLiveChat.Controls.Clear()

        Dim useFirebase As Boolean = EnsureFirebaseClient()
        Dim messages As List(Of FirebaseChatMessagePreview) = Nothing

        If useFirebase Then
            Try
                messages = Await _firebase.GetChatMessagesByRoomAsync(_chatRoomId, 40)
            Catch ex As Exception
                Debug.WriteLine($"Live chat firebase error: {ex.Message}")
                useFirebase = False
            End Try
        End If

        If Not useFirebase Then
            messages = _localChatMessages.
                Where(Function(m) String.Equals(m.RoomId, _chatRoomId, StringComparison.OrdinalIgnoreCase)).
                OrderBy(Function(m) m.Timestamp).
                ToList()

            If messages.Count > 40 Then
                messages = messages.Skip(messages.Count - 40).ToList()
            End If
        End If

        btnSendChat.Enabled = True

        If messages Is Nothing OrElse messages.Count = 0 Then
            lblLiveChatCounter.Text = If(useFirebase, "0 LIVE", "LOCAL")
            flpLiveChat.Controls.Add(CreateSystemChatBubble(
                If(useFirebase, "Belum ada komentar. Jadilah yang pertama chat!", "Mode lokal aktif. Chat tersimpan sementara di aplikasi.")))
            flpLiveChat.ResumeLayout()
            Return
        End If

        For Each message In messages
            flpLiveChat.Controls.Add(CreateChatBubble(message))
        Next

        lblLiveChatCounter.Text = $"{messages.Count} {If(useFirebase, "LIVE", "LOCAL")}"
        flpLiveChat.ResumeLayout()
        flpLiveChat.ScrollControlIntoView(flpLiveChat.Controls(flpLiveChat.Controls.Count - 1))
    End Function

    Private Function CreateChatBubble(message As FirebaseChatMessagePreview) As Control
        Dim bubble As New Panel With {
            .BackColor = Color.FromArgb(16, 22, 34),
            .Width = Math.Max(220, flpLiveChat.ClientSize.Width - 25),
            .Height = 72,
            .Margin = New Padding(0, 0, 0, 8)
        }

        Dim senderColor As Color = PickSenderColor(message.Sender)
        Dim senderLabel As New Label With {
            .ForeColor = senderColor,
            .Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold),
            .Location = New Point(10, 8),
            .Size = New Size(bubble.Width - 20, 18),
            .Text = If(String.IsNullOrWhiteSpace(message.Sender), "Guest", message.Sender),
            .AutoEllipsis = True
        }

        Dim textLabel As New Label With {
            .ForeColor = Color.FromArgb(238, 242, 250),
            .Font = New Font("Segoe UI", 9.2F),
            .Location = New Point(10, 27),
            .Size = New Size(bubble.Width - 20, 30),
            .Text = If(String.IsNullOrWhiteSpace(message.Text), "-", message.Text),
            .AutoEllipsis = True
        }

        Dim timeText As String = "now"
        If message.Timestamp > 0 Then
            timeText = DateTimeOffset.FromUnixTimeSeconds(message.Timestamp).ToLocalTime().ToString("HH:mm")
        End If

        Dim timeLabel As New Label With {
            .ForeColor = Color.FromArgb(130, 139, 157),
            .Font = New Font("Segoe UI", 8.0F),
            .Location = New Point(10, 55),
            .Size = New Size(bubble.Width - 20, 14),
            .Text = timeText,
            .TextAlign = ContentAlignment.MiddleRight
        }

        bubble.Controls.Add(senderLabel)
        bubble.Controls.Add(textLabel)
        bubble.Controls.Add(timeLabel)
        AddRoundedCorners(bubble, 8)
        Return bubble
    End Function

    Private Function CreateSystemChatBubble(text As String) As Control
        Dim bubble As New Panel With {
            .BackColor = Color.FromArgb(14, 31, 46),
            .Width = Math.Max(220, flpLiveChat.ClientSize.Width - 25),
            .Height = 58,
            .Margin = New Padding(0, 0, 0, 8)
        }

        Dim textLabel As New Label With {
            .ForeColor = Color.FromArgb(84, 234, 255),
            .Font = New Font("Segoe UI", 9.0F, FontStyle.Bold),
            .Location = New Point(10, 11),
            .Size = New Size(bubble.Width - 20, 36),
            .Text = text
        }

        bubble.Controls.Add(textLabel)
        AddRoundedCorners(bubble, 8)
        Return bubble
    End Function

    Private Shared Function PickSenderColor(sender As String) As Color
        Dim palette As Color() = {
            Color.FromArgb(237, 126, 255),
            Color.FromArgb(84, 234, 255),
            Color.FromArgb(255, 176, 82),
            Color.FromArgb(140, 245, 159),
            Color.FromArgb(255, 122, 164)
        }

        If String.IsNullOrWhiteSpace(sender) Then
            Return palette(0)
        End If

        Dim hash As Integer = sender.GetHashCode()
        Dim index As Integer = Math.Abs(hash) Mod palette.Length
        Return palette(index)
    End Function

    Private Sub AddLocalChatMessage(senderName As String, messageText As String)
        Dim message As New FirebaseChatMessagePreview With {
            .MessageId = $"local_{Guid.NewGuid():N}",
            .RoomId = _chatRoomId,
            .Sender = senderName,
            .Text = messageText,
            .Timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds()
        }

        _localChatMessages.Add(message)

        If _localChatMessages.Count > 200 Then
            _localChatMessages.RemoveRange(0, _localChatMessages.Count - 200)
        End If
    End Sub

    Private Async Sub btnSendChat_Click(sender As Object, e As EventArgs) Handles btnSendChat.Click
        Dim messageText As String = txtChatInput.Text.Trim()
        If String.IsNullOrWhiteSpace(messageText) Then
            Return
        End If

        btnSendChat.Enabled = False
        Try
            Dim senderName As String = If(String.IsNullOrWhiteSpace(CurrentUsername), "guest", CurrentUsername)
            Dim sentToFirebase As Boolean = False

            If EnsureFirebaseClient() Then
                Try
                    Await _firebase.SendChatMessageAsync(_chatRoomId, senderName, messageText, CurrentUserId)
                    sentToFirebase = True
                Catch ex As Exception
                    Debug.WriteLine($"Send chat firebase error: {ex.Message}")
                    sentToFirebase = False
                End Try
            End If

            If Not sentToFirebase Then
                AddLocalChatMessage(senderName, messageText)
                lblWatchHint.Text = "Live chat lokal aktif (Firebase offline)."
            End If

            txtChatInput.Clear()
            Await LoadLiveChatAsync()
        Finally
            btnSendChat.Enabled = True
        End Try
    End Sub

    Private Async Sub txtChatInput_KeyDown(sender As Object, e As KeyEventArgs) Handles txtChatInput.KeyDown
        If e.KeyCode <> Keys.Enter Then
            Return
        End If

        e.SuppressKeyPress = True
        btnSendChat.PerformClick()
        Await Task.CompletedTask
    End Sub

    Private Async Sub tmrLiveChat_Tick(sender As Object, e As EventArgs) Handles tmrLiveChat.Tick
        If _isWatchLoading OrElse Not pnlWatch.Visible Then
            Return
        End If

        Await LoadLiveChatAsync()
    End Sub

    Private Async Function EnsureWebViewReadyAsync() As Task(Of Boolean)
        If webEpisodePlayer Is Nothing OrElse webEpisodePlayer.IsDisposed Then
            Return False
        End If

        If _isWebViewReady AndAlso webEpisodePlayer.CoreWebView2 IsNot Nothing Then
            Return True
        End If

        If _isInitializingWebView Then
            For i As Integer = 1 To 100
                Await Task.Delay(30)
                If _isWebViewReady AndAlso webEpisodePlayer.CoreWebView2 IsNot Nothing Then
                    Return True
                End If
                If Not _isInitializingWebView Then
                    Exit For
                End If
            Next
        End If

        _isInitializingWebView = True
        Try
            Await webEpisodePlayer.EnsureCoreWebView2Async(Nothing)
            Dim settings As CoreWebView2Settings = webEpisodePlayer.CoreWebView2.Settings
            settings.AreDefaultContextMenusEnabled = False
            settings.AreDevToolsEnabled = False
            settings.IsStatusBarEnabled = False
            settings.IsZoomControlEnabled = True

            If Not _isWebViewEventsAttached Then
                AddHandler webEpisodePlayer.CoreWebView2.ContainsFullScreenElementChanged, AddressOf WebEpisodePlayer_ContainsFullScreenElementChanged
                _isWebViewEventsAttached = True
            End If

            _isWebViewReady = True
            Return True
        Catch ex As Exception
            _isWebViewReady = False
            Debug.WriteLine($"WebView2 init error: {ex.Message}")
            Return False
        Finally
            _isInitializingWebView = False
        End Try
    End Function

    Private Sub WebEpisodePlayer_ContainsFullScreenElementChanged(sender As Object, e As Object)
        If IsDisposed OrElse Disposing Then
            Return
        End If

        If InvokeRequired Then
            BeginInvoke(New Action(Of Object, Object)(AddressOf WebEpisodePlayer_ContainsFullScreenElementChanged), sender, e)
            Return
        End If

        Dim core As CoreWebView2 = webEpisodePlayer?.CoreWebView2
        If core Is Nothing Then
            Return
        End If

        If _isManualVideoFullscreen Then
            Return
        End If

        If _isApplyingFullscreenTransition Then
            Return
        End If

        Try
            _isApplyingFullscreenTransition = True
            If core.ContainsFullScreenElement Then
                EnterWebFullscreenMode(False)
            Else
                ExitWebFullscreenMode()
            End If
        Finally
            _isApplyingFullscreenTransition = False
        End Try
    End Sub

    Private Sub SetVideoOnlyWebMode(enable As Boolean)
        Try
            Dim core As CoreWebView2 = webEpisodePlayer?.CoreWebView2
            If core Is Nothing Then
                Return
            End If

            Dim script As String = If(enable, BuildEnableVideoOnlyScript(), BuildDisableVideoOnlyScript())
            core.ExecuteScriptAsync(script)
        Catch ex As Exception
            Debug.WriteLine($"Video-only script error: {ex.Message}")
        End Try
    End Sub

    Private Shared Function BuildEnableVideoOnlyScript() As String
        Return String.Join(vbLf, New String() {
            "(() => {",
            "  const STYLE_ID = 'animit-video-only-style';",
            "  const KEEP_CLASS = 'animit-video-keep';",
            "  const TARGET_CLASS = 'animit-video-target';",
            "  const cleanup = () => {",
            "    try {",
            "      const oldStyle = document.getElementById(STYLE_ID);",
            "      if (oldStyle) oldStyle.remove();",
            "      document.querySelectorAll('.' + KEEP_CLASS).forEach(el => el.classList.remove(KEEP_CLASS));",
            "      document.querySelectorAll('.' + TARGET_CLASS).forEach(el => el.classList.remove(TARGET_CLASS));",
            "      document.documentElement.style.overflow = '';",
            "      if (document.body) {",
            "        document.body.style.overflow = '';",
            "        document.body.style.background = '';",
            "      }",
            "    } catch (_) {}",
            "  };",
            "  cleanup();",
            "  const nodes = Array.from(document.querySelectorAll('video, iframe'));",
            "  if (!nodes.length) return false;",
            "  let target = nodes[0];",
            "  let bestArea = 0;",
            "  nodes.forEach(n => {",
            "    const r = n.getBoundingClientRect();",
            "    const area = Math.max(0, r.width) * Math.max(0, r.height);",
            "    if (area > bestArea) { bestArea = area; target = n; }",
            "  });",
            "  let p = target;",
            "  while (p) { p.classList.add(KEEP_CLASS); p = p.parentElement; }",
            "  target.classList.add(TARGET_CLASS);",
            "  const style = document.createElement('style');",
            "  style.id = STYLE_ID;",
            "  style.textContent = `",
            "    html, body { margin:0 !important; padding:0 !important; width:100% !important; height:100% !important; overflow:hidden !important; background:#000 !important; }",
            "    body * { visibility:hidden !important; }",
            "    .${KEEP_CLASS}, .${KEEP_CLASS} * { visibility:visible !important; }",
            "    .${TARGET_CLASS} {",
            "      position: fixed !important;",
            "      left: 0 !important; top: 0 !important;",
            "      width: 100vw !important; height: 100vh !important;",
            "      margin: 0 !important; padding: 0 !important; border: 0 !important;",
            "      z-index: 2147483647 !important;",
            "      background: #000 !important;",
            "      object-fit: contain !important;",
            "    }",
            "  `;",
            "  document.head.appendChild(style);",
            "  window.__animitVideoOnlyCleanup = cleanup;",
            "  return true;",
            "})();"
        })
    End Function

    Private Shared Function BuildDisableVideoOnlyScript() As String
        Return String.Join(vbLf, New String() {
            "(() => {",
            "  try {",
            "    if (window.__animitVideoOnlyCleanup) {",
            "      window.__animitVideoOnlyCleanup();",
            "      window.__animitVideoOnlyCleanup = null;",
            "    } else {",
            "      const oldStyle = document.getElementById('animit-video-only-style');",
            "      if (oldStyle) oldStyle.remove();",
            "      document.querySelectorAll('.animit-video-keep').forEach(el => el.classList.remove('animit-video-keep'));",
            "      document.querySelectorAll('.animit-video-target').forEach(el => el.classList.remove('animit-video-target'));",
            "      document.documentElement.style.overflow = '';",
            "      if (document.body) {",
            "        document.body.style.overflow = '';",
            "        document.body.style.background = '';",
            "      }",
            "    }",
            "  } catch (_) {}",
            "  return true;",
            "})();"
        })
    End Function

    Private Shared Function SelectEpisodeToWatch(item As AnimeCardItem, detail As AnimeDetailItem) As EpisodeItem
        If detail Is Nothing OrElse detail.Episodes.Count = 0 Then
            Return Nothing
        End If

        If Not String.IsNullOrWhiteSpace(item?.Episode) Then
            Dim exact As EpisodeItem = detail.Episodes.FirstOrDefault(Function(ep) String.Equals(ep.Number, item.Episode, StringComparison.OrdinalIgnoreCase))
            If exact IsNot Nothing Then
                Return exact
            End If
        End If

        Return detail.Episodes.FirstOrDefault()
    End Function

    Private Shared Function BuildChatRoomId(animeSlug As String, episodeNumber As String) As String
        Dim raw As String = $"{If(String.IsNullOrWhiteSpace(animeSlug), "lobby", animeSlug)}-{If(String.IsNullOrWhiteSpace(episodeNumber), "live", episodeNumber)}".ToLowerInvariant()
        Dim normalized As Char() = raw.Select(Function(ch) If(Char.IsLetterOrDigit(ch), ch, "-"c)).ToArray()
        Dim room As String = New String(normalized).Trim("-"c)

        While room.Contains("--")
            room = room.Replace("--", "-")
        End While

        If String.IsNullOrWhiteSpace(room) Then
            room = "lobby"
        End If

        Return $"chat_room_{room}"
    End Function

    Private Shared Sub LoadPictureAsync(picture As PictureBox, imageUrl As String)
        picture.Image = Nothing
        If String.IsNullOrWhiteSpace(imageUrl) Then
            Return
        End If

        Try
            picture.LoadAsync(imageUrl)
        Catch ex As Exception
            Debug.WriteLine($"Image load failed: {ex.Message}")
        End Try
    End Sub

    Private Shared Function TrimToLength(value As String, maxLength As Integer) As String
        If String.IsNullOrWhiteSpace(value) Then
            Return String.Empty
        End If

        If value.Length <= maxLength Then
            Return value
        End If

        Return value.Substring(0, maxLength - 1) & "…"
    End Function

    Private Shared Sub AddRoundedCorners(control As Control, radius As Integer)
        If control.Width <= 0 OrElse control.Height <= 0 Then
            Return
        End If

        Dim path As New GraphicsPath()
        Dim diameter As Integer = radius * 2

        path.AddArc(0, 0, diameter, diameter, 180, 90)
        path.AddArc(control.Width - diameter, 0, diameter, diameter, 270, 90)
        path.AddArc(control.Width - diameter, control.Height - diameter, diameter, diameter, 0, 90)
        path.AddArc(0, control.Height - diameter, diameter, diameter, 90, 90)
        path.CloseFigure()

        control.Region = New Region(path)
    End Sub

    Private Sub lnkLogout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLogout.LinkClicked
        tmrLiveChat.Stop()
        ExitWebFullscreenMode()
        Dim loginPage As New LoginPage()
        loginPage.Show()
        Hide()
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        tmrLiveChat.Stop()
        ExitWebFullscreenMode()
        Close()
    End Sub

    Private Sub MainPage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        tmrLiveChat.Stop()

        Try
            If _isWebViewEventsAttached AndAlso webEpisodePlayer?.CoreWebView2 IsNot Nothing Then
                RemoveHandler webEpisodePlayer.CoreWebView2.ContainsFullScreenElementChanged, AddressOf WebEpisodePlayer_ContainsFullScreenElementChanged
            End If
        Catch ex As Exception
            Debug.WriteLine($"WebView2 cleanup error: {ex.Message}")
        Finally
            _isWebViewEventsAttached = False
        End Try
    End Sub

    Private Enum DashboardNav
        Browse
        Simulcasts
        Movies
    End Enum
End Class
