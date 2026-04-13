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
        grpProfile = New Panel()
        btnSaveProfile = New StableActionButton()
        txtProfileBio = New TextBox()
        lblProfileBio = New Label()
        txtProfileUsername = New TextBox()
        lblProfileUsername = New Label()
        txtProfileEmail = New TextBox()
        lblProfileEmail = New Label()
        grpFollow = New Panel()
        btnClose = New StableActionButton()
        lblProfileUserId = New Label()
        lbFollowing = New ListBox()
        btnRefreshFollowing = New StableActionButton()
        btnFollow = New StableActionButton()
        txtFollowUsername = New TextBox()
        lblFollowUsername = New Label()
        grpMessage = New Panel()
        btnSendMessage = New StableActionButton()
        txtMessageBody = New TextBox()
        lblMessageBody = New Label()
        lbConversation = New ListBox()
        btnLoadConversation = New StableActionButton()
        txtMessageTo = New TextBox()
        lblMessageTo = New Label()
        lblStatus = New NightLabel()
        lblTitle = New NightLabel()
        NightForm1.SuspendLayout()
        grpProfile.SuspendLayout()
        grpFollow.SuspendLayout()
        grpMessage.SuspendLayout()
        SuspendLayout()
        '
        'NightForm1
        '
        NightForm1.BackColor = Color.FromArgb(CByte(8), CByte(14), CByte(26))
        NightForm1.Controls.Add(lblClose)
        NightForm1.Controls.Add(lblBrand)
        NightForm1.Controls.Add(lblBadge)
        NightForm1.Controls.Add(grpProfile)
        NightForm1.Controls.Add(grpFollow)
        NightForm1.Controls.Add(grpMessage)
        NightForm1.Dock = DockStyle.Fill
        NightForm1.DrawIcon = False
        NightForm1.Font = New Font("Segoe UI", 9.0F)
        NightForm1.HeadColor = Color.FromArgb(CByte(8), CByte(14), CByte(26))
        NightForm1.Location = New Point(0, 0)
        NightForm1.MinimumSize = New Size(100, 42)
        NightForm1.Name = "NightForm1"
        NightForm1.Padding = New Padding(16, 40, 16, 16)
        NightForm1.Size = New Size(1180, 760)
        NightForm1.TabIndex = 0
        NightForm1.Text = "ANIMIT - SOCIAL HUB"
        NightForm1.TextAlignment = NightForm.Alignment.Left
        NightForm1.TitleBarTextColor = Color.FromArgb(CByte(83), CByte(107), CByte(138))
        '
        'lblClose
        '
        lblClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblClose.AutoSize = True
        lblClose.BackColor = Color.Transparent
        lblClose.Cursor = Cursors.Hand
        lblClose.Font = New Font("Segoe UI Symbol", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblClose.ForeColor = Color.FromArgb(CByte(83), CByte(107), CByte(138))
        lblClose.Location = New Point(1157, 0)
        lblClose.Name = "lblClose"
        lblClose.Size = New Size(23, 21)
        lblClose.TabIndex = 0
        lblClose.Text = "✕"
        '
        'lblBrand
        '
        lblBrand.AutoSize = True
        lblBrand.BackColor = Color.Transparent
        lblBrand.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblBrand.ForeColor = Color.FromArgb(CByte(83), CByte(231), CByte(248))
        lblBrand.Location = New Point(22, 50)
        lblBrand.Name = "lblBrand"
        lblBrand.Size = New Size(170, 32)
        lblBrand.TabIndex = 1
        lblBrand.Text = "Social Lounge"
        '
        'lblBadge
        '
        lblBadge.BackColor = Color.FromArgb(CByte(16), CByte(48), CByte(63))
        lblBadge.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblBadge.ForeColor = Color.FromArgb(CByte(84), CByte(234), CByte(255))
        lblBadge.Location = New Point(198, 56)
        lblBadge.Name = "lblBadge"
        lblBadge.Size = New Size(138, 24)
        lblBadge.TabIndex = 2
        lblBadge.Text = "FOLLOW + CHAT"
        lblBadge.TextAlign = ContentAlignment.MiddleCenter
        '
        'grpProfile
        '
        grpProfile.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        grpProfile.BackColor = Color.FromArgb(CByte(12), CByte(20), CByte(34))
        grpProfile.Controls.Add(btnSaveProfile)
        grpProfile.Controls.Add(txtProfileBio)
        grpProfile.Controls.Add(lblProfileBio)
        grpProfile.Controls.Add(txtProfileUsername)
        grpProfile.Controls.Add(lblProfileUsername)
        grpProfile.Controls.Add(txtProfileEmail)
        grpProfile.Controls.Add(lblProfileEmail)
        grpProfile.Location = New Point(22, 92)
        grpProfile.Name = "grpProfile"
        grpProfile.Size = New Size(262, 168)
        grpProfile.TabIndex = 3
        '
        'btnSaveProfile
        '
        btnSaveProfile.BackColor = Color.FromArgb(CByte(44), CByte(186), CByte(210))
        btnSaveProfile.Cursor = Cursors.Hand
        btnSaveProfile.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnSaveProfile.ForeColor = Color.FromArgb(CByte(10), CByte(48), CByte(62))
        btnSaveProfile.Location = New Point(14, 132)
        btnSaveProfile.Name = "btnSaveProfile"
        btnSaveProfile.Size = New Size(234, 26)
        btnSaveProfile.TabIndex = 6
        btnSaveProfile.Text = "Simpan Profil"
        btnSaveProfile.UseVisualStyleBackColor = False
        '
        'txtProfileBio
        '
        txtProfileBio.BackColor = Color.FromArgb(CByte(19), CByte(24), CByte(37))
        txtProfileBio.BorderStyle = BorderStyle.FixedSingle
        txtProfileBio.Font = New Font("Segoe UI Semibold", 9.5F)
        txtProfileBio.ForeColor = Color.Gainsboro
        txtProfileBio.Location = New Point(14, 84)
        txtProfileBio.Multiline = True
        txtProfileBio.Name = "txtProfileBio"
        txtProfileBio.ScrollBars = ScrollBars.Vertical
        txtProfileBio.Size = New Size(234, 44)
        txtProfileBio.TabIndex = 5
        '
        'lblProfileBio
        '
        lblProfileBio.AutoSize = True
        lblProfileBio.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblProfileBio.ForeColor = Color.FromArgb(CByte(143), CByte(153), CByte(171))
        lblProfileBio.Location = New Point(14, 66)
        lblProfileBio.Name = "lblProfileBio"
        lblProfileBio.Size = New Size(23, 15)
        lblProfileBio.TabIndex = 4
        lblProfileBio.Text = "Bio"
        '
        'txtProfileUsername
        '
        txtProfileUsername.BackColor = Color.FromArgb(CByte(19), CByte(24), CByte(37))
        txtProfileUsername.BorderStyle = BorderStyle.FixedSingle
        txtProfileUsername.Font = New Font("Segoe UI Semibold", 9.5F)
        txtProfileUsername.ForeColor = Color.Gainsboro
        txtProfileUsername.Location = New Point(14, 36)
        txtProfileUsername.Name = "txtProfileUsername"
        txtProfileUsername.Size = New Size(234, 24)
        txtProfileUsername.TabIndex = 1
        '
        'lblProfileUsername
        '
        lblProfileUsername.AutoSize = True
        lblProfileUsername.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblProfileUsername.ForeColor = Color.FromArgb(CByte(143), CByte(153), CByte(171))
        lblProfileUsername.Location = New Point(14, 18)
        lblProfileUsername.Name = "lblProfileUsername"
        lblProfileUsername.Size = New Size(67, 15)
        lblProfileUsername.TabIndex = 0
        lblProfileUsername.Text = "Display tag"
        '
        'txtProfileEmail
        '
        txtProfileEmail.Location = New Point(14, 10)
        txtProfileEmail.Name = "txtProfileEmail"
        txtProfileEmail.Size = New Size(100, 23)
        txtProfileEmail.TabIndex = 2
        txtProfileEmail.Visible = False
        '
        'lblProfileEmail
        '
        lblProfileEmail.AutoSize = True
        lblProfileEmail.Location = New Point(120, 10)
        lblProfileEmail.Name = "lblProfileEmail"
        lblProfileEmail.Size = New Size(36, 15)
        lblProfileEmail.TabIndex = 3
        lblProfileEmail.Text = "Email"
        lblProfileEmail.Visible = False
        '
        'grpFollow
        '
        grpFollow.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        grpFollow.BackColor = Color.FromArgb(CByte(12), CByte(20), CByte(34))
        grpFollow.Controls.Add(btnClose)
        grpFollow.Controls.Add(lblProfileUserId)
        grpFollow.Controls.Add(lbFollowing)
        grpFollow.Controls.Add(btnRefreshFollowing)
        grpFollow.Controls.Add(btnFollow)
        grpFollow.Controls.Add(txtFollowUsername)
        grpFollow.Controls.Add(lblFollowUsername)
        grpFollow.Location = New Point(22, 272)
        grpFollow.Name = "grpFollow"
        grpFollow.Size = New Size(262, 472)
        grpFollow.TabIndex = 4
        '
        'btnClose
        '
        btnClose.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnClose.BackColor = Color.FromArgb(CByte(26), CByte(38), CByte(56))
        btnClose.Cursor = Cursors.Hand
        btnClose.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnClose.ForeColor = Color.Gainsboro
        btnClose.Location = New Point(14, 434)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(234, 28)
        btnClose.TabIndex = 6
        btnClose.Text = "Tutup Social"
        btnClose.UseVisualStyleBackColor = False
        '
        'lblProfileUserId
        '
        lblProfileUserId.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblProfileUserId.AutoEllipsis = True
        lblProfileUserId.Font = New Font("Segoe UI", 8.0F, FontStyle.Italic)
        lblProfileUserId.ForeColor = Color.FromArgb(CByte(130), CByte(139), CByte(157))
        lblProfileUserId.Location = New Point(14, 414)
        lblProfileUserId.Name = "lblProfileUserId"
        lblProfileUserId.Size = New Size(234, 16)
        lblProfileUserId.TabIndex = 5
        lblProfileUserId.Text = "User ID: -"
        '
        'lbFollowing
        '
        lbFollowing.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbFollowing.BackColor = Color.FromArgb(CByte(16), CByte(22), CByte(35))
        lbFollowing.BorderStyle = BorderStyle.None
        lbFollowing.Font = New Font("Segoe UI Semibold", 10.0F)
        lbFollowing.ForeColor = Color.Gainsboro
        lbFollowing.FormattingEnabled = True
        lbFollowing.ItemHeight = 17
        lbFollowing.Location = New Point(14, 103)
        lbFollowing.Name = "lbFollowing"
        lbFollowing.Size = New Size(234, 306)
        lbFollowing.TabIndex = 4
        '
        'btnRefreshFollowing
        '
        btnRefreshFollowing.BackColor = Color.FromArgb(CByte(26), CByte(38), CByte(56))
        btnRefreshFollowing.Cursor = Cursors.Hand
        btnRefreshFollowing.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnRefreshFollowing.ForeColor = Color.Gainsboro
        btnRefreshFollowing.Location = New Point(143, 69)
        btnRefreshFollowing.Name = "btnRefreshFollowing"
        btnRefreshFollowing.Size = New Size(105, 28)
        btnRefreshFollowing.TabIndex = 3
        btnRefreshFollowing.Text = "Refresh"
        btnRefreshFollowing.UseVisualStyleBackColor = False
        '
        'btnFollow
        '
        btnFollow.BackColor = Color.FromArgb(CByte(44), CByte(186), CByte(210))
        btnFollow.Cursor = Cursors.Hand
        btnFollow.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnFollow.ForeColor = Color.FromArgb(CByte(10), CByte(48), CByte(62))
        btnFollow.Location = New Point(14, 69)
        btnFollow.Name = "btnFollow"
        btnFollow.Size = New Size(123, 28)
        btnFollow.TabIndex = 2
        btnFollow.Text = "Follow"
        btnFollow.UseVisualStyleBackColor = False
        '
        'txtFollowUsername
        '
        txtFollowUsername.BackColor = Color.FromArgb(CByte(19), CByte(24), CByte(37))
        txtFollowUsername.BorderStyle = BorderStyle.FixedSingle
        txtFollowUsername.Font = New Font("Segoe UI Semibold", 9.5F)
        txtFollowUsername.ForeColor = Color.Gainsboro
        txtFollowUsername.Location = New Point(14, 39)
        txtFollowUsername.Name = "txtFollowUsername"
        txtFollowUsername.PlaceholderText = "@username target"
        txtFollowUsername.Size = New Size(234, 24)
        txtFollowUsername.TabIndex = 1
        '
        'lblFollowUsername
        '
        lblFollowUsername.AutoSize = True
        lblFollowUsername.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblFollowUsername.ForeColor = Color.FromArgb(CByte(143), CByte(153), CByte(171))
        lblFollowUsername.Location = New Point(14, 20)
        lblFollowUsername.Name = "lblFollowUsername"
        lblFollowUsername.Size = New Size(52, 15)
        lblFollowUsername.TabIndex = 0
        lblFollowUsername.Text = "Channels"
        '
        'grpMessage
        '
        grpMessage.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        grpMessage.BackColor = Color.FromArgb(CByte(12), CByte(20), CByte(34))
        grpMessage.Controls.Add(btnSendMessage)
        grpMessage.Controls.Add(txtMessageBody)
        grpMessage.Controls.Add(lblMessageBody)
        grpMessage.Controls.Add(lbConversation)
        grpMessage.Controls.Add(btnLoadConversation)
        grpMessage.Controls.Add(txtMessageTo)
        grpMessage.Controls.Add(lblMessageTo)
        grpMessage.Controls.Add(lblStatus)
        grpMessage.Controls.Add(lblTitle)
        grpMessage.Location = New Point(298, 92)
        grpMessage.Name = "grpMessage"
        grpMessage.Size = New Size(860, 652)
        grpMessage.TabIndex = 5
        '
        'btnSendMessage
        '
        btnSendMessage.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnSendMessage.BackColor = Color.FromArgb(CByte(44), CByte(186), CByte(210))
        btnSendMessage.Cursor = Cursors.Hand
        btnSendMessage.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        btnSendMessage.ForeColor = Color.FromArgb(CByte(10), CByte(48), CByte(62))
        btnSendMessage.Location = New Point(708, 601)
        btnSendMessage.Name = "btnSendMessage"
        btnSendMessage.Size = New Size(138, 34)
        btnSendMessage.TabIndex = 8
        btnSendMessage.Text = "Kirim"
        btnSendMessage.UseVisualStyleBackColor = False
        '
        'txtMessageBody
        '
        txtMessageBody.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtMessageBody.BackColor = Color.FromArgb(CByte(19), CByte(24), CByte(37))
        txtMessageBody.BorderStyle = BorderStyle.FixedSingle
        txtMessageBody.Font = New Font("Segoe UI Semibold", 10.0F)
        txtMessageBody.ForeColor = Color.Gainsboro
        txtMessageBody.Location = New Point(16, 606)
        txtMessageBody.Name = "txtMessageBody"
        txtMessageBody.PlaceholderText = "Type a message..."
        txtMessageBody.Size = New Size(686, 25)
        txtMessageBody.TabIndex = 7
        '
        'lblMessageBody
        '
        lblMessageBody.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblMessageBody.AutoSize = True
        lblMessageBody.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblMessageBody.ForeColor = Color.FromArgb(CByte(143), CByte(153), CByte(171))
        lblMessageBody.Location = New Point(16, 588)
        lblMessageBody.Name = "lblMessageBody"
        lblMessageBody.Size = New Size(38, 15)
        lblMessageBody.TabIndex = 6
        lblMessageBody.Text = "Pesan"
        '
        'lbConversation
        '
        lbConversation.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbConversation.BackColor = Color.FromArgb(CByte(16), CByte(22), CByte(35))
        lbConversation.BorderStyle = BorderStyle.None
        lbConversation.Font = New Font("Segoe UI Semibold", 10.0F)
        lbConversation.ForeColor = Color.Gainsboro
        lbConversation.FormattingEnabled = True
        lbConversation.ItemHeight = 17
        lbConversation.Location = New Point(16, 131)
        lbConversation.Name = "lbConversation"
        lbConversation.Size = New Size(830, 442)
        lbConversation.TabIndex = 5
        '
        'btnLoadConversation
        '
        btnLoadConversation.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLoadConversation.BackColor = Color.FromArgb(CByte(26), CByte(38), CByte(56))
        btnLoadConversation.Cursor = Cursors.Hand
        btnLoadConversation.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnLoadConversation.ForeColor = Color.Gainsboro
        btnLoadConversation.Location = New Point(708, 96)
        btnLoadConversation.Name = "btnLoadConversation"
        btnLoadConversation.Size = New Size(138, 28)
        btnLoadConversation.TabIndex = 4
        btnLoadConversation.Text = "Buka Chat"
        btnLoadConversation.UseVisualStyleBackColor = False
        '
        'txtMessageTo
        '
        txtMessageTo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtMessageTo.BackColor = Color.FromArgb(CByte(19), CByte(24), CByte(37))
        txtMessageTo.BorderStyle = BorderStyle.FixedSingle
        txtMessageTo.Font = New Font("Segoe UI Semibold", 10.0F)
        txtMessageTo.ForeColor = Color.Gainsboro
        txtMessageTo.Location = New Point(16, 99)
        txtMessageTo.Name = "txtMessageTo"
        txtMessageTo.PlaceholderText = "@username tujuan"
        txtMessageTo.Size = New Size(686, 25)
        txtMessageTo.TabIndex = 3
        '
        'lblMessageTo
        '
        lblMessageTo.AutoSize = True
        lblMessageTo.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblMessageTo.ForeColor = Color.FromArgb(CByte(143), CByte(153), CByte(171))
        lblMessageTo.Location = New Point(16, 81)
        lblMessageTo.Name = "lblMessageTo"
        lblMessageTo.Size = New Size(90, 15)
        lblMessageTo.TabIndex = 2
        lblMessageTo.Text = "Chat dengan (@)"
        '
        'lblStatus
        '
        lblStatus.AutoSize = False
        lblStatus.BackColor = Color.Transparent
        lblStatus.Font = New Font("Segoe UI Semibold", 9.0F)
        lblStatus.ForeColor = Color.FromArgb(CByte(130), CByte(139), CByte(157))
        lblStatus.Location = New Point(16, 49)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(830, 20)
        lblStatus.TabIndex = 1
        lblStatus.Text = "Pilih teman di kiri untuk mulai chat."
        '
        'lblTitle
        '
        lblTitle.AutoSize = False
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(238), CByte(242), CByte(250))
        lblTitle.Location = New Point(16, 14)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(830, 34)
        lblTitle.TabIndex = 0
        lblTitle.Text = "# Social Room"
        '
        'SocialHubPage
        '
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1180, 760)
        Controls.Add(NightForm1)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(1920, 1080)
        MinimumSize = New Size(1024, 700)
        Name = "SocialHubPage"
        StartPosition = FormStartPosition.CenterParent
        TransparencyKey = Color.Fuchsia
        NightForm1.ResumeLayout(False)
        NightForm1.PerformLayout()
        grpProfile.ResumeLayout(False)
        grpProfile.PerformLayout()
        grpFollow.ResumeLayout(False)
        grpFollow.PerformLayout()
        grpMessage.ResumeLayout(False)
        grpMessage.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents NightForm1 As NightForm
    Friend WithEvents lblClose As Label
    Friend WithEvents lblBrand As NightLabel
    Friend WithEvents lblBadge As NightLabel
    Friend WithEvents grpProfile As Panel
    Friend WithEvents btnSaveProfile As StableActionButton
    Friend WithEvents txtProfileBio As TextBox
    Friend WithEvents lblProfileBio As Label
    Friend WithEvents txtProfileUsername As TextBox
    Friend WithEvents lblProfileUsername As Label
    Friend WithEvents txtProfileEmail As TextBox
    Friend WithEvents lblProfileEmail As Label
    Friend WithEvents grpFollow As Panel
    Friend WithEvents btnClose As StableActionButton
    Friend WithEvents lblProfileUserId As Label
    Friend WithEvents lbFollowing As ListBox
    Friend WithEvents btnRefreshFollowing As StableActionButton
    Friend WithEvents btnFollow As StableActionButton
    Friend WithEvents txtFollowUsername As TextBox
    Friend WithEvents lblFollowUsername As Label
    Friend WithEvents grpMessage As Panel
    Friend WithEvents btnSendMessage As StableActionButton
    Friend WithEvents txtMessageBody As TextBox
    Friend WithEvents lblMessageBody As Label
    Friend WithEvents lbConversation As ListBox
    Friend WithEvents btnLoadConversation As StableActionButton
    Friend WithEvents txtMessageTo As TextBox
    Friend WithEvents lblMessageTo As Label
    Friend WithEvents lblStatus As NightLabel
    Friend WithEvents lblTitle As NightLabel
End Class
