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
        lblBrand = New NightLabel()
        lnkNavBrowse = New NightLinkLabel()
        lnkNavSimulcasts = New NightLinkLabel()
        lnkNavMovies = New NightLinkLabel()
        lnkSocial = New NightLinkLabel()
        lnkLogout = New NightLinkLabel()
        pnlProfileAvatar = New Panel()
        lblProfileInitial = New Label()
        picMainAvatar = New PictureBox()
        pnlSearchInput = New Panel()
        lblSearchIcon = New Label()
        txtSearch = New TextBox()
        btnSearch = New StableActionButton()
        btnRefresh = New StableActionButton()
        pnlContentHost = New Panel()
        pnlDashboard = New Panel()
        pnlFeatured = New Panel()
        picFeaturedBackdrop = New PictureBox()
        pnlFeaturedOverlay = New Panel()
        lblFeaturedTag = New NightLabel()
        lblFeaturedTitle = New NightLabel()
        lblFeaturedMeta = New NightLabel()
        lblFeaturedDesc = New NightLabel()
        btnFeaturedPlay = New StableActionButton()
        btnFeaturedInfo = New StableActionButton()
        lblRowTitle = New NightLabel()
        btnEpisodePrev = New StableActionButton()
        btnEpisodeNext = New StableActionButton()
        flpEpisodeRow = New FlowLayoutPanel()
        lblDashboardHint = New NightLabel()
        pnlWatch = New Panel()
        btnBackToBrowse = New StableActionButton()
        pnlWatchPlayer = New Panel()
        picWatchBackdrop = New PictureBox()
        webEpisodePlayer = New WebView2()
        pnlWatchOverlay = New Panel()
        lblWatchMeta = New NightLabel()
        lblWatchTitle = New NightLabel()
        lblWatchDesc = New NightLabel()
        cmbServerQuality = New ComboBox()
        btnFullscreen = New StableActionButton()
        btnWatchExternal = New StableActionButton()
        pnlLiveChat = New Panel()
        lblLiveChatTitle = New NightLabel()
        lblLiveChatCounter = New NightLabel()
        flpLiveChat = New FlowLayoutPanel()
        pnlChatInput = New Panel()
        txtChatInput = New TextBox()
        btnSendChat = New StableActionButton()
        lblWatchEpisodesTitle = New NightLabel()
        flpWatchEpisodes = New FlowLayoutPanel()
        lblWatchHint = New NightLabel()
        tmrLiveChat = New Timer(components)
        NightForm1.SuspendLayout()
        pnlProfileAvatar.SuspendLayout()
        CType(picMainAvatar, ComponentModel.ISupportInitialize).BeginInit()
        pnlSearchInput.SuspendLayout()
        pnlContentHost.SuspendLayout()
        pnlDashboard.SuspendLayout()
        pnlFeatured.SuspendLayout()
        CType(picFeaturedBackdrop, ComponentModel.ISupportInitialize).BeginInit()
        pnlFeaturedOverlay.SuspendLayout()
        pnlWatch.SuspendLayout()
        pnlWatchPlayer.SuspendLayout()
        CType(picWatchBackdrop, ComponentModel.ISupportInitialize).BeginInit()
        CType(webEpisodePlayer, ComponentModel.ISupportInitialize).BeginInit()
        pnlWatchOverlay.SuspendLayout()
        pnlLiveChat.SuspendLayout()
        pnlChatInput.SuspendLayout()
        SuspendLayout()
        ' 
        ' NightForm1
        ' 
        NightForm1.BackColor = Color.FromArgb(CByte(4), CByte(7), CByte(14))
        NightForm1.Controls.Add(lblClose)
        NightForm1.Controls.Add(lblBrand)
        NightForm1.Controls.Add(lnkNavBrowse)
        NightForm1.Controls.Add(lnkNavSimulcasts)
        NightForm1.Controls.Add(lnkNavMovies)
        NightForm1.Controls.Add(lnkSocial)
        NightForm1.Controls.Add(lnkLogout)
        NightForm1.Controls.Add(pnlProfileAvatar)
        NightForm1.Controls.Add(pnlSearchInput)
        NightForm1.Controls.Add(btnSearch)
        NightForm1.Controls.Add(btnRefresh)
        NightForm1.Controls.Add(pnlContentHost)
        NightForm1.Dock = DockStyle.Fill
        NightForm1.DrawIcon = False
        NightForm1.Font = New Font("Segoe UI", 9.0F)
        NightForm1.HeadColor = Color.FromArgb(CByte(4), CByte(7), CByte(14))
        NightForm1.Location = New Point(0, 0)
        NightForm1.MinimumSize = New Size(100, 42)
        NightForm1.Name = "NightForm1"
        NightForm1.Padding = New Padding(18, 40, 18, 18)
        NightForm1.Size = New Size(1280, 720)
        NightForm1.TabIndex = 0
        NightForm1.TextAlignment = NightForm.Alignment.Left
        NightForm1.TitleBarTextColor = Color.FromArgb(CByte(83), CByte(107), CByte(138))
        ' 
        ' lblClose
        ' 
        lblClose.AutoSize = True
        lblClose.BackColor = Color.Transparent
        lblClose.Cursor = Cursors.Hand
        lblClose.Font = New Font("Segoe UI Symbol", 12.0F)
        lblClose.ForeColor = Color.FromArgb(CByte(83), CByte(107), CByte(138))
        lblClose.Location = New Point(1258, 0)
        lblClose.Name = "lblClose"
        lblClose.Size = New Size(23, 21)
        lblClose.TabIndex = 100
        lblClose.Text = "✕"
        ' 
        ' lblBrand
        ' 
        lblBrand.AutoSize = True
        lblBrand.BackColor = Color.Transparent
        lblBrand.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblBrand.ForeColor = Color.FromArgb(CByte(83), CByte(231), CByte(248))
        lblBrand.Location = New Point(48, 22)
        lblBrand.Name = "lblBrand"
        lblBrand.Size = New Size(103, 32)
        lblBrand.TabIndex = 99
        lblBrand.Text = "ANIMIT"
        ' 
        ' lnkNavBrowse
        ' 
        lnkNavBrowse.ActiveLinkColor = Color.FromArgb(CByte(93), CByte(228), CByte(245))
        lnkNavBrowse.AutoSize = True
        lnkNavBrowse.BackColor = Color.Transparent
        lnkNavBrowse.Cursor = Cursors.Hand
        lnkNavBrowse.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lnkNavBrowse.LinkBehavior = LinkBehavior.NeverUnderline
        lnkNavBrowse.LinkColor = Color.FromArgb(CByte(93), CByte(228), CByte(245))
        lnkNavBrowse.Location = New Point(157, 31)
        lnkNavBrowse.Name = "lnkNavBrowse"
        lnkNavBrowse.Size = New Size(58, 19)
        lnkNavBrowse.TabIndex = 2
        lnkNavBrowse.TabStop = True
        lnkNavBrowse.Text = "Browse"
        lnkNavBrowse.VisitedLinkColor = Color.FromArgb(CByte(93), CByte(228), CByte(245))
        ' 
        ' lnkNavSimulcasts
        ' 
        lnkNavSimulcasts.ActiveLinkColor = Color.FromArgb(CByte(93), CByte(228), CByte(245))
        lnkNavSimulcasts.AutoSize = True
        lnkNavSimulcasts.BackColor = Color.Transparent
        lnkNavSimulcasts.Cursor = Cursors.Hand
        lnkNavSimulcasts.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lnkNavSimulcasts.LinkBehavior = LinkBehavior.NeverUnderline
        lnkNavSimulcasts.LinkColor = Color.FromArgb(CByte(150), CByte(158), CByte(171))
        lnkNavSimulcasts.Location = New Point(229, 31)
        lnkNavSimulcasts.Name = "lnkNavSimulcasts"
        lnkNavSimulcasts.Size = New Size(78, 19)
        lnkNavSimulcasts.TabIndex = 3
        lnkNavSimulcasts.TabStop = True
        lnkNavSimulcasts.Text = "Simulcasts"
        lnkNavSimulcasts.VisitedLinkColor = Color.FromArgb(CByte(150), CByte(158), CByte(171))
        ' 
        ' lnkNavMovies
        ' 
        lnkNavMovies.ActiveLinkColor = Color.FromArgb(CByte(93), CByte(228), CByte(245))
        lnkNavMovies.AutoSize = True
        lnkNavMovies.BackColor = Color.Transparent
        lnkNavMovies.Cursor = Cursors.Hand
        lnkNavMovies.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lnkNavMovies.LinkBehavior = LinkBehavior.NeverUnderline
        lnkNavMovies.LinkColor = Color.FromArgb(CByte(150), CByte(158), CByte(171))
        lnkNavMovies.Location = New Point(327, 31)
        lnkNavMovies.Name = "lnkNavMovies"
        lnkNavMovies.Size = New Size(57, 19)
        lnkNavMovies.TabIndex = 4
        lnkNavMovies.TabStop = True
        lnkNavMovies.Text = "Movies"
        lnkNavMovies.VisitedLinkColor = Color.FromArgb(CByte(150), CByte(158), CByte(171))
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
        lnkSocial.Location = New Point(399, 31)
        lnkSocial.Name = "lnkSocial"
        lnkSocial.Size = New Size(48, 19)
        lnkSocial.TabIndex = 5
        lnkSocial.TabStop = True
        lnkSocial.Text = "Sosial"
        lnkSocial.VisitedLinkColor = Color.FromArgb(CByte(150), CByte(158), CByte(171))
        ' 
        ' lnkLogout
        ' 
        lnkLogout.ActiveLinkColor = Color.FromArgb(CByte(93), CByte(228), CByte(245))
        lnkLogout.AutoSize = True
        lnkLogout.BackColor = Color.Transparent
        lnkLogout.Cursor = Cursors.Hand
        lnkLogout.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lnkLogout.LinkBehavior = LinkBehavior.NeverUnderline
        lnkLogout.LinkColor = Color.FromArgb(CByte(150), CByte(158), CByte(171))
        lnkLogout.Location = New Point(730, 34)
        lnkLogout.Name = "lnkLogout"
        lnkLogout.Size = New Size(56, 19)
        lnkLogout.TabIndex = 6
        lnkLogout.TabStop = True
        lnkLogout.Text = "Logout"
        lnkLogout.VisitedLinkColor = Color.FromArgb(CByte(150), CByte(158), CByte(171))
        ' 
        ' pnlProfileAvatar
        ' 
        pnlProfileAvatar.BackColor = Color.FromArgb(CByte(44), CByte(186), CByte(210))
        pnlProfileAvatar.Controls.Add(lblProfileInitial)
        pnlProfileAvatar.Controls.Add(picMainAvatar)
        pnlProfileAvatar.Cursor = Cursors.Hand
        pnlProfileAvatar.EdgeColor = Color.FromArgb(CByte(32), CByte(41), CByte(50))
        pnlProfileAvatar.Location = New Point(1206, 23)
        pnlProfileAvatar.Name = "pnlProfileAvatar"
        pnlProfileAvatar.Padding = New Padding(5)
        pnlProfileAvatar.Size = New Size(38, 38)
        pnlProfileAvatar.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        pnlProfileAvatar.TabIndex = 101
        ' 
        ' lblProfileInitial
        ' 
        lblProfileInitial.Dock = DockStyle.Fill
        lblProfileInitial.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblProfileInitial.ForeColor = Color.FromArgb(CByte(8), CByte(36), CByte(50))
        lblProfileInitial.Location = New Point(5, 5)
        lblProfileInitial.Name = "lblProfileInitial"
        lblProfileInitial.Size = New Size(28, 28)
        lblProfileInitial.TabIndex = 0
        lblProfileInitial.Text = "?"
        lblProfileInitial.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picMainAvatar
        ' 
        picMainAvatar.BackColor = Color.Transparent
        picMainAvatar.Dock = DockStyle.Fill
        picMainAvatar.Location = New Point(5, 5)
        picMainAvatar.Name = "picMainAvatar"
        picMainAvatar.Size = New Size(28, 28)
        picMainAvatar.SizeMode = PictureBoxSizeMode.Zoom
        picMainAvatar.TabIndex = 1
        picMainAvatar.TabStop = False
        picMainAvatar.Visible = False
        ' 
        ' pnlSearchInput
        ' 
        pnlSearchInput.BackColor = Color.FromArgb(CByte(12), CByte(17), CByte(28))
        pnlSearchInput.Controls.Add(lblSearchIcon)
        pnlSearchInput.Controls.Add(txtSearch)
        pnlSearchInput.EdgeColor = Color.FromArgb(CByte(26), CByte(34), CByte(50))
        pnlSearchInput.Location = New Point(792, 24)
        pnlSearchInput.Name = "pnlSearchInput"
        pnlSearchInput.Padding = New Padding(4)
        pnlSearchInput.Size = New Size(260, 38)
        pnlSearchInput.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        pnlSearchInput.TabIndex = 7
        ' 
        ' lblSearchIcon
        ' 
        lblSearchIcon.AutoSize = True
        lblSearchIcon.BackColor = Color.Transparent
        lblSearchIcon.Font = New Font("Segoe UI Symbol", 11.0F)
        lblSearchIcon.ForeColor = Color.FromArgb(CByte(110), CByte(120), CByte(140))
        lblSearchIcon.Location = New Point(8, 8)
        lblSearchIcon.Name = "lblSearchIcon"
        lblSearchIcon.Size = New Size(20, 20)
        lblSearchIcon.TabIndex = 1
        lblSearchIcon.Text = "⌕"
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.FromArgb(CByte(12), CByte(17), CByte(28))
        txtSearch.BorderStyle = BorderStyle.None
        txtSearch.Font = New Font("Segoe UI Semibold", 10.0F)
        txtSearch.ForeColor = Color.Gainsboro
        txtSearch.Location = New Point(34, 8)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search anime..."
        txtSearch.Size = New Size(218, 18)
        txtSearch.TabIndex = 0
        ' 
        ' btnSearch
        ' 
        btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSearch.BackColor = Color.FromArgb(CByte(18), CByte(24), CByte(40))
        btnSearch.Cursor = Cursors.Hand
        btnSearch.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(14))
        btnSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(6), CByte(22))
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(30), CByte(36), CByte(52))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnSearch.ForeColor = Color.WhiteSmoke
        btnSearch.Location = New Point(1060, 24)
        btnSearch.Margin = New Padding(4, 6, 4, 6)
        btnSearch.MinimumSize = New Size(70, 38)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(70, 38)
        btnSearch.TabIndex = 8
        btnSearch.Text = "Cari"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnRefresh.BackColor = Color.FromArgb(CByte(44), CByte(186), CByte(210))
        btnRefresh.Cursor = Cursors.Hand
        btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(CByte(18), CByte(160), CByte(184))
        btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(26), CByte(168), CByte(192))
        btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(56), CByte(198), CByte(222))
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.FromArgb(CByte(6), CByte(36), CByte(48))
        btnRefresh.Location = New Point(1139, 24)
        btnRefresh.Margin = New Padding(4, 6, 4, 6)
        btnRefresh.MinimumSize = New Size(58, 38)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(58, 38)
        btnRefresh.TabIndex = 9
        btnRefresh.Text = "↻"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' pnlContentHost
        ' 
        pnlContentHost.BackColor = Color.FromArgb(CByte(4), CByte(7), CByte(14))
        pnlContentHost.Controls.Add(pnlDashboard)
        pnlContentHost.Controls.Add(pnlWatch)
        pnlContentHost.EdgeColor = Color.FromArgb(CByte(4), CByte(7), CByte(14))
        pnlContentHost.Location = New Point(24, 69)
        pnlContentHost.Name = "pnlContentHost"
        pnlContentHost.Padding = New Padding(5)
        pnlContentHost.Size = New Size(1232, 633)
        pnlContentHost.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        pnlContentHost.TabIndex = 10
        ' 
        ' pnlDashboard
        ' 
        pnlDashboard.BackColor = Color.FromArgb(CByte(4), CByte(7), CByte(14))
        pnlDashboard.Controls.Add(pnlFeatured)
        pnlDashboard.Controls.Add(lblRowTitle)
        pnlDashboard.Controls.Add(btnEpisodePrev)
        pnlDashboard.Controls.Add(btnEpisodeNext)
        pnlDashboard.Controls.Add(flpEpisodeRow)
        pnlDashboard.Controls.Add(lblDashboardHint)
        pnlDashboard.Dock = DockStyle.Fill
        pnlDashboard.EdgeColor = Color.FromArgb(CByte(4), CByte(7), CByte(14))
        pnlDashboard.Location = New Point(5, 5)
        pnlDashboard.Name = "pnlDashboard"
        pnlDashboard.Padding = New Padding(1)
        pnlDashboard.Size = New Size(1222, 623)
        pnlDashboard.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        pnlDashboard.TabIndex = 0
        ' 
        ' pnlFeatured
        ' 
        pnlFeatured.BackColor = Color.FromArgb(CByte(8), CByte(12), CByte(20))
        pnlFeatured.Controls.Add(picFeaturedBackdrop)
        pnlFeatured.Controls.Add(pnlFeaturedOverlay)
        pnlFeatured.EdgeColor = Color.FromArgb(CByte(16), CByte(22), CByte(34))
        pnlFeatured.Location = New Point(12, 12)
        pnlFeatured.Name = "pnlFeatured"
        pnlFeatured.Padding = New Padding(5)
        pnlFeatured.Size = New Size(1208, 316)
        pnlFeatured.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        pnlFeatured.TabIndex = 0
        ' 
        ' picFeaturedBackdrop
        ' 
        picFeaturedBackdrop.BackColor = Color.FromArgb(CByte(8), CByte(12), CByte(20))
        picFeaturedBackdrop.Dock = DockStyle.Fill
        picFeaturedBackdrop.Location = New Point(465, 5)
        picFeaturedBackdrop.Name = "picFeaturedBackdrop"
        picFeaturedBackdrop.Size = New Size(738, 306)
        picFeaturedBackdrop.SizeMode = PictureBoxSizeMode.Zoom
        picFeaturedBackdrop.TabIndex = 0
        picFeaturedBackdrop.TabStop = False
        ' 
        ' pnlFeaturedOverlay
        ' 
        pnlFeaturedOverlay.BackColor = Color.FromArgb(CByte(8), CByte(12), CByte(20))
        pnlFeaturedOverlay.Controls.Add(lblFeaturedTag)
        pnlFeaturedOverlay.Controls.Add(lblFeaturedTitle)
        pnlFeaturedOverlay.Controls.Add(lblFeaturedMeta)
        pnlFeaturedOverlay.Controls.Add(lblFeaturedDesc)
        pnlFeaturedOverlay.Controls.Add(btnFeaturedPlay)
        pnlFeaturedOverlay.Controls.Add(btnFeaturedInfo)
        pnlFeaturedOverlay.Dock = DockStyle.Left
        pnlFeaturedOverlay.EdgeColor = Color.FromArgb(CByte(8), CByte(12), CByte(20))
        pnlFeaturedOverlay.Location = New Point(5, 5)
        pnlFeaturedOverlay.Name = "pnlFeaturedOverlay"
        pnlFeaturedOverlay.Padding = New Padding(5)
        pnlFeaturedOverlay.Size = New Size(460, 306)
        pnlFeaturedOverlay.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        pnlFeaturedOverlay.TabIndex = 1
        ' 
        ' lblFeaturedTag
        ' 
        lblFeaturedTag.AutoSize = True
        lblFeaturedTag.BackColor = Color.Transparent
        lblFeaturedTag.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblFeaturedTag.ForeColor = Color.FromArgb(CByte(130), CByte(139), CByte(157))
        lblFeaturedTag.Location = New Point(52, 22)
        lblFeaturedTag.Name = "lblFeaturedTag"
        lblFeaturedTag.Size = New Size(86, 15)
        lblFeaturedTag.TabIndex = 0
        lblFeaturedTag.Text = "ANIMIT PICKS"
        ' 
        ' lblFeaturedTitle
        ' 
        lblFeaturedTitle.BackColor = Color.Transparent
        lblFeaturedTitle.Font = New Font("Segoe UI Semibold", 26.0F, FontStyle.Bold)
        lblFeaturedTitle.ForeColor = Color.FromArgb(CByte(238), CByte(242), CByte(250))
        lblFeaturedTitle.Location = New Point(52, 44)
        lblFeaturedTitle.Name = "lblFeaturedTitle"
        lblFeaturedTitle.Size = New Size(380, 62)
        lblFeaturedTitle.TabIndex = 1
        lblFeaturedTitle.Text = "Loading..."
        ' 
        ' lblFeaturedMeta
        ' 
        lblFeaturedMeta.AutoSize = True
        lblFeaturedMeta.BackColor = Color.Transparent
        lblFeaturedMeta.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        lblFeaturedMeta.ForeColor = Color.FromArgb(CByte(84), CByte(234), CByte(255))
        lblFeaturedMeta.Location = New Point(52, 110)
        lblFeaturedMeta.Name = "lblFeaturedMeta"
        lblFeaturedMeta.Size = New Size(126, 19)
        lblFeaturedMeta.TabIndex = 2
        lblFeaturedMeta.Text = "Episode • Ongoing"
        ' 
        ' lblFeaturedDesc
        ' 
        lblFeaturedDesc.BackColor = Color.Transparent
        lblFeaturedDesc.Font = New Font("Segoe UI", 10.0F)
        lblFeaturedDesc.ForeColor = Color.FromArgb(CByte(182), CByte(192), CByte(210))
        lblFeaturedDesc.Location = New Point(52, 136)
        lblFeaturedDesc.Name = "lblFeaturedDesc"
        lblFeaturedDesc.Size = New Size(374, 80)
        lblFeaturedDesc.TabIndex = 3
        lblFeaturedDesc.Text = "Klik Play untuk masuk mode nonton dengan live chat."
        ' 
        ' btnFeaturedPlay
        ' 
        btnFeaturedPlay.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnFeaturedPlay.BackColor = Color.FromArgb(CByte(44), CByte(186), CByte(210))
        btnFeaturedPlay.Cursor = Cursors.Hand
        btnFeaturedPlay.FlatAppearance.BorderColor = Color.FromArgb(CByte(18), CByte(160), CByte(184))
        btnFeaturedPlay.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(26), CByte(168), CByte(192))
        btnFeaturedPlay.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(56), CByte(198), CByte(222))
        btnFeaturedPlay.FlatStyle = FlatStyle.Flat
        btnFeaturedPlay.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnFeaturedPlay.ForeColor = Color.FromArgb(CByte(6), CByte(36), CByte(48))
        btnFeaturedPlay.Location = New Point(52, 256)
        btnFeaturedPlay.Margin = New Padding(4, 6, 4, 6)
        btnFeaturedPlay.MinimumSize = New Size(120, 42)
        btnFeaturedPlay.Name = "btnFeaturedPlay"
        btnFeaturedPlay.Size = New Size(120, 42)
        btnFeaturedPlay.TabIndex = 4
        btnFeaturedPlay.Text = "▶ Play"
        btnFeaturedPlay.UseVisualStyleBackColor = False
        ' 
        ' btnFeaturedInfo
        ' 
        btnFeaturedInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnFeaturedInfo.BackColor = Color.FromArgb(CByte(18), CByte(24), CByte(40))
        btnFeaturedInfo.Cursor = Cursors.Hand
        btnFeaturedInfo.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(14))
        btnFeaturedInfo.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(6), CByte(22))
        btnFeaturedInfo.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(30), CByte(36), CByte(52))
        btnFeaturedInfo.FlatStyle = FlatStyle.Flat
        btnFeaturedInfo.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnFeaturedInfo.ForeColor = Color.FromArgb(CByte(222), CByte(230), CByte(245))
        btnFeaturedInfo.Location = New Point(182, 256)
        btnFeaturedInfo.Margin = New Padding(4, 6, 4, 6)
        btnFeaturedInfo.MinimumSize = New Size(120, 42)
        btnFeaturedInfo.Name = "btnFeaturedInfo"
        btnFeaturedInfo.Size = New Size(120, 42)
        btnFeaturedInfo.TabIndex = 5
        btnFeaturedInfo.Text = "Detail"
        btnFeaturedInfo.UseVisualStyleBackColor = False
        ' 
        ' lblRowTitle
        ' 
        lblRowTitle.AutoSize = True
        lblRowTitle.BackColor = Color.Transparent
        lblRowTitle.Font = New Font("Segoe UI Semibold", 13.0F, FontStyle.Bold)
        lblRowTitle.ForeColor = Color.FromArgb(CByte(232), CByte(238), CByte(250))
        lblRowTitle.Location = New Point(8, 338)
        lblRowTitle.Name = "lblRowTitle"
        lblRowTitle.Size = New Size(183, 25)
        lblRowTitle.TabIndex = 1
        lblRowTitle.Text = "Episode Terbaru Live"
        ' 
        ' btnEpisodePrev
        ' 
        btnEpisodePrev.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnEpisodePrev.BackColor = Color.FromArgb(CByte(18), CByte(24), CByte(40))
        btnEpisodePrev.Cursor = Cursors.Hand
        btnEpisodePrev.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(14))
        btnEpisodePrev.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(6), CByte(22))
        btnEpisodePrev.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(30), CByte(36), CByte(52))
        btnEpisodePrev.FlatStyle = FlatStyle.Flat
        btnEpisodePrev.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnEpisodePrev.ForeColor = Color.Gainsboro
        btnEpisodePrev.Location = New Point(1124, 338)
        btnEpisodePrev.Margin = New Padding(4, 6, 4, 6)
        btnEpisodePrev.MinimumSize = New Size(44, 32)
        btnEpisodePrev.Name = "btnEpisodePrev"
        btnEpisodePrev.Size = New Size(44, 32)
        btnEpisodePrev.TabIndex = 4
        btnEpisodePrev.Text = "◀"
        btnEpisodePrev.UseVisualStyleBackColor = False
        ' 
        ' btnEpisodeNext
        ' 
        btnEpisodeNext.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnEpisodeNext.BackColor = Color.FromArgb(CByte(18), CByte(24), CByte(40))
        btnEpisodeNext.Cursor = Cursors.Hand
        btnEpisodeNext.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(14))
        btnEpisodeNext.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(6), CByte(22))
        btnEpisodeNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(30), CByte(36), CByte(52))
        btnEpisodeNext.FlatStyle = FlatStyle.Flat
        btnEpisodeNext.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnEpisodeNext.ForeColor = Color.Gainsboro
        btnEpisodeNext.Location = New Point(1176, 338)
        btnEpisodeNext.Margin = New Padding(4, 6, 4, 6)
        btnEpisodeNext.MinimumSize = New Size(44, 32)
        btnEpisodeNext.Name = "btnEpisodeNext"
        btnEpisodeNext.Size = New Size(44, 32)
        btnEpisodeNext.TabIndex = 5
        btnEpisodeNext.Text = "▶"
        btnEpisodeNext.UseVisualStyleBackColor = False
        ' 
        ' flpEpisodeRow
        ' 
        flpEpisodeRow.Location = New Point(12, 378)
        flpEpisodeRow.Name = "flpEpisodeRow"
        flpEpisodeRow.Size = New Size(1208, 198)
        flpEpisodeRow.TabIndex = 2
        flpEpisodeRow.WrapContents = False
        ' 
        ' lblDashboardHint
        ' 
        lblDashboardHint.BackColor = Color.Transparent
        lblDashboardHint.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic)
        lblDashboardHint.ForeColor = Color.FromArgb(CByte(100), CByte(110), CByte(128))
        lblDashboardHint.Location = New Point(12, 584)
        lblDashboardHint.Name = "lblDashboardHint"
        lblDashboardHint.Size = New Size(1208, 20)
        lblDashboardHint.TabIndex = 6
        lblDashboardHint.Text = "Pilih episode untuk masuk mode nonton."
        lblDashboardHint.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlWatch
        ' 
        pnlWatch.BackColor = Color.FromArgb(CByte(4), CByte(7), CByte(14))
        pnlWatch.Controls.Add(btnBackToBrowse)
        pnlWatch.Controls.Add(pnlWatchPlayer)
        pnlWatch.Controls.Add(pnlLiveChat)
        pnlWatch.Controls.Add(lblWatchEpisodesTitle)
        pnlWatch.Controls.Add(flpWatchEpisodes)
        pnlWatch.Controls.Add(lblWatchHint)
        pnlWatch.Dock = DockStyle.Fill
        pnlWatch.EdgeColor = Color.FromArgb(CByte(4), CByte(7), CByte(14))
        pnlWatch.Location = New Point(5, 5)
        pnlWatch.Name = "pnlWatch"
        pnlWatch.Padding = New Padding(5)
        pnlWatch.Size = New Size(1222, 623)
        pnlWatch.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        pnlWatch.TabIndex = 1
        pnlWatch.Visible = False
        ' 
        ' btnBackToBrowse
        ' 
        btnBackToBrowse.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnBackToBrowse.BackColor = Color.FromArgb(CByte(18), CByte(24), CByte(40))
        btnBackToBrowse.Cursor = Cursors.Hand
        btnBackToBrowse.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(14))
        btnBackToBrowse.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(6), CByte(22))
        btnBackToBrowse.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(30), CByte(36), CByte(52))
        btnBackToBrowse.FlatStyle = FlatStyle.Flat
        btnBackToBrowse.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnBackToBrowse.ForeColor = Color.FromArgb(CByte(222), CByte(230), CByte(245))
        btnBackToBrowse.Location = New Point(12, 10)
        btnBackToBrowse.Margin = New Padding(4, 6, 4, 6)
        btnBackToBrowse.MinimumSize = New Size(128, 34)
        btnBackToBrowse.Name = "btnBackToBrowse"
        btnBackToBrowse.Size = New Size(128, 34)
        btnBackToBrowse.TabIndex = 0
        btnBackToBrowse.Text = "← Dashboard"
        btnBackToBrowse.UseVisualStyleBackColor = False
        ' 
        ' pnlWatchPlayer
        ' 
        pnlWatchPlayer.BackColor = Color.FromArgb(CByte(6), CByte(10), CByte(18))
        pnlWatchPlayer.Controls.Add(picWatchBackdrop)
        pnlWatchPlayer.Controls.Add(webEpisodePlayer)
        pnlWatchPlayer.Controls.Add(pnlWatchOverlay)
        pnlWatchPlayer.EdgeColor = Color.FromArgb(CByte(16), CByte(22), CByte(34))
        pnlWatchPlayer.Location = New Point(12, 52)
        pnlWatchPlayer.Name = "pnlWatchPlayer"
        pnlWatchPlayer.Padding = New Padding(5)
        pnlWatchPlayer.Size = New Size(880, 380)
        pnlWatchPlayer.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        pnlWatchPlayer.TabIndex = 1
        ' 
        ' picWatchBackdrop
        ' 
        picWatchBackdrop.BackColor = Color.FromArgb(CByte(6), CByte(10), CByte(18))
        picWatchBackdrop.Dock = DockStyle.Fill
        picWatchBackdrop.Location = New Point(5, 5)
        picWatchBackdrop.Name = "picWatchBackdrop"
        picWatchBackdrop.Size = New Size(870, 212)
        picWatchBackdrop.SizeMode = PictureBoxSizeMode.Zoom
        picWatchBackdrop.TabIndex = 0
        picWatchBackdrop.TabStop = False
        ' 
        ' webEpisodePlayer
        ' 
        webEpisodePlayer.AllowExternalDrop = True
        webEpisodePlayer.CreationProperties = Nothing
        webEpisodePlayer.DefaultBackgroundColor = Color.FromArgb(CByte(6), CByte(10), CByte(18))
        webEpisodePlayer.Dock = DockStyle.Fill
        webEpisodePlayer.Location = New Point(5, 5)
        webEpisodePlayer.Name = "webEpisodePlayer"
        webEpisodePlayer.Size = New Size(870, 212)
        webEpisodePlayer.TabIndex = 2
        webEpisodePlayer.Visible = False
        webEpisodePlayer.ZoomFactor = 1.0R
        ' 
        ' pnlWatchOverlay
        ' 
        pnlWatchOverlay.BackColor = Color.FromArgb(CByte(5), CByte(9), CByte(16))
        pnlWatchOverlay.Controls.Add(lblWatchMeta)
        pnlWatchOverlay.Controls.Add(lblWatchTitle)
        pnlWatchOverlay.Controls.Add(lblWatchDesc)
        pnlWatchOverlay.Controls.Add(cmbServerQuality)
        pnlWatchOverlay.Controls.Add(btnFullscreen)
        pnlWatchOverlay.Controls.Add(btnWatchExternal)
        pnlWatchOverlay.Dock = DockStyle.Bottom
        pnlWatchOverlay.EdgeColor = Color.FromArgb(CByte(16), CByte(22), CByte(34))
        pnlWatchOverlay.Location = New Point(5, 217)
        pnlWatchOverlay.Name = "pnlWatchOverlay"
        pnlWatchOverlay.Padding = New Padding(5)
        pnlWatchOverlay.Size = New Size(870, 158)
        pnlWatchOverlay.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        pnlWatchOverlay.TabIndex = 1
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
        ' lblWatchTitle
        ' 
        lblWatchTitle.BackColor = Color.Transparent
        lblWatchTitle.Font = New Font("Segoe UI Semibold", 20.0F, FontStyle.Bold)
        lblWatchTitle.ForeColor = Color.FromArgb(CByte(238), CByte(242), CByte(250))
        lblWatchTitle.Location = New Point(16, 28)
        lblWatchTitle.Name = "lblWatchTitle"
        lblWatchTitle.Size = New Size(620, 43)
        lblWatchTitle.TabIndex = 1
        lblWatchTitle.Text = "Loading episode..."
        ' 
        ' lblWatchDesc
        ' 
        lblWatchDesc.BackColor = Color.Transparent
        lblWatchDesc.Font = New Font("Segoe UI", 9.5F)
        lblWatchDesc.ForeColor = Color.FromArgb(CByte(182), CByte(192), CByte(210))
        lblWatchDesc.Location = New Point(16, 78)
        lblWatchDesc.Name = "lblWatchDesc"
        lblWatchDesc.Size = New Size(700, 60)
        lblWatchDesc.TabIndex = 2
        lblWatchDesc.Text = "Sinopsis akan tampil di sini."
        ' 
        ' cmbServerQuality
        ' 
        cmbServerQuality.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbServerQuality.BackColor = Color.FromArgb(CByte(12), CByte(17), CByte(28))
        cmbServerQuality.DropDownStyle = ComboBoxStyle.DropDownList
        cmbServerQuality.FlatStyle = FlatStyle.Flat
        cmbServerQuality.Font = New Font("Segoe UI Semibold", 9.0F)
        cmbServerQuality.ForeColor = Color.Gainsboro
        cmbServerQuality.FormattingEnabled = True
        cmbServerQuality.Location = New Point(490, 20)
        cmbServerQuality.Name = "cmbServerQuality"
        cmbServerQuality.Size = New Size(150, 23)
        cmbServerQuality.TabIndex = 4
        ' 
        ' btnFullscreen
        ' 
        btnFullscreen.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnFullscreen.BackColor = Color.FromArgb(CByte(18), CByte(24), CByte(40))
        btnFullscreen.Cursor = Cursors.Hand
        btnFullscreen.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(14))
        btnFullscreen.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(6), CByte(22))
        btnFullscreen.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(30), CByte(36), CByte(52))
        btnFullscreen.FlatStyle = FlatStyle.Flat
        btnFullscreen.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnFullscreen.ForeColor = Color.Gainsboro
        btnFullscreen.Location = New Point(658, 14)
        btnFullscreen.Margin = New Padding(4, 6, 4, 6)
        btnFullscreen.MinimumSize = New Size(50, 38)
        btnFullscreen.Name = "btnFullscreen"
        btnFullscreen.Size = New Size(50, 38)
        btnFullscreen.TabIndex = 6
        btnFullscreen.Text = "⛶"
        btnFullscreen.UseVisualStyleBackColor = False
        ' 
        ' btnWatchExternal
        ' 
        btnWatchExternal.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnWatchExternal.BackColor = Color.FromArgb(CByte(44), CByte(186), CByte(210))
        btnWatchExternal.Cursor = Cursors.Hand
        btnWatchExternal.FlatAppearance.BorderColor = Color.FromArgb(CByte(18), CByte(160), CByte(184))
        btnWatchExternal.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(26), CByte(168), CByte(192))
        btnWatchExternal.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(56), CByte(198), CByte(222))
        btnWatchExternal.FlatStyle = FlatStyle.Flat
        btnWatchExternal.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnWatchExternal.ForeColor = Color.FromArgb(CByte(6), CByte(36), CByte(48))
        btnWatchExternal.Location = New Point(716, 14)
        btnWatchExternal.Margin = New Padding(4, 6, 4, 6)
        btnWatchExternal.MinimumSize = New Size(148, 38)
        btnWatchExternal.Name = "btnWatchExternal"
        btnWatchExternal.Size = New Size(148, 38)
        btnWatchExternal.TabIndex = 7
        btnWatchExternal.Text = "Play Ulang"
        btnWatchExternal.UseVisualStyleBackColor = False
        ' 
        ' pnlLiveChat
        ' 
        pnlLiveChat.BackColor = Color.FromArgb(CByte(8), CByte(12), CByte(22))
        pnlLiveChat.Controls.Add(lblLiveChatTitle)
        pnlLiveChat.Controls.Add(lblLiveChatCounter)
        pnlLiveChat.Controls.Add(flpLiveChat)
        pnlLiveChat.Controls.Add(pnlChatInput)
        pnlLiveChat.EdgeColor = Color.FromArgb(CByte(16), CByte(22), CByte(34))
        pnlLiveChat.Location = New Point(904, 52)
        pnlLiveChat.Name = "pnlLiveChat"
        pnlLiveChat.Padding = New Padding(5)
        pnlLiveChat.Size = New Size(316, 536)
        pnlLiveChat.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        pnlLiveChat.TabIndex = 2
        ' 
        ' lblLiveChatTitle
        ' 
        lblLiveChatTitle.AutoSize = True
        lblLiveChatTitle.BackColor = Color.Transparent
        lblLiveChatTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblLiveChatTitle.ForeColor = Color.FromArgb(CByte(238), CByte(242), CByte(250))
        lblLiveChatTitle.Location = New Point(14, 16)
        lblLiveChatTitle.Name = "lblLiveChatTitle"
        lblLiveChatTitle.Size = New Size(77, 19)
        lblLiveChatTitle.TabIndex = 0
        lblLiveChatTitle.Text = "LIVE CHAT"
        ' 
        ' lblLiveChatCounter
        ' 
        lblLiveChatCounter.BackColor = Color.Transparent
        lblLiveChatCounter.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblLiveChatCounter.ForeColor = Color.FromArgb(CByte(110), CByte(120), CByte(140))
        lblLiveChatCounter.Location = New Point(210, 18)
        lblLiveChatCounter.Name = "lblLiveChatCounter"
        lblLiveChatCounter.Size = New Size(90, 15)
        lblLiveChatCounter.TabIndex = 1
        lblLiveChatCounter.Text = "0 LIVE"
        lblLiveChatCounter.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' flpLiveChat
        ' 
        flpLiveChat.AutoScroll = True
        flpLiveChat.FlowDirection = FlowDirection.TopDown
        flpLiveChat.Location = New Point(10, 48)
        flpLiveChat.Name = "flpLiveChat"
        flpLiveChat.Size = New Size(296, 432)
        flpLiveChat.TabIndex = 2
        flpLiveChat.WrapContents = False
        ' 
        ' pnlChatInput
        ' 
        pnlChatInput.BackColor = Color.FromArgb(CByte(12), CByte(17), CByte(28))
        pnlChatInput.Controls.Add(txtChatInput)
        pnlChatInput.Controls.Add(btnSendChat)
        pnlChatInput.EdgeColor = Color.FromArgb(CByte(26), CByte(34), CByte(50))
        pnlChatInput.Location = New Point(10, 488)
        pnlChatInput.Name = "pnlChatInput"
        pnlChatInput.Padding = New Padding(4)
        pnlChatInput.Size = New Size(296, 44)
        pnlChatInput.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        pnlChatInput.TabIndex = 3
        ' 
        ' txtChatInput
        ' 
        txtChatInput.BackColor = Color.FromArgb(CByte(12), CByte(17), CByte(28))
        txtChatInput.BorderStyle = BorderStyle.None
        txtChatInput.Font = New Font("Segoe UI Semibold", 10.0F)
        txtChatInput.ForeColor = Color.Gainsboro
        txtChatInput.Location = New Point(8, 12)
        txtChatInput.Name = "txtChatInput"
        txtChatInput.PlaceholderText = "Ketik komentar..."
        txtChatInput.Size = New Size(218, 18)
        txtChatInput.TabIndex = 0
        ' 
        ' btnSendChat
        ' 
        btnSendChat.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSendChat.BackColor = Color.FromArgb(CByte(44), CByte(186), CByte(210))
        btnSendChat.Cursor = Cursors.Hand
        btnSendChat.FlatAppearance.BorderColor = Color.FromArgb(CByte(18), CByte(160), CByte(184))
        btnSendChat.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(26), CByte(168), CByte(192))
        btnSendChat.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(56), CByte(198), CByte(222))
        btnSendChat.FlatStyle = FlatStyle.Flat
        btnSendChat.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        btnSendChat.ForeColor = Color.FromArgb(CByte(6), CByte(36), CByte(48))
        btnSendChat.Location = New Point(232, 7)
        btnSendChat.Margin = New Padding(4, 6, 4, 6)
        btnSendChat.MinimumSize = New Size(58, 30)
        btnSendChat.Name = "btnSendChat"
        btnSendChat.Size = New Size(58, 30)
        btnSendChat.TabIndex = 1
        btnSendChat.Text = "Kirim"
        btnSendChat.UseVisualStyleBackColor = False
        ' 
        ' lblWatchEpisodesTitle
        ' 
        lblWatchEpisodesTitle.AutoSize = True
        lblWatchEpisodesTitle.BackColor = Color.Transparent
        lblWatchEpisodesTitle.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        lblWatchEpisodesTitle.ForeColor = Color.FromArgb(CByte(238), CByte(242), CByte(250))
        lblWatchEpisodesTitle.Location = New Point(12, 444)
        lblWatchEpisodesTitle.Name = "lblWatchEpisodesTitle"
        lblWatchEpisodesTitle.Size = New Size(117, 21)
        lblWatchEpisodesTitle.TabIndex = 3
        lblWatchEpisodesTitle.Text = "Daftar Episode"
        ' 
        ' flpWatchEpisodes
        ' 
        flpWatchEpisodes.AutoScroll = True
        flpWatchEpisodes.Location = New Point(12, 470)
        flpWatchEpisodes.Name = "flpWatchEpisodes"
        flpWatchEpisodes.Size = New Size(878, 118)
        flpWatchEpisodes.TabIndex = 4
        ' 
        ' lblWatchHint
        ' 
        lblWatchHint.BackColor = Color.Transparent
        lblWatchHint.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic)
        lblWatchHint.ForeColor = Color.FromArgb(CByte(100), CByte(110), CByte(128))
        lblWatchHint.Location = New Point(12, 592)
        lblWatchHint.Name = "lblWatchHint"
        lblWatchHint.Size = New Size(880, 14)
        lblWatchHint.TabIndex = 5
        lblWatchHint.Text = "Mode nonton aktif."
        lblWatchHint.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tmrLiveChat
        ' 
        tmrLiveChat.Interval = 8000
        ' 
        ' MainPage
        ' 
        ClientSize = New Size(1280, 720)
        Controls.Add(NightForm1)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(1920, 1080)
        MinimumSize = New Size(900, 600)
        Name = "MainPage"
        StartPosition = FormStartPosition.CenterScreen
        TransparencyKey = Color.Fuchsia
        NightForm1.ResumeLayout(False)
        NightForm1.PerformLayout()
        pnlProfileAvatar.ResumeLayout(False)
        CType(picMainAvatar, ComponentModel.ISupportInitialize).EndInit()
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
        pnlWatchPlayer.ResumeLayout(False)
        CType(picWatchBackdrop, ComponentModel.ISupportInitialize).EndInit()
        CType(webEpisodePlayer, ComponentModel.ISupportInitialize).EndInit()
        pnlWatchOverlay.ResumeLayout(False)
        pnlWatchOverlay.PerformLayout()
        pnlLiveChat.ResumeLayout(False)
        pnlLiveChat.PerformLayout()
        pnlChatInput.ResumeLayout(False)
        pnlChatInput.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents NightForm1 As NightForm
    Friend WithEvents lblClose As Label
    Friend WithEvents lblBrand As NightLabel
    Friend WithEvents lnkNavBrowse As NightLinkLabel
    Friend WithEvents lnkNavSimulcasts As NightLinkLabel
    Friend WithEvents lnkNavMovies As NightLinkLabel
    Friend WithEvents lnkSocial As NightLinkLabel
    Friend WithEvents lnkLogout As NightLinkLabel
    Friend WithEvents pnlProfileAvatar As Panel
    Friend WithEvents lblProfileInitial As Label
    Friend WithEvents picMainAvatar As PictureBox
    Friend WithEvents pnlSearchInput As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearchIcon As Label
    Friend WithEvents btnSearch As StableActionButton
    Friend WithEvents btnRefresh As StableActionButton
    Friend WithEvents pnlContentHost As Panel
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents pnlFeatured As Panel
    Friend WithEvents picFeaturedBackdrop As PictureBox
    Friend WithEvents pnlFeaturedOverlay As Panel
    Friend WithEvents lblFeaturedTag As NightLabel
    Friend WithEvents lblFeaturedTitle As NightLabel
    Friend WithEvents lblFeaturedMeta As NightLabel
    Friend WithEvents lblFeaturedDesc As NightLabel
    Friend WithEvents btnFeaturedPlay As StableActionButton
    Friend WithEvents btnFeaturedInfo As StableActionButton
    Friend WithEvents lblRowTitle As NightLabel
    Friend WithEvents btnEpisodePrev As StableActionButton
    Friend WithEvents btnEpisodeNext As StableActionButton
    Friend WithEvents flpEpisodeRow As FlowLayoutPanel
    Friend WithEvents lblDashboardHint As NightLabel
    Friend WithEvents pnlWatch As Panel
    Friend WithEvents btnBackToBrowse As StableActionButton
    Friend WithEvents pnlWatchPlayer As Panel
    Friend WithEvents picWatchBackdrop As PictureBox
    Friend WithEvents webEpisodePlayer As WebView2
    Friend WithEvents pnlWatchOverlay As Panel
    Friend WithEvents lblWatchMeta As NightLabel
    Friend WithEvents lblWatchTitle As NightLabel
    Friend WithEvents lblWatchDesc As NightLabel
    Friend WithEvents cmbServerQuality As ComboBox
    Friend WithEvents btnFullscreen As StableActionButton
    Friend WithEvents btnWatchExternal As StableActionButton
    Friend WithEvents pnlLiveChat As Panel
    Friend WithEvents lblLiveChatTitle As NightLabel
    Friend WithEvents lblLiveChatCounter As NightLabel
    Friend WithEvents flpLiveChat As FlowLayoutPanel
    Friend WithEvents pnlChatInput As Panel
    Friend WithEvents txtChatInput As TextBox
    Friend WithEvents btnSendChat As StableActionButton
    Friend WithEvents lblWatchEpisodesTitle As NightLabel
    Friend WithEvents flpWatchEpisodes As FlowLayoutPanel
    Friend WithEvents lblWatchHint As NightLabel
    Friend WithEvents tmrLiveChat As Timer
End Class
