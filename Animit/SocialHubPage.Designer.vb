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
        ' ── Instantiation ──────────────────────
        NightForm1 = New NightForm()
        lblClose = New Label()
        lblBrand = New NightLabel()
        lblBadge = New NightLabel()

        panelLeft = New Panel()
        panelAvatarBg = New Panel()
        picProfileAvatar = New PictureBox()
        lblAvatarInitial = New Label()
        lblDisplayName = New Label()
        lblDisplayBio = New Label()
        lblSectionProfile = New Label()
        lblProfileUsernameHint = New Label()
        txtProfileUsername = New TextBox()
        lblProfileEmailHint = New Label()
        txtProfileEmail = New TextBox()
        lblProfileBioHint = New Label()
        txtProfileBio = New TextBox()
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
        CType(picProfileAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        panelMiddle.SuspendLayout()
        pnlFollowingHeader.SuspendLayout()
        panelRight.SuspendLayout()
        panelChatHeader.SuspendLayout()
        panelChatArea.SuspendLayout()
        panelChatInput.SuspendLayout()
        SuspendLayout()

        ' ── NightForm1 ─────────────────────────
        NightForm1.BackColor = Color.FromArgb(CByte(8), CByte(14), CByte(26))
        NightForm1.Controls.Add(lblClose)
        NightForm1.Controls.Add(lblBrand)
        NightForm1.Controls.Add(lblBadge)
        NightForm1.Controls.Add(panelLeft)
        NightForm1.Controls.Add(panelMiddle)
        NightForm1.Controls.Add(panelRight)
        NightForm1.Dock = DockStyle.Fill
        NightForm1.DrawIcon = False
        NightForm1.Font = New Font("Segoe UI", 9F)
        NightForm1.HeadColor = Color.FromArgb(CByte(8), CByte(14), CByte(26))
        NightForm1.Location = New Point(0, 0)
        NightForm1.MinimumSize = New Size(114, 56)
        NightForm1.Name = "NightForm1"
        NightForm1.Padding = New Padding(0, 53, 0, 0)
        NightForm1.Size = New Size(1200, 900)
        NightForm1.TabIndex = 0
        NightForm1.TextAlignment = NightForm.Alignment.Left
        NightForm1.TitleBarTextColor = Color.FromArgb(CByte(83), CByte(107), CByte(138))

        ' ── lblClose ──────────────────────────
        lblClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblClose.AutoSize = True
        lblClose.BackColor = Color.Transparent
        lblClose.Cursor = Cursors.Hand
        lblClose.Font = New Font("Segoe UI Symbol", 11F)
        lblClose.ForeColor = Color.FromArgb(CByte(70), CByte(90), CByte(120))
        lblClose.Location = New Point(1172, 2)
        lblClose.Name = "lblClose"
        lblClose.TabIndex = 0
        lblClose.Text = "✕"

        ' ── lblBrand ──────────────────────────
        lblBrand.AutoSize = True
        lblBrand.BackColor = Color.Transparent
        lblBrand.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblBrand.ForeColor = Color.FromArgb(CByte(83), CByte(231), CByte(248))
        lblBrand.Location = New Point(20, 14)
        lblBrand.Name = "lblBrand"
        lblBrand.TabIndex = 1
        lblBrand.Text = "Social Hub"

        ' ── lblBadge ──────────────────────────
        lblBadge.BackColor = Color.FromArgb(CByte(14), CByte(42), CByte(58))
        lblBadge.Font = New Font("Segoe UI Semibold", 7.5F, FontStyle.Bold)
        lblBadge.ForeColor = Color.FromArgb(CByte(84), CByte(234), CByte(255))
        lblBadge.Location = New Point(192, 20)
        lblBadge.Name = "lblBadge"
        lblBadge.Size = New Size(110, 22)
        lblBadge.TabIndex = 2
        lblBadge.Text = "FOLLOW · CHAT"
        lblBadge.TextAlign = ContentAlignment.MiddleCenter

        ' ══════════════════════════════════════
        '  panelLeft  (w=260)  – Profile
        ' ══════════════════════════════════════
        panelLeft.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        panelLeft.BackColor = Color.FromArgb(CByte(10), CByte(16), CByte(28))
        panelLeft.Controls.Add(panelAvatarBg)
        panelLeft.Controls.Add(lblDisplayName)
        panelLeft.Controls.Add(lblDisplayBio)
        panelLeft.Controls.Add(lblSectionProfile)
        panelLeft.Controls.Add(lblProfileUsernameHint)
        panelLeft.Controls.Add(txtProfileUsername)
        panelLeft.Controls.Add(lblProfileEmailHint)
        panelLeft.Controls.Add(txtProfileEmail)
        panelLeft.Controls.Add(lblProfileBioHint)
        panelLeft.Controls.Add(txtProfileBio)
        panelLeft.Controls.Add(btnSaveProfile)
        panelLeft.Controls.Add(lblProfileUserId)
        panelLeft.Location = New Point(0, 53)
        panelLeft.Name = "panelLeft"
        panelLeft.Size = New Size(260, 847)
        panelLeft.TabIndex = 3

        ' ── Avatar circle ──
        panelAvatarBg.BackColor = Color.FromArgb(CByte(26), CByte(72), CByte(100))
        panelAvatarBg.Controls.Add(lblAvatarInitial)
        panelAvatarBg.Controls.Add(picProfileAvatar)
        panelAvatarBg.Location = New Point(90, 18)
        panelAvatarBg.Name = "panelAvatarBg"
        panelAvatarBg.Size = New Size(76, 76)
        panelAvatarBg.TabIndex = 0

        lblAvatarInitial.Dock = DockStyle.Fill
        lblAvatarInitial.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        lblAvatarInitial.ForeColor = Color.FromArgb(CByte(83), CByte(231), CByte(248))
        lblAvatarInitial.Name = "lblAvatarInitial"
        lblAvatarInitial.TabIndex = 0
        lblAvatarInitial.Text = "?"
        lblAvatarInitial.TextAlign = ContentAlignment.MiddleCenter

        picProfileAvatar.Dock = DockStyle.Fill
        picProfileAvatar.SizeMode = PictureBoxSizeMode.Zoom
        picProfileAvatar.BackColor = Color.Transparent
        picProfileAvatar.Cursor = Cursors.Hand
        picProfileAvatar.Name = "picProfileAvatar"
        picProfileAvatar.TabIndex = 1
        picProfileAvatar.TabStop = False
        picProfileAvatar.Visible = False

        ' ── Display name & bio ──
        lblDisplayName.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblDisplayName.ForeColor = Color.FromArgb(CByte(230), CByte(238), CByte(252))
        lblDisplayName.Location = New Point(10, 104)
        lblDisplayName.Name = "lblDisplayName"
        lblDisplayName.Size = New Size(240, 26)
        lblDisplayName.TabIndex = 1
        lblDisplayName.Text = "Loading..."
        lblDisplayName.TextAlign = ContentAlignment.MiddleCenter

        lblDisplayBio.Font = New Font("Segoe UI", 8.5F, FontStyle.Italic)
        lblDisplayBio.ForeColor = Color.FromArgb(CByte(120), CByte(134), CByte(158))
        lblDisplayBio.Location = New Point(10, 132)
        lblDisplayBio.Name = "lblDisplayBio"
        lblDisplayBio.Size = New Size(240, 38)
        lblDisplayBio.TabIndex = 2
        lblDisplayBio.Text = "-"
        lblDisplayBio.TextAlign = ContentAlignment.TopCenter

        ' ── Section header "EDIT PROFIL" ──
        lblSectionProfile.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblSectionProfile.ForeColor = Color.FromArgb(CByte(70), CByte(90), CByte(120))
        lblSectionProfile.Location = New Point(14, 196)
        lblSectionProfile.Name = "lblSectionProfile"
        lblSectionProfile.Size = New Size(232, 16)
        lblSectionProfile.TabIndex = 3
        lblSectionProfile.Text = "EDIT PROFIL"

        ' ── Username ──
        lblProfileUsernameHint.AutoSize = True
        lblProfileUsernameHint.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblProfileUsernameHint.ForeColor = Color.FromArgb(CByte(110), CByte(126), CByte(152))
        lblProfileUsernameHint.Location = New Point(14, 218)
        lblProfileUsernameHint.Name = "lblProfileUsernameHint"
        lblProfileUsernameHint.TabIndex = 4
        lblProfileUsernameHint.Text = "Username"

        txtProfileUsername.BackColor = Color.FromArgb(CByte(16), CByte(22), CByte(36))
        txtProfileUsername.BorderStyle = BorderStyle.FixedSingle
        txtProfileUsername.Font = New Font("Segoe UI Semibold", 9.5F)
        txtProfileUsername.ForeColor = Color.Gainsboro
        txtProfileUsername.Location = New Point(14, 236)
        txtProfileUsername.Name = "txtProfileUsername"
        txtProfileUsername.Size = New Size(232, 28)
        txtProfileUsername.TabIndex = 5

        ' ── Email ──
        lblProfileEmailHint.AutoSize = True
        lblProfileEmailHint.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblProfileEmailHint.ForeColor = Color.FromArgb(CByte(110), CByte(126), CByte(152))
        lblProfileEmailHint.Location = New Point(14, 272)
        lblProfileEmailHint.Name = "lblProfileEmailHint"
        lblProfileEmailHint.TabIndex = 6
        lblProfileEmailHint.Text = "Email"

        txtProfileEmail.BackColor = Color.FromArgb(CByte(13), CByte(18), CByte(28))
        txtProfileEmail.BorderStyle = BorderStyle.FixedSingle
        txtProfileEmail.Font = New Font("Segoe UI", 9.5F)
        txtProfileEmail.ForeColor = Color.FromArgb(CByte(80), CByte(96), CByte(118))
        txtProfileEmail.Location = New Point(14, 290)
        txtProfileEmail.Name = "txtProfileEmail"
        txtProfileEmail.ReadOnly = True
        txtProfileEmail.Size = New Size(232, 28)
        txtProfileEmail.TabIndex = 7

        ' ── Bio ──
        lblProfileBioHint.AutoSize = True
        lblProfileBioHint.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblProfileBioHint.ForeColor = Color.FromArgb(CByte(110), CByte(126), CByte(152))
        lblProfileBioHint.Location = New Point(14, 326)
        lblProfileBioHint.Name = "lblProfileBioHint"
        lblProfileBioHint.TabIndex = 8
        lblProfileBioHint.Text = "Bio"

        txtProfileBio.BackColor = Color.FromArgb(CByte(16), CByte(22), CByte(36))
        txtProfileBio.BorderStyle = BorderStyle.FixedSingle
        txtProfileBio.Font = New Font("Segoe UI", 9.5F)
        txtProfileBio.ForeColor = Color.Gainsboro
        txtProfileBio.Location = New Point(14, 344)
        txtProfileBio.Multiline = True
        txtProfileBio.Name = "txtProfileBio"
        txtProfileBio.ScrollBars = ScrollBars.Vertical
        txtProfileBio.Size = New Size(232, 62)
        txtProfileBio.TabIndex = 9

        ' ── Save button ──
        btnSaveProfile.BackColor = Color.FromArgb(CByte(38), CByte(174), CByte(200))
        btnSaveProfile.Cursor = Cursors.Hand
        btnSaveProfile.FlatStyle = FlatStyle.Flat
        btnSaveProfile.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnSaveProfile.ForeColor = Color.FromArgb(CByte(8), CByte(42), CByte(58))
        btnSaveProfile.Location = New Point(14, 418)
        btnSaveProfile.Name = "btnSaveProfile"
        btnSaveProfile.Size = New Size(232, 34)
        btnSaveProfile.TabIndex = 10
        btnSaveProfile.Text = "Simpan Profil"
        btnSaveProfile.UseVisualStyleBackColor = False

        ' ── User ID (anchored bottom) ──
        lblProfileUserId.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblProfileUserId.AutoEllipsis = True
        lblProfileUserId.Font = New Font("Segoe UI", 7F, FontStyle.Italic)
        lblProfileUserId.ForeColor = Color.FromArgb(CByte(45), CByte(58), CByte(80))
        lblProfileUserId.Location = New Point(14, 822)
        lblProfileUserId.Name = "lblProfileUserId"
        lblProfileUserId.Size = New Size(232, 16)
        lblProfileUserId.TabIndex = 11
        lblProfileUserId.Text = "uid: -"

        ' ══════════════════════════════════════
        '  panelMiddle  (w=220)  – Following
        ' ══════════════════════════════════════
        panelMiddle.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        panelMiddle.BackColor = Color.FromArgb(CByte(8), CByte(13), CByte(24))
        panelMiddle.Controls.Add(lblSectionFollow)
        panelMiddle.Controls.Add(txtFollowUsername)
        panelMiddle.Controls.Add(btnFollow)
        panelMiddle.Controls.Add(pnlFollowingHeader)
        panelMiddle.Controls.Add(lbFollowing)
        panelMiddle.Controls.Add(btnClose)
        panelMiddle.Location = New Point(260, 53)
        panelMiddle.Name = "panelMiddle"
        panelMiddle.Size = New Size(220, 847)
        panelMiddle.TabIndex = 4

        ' ── "TAMBAH TEMAN" section ──
        lblSectionFollow.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblSectionFollow.ForeColor = Color.FromArgb(CByte(70), CByte(90), CByte(120))
        lblSectionFollow.Location = New Point(12, 14)
        lblSectionFollow.Name = "lblSectionFollow"
        lblSectionFollow.Size = New Size(196, 16)
        lblSectionFollow.TabIndex = 0
        lblSectionFollow.Text = "TAMBAH TEMAN"

        txtFollowUsername.BackColor = Color.FromArgb(CByte(16), CByte(22), CByte(36))
        txtFollowUsername.BorderStyle = BorderStyle.FixedSingle
        txtFollowUsername.Font = New Font("Segoe UI", 9.5F)
        txtFollowUsername.ForeColor = Color.Gainsboro
        txtFollowUsername.Location = New Point(12, 34)
        txtFollowUsername.Name = "txtFollowUsername"
        txtFollowUsername.PlaceholderText = "@username..."
        txtFollowUsername.Size = New Size(196, 28)
        txtFollowUsername.TabIndex = 1

        btnFollow.BackColor = Color.FromArgb(CByte(38), CByte(174), CByte(200))
        btnFollow.Cursor = Cursors.Hand
        btnFollow.FlatStyle = FlatStyle.Flat
        btnFollow.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnFollow.ForeColor = Color.FromArgb(CByte(8), CByte(42), CByte(58))
        btnFollow.Location = New Point(12, 68)
        btnFollow.Name = "btnFollow"
        btnFollow.Size = New Size(196, 30)
        btnFollow.TabIndex = 2
        btnFollow.Text = "+ Follow"
        btnFollow.UseVisualStyleBackColor = False

        ' ── Following header strip ──
        pnlFollowingHeader.BackColor = Color.FromArgb(CByte(10), CByte(16), CByte(28))
        pnlFollowingHeader.Controls.Add(lblFollowingTitle)
        pnlFollowingHeader.Controls.Add(btnRefreshFollowing)
        pnlFollowingHeader.Location = New Point(0, 108)
        pnlFollowingHeader.Name = "pnlFollowingHeader"
        pnlFollowingHeader.Size = New Size(220, 30)
        pnlFollowingHeader.TabIndex = 3

        lblFollowingTitle.AutoSize = True
        lblFollowingTitle.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblFollowingTitle.ForeColor = Color.FromArgb(CByte(70), CByte(90), CByte(120))
        lblFollowingTitle.Location = New Point(12, 7)
        lblFollowingTitle.Name = "lblFollowingTitle"
        lblFollowingTitle.TabIndex = 0
        lblFollowingTitle.Text = "FOLLOWING"

        btnRefreshFollowing.Anchor = AnchorStyles.Right
        btnRefreshFollowing.BackColor = Color.Transparent
        btnRefreshFollowing.Cursor = Cursors.Hand
        btnRefreshFollowing.FlatStyle = FlatStyle.Flat
        btnRefreshFollowing.FlatAppearance.BorderColor = Color.Transparent
        btnRefreshFollowing.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(18), CByte(28), CByte(48))
        btnRefreshFollowing.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(18), CByte(28), CByte(48))
        btnRefreshFollowing.Font = New Font("Segoe UI Symbol", 9F)
        btnRefreshFollowing.ForeColor = Color.FromArgb(CByte(70), CByte(90), CByte(120))
        btnRefreshFollowing.Location = New Point(188, 4)
        btnRefreshFollowing.Name = "btnRefreshFollowing"
        btnRefreshFollowing.Size = New Size(24, 22)
        btnRefreshFollowing.TabIndex = 1
        btnRefreshFollowing.Text = "↺"
        btnRefreshFollowing.UseVisualStyleBackColor = False

        ' ── Following list ──
        lbFollowing.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbFollowing.BackColor = Color.FromArgb(CByte(8), CByte(13), CByte(24))
        lbFollowing.BorderStyle = BorderStyle.None
        lbFollowing.DrawMode = DrawMode.OwnerDrawFixed
        lbFollowing.Font = New Font("Segoe UI Semibold", 9.5F)
        lbFollowing.ForeColor = Color.FromArgb(CByte(170), CByte(184), CByte(208))
        lbFollowing.FormattingEnabled = True
        lbFollowing.ItemHeight = 42
        lbFollowing.Location = New Point(0, 138)
        lbFollowing.Name = "lbFollowing"
        lbFollowing.Size = New Size(220, 664)
        lbFollowing.TabIndex = 4

        ' ── Close button ──
        btnClose.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnClose.BackColor = Color.FromArgb(CByte(14), CByte(22), CByte(38))
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnClose.ForeColor = Color.FromArgb(CByte(100), CByte(114), CByte(140))
        btnClose.Location = New Point(0, 809)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(220, 38)
        btnClose.TabIndex = 5
        btnClose.Text = "✕  Tutup"
        btnClose.UseVisualStyleBackColor = False

        ' ══════════════════════════════════════
        '  panelRight  – Chat area
        ' ══════════════════════════════════════
        panelRight.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        panelRight.BackColor = Color.FromArgb(CByte(11), CByte(18), CByte(32))
        panelRight.Controls.Add(panelChatHeader)
        panelRight.Controls.Add(panelChatArea)
        panelRight.Controls.Add(panelChatInput)
        panelRight.Location = New Point(480, 53)
        panelRight.Name = "panelRight"
        panelRight.Size = New Size(720, 847)
        panelRight.TabIndex = 5

        ' ── Chat header ──
        panelChatHeader.BackColor = Color.FromArgb(CByte(9), CByte(14), CByte(26))
        panelChatHeader.Controls.Add(lblTitle)
        panelChatHeader.Controls.Add(lblStatus)
        panelChatHeader.Dock = DockStyle.Top
        panelChatHeader.Name = "panelChatHeader"
        panelChatHeader.Size = New Size(720, 66)
        panelChatHeader.TabIndex = 0

        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(228), CByte(236), CByte(252))
        lblTitle.Location = New Point(18, 10)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(680, 28)
        lblTitle.TabIndex = 0
        lblTitle.Text = "# Social Room"

        lblStatus.BackColor = Color.Transparent
        lblStatus.Font = New Font("Segoe UI", 8F)
        lblStatus.ForeColor = Color.FromArgb(CByte(70), CByte(90), CByte(120))
        lblStatus.Location = New Point(18, 40)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(680, 18)
        lblStatus.TabIndex = 1
        lblStatus.Text = "Pilih teman di kiri untuk mulai chat."

        ' ── Chat messages ──
        panelChatArea.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        panelChatArea.BackColor = Color.FromArgb(CByte(11), CByte(18), CByte(32))
        panelChatArea.Controls.Add(lbConversation)
        panelChatArea.Location = New Point(0, 67)
        panelChatArea.Name = "panelChatArea"
        panelChatArea.Size = New Size(720, 720)
        panelChatArea.TabIndex = 1

        lbConversation.BackColor = Color.FromArgb(CByte(11), CByte(18), CByte(32))
        lbConversation.BorderStyle = BorderStyle.None
        lbConversation.Dock = DockStyle.Fill
        lbConversation.DrawMode = DrawMode.OwnerDrawFixed
        lbConversation.Font = New Font("Segoe UI", 10F)
        lbConversation.ForeColor = Color.FromArgb(CByte(210), CByte(220), CByte(238))
        lbConversation.FormattingEnabled = True
        lbConversation.ItemHeight = 52
        lbConversation.Name = "lbConversation"
        lbConversation.TabIndex = 0

        ' ── Chat input bar ──
        panelChatInput.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        panelChatInput.BackColor = Color.FromArgb(CByte(13), CByte(20), CByte(34))
        panelChatInput.Controls.Add(txtMessageBody)
        panelChatInput.Controls.Add(btnSendMessage)
        panelChatInput.Location = New Point(0, 787)
        panelChatInput.Name = "panelChatInput"
        panelChatInput.Size = New Size(720, 60)
        panelChatInput.TabIndex = 2

        txtMessageBody.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtMessageBody.BackColor = Color.FromArgb(CByte(16), CByte(22), CByte(36))
        txtMessageBody.BorderStyle = BorderStyle.FixedSingle
        txtMessageBody.Font = New Font("Segoe UI", 10F)
        txtMessageBody.ForeColor = Color.Gainsboro
        txtMessageBody.Location = New Point(12, 14)
        txtMessageBody.Name = "txtMessageBody"
        txtMessageBody.PlaceholderText = "Tulis pesan... (Enter kirim)"
        txtMessageBody.Size = New Size(560, 30)
        txtMessageBody.TabIndex = 0

        btnSendMessage.Anchor = AnchorStyles.Right
        btnSendMessage.BackColor = Color.FromArgb(CByte(38), CByte(174), CByte(200))
        btnSendMessage.Cursor = Cursors.Hand
        btnSendMessage.FlatStyle = FlatStyle.Flat
        btnSendMessage.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnSendMessage.ForeColor = Color.FromArgb(CByte(8), CByte(42), CByte(58))
        btnSendMessage.Location = New Point(578, 10)
        btnSendMessage.Name = "btnSendMessage"
        btnSendMessage.Size = New Size(130, 38)
        btnSendMessage.TabIndex = 1
        btnSendMessage.Text = "Kirim ➤"
        btnSendMessage.UseVisualStyleBackColor = False

        ' ── Form ──────────────────────────────
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1200, 900)
        Controls.Add(NightForm1)
        FormBorderStyle = FormBorderStyle.None
        MinimumSize = New Size(900, 640)
        Name = "SocialHubPage"
        StartPosition = FormStartPosition.CenterParent
        TransparencyKey = Color.Fuchsia

        NightForm1.ResumeLayout(False)
        NightForm1.PerformLayout()
        CType(picProfileAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        panelAvatarBg.ResumeLayout(False)
        panelLeft.ResumeLayout(False)
        panelLeft.PerformLayout()
        pnlFollowingHeader.ResumeLayout(False)
        pnlFollowingHeader.PerformLayout()
        panelMiddle.ResumeLayout(False)
        panelMiddle.PerformLayout()
        panelChatHeader.ResumeLayout(False)
        panelChatArea.ResumeLayout(False)
        panelChatInput.ResumeLayout(False)
        panelChatInput.PerformLayout()
        panelRight.ResumeLayout(False)
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
    Friend WithEvents lblProfileUserId As Label
    Friend WithEvents lblSectionProfile As Label
    Friend WithEvents lblProfileUsernameHint As Label
    Friend WithEvents txtProfileUsername As TextBox
    Friend WithEvents lblProfileEmailHint As Label
    Friend WithEvents txtProfileEmail As TextBox
    Friend WithEvents lblProfileBioHint As Label
    Friend WithEvents txtProfileBio As TextBox
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
