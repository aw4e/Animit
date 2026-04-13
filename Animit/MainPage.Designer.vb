Imports ReaLTaiizor.Controls
Imports ReaLTaiizor.Forms
Imports Microsoft.Web.WebView2.WinForms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPage
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        NightForm1 = New NightForm()
        lblClose = New Label()
        lnkLogout = New NightLinkLabel()
        lnkSocial = New NightLinkLabel()
        lnkNavMovies = New NightLinkLabel()
        lnkNavSimulcasts = New NightLinkLabel()
        lnkNavBrowse = New NightLinkLabel()
        pnlSearchInput = New Panel()
        txtSearch = New TextBox()
        lblSearchIcon = New Label()
        btnSearch = New StableActionButton()
        btnRefresh = New StableActionButton()
        pnlContentHost = New Panel()
        pnlDashboard = New Panel()
        lblDashboardHint = New NightLabel()
        flpEpisodeRow = New FlowLayoutPanel()
        lblRowTitle = New NightLabel()
        btnEpisodePrev = New StableActionButton()
        btnEpisodeNext = New StableActionButton()
        pnlFeatured = New Panel()
        picFeaturedBackdrop = New PictureBox()
        pnlFeaturedOverlay = New Panel()
        btnFeaturedInfo = New StableActionButton()
        btnFeaturedPlay = New StableActionButton()
        lblFeaturedDesc = New NightLabel()
        lblFeaturedMeta = New NightLabel()
        lblFeaturedTitle = New NightLabel()
        lblFeaturedTag = New NightLabel()
        pnlWatch = New Panel()
        lblWatchHint = New NightLabel()
        flpWatchEpisodes = New FlowLayoutPanel()
        lblWatchEpisodesTitle = New NightLabel()
        pnlLiveChat = New Panel()
        pnlChatInput = New Panel()
        btnSendChat = New StableActionButton()
        txtChatInput = New TextBox()
        flpLiveChat = New FlowLayoutPanel()
        lblLiveChatCounter = New NightLabel()
        lblLiveChatTitle = New NightLabel()
        pnlWatchPlayer = New Panel()
        webEpisodePlayer = New WebView2()
        picWatchBackdrop = New PictureBox()
        pnlWatchOverlay = New Panel()
        cmbServerQuality = New ComboBox()
        btnFullscreen = New StableActionButton()
        btnWatchExternal = New StableActionButton()
        lblWatchDesc = New NightLabel()
        lblWatchTitle = New NightLabel()
        lblWatchMeta = New NightLabel()
        btnBackToBrowse = New StableActionButton()
        tmrLiveChat = New Timer(components)
        NightForm1.SuspendLayout()
        pnlSearchInput.SuspendLayout()
        pnlContentHost.SuspendLayout()
        pnlDashboard.SuspendLayout()
        pnlFeatured.SuspendLayout()
        CType(picFeaturedBackdrop, ComponentModel.ISupportInitialize).BeginInit()
        pnlFeaturedOverlay.SuspendLayout()
        pnlWatch.SuspendLayout()
        pnlLiveChat.SuspendLayout()
        pnlChatInput.SuspendLayout()
        pnlWatchPlayer.SuspendLayout()
        CType(picWatchBackdrop, ComponentModel.ISupportInitialize).BeginInit()
        pnlWatchOverlay.SuspendLayout()
        SuspendLayout()
        ' 
        ' NightForm1
        ' 
        NightForm1.BackColor = Color.FromArgb(CByte(4), CByte(7), CByte(14))
        NightForm1.Controls.Add(lblClose)
        NightForm1.Controls.Add(lnkLogout)
        NightForm1.Controls.Add(lnkSocial)
        NightForm1.Controls.Add(lnkNavMovies)
        NightForm1.Controls.Add(lnkNavSimulcasts)
        NightForm1.Controls.Add(lnkNavBrowse)
        NightForm1.Controls.Add(pnlSearchInput)
        NightForm1.Controls.Add(btnSearch)
        NightForm1.Controls.Add(btnRefresh)
        NightForm1.Controls.Add(pnlContentHost)
        NightForm1.Dock = DockStyle.Fill
        NightForm1.DrawIcon = False
        NightForm1.Font = New Font("Segoe UI", 9F)
        NightForm1.HeadColor = Color.FromArgb(CByte(4), CByte(7), CByte(14))
        NightForm1.Location = New Point(0, 0)
        NightForm1.MinimumSize = New Size(100, 42)
        NightForm1.Name = "NightForm1"
        NightForm1.Padding = New Padding(18, 40, 18, 18)
        NightForm1.Size = New Size(1280, 760)
        NightForm1.TabIndex = 0
        NightForm1.Text = "ANIMIT"
        NightForm1.TextAlignment = NightForm.Alignment.Left
        NightForm1.TitleBarTextColor = Color.FromArgb(CByte(83), CByte(107), CByte(138))
        ' 
        ' lblClose
        ' 
        lblClose.AutoSize = True
        lblClose.BackColor = Color.Transparent
        lblClose.Cursor = Cursors.Hand
        lblClose.Font = New Font("Segoe UI Symbol", 12F)
        lblClose.ForeColor = Color.FromArgb(CByte(83), CByte(107), CByte(138))
        lblClose.Location = New Point(1258, 0)
        lblClose.Name = "lblClose"
        lblClose.Size = New Size(23, 21)
        lblClose.TabIndex = 100
        lblClose.Text = "✕"
        ' 
        ' lnkLogout
        ' 
        lnkLogout.ActiveLinkColor = Color.FromArgb(CByte(93), CByte(228), CByte(245))
        lnkLogout.AutoSize = True
        lnkLogout.BackColor = Color.Transparent
        lnkLogout.Cursor = Cursors.Hand
        lnkLogout.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lnkLogout.LinkBehavior = LinkBehavior.NeverUnderline
        lnkLogout.LinkColor = Color.FromArgb(CByte(150), CByte(158), CByte(171))
        lnkLogout.Location = New Point(761, 59)
        lnkLogout.Name = "lnkLogout"
        lnkLogout.Size = New Size(56, 19)
        lnkLogout.TabIndex = 5
        lnkLogout.TabStop = True
        lnkLogout.Text = "Logout"
        lnkLogout.VisitedLinkColor = Color.FromArgb(CByte(150), CByte(158), CByte(171))
        ' 
        ' lnkSocial
        ' 
        lnkSocial.ActiveLinkColor = Color.FromArgb(CByte(93), CByte(228), CByte(245))
        lnkSocial.AutoSize = True
        lnkSocial.BackColor = Color.Transparent
        lnkSocial.Cursor = Cursors.Hand
        lnkSocial.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lnkSocial.LinkBehavior = LinkBehavior.NeverUnderline
        lnkSocial.LinkColor = Color.FromArgb(CByte(150), CByte(158), CByte(171))
        lnkSocial.Location = New Point(706, 59)
        lnkSocial.Name = "lnkSocial"
        lnkSocial.Size = New Size(45, 19)
        lnkSocial.TabIndex = 4
        lnkSocial.TabStop = True
        lnkSocial.Text = "Sosial"
        lnkSocial.VisitedLinkColor = Color.FromArgb(CByte(150), CByte(158), CByte(171))
        ' 
        ' lnkNavMovies
        ' 
        lnkNavMovies.ActiveLinkColor = Color.FromArgb(CByte(93), CByte(228), CByte(245))
        lnkNavMovies.AutoSize = True
        lnkNavMovies.BackColor = Color.Transparent
        lnkNavMovies.Cursor = Cursors.Hand
        lnkNavMovies.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lnkNavMovies.LinkBehavior = LinkBehavior.NeverUnderline
        lnkNavMovies.LinkColor = Color.FromArgb(CByte(150), CByte(158), CByte(171))
        lnkNavMovies.Location = New Point(170, 61)
        lnkNavMovies.Name = "lnkNavMovies"
        lnkNavMovies.Size = New Size(57, 19)
        lnkNavMovies.TabIndex = 4
        lnkNavMovies.TabStop = True
        lnkNavMovies.Text = "Movies"
        lnkNavMovies.VisitedLinkColor = Color.FromArgb(CByte(150), CByte(158), CByte(171))
        ' 
        ' lnkNavSimulcasts
        ' 
        lnkNavSimulcasts.ActiveLinkColor = Color.FromArgb(CByte(93), CByte(228), CByte(245))
        lnkNavSimulcasts.AutoSize = True
        lnkNavSimulcasts.BackColor = Color.Transparent
        lnkNavSimulcasts.Cursor = Cursors.Hand
        lnkNavSimulcasts.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lnkNavSimulcasts.LinkBehavior = LinkBehavior.NeverUnderline
        lnkNavSimulcasts.LinkColor = Color.FromArgb(CByte(150), CByte(158), CByte(171))
        lnkNavSimulcasts.Location = New Point(86, 61)
        lnkNavSimulcasts.Name = "lnkNavSimulcasts"
        lnkNavSimulcasts.Size = New Size(78, 19)
        lnkNavSimulcasts.TabIndex = 3
        lnkNavSimulcasts.TabStop = True
        lnkNavSimulcasts.Text = "Simulcasts"
        lnkNavSimulcasts.VisitedLinkColor = Color.FromArgb(CByte(150), CByte(158), CByte(171))
        ' 
        ' lnkNavBrowse
        ' 
        lnkNavBrowse.ActiveLinkColor = Color.FromArgb(CByte(93), CByte(228), CByte(245))
        lnkNavBrowse.AutoSize = True
        lnkNavBrowse.BackColor = Color.Transparent
        lnkNavBrowse.Cursor = Cursors.Hand
        lnkNavBrowse.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lnkNavBrowse.LinkBehavior = LinkBehavior.NeverUnderline
        lnkNavBrowse.LinkColor = Color.FromArgb(CByte(93), CByte(228), CByte(245))
        lnkNavBrowse.Location = New Point(22, 61)
        lnkNavBrowse.Name = "lnkNavBrowse"
        lnkNavBrowse.Size = New Size(58, 19)
        lnkNavBrowse.TabIndex = 2
        lnkNavBrowse.TabStop = True
        lnkNavBrowse.Text = "Browse"
        lnkNavBrowse.VisitedLinkColor = Color.FromArgb(CByte(93), CByte(228), CByte(245))
        ' 
        ' pnlSearchInput
        ' 
        pnlSearchInput.BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(37))
        pnlSearchInput.Controls.Add(txtSearch)
        pnlSearchInput.Controls.Add(lblSearchIcon)
        pnlSearchInput.EdgeColor = Color.FromArgb(CByte(32), CByte(41), CByte(50))
        pnlSearchInput.Location = New Point(836, 50)
        pnlSearchInput.Name = "pnlSearchInput"
        pnlSearchInput.Padding = New Padding(5)
        pnlSearchInput.Size = New Size(272, 38)
        pnlSearchInput.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        pnlSearchInput.TabIndex = 6
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.FromArgb(CByte(18), CByte(23), CByte(37))
        txtSearch.BorderStyle = BorderStyle.None
        txtSearch.Font = New Font("Segoe UI Semibold", 10F)
        txtSearch.ForeColor = Color.Gainsboro
        txtSearch.Location = New Point(34, 10)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search anime..."
        txtSearch.Size = New Size(228, 18)
        txtSearch.TabIndex = 0
        ' 
        ' lblSearchIcon
        ' 
        lblSearchIcon.AutoSize = True
        lblSearchIcon.Font = New Font("Segoe UI Symbol", 10F)
        lblSearchIcon.ForeColor = Color.FromArgb(CByte(130), CByte(139), CByte(157))
        lblSearchIcon.Location = New Point(10, 9)
        lblSearchIcon.Name = "lblSearchIcon"
        lblSearchIcon.Size = New Size(20, 19)
        lblSearchIcon.TabIndex = 1
        lblSearchIcon.Text = "⌕"
        ' 
        ' btnSearch
        ' 
        btnSearch.AutoSize = False
        btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSearch.BackColor = Color.FromArgb(CByte(25), CByte(31), CByte(48))
        btnSearch.Cursor = Cursors.Hand
        btnSearch.Density = MaterialButton.MaterialButtonDensity.Default
        btnSearch.Depth = 0
        btnSearch.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnSearch.ForeColor = Color.WhiteSmoke
        btnSearch.HighEmphasis = True
        btnSearch.Icon = Nothing
        btnSearch.IconType = MaterialButton.MaterialIconType.Rebase
        btnSearch.Location = New Point(1116, 50)
        btnSearch.Margin = New Padding(4, 6, 4, 6)
        btnSearch.MinimumSize = New Size(70, 38)
        btnSearch.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        btnSearch.Name = "btnSearch"
        btnSearch.NoAccentTextColor = Color.Empty
        btnSearch.Size = New Size(70, 38)
        btnSearch.TabIndex = 7
        btnSearch.Text = "Cari"
        btnSearch.Type = MaterialButton.MaterialButtonType.Contained
        btnSearch.UseAccentColor = False
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.AutoSize = False
        btnRefresh.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnRefresh.BackColor = Color.FromArgb(CByte(44), CByte(186), CByte(210))
        btnRefresh.Cursor = Cursors.Hand
        btnRefresh.Density = MaterialButton.MaterialButtonDensity.Default
        btnRefresh.Depth = 0
        btnRefresh.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.FromArgb(CByte(10), CByte(48), CByte(62))
        btnRefresh.HighEmphasis = True
        btnRefresh.Icon = Nothing
        btnRefresh.IconType = MaterialButton.MaterialIconType.Rebase
        btnRefresh.Location = New Point(1194, 50)
        btnRefresh.Margin = New Padding(4, 6, 4, 6)
        btnRefresh.MinimumSize = New Size(62, 38)
        btnRefresh.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        btnRefresh.Name = "btnRefresh"
        btnRefresh.NoAccentTextColor = Color.Empty
        btnRefresh.Size = New Size(62, 38)
        btnRefresh.TabIndex = 8
        btnRefresh.Text = "↻"
        btnRefresh.Type = MaterialButton.MaterialButtonType.Contained
        btnRefresh.UseAccentColor = False
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' pnlContentHost
        ' 
        pnlContentHost.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlContentHost.BackColor = Color.FromArgb(CByte(39), CByte(51), CByte(63))
        pnlContentHost.Controls.Add(pnlDashboard)
        pnlContentHost.Controls.Add(pnlWatch)
        pnlContentHost.EdgeColor = Color.FromArgb(CByte(32), CByte(41), CByte(50))
        pnlContentHost.Location = New Point(24, 98)
        pnlContentHost.Name = "pnlContentHost"
        pnlContentHost.Padding = New Padding(5)
        pnlContentHost.Size = New Size(1232, 638)
        pnlContentHost.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        pnlContentHost.TabIndex = 9
        ' 
        ' pnlDashboard
        ' 
        pnlDashboard.BackColor = Color.FromArgb(CByte(39), CByte(51), CByte(63))
        pnlDashboard.Controls.Add(lblDashboardHint)
        pnlDashboard.Controls.Add(flpEpisodeRow)
        pnlDashboard.Controls.Add(btnEpisodeNext)
        pnlDashboard.Controls.Add(btnEpisodePrev)
        pnlDashboard.Controls.Add(lblRowTitle)
        pnlDashboard.Controls.Add(pnlFeatured)
        pnlDashboard.Dock = DockStyle.Fill
        pnlDashboard.EdgeColor = Color.FromArgb(CByte(32), CByte(41), CByte(50))
        pnlDashboard.Location = New Point(5, 5)
        pnlDashboard.Name = "pnlDashboard"
        pnlDashboard.Padding = New Padding(5)
        pnlDashboard.Size = New Size(1222, 628)
        pnlDashboard.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        pnlDashboard.TabIndex = 0
        ' 
        ' lblDashboardHint
        ' 
        lblDashboardHint.BackColor = Color.Transparent
        lblDashboardHint.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        lblDashboardHint.ForeColor = Color.FromArgb(CByte(130), CByte(139), CByte(157))
        lblDashboardHint.Location = New Point(12, 604)
        lblDashboardHint.Name = "lblDashboardHint"
        lblDashboardHint.Size = New Size(1208, 22)
        lblDashboardHint.TabIndex = 3
        lblDashboardHint.Text = "Pilih episode untuk masuk mode nonton."
        lblDashboardHint.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' flpEpisodeRow
        ' 
        flpEpisodeRow.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        flpEpisodeRow.AutoScroll = False
        flpEpisodeRow.Location = New Point(12, 396)
        flpEpisodeRow.Name = "flpEpisodeRow"
        flpEpisodeRow.Size = New Size(1198, 192)
        flpEpisodeRow.TabIndex = 2
        flpEpisodeRow.WrapContents = False
        ' 
        ' lblRowTitle
        ' 
        lblRowTitle.AutoSize = True
        lblRowTitle.BackColor = Color.Transparent
        lblRowTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblRowTitle.ForeColor = Color.FromArgb(CByte(238), CByte(242), CByte(250))
        lblRowTitle.Location = New Point(12, 364)
        lblRowTitle.Name = "lblRowTitle"
        lblRowTitle.Size = New Size(186, 25)
        lblRowTitle.TabIndex = 1
        lblRowTitle.Text = "Episode Terbaru Live"
        ' 
        ' btnEpisodePrev
        ' 
        btnEpisodePrev.AutoSize = False
        btnEpisodePrev.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnEpisodePrev.BackColor = Color.FromArgb(CByte(25), CByte(31), CByte(48))
        btnEpisodePrev.Cursor = Cursors.Hand
        btnEpisodePrev.Density = MaterialButton.MaterialButtonDensity.Default
        btnEpisodePrev.Depth = 0
        btnEpisodePrev.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnEpisodePrev.ForeColor = Color.Gainsboro
        btnEpisodePrev.HighEmphasis = True
        btnEpisodePrev.Icon = Nothing
        btnEpisodePrev.IconType = MaterialButton.MaterialIconType.Rebase
        btnEpisodePrev.Location = New Point(1114, 358)
        btnEpisodePrev.Margin = New Padding(4, 6, 4, 6)
        btnEpisodePrev.MinimumSize = New Size(44, 32)
        btnEpisodePrev.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        btnEpisodePrev.Name = "btnEpisodePrev"
        btnEpisodePrev.NoAccentTextColor = Color.Empty
        btnEpisodePrev.Size = New Size(44, 32)
        btnEpisodePrev.TabIndex = 4
        btnEpisodePrev.Text = "◀"
        btnEpisodePrev.Type = MaterialButton.MaterialButtonType.Contained
        btnEpisodePrev.UseAccentColor = False
        btnEpisodePrev.UseVisualStyleBackColor = False
        ' 
        ' btnEpisodeNext
        ' 
        btnEpisodeNext.AutoSize = False
        btnEpisodeNext.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnEpisodeNext.BackColor = Color.FromArgb(CByte(25), CByte(31), CByte(48))
        btnEpisodeNext.Cursor = Cursors.Hand
        btnEpisodeNext.Density = MaterialButton.MaterialButtonDensity.Default
        btnEpisodeNext.Depth = 0
        btnEpisodeNext.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnEpisodeNext.ForeColor = Color.Gainsboro
        btnEpisodeNext.HighEmphasis = True
        btnEpisodeNext.Icon = Nothing
        btnEpisodeNext.IconType = MaterialButton.MaterialIconType.Rebase
        btnEpisodeNext.Location = New Point(1166, 358)
        btnEpisodeNext.Margin = New Padding(4, 6, 4, 6)
        btnEpisodeNext.MinimumSize = New Size(44, 32)
        btnEpisodeNext.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        btnEpisodeNext.Name = "btnEpisodeNext"
        btnEpisodeNext.NoAccentTextColor = Color.Empty
        btnEpisodeNext.Size = New Size(44, 32)
        btnEpisodeNext.TabIndex = 5
        btnEpisodeNext.Text = "▶"
        btnEpisodeNext.Type = MaterialButton.MaterialButtonType.Contained
        btnEpisodeNext.UseAccentColor = False
        btnEpisodeNext.UseVisualStyleBackColor = False
        ' 
        ' pnlFeatured
        ' 
        pnlFeatured.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlFeatured.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(24))
        pnlFeatured.Controls.Add(picFeaturedBackdrop)
        pnlFeatured.Controls.Add(pnlFeaturedOverlay)
        pnlFeatured.EdgeColor = Color.FromArgb(CByte(32), CByte(41), CByte(50))
        pnlFeatured.Location = New Point(12, 12)
        pnlFeatured.Name = "pnlFeatured"
        pnlFeatured.Padding = New Padding(5)
        pnlFeatured.Size = New Size(1198, 340)
        pnlFeatured.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        pnlFeatured.TabIndex = 0
        ' 
        ' picFeaturedBackdrop
        ' 
        picFeaturedBackdrop.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(24))
        picFeaturedBackdrop.Dock = DockStyle.Fill
        picFeaturedBackdrop.Location = New Point(475, 5)
        picFeaturedBackdrop.Name = "picFeaturedBackdrop"
        picFeaturedBackdrop.Size = New Size(718, 330)
        picFeaturedBackdrop.SizeMode = PictureBoxSizeMode.Zoom
        picFeaturedBackdrop.TabIndex = 0
        picFeaturedBackdrop.TabStop = False
        ' 
        ' pnlFeaturedOverlay
        ' 
        pnlFeaturedOverlay.BackColor = Color.FromArgb(CByte(12), CByte(18), CByte(30))
        pnlFeaturedOverlay.Controls.Add(btnFeaturedInfo)
        pnlFeaturedOverlay.Controls.Add(btnFeaturedPlay)
        pnlFeaturedOverlay.Controls.Add(lblFeaturedDesc)
        pnlFeaturedOverlay.Controls.Add(lblFeaturedMeta)
        pnlFeaturedOverlay.Controls.Add(lblFeaturedTitle)
        pnlFeaturedOverlay.Controls.Add(lblFeaturedTag)
        pnlFeaturedOverlay.Dock = DockStyle.Left
        pnlFeaturedOverlay.EdgeColor = Color.FromArgb(CByte(32), CByte(41), CByte(50))
        pnlFeaturedOverlay.Location = New Point(5, 5)
        pnlFeaturedOverlay.Name = "pnlFeaturedOverlay"
        pnlFeaturedOverlay.Padding = New Padding(5)
        pnlFeaturedOverlay.Size = New Size(470, 330)
        pnlFeaturedOverlay.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        pnlFeaturedOverlay.TabIndex = 1
        ' 
        ' btnFeaturedInfo
        ' 
        btnFeaturedInfo.AutoSize = False
        btnFeaturedInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnFeaturedInfo.BackColor = Color.FromArgb(CByte(25), CByte(31), CByte(48))
        btnFeaturedInfo.Cursor = Cursors.Hand
        btnFeaturedInfo.Density = MaterialButton.MaterialButtonDensity.Default
        btnFeaturedInfo.Depth = 0
        btnFeaturedInfo.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnFeaturedInfo.ForeColor = Color.FromArgb(CByte(230), CByte(235), CByte(246))
        btnFeaturedInfo.HighEmphasis = True
        btnFeaturedInfo.Icon = Nothing
        btnFeaturedInfo.IconType = MaterialButton.MaterialIconType.Rebase
        btnFeaturedInfo.Location = New Point(197, 268)
        btnFeaturedInfo.Margin = New Padding(4, 6, 4, 6)
        btnFeaturedInfo.MinimumSize = New Size(130, 42)
        btnFeaturedInfo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        btnFeaturedInfo.Name = "btnFeaturedInfo"
        btnFeaturedInfo.NoAccentTextColor = Color.Empty
        btnFeaturedInfo.Size = New Size(130, 42)
        btnFeaturedInfo.TabIndex = 5
        btnFeaturedInfo.Text = "Detail"
        btnFeaturedInfo.Type = MaterialButton.MaterialButtonType.Contained
        btnFeaturedInfo.UseAccentColor = False
        btnFeaturedInfo.UseVisualStyleBackColor = False
        ' 
        ' btnFeaturedPlay
        ' 
        btnFeaturedPlay.AutoSize = False
        btnFeaturedPlay.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnFeaturedPlay.BackColor = Color.FromArgb(CByte(44), CByte(186), CByte(210))
        btnFeaturedPlay.Cursor = Cursors.Hand
        btnFeaturedPlay.Density = MaterialButton.MaterialButtonDensity.Default
        btnFeaturedPlay.Depth = 0
        btnFeaturedPlay.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnFeaturedPlay.ForeColor = Color.FromArgb(CByte(10), CByte(48), CByte(62))
        btnFeaturedPlay.HighEmphasis = True
        btnFeaturedPlay.Icon = Nothing
        btnFeaturedPlay.IconType = MaterialButton.MaterialIconType.Rebase
        btnFeaturedPlay.Location = New Point(52, 268)
        btnFeaturedPlay.Margin = New Padding(4, 6, 4, 6)
        btnFeaturedPlay.MinimumSize = New Size(130, 42)
        btnFeaturedPlay.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        btnFeaturedPlay.Name = "btnFeaturedPlay"
        btnFeaturedPlay.NoAccentTextColor = Color.Empty
        btnFeaturedPlay.Size = New Size(130, 42)
        btnFeaturedPlay.TabIndex = 4
        btnFeaturedPlay.Text = "▶ Play"
        btnFeaturedPlay.Type = MaterialButton.MaterialButtonType.Contained
        btnFeaturedPlay.UseAccentColor = False
        btnFeaturedPlay.UseVisualStyleBackColor = False
        ' 
        ' lblFeaturedDesc
        ' 
        lblFeaturedDesc.BackColor = Color.Transparent
        lblFeaturedDesc.Font = New Font("Segoe UI", 10F)
        lblFeaturedDesc.ForeColor = Color.FromArgb(CByte(190), CByte(199), CByte(216))
        lblFeaturedDesc.Location = New Point(52, 143)
        lblFeaturedDesc.Name = "lblFeaturedDesc"
        lblFeaturedDesc.Size = New Size(364, 107)
        lblFeaturedDesc.TabIndex = 3
        lblFeaturedDesc.Text = "Klik Play untuk masuk mode nonton dengan live chat tanpa pindah layar."
        ' 
        ' lblFeaturedMeta
        ' 
        lblFeaturedMeta.AutoSize = True
        lblFeaturedMeta.BackColor = Color.Transparent
        lblFeaturedMeta.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblFeaturedMeta.ForeColor = Color.FromArgb(CByte(84), CByte(234), CByte(255))
        lblFeaturedMeta.Location = New Point(52, 112)
        lblFeaturedMeta.Name = "lblFeaturedMeta"
        lblFeaturedMeta.Size = New Size(126, 19)
        lblFeaturedMeta.TabIndex = 2
        lblFeaturedMeta.Text = "Episode • Ongoing"
        ' 
        ' lblFeaturedTitle
        ' 
        lblFeaturedTitle.BackColor = Color.Transparent
        lblFeaturedTitle.Font = New Font("Segoe UI Semibold", 26F, FontStyle.Bold)
        lblFeaturedTitle.ForeColor = Color.FromArgb(CByte(238), CByte(242), CByte(250))
        lblFeaturedTitle.Location = New Point(52, 49)
        lblFeaturedTitle.Name = "lblFeaturedTitle"
        lblFeaturedTitle.Size = New Size(380, 62)
        lblFeaturedTitle.TabIndex = 1
        lblFeaturedTitle.Text = "Loading..."
        ' 
        ' lblFeaturedTag
        ' 
        lblFeaturedTag.AutoSize = True
        lblFeaturedTag.BackColor = Color.Transparent
        lblFeaturedTag.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblFeaturedTag.ForeColor = Color.FromArgb(CByte(150), CByte(158), CByte(171))
        lblFeaturedTag.Location = New Point(52, 23)
        lblFeaturedTag.Name = "lblFeaturedTag"
        lblFeaturedTag.Size = New Size(86, 15)
        lblFeaturedTag.TabIndex = 0
        lblFeaturedTag.Text = "ANIMIT PICKS"
        ' 
        ' pnlWatch
        ' 
        pnlWatch.BackColor = Color.FromArgb(CByte(39), CByte(51), CByte(63))
        pnlWatch.Controls.Add(lblWatchHint)
        pnlWatch.Controls.Add(flpWatchEpisodes)
        pnlWatch.Controls.Add(lblWatchEpisodesTitle)
        pnlWatch.Controls.Add(pnlLiveChat)
        pnlWatch.Controls.Add(pnlWatchPlayer)
        pnlWatch.Controls.Add(btnBackToBrowse)
        pnlWatch.Dock = DockStyle.Fill
        pnlWatch.EdgeColor = Color.FromArgb(CByte(32), CByte(41), CByte(50))
        pnlWatch.Location = New Point(5, 5)
        pnlWatch.Name = "pnlWatch"
        pnlWatch.Padding = New Padding(5)
        pnlWatch.Size = New Size(1222, 628)
        pnlWatch.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        pnlWatch.TabIndex = 1
        pnlWatch.Visible = False
        ' 
        ' lblWatchHint
        ' 
        lblWatchHint.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblWatchHint.BackColor = Color.Transparent
        lblWatchHint.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        lblWatchHint.ForeColor = Color.FromArgb(CByte(130), CByte(139), CByte(157))
        lblWatchHint.Location = New Point(12, 594)
        lblWatchHint.Name = "lblWatchHint"
        lblWatchHint.Size = New Size(1198, 22)
        lblWatchHint.TabIndex = 5
        lblWatchHint.Text = "Mode nonton aktif."
        lblWatchHint.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' flpWatchEpisodes
        ' 
        flpWatchEpisodes.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        flpWatchEpisodes.AutoScroll = False
        flpWatchEpisodes.Location = New Point(12, 453)
        flpWatchEpisodes.Name = "flpWatchEpisodes"
        flpWatchEpisodes.Size = New Size(832, 135)
        flpWatchEpisodes.TabIndex = 4
        flpWatchEpisodes.WrapContents = True
        ' 
        ' lblWatchEpisodesTitle
        ' 
        lblWatchEpisodesTitle.AutoSize = True
        lblWatchEpisodesTitle.BackColor = Color.Transparent
        lblWatchEpisodesTitle.Font = New Font("Segoe UI Semibold", 12.5F, FontStyle.Bold)
        lblWatchEpisodesTitle.ForeColor = Color.FromArgb(CByte(238), CByte(242), CByte(250))
        lblWatchEpisodesTitle.Location = New Point(12, 432)
        lblWatchEpisodesTitle.Name = "lblWatchEpisodesTitle"
        lblWatchEpisodesTitle.Size = New Size(122, 23)
        lblWatchEpisodesTitle.TabIndex = 3
        lblWatchEpisodesTitle.Text = "Daftar Episode"
        ' 
        ' pnlLiveChat
        ' 
        pnlLiveChat.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        pnlLiveChat.BackColor = Color.FromArgb(CByte(12), CByte(18), CByte(30))
        pnlLiveChat.Controls.Add(pnlChatInput)
        pnlLiveChat.Controls.Add(flpLiveChat)
        pnlLiveChat.Controls.Add(lblLiveChatCounter)
        pnlLiveChat.Controls.Add(lblLiveChatTitle)
        pnlLiveChat.EdgeColor = Color.FromArgb(CByte(32), CByte(41), CByte(50))
        pnlLiveChat.Location = New Point(856, 52)
        pnlLiveChat.Name = "pnlLiveChat"
        pnlLiveChat.Padding = New Padding(5)
        pnlLiveChat.Size = New Size(354, 536)
        pnlLiveChat.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        pnlLiveChat.TabIndex = 2
        ' 
        ' pnlChatInput
        ' 
        pnlChatInput.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlChatInput.BackColor = Color.FromArgb(CByte(18), CByte(24), CByte(38))
        pnlChatInput.Controls.Add(btnSendChat)
        pnlChatInput.Controls.Add(txtChatInput)
        pnlChatInput.EdgeColor = Color.FromArgb(CByte(32), CByte(41), CByte(50))
        pnlChatInput.Location = New Point(14, 484)
        pnlChatInput.Name = "pnlChatInput"
        pnlChatInput.Padding = New Padding(5)
        pnlChatInput.Size = New Size(326, 50)
        pnlChatInput.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        pnlChatInput.TabIndex = 3
        ' 
        ' btnSendChat
        ' 
        btnSendChat.AutoSize = False
        btnSendChat.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSendChat.BackColor = Color.FromArgb(CByte(44), CByte(186), CByte(210))
        btnSendChat.Cursor = Cursors.Hand
        btnSendChat.Density = MaterialButton.MaterialButtonDensity.Default
        btnSendChat.Depth = 0
        btnSendChat.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        btnSendChat.ForeColor = Color.FromArgb(CByte(10), CByte(48), CByte(62))
        btnSendChat.HighEmphasis = True
        btnSendChat.Icon = Nothing
        btnSendChat.IconType = MaterialButton.MaterialIconType.Rebase
        btnSendChat.Location = New Point(262, 8)
        btnSendChat.Margin = New Padding(4, 6, 4, 6)
        btnSendChat.MinimumSize = New Size(60, 32)
        btnSendChat.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        btnSendChat.Name = "btnSendChat"
        btnSendChat.NoAccentTextColor = Color.Empty
        btnSendChat.Size = New Size(60, 32)
        btnSendChat.TabIndex = 1
        btnSendChat.Text = "Kirim"
        btnSendChat.Type = MaterialButton.MaterialButtonType.Contained
        btnSendChat.UseAccentColor = False
        btnSendChat.UseVisualStyleBackColor = False
        ' 
        ' txtChatInput
        ' 
        txtChatInput.BackColor = Color.FromArgb(CByte(18), CByte(24), CByte(38))
        txtChatInput.BorderStyle = BorderStyle.FixedSingle
        txtChatInput.Font = New Font("Segoe UI Semibold", 10F)
        txtChatInput.ForeColor = Color.Gainsboro
        txtChatInput.Location = New Point(10, 12)
        txtChatInput.Name = "txtChatInput"
        txtChatInput.PlaceholderText = "Ketik komentar..."
        txtChatInput.Size = New Size(246, 24)
        txtChatInput.TabIndex = 0
        ' 
        ' flpLiveChat
        ' 
        flpLiveChat.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        flpLiveChat.AutoScroll = True
        flpLiveChat.FlowDirection = FlowDirection.TopDown
        flpLiveChat.Location = New Point(14, 52)
        flpLiveChat.Name = "flpLiveChat"
        flpLiveChat.Size = New Size(326, 424)
        flpLiveChat.TabIndex = 2
        flpLiveChat.WrapContents = False
        ' 
        ' lblLiveChatCounter
        ' 
        lblLiveChatCounter.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblLiveChatCounter.BackColor = Color.Transparent
        lblLiveChatCounter.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblLiveChatCounter.ForeColor = Color.FromArgb(CByte(130), CByte(139), CByte(157))
        lblLiveChatCounter.Location = New Point(245, 18)
        lblLiveChatCounter.Name = "lblLiveChatCounter"
        lblLiveChatCounter.Size = New Size(95, 15)
        lblLiveChatCounter.TabIndex = 1
        lblLiveChatCounter.Text = "0 LIVE"
        lblLiveChatCounter.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblLiveChatTitle
        ' 
        lblLiveChatTitle.AutoSize = True
        lblLiveChatTitle.BackColor = Color.Transparent
        lblLiveChatTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblLiveChatTitle.ForeColor = Color.FromArgb(CByte(238), CByte(242), CByte(250))
        lblLiveChatTitle.Location = New Point(14, 16)
        lblLiveChatTitle.Name = "lblLiveChatTitle"
        lblLiveChatTitle.Size = New Size(77, 19)
        lblLiveChatTitle.TabIndex = 0
        lblLiveChatTitle.Text = "LIVE CHAT"
        ' 
        ' pnlWatchPlayer
        ' 
        pnlWatchPlayer.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlWatchPlayer.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(24))
        pnlWatchPlayer.Controls.Add(webEpisodePlayer)
        pnlWatchPlayer.Controls.Add(picWatchBackdrop)
        pnlWatchPlayer.Controls.Add(pnlWatchOverlay)
        pnlWatchPlayer.EdgeColor = Color.FromArgb(CByte(32), CByte(41), CByte(50))
        pnlWatchPlayer.Location = New Point(12, 52)
        pnlWatchPlayer.Name = "pnlWatchPlayer"
        pnlWatchPlayer.Padding = New Padding(5)
        pnlWatchPlayer.Size = New Size(832, 374)
        pnlWatchPlayer.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        pnlWatchPlayer.TabIndex = 1
        ' 
        ' webEpisodePlayer
        ' 
        webEpisodePlayer.Dock = DockStyle.Fill
        webEpisodePlayer.Location = New Point(5, 5)
        webEpisodePlayer.CreationProperties = Nothing
        webEpisodePlayer.DefaultBackgroundColor = Color.FromArgb(CByte(10), CByte(15), CByte(24))
        webEpisodePlayer.Name = "webEpisodePlayer"
        webEpisodePlayer.Size = New Size(822, 208)
        webEpisodePlayer.TabIndex = 2
        webEpisodePlayer.Visible = False
        webEpisodePlayer.ZoomFactor = 1R
        ' 
        ' picWatchBackdrop
        ' 
        picWatchBackdrop.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(24))
        picWatchBackdrop.Dock = DockStyle.Fill
        picWatchBackdrop.Location = New Point(5, 5)
        picWatchBackdrop.Name = "picWatchBackdrop"
        picWatchBackdrop.Size = New Size(822, 208)
        picWatchBackdrop.SizeMode = PictureBoxSizeMode.Zoom
        picWatchBackdrop.TabIndex = 0
        picWatchBackdrop.TabStop = False
        ' 
        ' pnlWatchOverlay
        ' 
        pnlWatchOverlay.BackColor = Color.FromArgb(CByte(8), CByte(12), CByte(20))
        pnlWatchOverlay.Controls.Add(cmbServerQuality)
        pnlWatchOverlay.Controls.Add(btnFullscreen)
        pnlWatchOverlay.Controls.Add(btnWatchExternal)
        pnlWatchOverlay.Controls.Add(lblWatchDesc)
        pnlWatchOverlay.Controls.Add(lblWatchTitle)
        pnlWatchOverlay.Controls.Add(lblWatchMeta)
        pnlWatchOverlay.Dock = DockStyle.Bottom
        pnlWatchOverlay.EdgeColor = Color.FromArgb(CByte(32), CByte(41), CByte(50))
        pnlWatchOverlay.Location = New Point(5, 213)
        pnlWatchOverlay.Name = "pnlWatchOverlay"
        pnlWatchOverlay.Padding = New Padding(5)
        pnlWatchOverlay.Size = New Size(822, 156)
        pnlWatchOverlay.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        pnlWatchOverlay.TabIndex = 1
        ' 
        ' cmbServerQuality
        ' 
        cmbServerQuality.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbServerQuality.BackColor = Color.FromArgb(CByte(18), CByte(24), CByte(38))
        cmbServerQuality.DropDownStyle = ComboBoxStyle.DropDownList
        cmbServerQuality.FlatStyle = FlatStyle.Flat
        cmbServerQuality.Font = New Font("Segoe UI Semibold", 9F)
        cmbServerQuality.ForeColor = Color.Gainsboro
        cmbServerQuality.FormattingEnabled = True
        cmbServerQuality.Location = New Point(496, 20)
        cmbServerQuality.Name = "cmbServerQuality"
        cmbServerQuality.Size = New Size(150, 23)
        cmbServerQuality.TabIndex = 4
        ' 
        ' btnFullscreen
        ' 
        btnFullscreen.AutoSize = False
        btnFullscreen.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnFullscreen.BackColor = Color.FromArgb(CByte(25), CByte(31), CByte(48))
        btnFullscreen.Cursor = Cursors.Hand
        btnFullscreen.Density = MaterialButton.MaterialButtonDensity.Default
        btnFullscreen.Depth = 0
        btnFullscreen.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnFullscreen.ForeColor = Color.Gainsboro
        btnFullscreen.HighEmphasis = True
        btnFullscreen.Icon = Nothing
        btnFullscreen.IconType = MaterialButton.MaterialIconType.Rebase
        btnFullscreen.Location = New Point(618, 14)
        btnFullscreen.Margin = New Padding(4, 6, 4, 6)
        btnFullscreen.MinimumSize = New Size(50, 38)
        btnFullscreen.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        btnFullscreen.Name = "btnFullscreen"
        btnFullscreen.NoAccentTextColor = Color.Empty
        btnFullscreen.Size = New Size(50, 38)
        btnFullscreen.TabIndex = 6
        btnFullscreen.Text = "⛶"
        btnFullscreen.Type = MaterialButton.MaterialButtonType.Contained
        btnFullscreen.UseAccentColor = False
        btnFullscreen.UseVisualStyleBackColor = False
        ' 
        ' btnWatchExternal
        ' 
        btnWatchExternal.AutoSize = False
        btnWatchExternal.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnWatchExternal.BackColor = Color.FromArgb(CByte(44), CByte(186), CByte(210))
        btnWatchExternal.Cursor = Cursors.Hand
        btnWatchExternal.Density = MaterialButton.MaterialButtonDensity.Default
        btnWatchExternal.Depth = 0
        btnWatchExternal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnWatchExternal.ForeColor = Color.FromArgb(CByte(10), CByte(48), CByte(62))
        btnWatchExternal.HighEmphasis = True
        btnWatchExternal.Icon = Nothing
        btnWatchExternal.IconType = MaterialButton.MaterialIconType.Rebase
        btnWatchExternal.Location = New Point(676, 14)
        btnWatchExternal.Margin = New Padding(4, 6, 4, 6)
        btnWatchExternal.MinimumSize = New Size(150, 38)
        btnWatchExternal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        btnWatchExternal.Name = "btnWatchExternal"
        btnWatchExternal.NoAccentTextColor = Color.Empty
        btnWatchExternal.Size = New Size(150, 38)
        btnWatchExternal.TabIndex = 7
        btnWatchExternal.Text = "Play Ulang"
        btnWatchExternal.Type = MaterialButton.MaterialButtonType.Contained
        btnWatchExternal.UseAccentColor = False
        btnWatchExternal.UseVisualStyleBackColor = False
        ' 
        ' lblWatchDesc
        ' 
        lblWatchDesc.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblWatchDesc.BackColor = Color.Transparent
        lblWatchDesc.Font = New Font("Segoe UI", 9.5F)
        lblWatchDesc.ForeColor = Color.FromArgb(CByte(190), CByte(199), CByte(216))
        lblWatchDesc.Location = New Point(16, 79)
        lblWatchDesc.Name = "lblWatchDesc"
        lblWatchDesc.Size = New Size(790, 64)
        lblWatchDesc.TabIndex = 2
        lblWatchDesc.Text = "Sinopsis akan tampil di sini."
        ' 
        ' lblWatchTitle
        ' 
        lblWatchTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblWatchTitle.BackColor = Color.Transparent
        lblWatchTitle.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        lblWatchTitle.ForeColor = Color.FromArgb(CByte(238), CByte(242), CByte(250))
        lblWatchTitle.Location = New Point(16, 28)
        lblWatchTitle.Name = "lblWatchTitle"
        lblWatchTitle.Size = New Size(626, 43)
        lblWatchTitle.TabIndex = 1
        lblWatchTitle.Text = "Loading episode..."
        ' 
        ' lblWatchMeta
        ' 
        lblWatchMeta.AutoSize = True
        lblWatchMeta.BackColor = Color.Transparent
        lblWatchMeta.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblWatchMeta.ForeColor = Color.FromArgb(CByte(84), CByte(234), CByte(255))
        lblWatchMeta.Location = New Point(16, 10)
        lblWatchMeta.Name = "lblWatchMeta"
        lblWatchMeta.Size = New Size(98, 17)
        lblWatchMeta.TabIndex = 0
        lblWatchMeta.Text = "EPISODE • LIVE"
        ' 
        ' btnBackToBrowse
        ' 
        btnBackToBrowse.AutoSize = False
        btnBackToBrowse.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnBackToBrowse.BackColor = Color.FromArgb(CByte(25), CByte(31), CByte(48))
        btnBackToBrowse.Cursor = Cursors.Hand
        btnBackToBrowse.Density = MaterialButton.MaterialButtonDensity.Default
        btnBackToBrowse.Depth = 0
        btnBackToBrowse.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnBackToBrowse.ForeColor = Color.FromArgb(CByte(230), CByte(235), CByte(246))
        btnBackToBrowse.HighEmphasis = True
        btnBackToBrowse.Icon = Nothing
        btnBackToBrowse.IconType = MaterialButton.MaterialIconType.Rebase
        btnBackToBrowse.Location = New Point(12, 10)
        btnBackToBrowse.Margin = New Padding(4, 6, 4, 6)
        btnBackToBrowse.MinimumSize = New Size(128, 34)
        btnBackToBrowse.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER
        btnBackToBrowse.Name = "btnBackToBrowse"
        btnBackToBrowse.NoAccentTextColor = Color.Empty
        btnBackToBrowse.Size = New Size(128, 34)
        btnBackToBrowse.TabIndex = 0
        btnBackToBrowse.Text = "← Dashboard"
        btnBackToBrowse.Type = MaterialButton.MaterialButtonType.Contained
        btnBackToBrowse.UseAccentColor = False
        btnBackToBrowse.UseVisualStyleBackColor = False
        ' 
        ' tmrLiveChat
        ' 
        tmrLiveChat.Interval = 8000
        ' 
        ' MainPage
        ' 
        ClientSize = New Size(1280, 760)
        Controls.Add(NightForm1)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(1920, 1080)
        MinimumSize = New Size(1020, 700)
        Name = "MainPage"
        StartPosition = FormStartPosition.CenterScreen
        TransparencyKey = Color.Fuchsia
        NightForm1.ResumeLayout(False)
        NightForm1.PerformLayout()
        pnlSearchInput.ResumeLayout(False)
        pnlSearchInput.PerformLayout()
        pnlContentHost.ResumeLayout(False)
        pnlDashboard.ResumeLayout(False)
        pnlDashboard.PerformLayout()
        pnlFeatured.ResumeLayout(False)
        CType(picFeaturedBackdrop, ComponentModel.ISupportInitialize).EndInit()
        pnlFeaturedOverlay.ResumeLayout(False)
        pnlFeaturedOverlay.PerformLayout()
        pnlWatch.ResumeLayout(False)
        pnlWatch.PerformLayout()
        pnlLiveChat.ResumeLayout(False)
        pnlLiveChat.PerformLayout()
        pnlChatInput.ResumeLayout(False)
        pnlChatInput.PerformLayout()
        pnlWatchPlayer.ResumeLayout(False)
        CType(picWatchBackdrop, ComponentModel.ISupportInitialize).EndInit()
        pnlWatchOverlay.ResumeLayout(False)
        pnlWatchOverlay.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents NightForm1 As NightForm
    Friend WithEvents lblClose As Label
    Friend WithEvents lnkLogout As NightLinkLabel
    Friend WithEvents lnkSocial As NightLinkLabel
    Friend WithEvents lnkNavMovies As NightLinkLabel
    Friend WithEvents lnkNavSimulcasts As NightLinkLabel
    Friend WithEvents lnkNavBrowse As NightLinkLabel
    Friend WithEvents pnlSearchInput As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearchIcon As Label
    Friend WithEvents btnSearch As StableActionButton
    Friend WithEvents btnRefresh As StableActionButton
    Friend WithEvents pnlContentHost As Panel
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents lblDashboardHint As NightLabel
    Friend WithEvents flpEpisodeRow As FlowLayoutPanel
    Friend WithEvents lblRowTitle As NightLabel
    Friend WithEvents btnEpisodePrev As StableActionButton
    Friend WithEvents btnEpisodeNext As StableActionButton
    Friend WithEvents pnlFeatured As Panel
    Friend WithEvents pnlFeaturedOverlay As Panel
    Friend WithEvents btnFeaturedInfo As StableActionButton
    Friend WithEvents btnFeaturedPlay As StableActionButton
    Friend WithEvents lblFeaturedDesc As NightLabel
    Friend WithEvents lblFeaturedMeta As NightLabel
    Friend WithEvents lblFeaturedTitle As NightLabel
    Friend WithEvents lblFeaturedTag As NightLabel
    Friend WithEvents picFeaturedBackdrop As PictureBox
    Friend WithEvents pnlWatch As Panel
    Friend WithEvents lblWatchHint As NightLabel
    Friend WithEvents flpWatchEpisodes As FlowLayoutPanel
    Friend WithEvents lblWatchEpisodesTitle As NightLabel
    Friend WithEvents pnlLiveChat As Panel
    Friend WithEvents pnlChatInput As Panel
    Friend WithEvents btnSendChat As StableActionButton
    Friend WithEvents txtChatInput As TextBox
    Friend WithEvents flpLiveChat As FlowLayoutPanel
    Friend WithEvents lblLiveChatCounter As NightLabel
    Friend WithEvents lblLiveChatTitle As NightLabel
    Friend WithEvents pnlWatchPlayer As Panel
    Friend WithEvents pnlWatchOverlay As Panel
    Friend WithEvents cmbServerQuality As ComboBox
    Friend WithEvents btnFullscreen As StableActionButton
    Friend WithEvents btnWatchExternal As StableActionButton
    Friend WithEvents lblWatchDesc As NightLabel
    Friend WithEvents lblWatchTitle As NightLabel
    Friend WithEvents lblWatchMeta As NightLabel
    Friend WithEvents webEpisodePlayer As WebView2
    Friend WithEvents picWatchBackdrop As PictureBox
    Friend WithEvents btnBackToBrowse As StableActionButton
    Friend WithEvents tmrLiveChat As Timer
End Class
