Imports ReaLTaiizor.Controls
Imports ReaLTaiizor.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SocialHubPage
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
        NightForm1 = New NightForm()
        lblClose = New Label()
        lblBrand = New NightLabel()
        lblBadge = New NightLabel()
        panelLeft = New Panel()
        panelAvatarBg = New Panel()
        lblAvatarInitial = New Label()
        picProfileAvatar = New PictureBox()
        lblDisplayName = New Label()
        lblDisplayBio = New Label()
        lblProfileStats = New Label()
        lblSectionProfile = New Label()
        lblProfileUsernameHint = New Label()
        txtProfileUsername = New TextBox()
        lblProfileEmailHint = New Label()
        txtProfileEmail = New TextBox()
        lblProfileBioHint = New Label()
        txtProfileBio = New TextBox()
        lblProfileAvatarUrlHint = New Label()
        txtProfileAvatarUrl = New TextBox()
        btnBrowseAvatar = New StableActionButton()
        btnSaveProfile = New StableActionButton()
        lblProfileUserId = New Label()
        panelMiddle = New Panel()
        lblSectionFollow = New Label()
        txtFollowUsername = New TextBox()
        btnFollow = New StableActionButton()
        pnlFollowingHeader = New Panel()
        lblFollowingTitle = New Label()
        btnRefreshFollowing = New StableActionButton()
        lbFollowing = New ListBox()
        btnClose = New StableActionButton()
        panelRight = New Panel()
        panelChatHeader = New Panel()
        lblTitle = New NightLabel()
        lblStatus = New NightLabel()
        panelChatArea = New Panel()
        lbConversation = New ListBox()
        panelChatInput = New Panel()
        txtMessageBody = New TextBox()
        btnSendMessage = New StableActionButton()
        NightForm1.SuspendLayout()
        panelLeft.SuspendLayout()
        panelAvatarBg.SuspendLayout()
        CType(picProfileAvatar, ComponentModel.ISupportInitialize).BeginInit()
        panelMiddle.SuspendLayout()
        pnlFollowingHeader.SuspendLayout()
        panelRight.SuspendLayout()
        panelChatHeader.SuspendLayout()
        panelChatArea.SuspendLayout()
        panelChatInput.SuspendLayout()
        SuspendLayout()
        ' 
        ' NightForm1
        ' 
        NightForm1.BackColor = Color.FromArgb(CByte(8), CByte(14), CByte(26))
        NightForm1.Controls.Add(lblClose)
        NightForm1.Controls.Add(lblBrand)
        NightForm1.Controls.Add(lblBadge)
        NightForm1.Controls.Add(panelLeft)
        NightForm1.Controls.Add(panelMiddle)
        NightForm1.Controls.Add(panelRight)
        NightForm1.Dock = DockStyle.Fill
        NightForm1.DrawIcon = False
        NightForm1.Font = New Font("Segoe UI", 9.0F)
        NightForm1.HeadColor = Color.FromArgb(CByte(8), CByte(14), CByte(26))
        NightForm1.Location = New Point(0, 0)
        NightForm1.Margin = New Padding(3, 2, 3, 2)
        NightForm1.MinimumSize = New Size(100, 42)
        NightForm1.Name = "NightForm1"
        NightForm1.Padding = New Padding(0, 40, 0, 0)
        NightForm1.Size = New Size(822, 495)
        NightForm1.TabIndex = 0
        NightForm1.TextAlignment = NightForm.Alignment.Left
        NightForm1.TitleBarTextColor = Color.FromArgb(CByte(83), CByte(107), CByte(138))
        ' 
        ' lblClose
        ' 
        lblClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblClose.AutoSize = True
        lblClose.BackColor = Color.Transparent
        lblClose.Cursor = Cursors.Hand
        lblClose.Font = New Font("Segoe UI Symbol", 11.0F)
        lblClose.ForeColor = Color.FromArgb(CByte(70), CByte(90), CByte(120))
        lblClose.Location = New Point(798, 2)
        lblClose.Name = "lblClose"
        lblClose.Size = New Size(21, 20)
        lblClose.TabIndex = 0
        lblClose.Text = "✕"
        ' 
        ' lblBrand
        ' 
        lblBrand.AutoSize = True
        lblBrand.BackColor = Color.Transparent
        lblBrand.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblBrand.ForeColor = Color.FromArgb(CByte(83), CByte(231), CByte(248))
        lblBrand.Location = New Point(4, 5)
        lblBrand.Name = "lblBrand"
        lblBrand.Size = New Size(108, 25)
        lblBrand.TabIndex = 1
        lblBrand.Text = "Social Hub"
        ' 
        ' lblBadge
        ' 
        lblBadge.BackColor = Color.FromArgb(CByte(14), CByte(42), CByte(58))
        lblBadge.Font = New Font("Segoe UI Semibold", 7.0F, FontStyle.Bold)
        lblBadge.ForeColor = Color.FromArgb(CByte(84), CByte(234), CByte(255))
        lblBadge.Location = New Point(117, 11)
        lblBadge.Name = "lblBadge"
        lblBadge.Size = New Size(88, 15)
        lblBadge.TabIndex = 2
        lblBadge.Text = "FOLLOW · CHAT"
        lblBadge.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' panelLeft
        ' 
        panelLeft.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        panelLeft.BackColor = Color.FromArgb(CByte(10), CByte(16), CByte(28))
        panelLeft.Controls.Add(panelAvatarBg)
        panelLeft.Controls.Add(lblDisplayName)
        panelLeft.Controls.Add(lblDisplayBio)
        panelLeft.Controls.Add(lblProfileStats)
        panelLeft.Controls.Add(lblSectionProfile)
        panelLeft.Controls.Add(lblProfileUsernameHint)
        panelLeft.Controls.Add(txtProfileUsername)
        panelLeft.Controls.Add(lblProfileEmailHint)
        panelLeft.Controls.Add(txtProfileEmail)
        panelLeft.Controls.Add(lblProfileBioHint)
        panelLeft.Controls.Add(txtProfileBio)
        panelLeft.Controls.Add(lblProfileAvatarUrlHint)
        panelLeft.Controls.Add(txtProfileAvatarUrl)
        panelLeft.Controls.Add(btnBrowseAvatar)
        panelLeft.Controls.Add(btnSaveProfile)
        panelLeft.Controls.Add(lblProfileUserId)
        panelLeft.EdgeColor = Color.FromArgb(CByte(32), CByte(41), CByte(50))
        panelLeft.Location = New Point(0, 40)
        panelLeft.Margin = New Padding(3, 2, 3, 2)
        panelLeft.Name = "panelLeft"
        panelLeft.Padding = New Padding(4)
        panelLeft.Size = New Size(210, 455)
        panelLeft.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        panelLeft.TabIndex = 3
        ' 
        ' panelAvatarBg
        ' 
        panelAvatarBg.BackColor = Color.FromArgb(CByte(26), CByte(72), CByte(100))
        panelAvatarBg.Controls.Add(lblAvatarInitial)
        panelAvatarBg.Controls.Add(picProfileAvatar)
        panelAvatarBg.EdgeColor = Color.FromArgb(CByte(32), CByte(41), CByte(50))
        panelAvatarBg.Location = New Point(77, 10)
        panelAvatarBg.Margin = New Padding(3, 2, 3, 2)
        panelAvatarBg.Name = "panelAvatarBg"
        panelAvatarBg.Padding = New Padding(4)
        panelAvatarBg.Size = New Size(56, 48)
        panelAvatarBg.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        panelAvatarBg.TabIndex = 0
        ' 
        ' lblAvatarInitial
        ' 
        lblAvatarInitial.Dock = DockStyle.Fill
        lblAvatarInitial.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        lblAvatarInitial.ForeColor = Color.FromArgb(CByte(83), CByte(231), CByte(248))
        lblAvatarInitial.Location = New Point(4, 4)
        lblAvatarInitial.Name = "lblAvatarInitial"
        lblAvatarInitial.Size = New Size(48, 40)
        lblAvatarInitial.TabIndex = 0
        lblAvatarInitial.Text = "?"
        lblAvatarInitial.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picProfileAvatar
        ' 
        picProfileAvatar.BackColor = Color.Transparent
        picProfileAvatar.Cursor = Cursors.Hand
        picProfileAvatar.Dock = DockStyle.Fill
        picProfileAvatar.Location = New Point(4, 4)
        picProfileAvatar.Margin = New Padding(3, 2, 3, 2)
        picProfileAvatar.Name = "picProfileAvatar"
        picProfileAvatar.Size = New Size(48, 40)
        picProfileAvatar.SizeMode = PictureBoxSizeMode.Zoom
        picProfileAvatar.TabIndex = 1
        picProfileAvatar.TabStop = False
        picProfileAvatar.Visible = False
        ' 
        ' lblDisplayName
        ' 
        lblDisplayName.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold)
        lblDisplayName.ForeColor = Color.FromArgb(CByte(230), CByte(238), CByte(252))
        lblDisplayName.Location = New Point(9, 66)
        lblDisplayName.Name = "lblDisplayName"
        lblDisplayName.Size = New Size(192, 16)
        lblDisplayName.TabIndex = 1
        lblDisplayName.Text = "Loading..."
        lblDisplayName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDisplayBio
        ' 
        lblDisplayBio.Font = New Font("Segoe UI", 8.0F, FontStyle.Italic)
        lblDisplayBio.ForeColor = Color.FromArgb(CByte(120), CByte(134), CByte(158))
        lblDisplayBio.Location = New Point(9, 84)
        lblDisplayBio.Name = "lblDisplayBio"
        lblDisplayBio.Size = New Size(192, 22)
        lblDisplayBio.TabIndex = 2
        lblDisplayBio.Text = "-"
        lblDisplayBio.TextAlign = ContentAlignment.TopCenter
        '
        ' lblProfileStats
        '
        lblProfileStats.BackColor = Color.Transparent
        lblProfileStats.Font = New Font("Segoe UI", 7.5F)
        lblProfileStats.ForeColor = Color.FromArgb(CByte(100), CByte(120), CByte(152))
        lblProfileStats.Location = New Point(9, 109)
        lblProfileStats.Name = "lblProfileStats"
        lblProfileStats.Size = New Size(192, 16)
        lblProfileStats.TabIndex = 12
        lblProfileStats.Text = "memuat..."
        lblProfileStats.TextAlign = ContentAlignment.MiddleCenter
        '
        ' lblSectionProfile
        '
        lblSectionProfile.Font = New Font("Segoe UI", 7.0F, FontStyle.Bold)
        lblSectionProfile.ForeColor = Color.FromArgb(CByte(70), CByte(90), CByte(120))
        lblSectionProfile.Location = New Point(12, 129)
        lblSectionProfile.Name = "lblSectionProfile"
        lblSectionProfile.Size = New Size(186, 10)
        lblSectionProfile.TabIndex = 3
        lblSectionProfile.Text = "EDIT PROFIL"
        '
        ' lblProfileUsernameHint
        '
        lblProfileUsernameHint.AutoSize = True
        lblProfileUsernameHint.Font = New Font("Segoe UI", 7.0F, FontStyle.Bold)
        lblProfileUsernameHint.ForeColor = Color.FromArgb(CByte(110), CByte(126), CByte(152))
        lblProfileUsernameHint.Location = New Point(12, 142)
        lblProfileUsernameHint.Name = "lblProfileUsernameHint"
        lblProfileUsernameHint.Size = New Size(50, 12)
        lblProfileUsernameHint.TabIndex = 4
        lblProfileUsernameHint.Text = "Username"
        '
        ' txtProfileUsername
        '
        txtProfileUsername.BackColor = Color.FromArgb(CByte(16), CByte(22), CByte(36))
        txtProfileUsername.BorderStyle = BorderStyle.FixedSingle
        txtProfileUsername.Font = New Font("Segoe UI Semibold", 9.0F)
        txtProfileUsername.ForeColor = Color.Gainsboro
        txtProfileUsername.Location = New Point(12, 154)
        txtProfileUsername.Margin = New Padding(3, 2, 3, 2)
        txtProfileUsername.Name = "txtProfileUsername"
        txtProfileUsername.Size = New Size(186, 23)
        txtProfileUsername.TabIndex = 5
        '
        ' lblProfileEmailHint
        '
        lblProfileEmailHint.AutoSize = True
        lblProfileEmailHint.Font = New Font("Segoe UI", 7.0F, FontStyle.Bold)
        lblProfileEmailHint.ForeColor = Color.FromArgb(CByte(110), CByte(126), CByte(152))
        lblProfileEmailHint.Location = New Point(12, 178)
        lblProfileEmailHint.Name = "lblProfileEmailHint"
        lblProfileEmailHint.Size = New Size(30, 12)
        lblProfileEmailHint.TabIndex = 6
        lblProfileEmailHint.Text = "Email"
        '
        ' txtProfileEmail
        '
        txtProfileEmail.BackColor = Color.FromArgb(CByte(13), CByte(18), CByte(28))
        txtProfileEmail.BorderStyle = BorderStyle.FixedSingle
        txtProfileEmail.Font = New Font("Segoe UI", 9.0F)
        txtProfileEmail.ForeColor = Color.FromArgb(CByte(80), CByte(96), CByte(118))
        txtProfileEmail.Location = New Point(12, 190)
        txtProfileEmail.Margin = New Padding(3, 2, 3, 2)
        txtProfileEmail.Name = "txtProfileEmail"
        txtProfileEmail.ReadOnly = True
        txtProfileEmail.Size = New Size(186, 23)
        txtProfileEmail.TabIndex = 7
        '
        ' lblProfileBioHint
        '
        lblProfileBioHint.AutoSize = True
        lblProfileBioHint.Font = New Font("Segoe UI", 7.0F, FontStyle.Bold)
        lblProfileBioHint.ForeColor = Color.FromArgb(CByte(110), CByte(126), CByte(152))
        lblProfileBioHint.Location = New Point(12, 214)
        lblProfileBioHint.Name = "lblProfileBioHint"
        lblProfileBioHint.Size = New Size(20, 12)
        lblProfileBioHint.TabIndex = 8
        lblProfileBioHint.Text = "Bio"
        '
        ' txtProfileBio
        '
        txtProfileBio.BackColor = Color.FromArgb(CByte(16), CByte(22), CByte(36))
        txtProfileBio.BorderStyle = BorderStyle.FixedSingle
        txtProfileBio.Font = New Font("Segoe UI", 9.0F)
        txtProfileBio.ForeColor = Color.Gainsboro
        txtProfileBio.Location = New Point(12, 226)
        txtProfileBio.Margin = New Padding(3, 2, 3, 2)
        txtProfileBio.Multiline = True
        txtProfileBio.Name = "txtProfileBio"
        txtProfileBio.ScrollBars = ScrollBars.Vertical
        txtProfileBio.Size = New Size(186, 40)
        txtProfileBio.TabIndex = 9
        '
        ' lblProfileAvatarUrlHint
        '
        lblProfileAvatarUrlHint.AutoSize = True
        lblProfileAvatarUrlHint.Font = New Font("Segoe UI", 7.0F, FontStyle.Bold)
        lblProfileAvatarUrlHint.ForeColor = Color.FromArgb(CByte(110), CByte(126), CByte(152))
        lblProfileAvatarUrlHint.Location = New Point(12, 272)
        lblProfileAvatarUrlHint.Name = "lblProfileAvatarUrlHint"
        lblProfileAvatarUrlHint.Size = New Size(60, 12)
        lblProfileAvatarUrlHint.TabIndex = 13
        lblProfileAvatarUrlHint.Text = "Avatar URL"
        '
        ' txtProfileAvatarUrl
        '
        txtProfileAvatarUrl.BackColor = Color.FromArgb(CByte(16), CByte(22), CByte(36))
        txtProfileAvatarUrl.BorderStyle = BorderStyle.FixedSingle
        txtProfileAvatarUrl.Font = New Font("Segoe UI", 8.0F)
        txtProfileAvatarUrl.ForeColor = Color.Gainsboro
        txtProfileAvatarUrl.Location = New Point(12, 284)
        txtProfileAvatarUrl.Margin = New Padding(3, 2, 3, 2)
        txtProfileAvatarUrl.Name = "txtProfileAvatarUrl"
        txtProfileAvatarUrl.PlaceholderText = "URL atau pilih file..."
        txtProfileAvatarUrl.Size = New Size(148, 22)
        txtProfileAvatarUrl.TabIndex = 14
        '
        ' btnBrowseAvatar
        '
        btnBrowseAvatar.BackColor = Color.FromArgb(CByte(24), CByte(36), CByte(56))
        btnBrowseAvatar.Cursor = Cursors.Hand
        btnBrowseAvatar.FlatAppearance.BorderColor = Color.FromArgb(CByte(38), CByte(52), CByte(72))
        btnBrowseAvatar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(44), CByte(64))
        btnBrowseAvatar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(34), CByte(50), CByte(70))
        btnBrowseAvatar.FlatStyle = FlatStyle.Flat
        btnBrowseAvatar.Font = New Font("Segoe UI Semibold", 7.5F, FontStyle.Bold)
        btnBrowseAvatar.ForeColor = Color.FromArgb(CByte(120), CByte(160), CByte(200))
        btnBrowseAvatar.Location = New Point(162, 284)
        btnBrowseAvatar.Margin = New Padding(3, 2, 3, 2)
        btnBrowseAvatar.Name = "btnBrowseAvatar"
        btnBrowseAvatar.Size = New Size(36, 22)
        btnBrowseAvatar.TabIndex = 16
        btnBrowseAvatar.Text = "..."
        btnBrowseAvatar.UseVisualStyleBackColor = False
        '
        ' btnSaveProfile
        '
        btnSaveProfile.BackColor = Color.FromArgb(CByte(38), CByte(174), CByte(200))
        btnSaveProfile.Cursor = Cursors.Hand
        btnSaveProfile.FlatAppearance.BorderColor = Color.FromArgb(CByte(12), CByte(148), CByte(174))
        btnSaveProfile.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(156), CByte(182))
        btnSaveProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(50), CByte(186), CByte(212))
        btnSaveProfile.FlatStyle = FlatStyle.Flat
        btnSaveProfile.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnSaveProfile.ForeColor = Color.FromArgb(CByte(8), CByte(42), CByte(58))
        btnSaveProfile.Location = New Point(12, 310)
        btnSaveProfile.Margin = New Padding(3, 2, 3, 2)
        btnSaveProfile.Name = "btnSaveProfile"
        btnSaveProfile.Size = New Size(186, 22)
        btnSaveProfile.TabIndex = 15
        btnSaveProfile.Text = "Simpan Profil"
        btnSaveProfile.UseVisualStyleBackColor = False
        ' 
        ' lblProfileUserId
        ' 
        lblProfileUserId.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblProfileUserId.AutoEllipsis = True
        lblProfileUserId.Font = New Font("Segoe UI", 7.0F, FontStyle.Italic)
        lblProfileUserId.ForeColor = Color.FromArgb(CByte(45), CByte(58), CByte(80))
        lblProfileUserId.Location = New Point(12, 430)
        lblProfileUserId.Name = "lblProfileUserId"
        lblProfileUserId.Size = New Size(186, 10)
        lblProfileUserId.TabIndex = 11
        lblProfileUserId.Text = "uid: -"
        ' 
        ' panelMiddle
        ' 
        panelMiddle.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        panelMiddle.BackColor = Color.FromArgb(CByte(8), CByte(13), CByte(24))
        panelMiddle.Controls.Add(lblSectionFollow)
        panelMiddle.Controls.Add(txtFollowUsername)
        panelMiddle.Controls.Add(btnFollow)
        panelMiddle.Controls.Add(pnlFollowingHeader)
        panelMiddle.Controls.Add(lbFollowing)
        panelMiddle.Controls.Add(btnClose)
        panelMiddle.EdgeColor = Color.FromArgb(CByte(32), CByte(41), CByte(50))
        panelMiddle.Location = New Point(210, 40)
        panelMiddle.Margin = New Padding(3, 2, 3, 2)
        panelMiddle.Name = "panelMiddle"
        panelMiddle.Padding = New Padding(4)
        panelMiddle.Size = New Size(175, 455)
        panelMiddle.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        panelMiddle.TabIndex = 4
        ' 
        ' lblSectionFollow
        ' 
        lblSectionFollow.Font = New Font("Segoe UI", 7.0F, FontStyle.Bold)
        lblSectionFollow.ForeColor = Color.FromArgb(CByte(70), CByte(90), CByte(120))
        lblSectionFollow.Location = New Point(10, 9)
        lblSectionFollow.Name = "lblSectionFollow"
        lblSectionFollow.Size = New Size(154, 10)
        lblSectionFollow.TabIndex = 0
        lblSectionFollow.Text = "TAMBAH TEMAN"
        ' 
        ' txtFollowUsername
        ' 
        txtFollowUsername.BackColor = Color.FromArgb(CByte(16), CByte(22), CByte(36))
        txtFollowUsername.BorderStyle = BorderStyle.FixedSingle
        txtFollowUsername.Font = New Font("Segoe UI", 9.0F)
        txtFollowUsername.ForeColor = Color.Gainsboro
        txtFollowUsername.Location = New Point(10, 22)
        txtFollowUsername.Margin = New Padding(3, 2, 3, 2)
        txtFollowUsername.Name = "txtFollowUsername"
        txtFollowUsername.PlaceholderText = "@username..."
        txtFollowUsername.Size = New Size(154, 23)
        txtFollowUsername.TabIndex = 1
        ' 
        ' btnFollow
        ' 
        btnFollow.BackColor = Color.FromArgb(CByte(38), CByte(174), CByte(200))
        btnFollow.Cursor = Cursors.Hand
        btnFollow.FlatAppearance.BorderColor = Color.FromArgb(CByte(12), CByte(148), CByte(174))
        btnFollow.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(156), CByte(182))
        btnFollow.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(50), CByte(186), CByte(212))
        btnFollow.FlatStyle = FlatStyle.Flat
        btnFollow.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnFollow.ForeColor = Color.FromArgb(CByte(8), CByte(42), CByte(58))
        btnFollow.Location = New Point(10, 46)
        btnFollow.Margin = New Padding(3, 2, 3, 2)
        btnFollow.Name = "btnFollow"
        btnFollow.Size = New Size(154, 21)
        btnFollow.TabIndex = 2
        btnFollow.Text = "+ Follow"
        btnFollow.UseVisualStyleBackColor = False
        ' 
        ' pnlFollowingHeader
        ' 
        pnlFollowingHeader.BackColor = Color.FromArgb(CByte(10), CByte(16), CByte(28))
        pnlFollowingHeader.Controls.Add(lblFollowingTitle)
        pnlFollowingHeader.Controls.Add(btnRefreshFollowing)
        pnlFollowingHeader.EdgeColor = Color.FromArgb(CByte(32), CByte(41), CByte(50))
        pnlFollowingHeader.Location = New Point(0, 72)
        pnlFollowingHeader.Margin = New Padding(3, 2, 3, 2)
        pnlFollowingHeader.Name = "pnlFollowingHeader"
        pnlFollowingHeader.Padding = New Padding(4)
        pnlFollowingHeader.Size = New Size(175, 20)
        pnlFollowingHeader.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        pnlFollowingHeader.TabIndex = 3
        ' 
        ' lblFollowingTitle
        ' 
        lblFollowingTitle.AutoSize = True
        lblFollowingTitle.Font = New Font("Segoe UI", 7.0F, FontStyle.Bold)
        lblFollowingTitle.ForeColor = Color.FromArgb(CByte(70), CByte(90), CByte(120))
        lblFollowingTitle.Location = New Point(10, 4)
        lblFollowingTitle.Name = "lblFollowingTitle"
        lblFollowingTitle.Size = New Size(64, 12)
        lblFollowingTitle.TabIndex = 0
        lblFollowingTitle.Text = "FOLLOWING"
        ' 
        ' btnRefreshFollowing
        ' 
        btnRefreshFollowing.Anchor = AnchorStyles.Right
        btnRefreshFollowing.BackColor = Color.Transparent
        btnRefreshFollowing.Cursor = Cursors.Hand
        btnRefreshFollowing.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(229), CByte(229), CByte(229))
        btnRefreshFollowing.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(237), CByte(237), CByte(237))
        btnRefreshFollowing.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(255), CByte(255), CByte(255))
        btnRefreshFollowing.FlatStyle = FlatStyle.Flat
        btnRefreshFollowing.Font = New Font("Segoe UI Symbol", 9.0F)
        btnRefreshFollowing.ForeColor = Color.FromArgb(CByte(70), CByte(90), CByte(120))
        btnRefreshFollowing.Location = New Point(147, 2)
        btnRefreshFollowing.Margin = New Padding(3, 2, 3, 2)
        btnRefreshFollowing.Name = "btnRefreshFollowing"
        btnRefreshFollowing.Size = New Size(21, 16)
        btnRefreshFollowing.TabIndex = 1
        btnRefreshFollowing.Text = "↺"
        btnRefreshFollowing.UseVisualStyleBackColor = False
        ' 
        ' lbFollowing
        ' 
        lbFollowing.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbFollowing.BackColor = Color.FromArgb(CByte(8), CByte(13), CByte(24))
        lbFollowing.BorderStyle = BorderStyle.None
        lbFollowing.DrawMode = DrawMode.OwnerDrawFixed
        lbFollowing.Font = New Font("Segoe UI Semibold", 9.0F)
        lbFollowing.ForeColor = Color.FromArgb(CByte(170), CByte(184), CByte(208))
        lbFollowing.FormattingEnabled = True
        lbFollowing.ItemHeight = 38
        lbFollowing.Location = New Point(0, 92)
        lbFollowing.Margin = New Padding(3, 2, 3, 2)
        lbFollowing.Name = "lbFollowing"
        lbFollowing.Size = New Size(175, 304)
        lbFollowing.TabIndex = 4
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnClose.BackColor = Color.FromArgb(CByte(14), CByte(22), CByte(38))
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(12))
        btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(4), CByte(20))
        btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(26), CByte(34), CByte(50))
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnClose.ForeColor = Color.FromArgb(CByte(100), CByte(114), CByte(140))
        btnClose.Location = New Point(0, 427)
        btnClose.Margin = New Padding(3, 2, 3, 2)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(175, 28)
        btnClose.TabIndex = 5
        btnClose.Text = "✕  Tutup"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' panelRight
        ' 
        panelRight.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        panelRight.BackColor = Color.FromArgb(CByte(11), CByte(18), CByte(32))
        panelRight.Controls.Add(panelChatHeader)
        panelRight.Controls.Add(panelChatArea)
        panelRight.Controls.Add(panelChatInput)
        panelRight.EdgeColor = Color.FromArgb(CByte(32), CByte(41), CByte(50))
        panelRight.Location = New Point(385, 40)
        panelRight.Margin = New Padding(3, 2, 3, 2)
        panelRight.Name = "panelRight"
        panelRight.Padding = New Padding(4)
        panelRight.Size = New Size(438, 455)
        panelRight.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        panelRight.TabIndex = 5
        ' 
        ' panelChatHeader
        ' 
        panelChatHeader.BackColor = Color.FromArgb(CByte(9), CByte(14), CByte(26))
        panelChatHeader.Controls.Add(lblTitle)
        panelChatHeader.Controls.Add(lblStatus)
        panelChatHeader.Dock = DockStyle.Top
        panelChatHeader.EdgeColor = Color.FromArgb(CByte(32), CByte(41), CByte(50))
        panelChatHeader.Location = New Point(4, 4)
        panelChatHeader.Margin = New Padding(3, 2, 3, 2)
        panelChatHeader.Name = "panelChatHeader"
        panelChatHeader.Padding = New Padding(4)
        panelChatHeader.Size = New Size(430, 44)
        panelChatHeader.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        panelChatHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI Semibold", 13.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(228), CByte(236), CByte(252))
        lblTitle.Location = New Point(14, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(402, 24)
        lblTitle.TabIndex = 0
        lblTitle.Text = "# Social Room"
        ' 
        ' lblStatus
        ' 
        lblStatus.BackColor = Color.Transparent
        lblStatus.Font = New Font("Segoe UI", 7.5F)
        lblStatus.ForeColor = Color.FromArgb(CByte(70), CByte(90), CByte(120))
        lblStatus.Location = New Point(14, 26)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(402, 12)
        lblStatus.TabIndex = 1
        lblStatus.Text = "Pilih teman di kiri untuk mulai chat."
        ' 
        ' panelChatArea
        ' 
        panelChatArea.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        panelChatArea.BackColor = Color.FromArgb(CByte(11), CByte(18), CByte(32))
        panelChatArea.Controls.Add(lbConversation)
        panelChatArea.EdgeColor = Color.FromArgb(CByte(32), CByte(41), CByte(50))
        panelChatArea.Location = New Point(0, 44)
        panelChatArea.Margin = New Padding(3, 2, 3, 2)
        panelChatArea.Name = "panelChatArea"
        panelChatArea.Padding = New Padding(4)
        panelChatArea.Size = New Size(438, 368)
        panelChatArea.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        panelChatArea.TabIndex = 1
        ' 
        ' lbConversation
        ' 
        lbConversation.BackColor = Color.FromArgb(CByte(11), CByte(18), CByte(32))
        lbConversation.BorderStyle = BorderStyle.None
        lbConversation.Dock = DockStyle.Fill
        lbConversation.DrawMode = DrawMode.OwnerDrawVariable
        lbConversation.Font = New Font("Segoe UI", 9.5F)
        lbConversation.ForeColor = Color.FromArgb(CByte(210), CByte(220), CByte(238))
        lbConversation.FormattingEnabled = True
        lbConversation.Location = New Point(4, 4)
        lbConversation.Margin = New Padding(3, 2, 3, 2)
        lbConversation.Name = "lbConversation"
        lbConversation.Size = New Size(430, 360)
        lbConversation.TabIndex = 0
        ' 
        ' panelChatInput
        ' 
        panelChatInput.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        panelChatInput.BackColor = Color.FromArgb(CByte(13), CByte(20), CByte(34))
        panelChatInput.Controls.Add(txtMessageBody)
        panelChatInput.Controls.Add(btnSendMessage)
        panelChatInput.EdgeColor = Color.FromArgb(CByte(32), CByte(41), CByte(50))
        panelChatInput.Location = New Point(0, 412)
        panelChatInput.Margin = New Padding(3, 2, 3, 2)
        panelChatInput.Name = "panelChatInput"
        panelChatInput.Padding = New Padding(4)
        panelChatInput.Size = New Size(438, 44)
        panelChatInput.SmoothingType = Drawing2D.SmoothingMode.HighQuality
        panelChatInput.TabIndex = 2
        ' 
        ' txtMessageBody
        ' 
        txtMessageBody.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtMessageBody.BackColor = Color.FromArgb(CByte(16), CByte(22), CByte(36))
        txtMessageBody.BorderStyle = BorderStyle.FixedSingle
        txtMessageBody.Font = New Font("Segoe UI", 9.5F)
        txtMessageBody.ForeColor = Color.Gainsboro
        txtMessageBody.Location = New Point(10, 10)
        txtMessageBody.Margin = New Padding(3, 2, 3, 2)
        txtMessageBody.Name = "txtMessageBody"
        txtMessageBody.PlaceholderText = "Tulis pesan... (Enter kirim)"
        txtMessageBody.Size = New Size(298, 24)
        txtMessageBody.TabIndex = 0
        ' 
        ' btnSendMessage
        ' 
        btnSendMessage.Anchor = AnchorStyles.Right
        btnSendMessage.BackColor = Color.FromArgb(CByte(38), CByte(174), CByte(200))
        btnSendMessage.Cursor = Cursors.Hand
        btnSendMessage.FlatAppearance.BorderColor = Color.FromArgb(CByte(12), CByte(148), CByte(174))
        btnSendMessage.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(20), CByte(156), CByte(182))
        btnSendMessage.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(50), CByte(186), CByte(212))
        btnSendMessage.FlatStyle = FlatStyle.Flat
        btnSendMessage.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnSendMessage.ForeColor = Color.FromArgb(CByte(8), CByte(42), CByte(58))
        btnSendMessage.Location = New Point(313, 8)
        btnSendMessage.Margin = New Padding(3, 2, 3, 2)
        btnSendMessage.Name = "btnSendMessage"
        btnSendMessage.Size = New Size(114, 27)
        btnSendMessage.TabIndex = 1
        btnSendMessage.Text = "Kirim ➤"
        btnSendMessage.UseVisualStyleBackColor = False
        ' 
        ' SocialHubPage
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(822, 495)
        Controls.Add(NightForm1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        MaximumSize = New Size(1680, 774)
        MinimumSize = New Size(665, 405)
        Name = "SocialHubPage"
        StartPosition = FormStartPosition.CenterParent
        TransparencyKey = Color.Fuchsia
        NightForm1.ResumeLayout(False)
        NightForm1.PerformLayout()
        panelLeft.ResumeLayout(False)
        panelLeft.PerformLayout()
        panelAvatarBg.ResumeLayout(False)
        CType(picProfileAvatar, ComponentModel.ISupportInitialize).EndInit()
        panelMiddle.ResumeLayout(False)
        panelMiddle.PerformLayout()
        pnlFollowingHeader.ResumeLayout(False)
        pnlFollowingHeader.PerformLayout()
        panelRight.ResumeLayout(False)
        panelChatHeader.ResumeLayout(False)
        panelChatArea.ResumeLayout(False)
        panelChatInput.ResumeLayout(False)
        panelChatInput.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents NightForm1 As NightForm
    Friend WithEvents lblClose As Label
    Friend WithEvents lblBrand As NightLabel
    Friend WithEvents lblBadge As NightLabel

    Friend WithEvents panelLeft As Panel
    Friend WithEvents panelAvatarBg As Panel
    Friend WithEvents picProfileAvatar As PictureBox
    Friend WithEvents lblAvatarInitial As Label
    Friend WithEvents lblDisplayName As Label
    Friend WithEvents lblDisplayBio As Label
    Friend WithEvents lblProfileStats As Label
    Friend WithEvents lblProfileUserId As Label
    Friend WithEvents lblSectionProfile As Label
    Friend WithEvents lblProfileUsernameHint As Label
    Friend WithEvents txtProfileUsername As TextBox
    Friend WithEvents lblProfileEmailHint As Label
    Friend WithEvents txtProfileEmail As TextBox
    Friend WithEvents lblProfileBioHint As Label
    Friend WithEvents txtProfileBio As TextBox
    Friend WithEvents lblProfileAvatarUrlHint As Label
    Friend WithEvents txtProfileAvatarUrl As TextBox
    Friend WithEvents btnBrowseAvatar As StableActionButton
    Friend WithEvents btnSaveProfile As StableActionButton

    Friend WithEvents panelMiddle As Panel
    Friend WithEvents lblSectionFollow As Label
    Friend WithEvents txtFollowUsername As TextBox
    Friend WithEvents btnFollow As StableActionButton
    Friend WithEvents pnlFollowingHeader As Panel
    Friend WithEvents lblFollowingTitle As Label
    Friend WithEvents btnRefreshFollowing As StableActionButton
    Friend WithEvents lbFollowing As ListBox
    Friend WithEvents btnClose As StableActionButton

    Friend WithEvents panelRight As Panel
    Friend WithEvents panelChatHeader As Panel
    Friend WithEvents lblTitle As NightLabel
    Friend WithEvents lblStatus As NightLabel
    Friend WithEvents panelChatArea As Panel
    Friend WithEvents lbConversation As ListBox
    Friend WithEvents panelChatInput As Panel
    Friend WithEvents txtMessageBody As TextBox
    Friend WithEvents btnSendMessage As StableActionButton
End Class
