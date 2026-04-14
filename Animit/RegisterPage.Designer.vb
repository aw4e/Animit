Imports ReaLTaiizor.Forms
Imports ReaLTaiizor.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterPage
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        lblLoginPrompt = New NightLabel()
        lnkToLogin = New NightLinkLabel()
        pnlSecurity = New System.Windows.Forms.Panel()
        lblSecurityText = New NightLabel()
        lblSecurityIcon = New Label()
        btnSignup = New StableActionButton()
        pnlConfirmInput = New System.Windows.Forms.Panel()
        txtConfirmReg = New TextBox()
        lblConfirmIcon = New Label()
        lblConfirm = New NightLabel()
        pnlPasswordInput = New System.Windows.Forms.Panel()
        txtPassReg = New TextBox()
        lblPasswordIcon = New Label()
        lblPass = New NightLabel()
        pnlEmailInput = New System.Windows.Forms.Panel()
        txtEmailReg = New TextBox()
        lblEmailIcon = New Label()
        lblEmail = New NightLabel()
        pnlUserInput = New System.Windows.Forms.Panel()
        txtUserReg = New TextBox()
        lblUserIcon = New Label()
        lblUser = New NightLabel()
        lblSubtitle = New NightLabel()
        lblWelcome = New NightLabel()
        lblBadge = New NightLabel()
        lblBrand = New NightLabel()
        lblClose = New Label()
        NightForm1.SuspendLayout()
        pnlSecurity.SuspendLayout()
        pnlConfirmInput.SuspendLayout()
        pnlPasswordInput.SuspendLayout()
        pnlEmailInput.SuspendLayout()
        pnlUserInput.SuspendLayout()
        SuspendLayout()
        ' 
        ' NightForm1
        ' 
        NightForm1.BackColor = Color.FromArgb(CByte(8), CByte(14), CByte(26))
        NightForm1.Controls.Add(lblClose)
        NightForm1.Controls.Add(lblLoginPrompt)
        NightForm1.Controls.Add(lnkToLogin)
        NightForm1.Controls.Add(pnlSecurity)
        NightForm1.Controls.Add(btnSignup)
        NightForm1.Controls.Add(pnlConfirmInput)
        NightForm1.Controls.Add(lblConfirm)
        NightForm1.Controls.Add(pnlPasswordInput)
        NightForm1.Controls.Add(lblPass)
        NightForm1.Controls.Add(pnlEmailInput)
        NightForm1.Controls.Add(lblEmail)
        NightForm1.Controls.Add(pnlUserInput)
        NightForm1.Controls.Add(lblUser)
        NightForm1.Controls.Add(lblSubtitle)
        NightForm1.Controls.Add(lblWelcome)
        NightForm1.Controls.Add(lblBadge)
        NightForm1.Controls.Add(lblBrand)
        NightForm1.Dock = DockStyle.Fill
        NightForm1.DrawIcon = False
        NightForm1.Font = New Font("Segoe UI", 9F)
        NightForm1.HeadColor = Color.FromArgb(CByte(8), CByte(14), CByte(26))
        NightForm1.Location = New Point(0, 0)
        NightForm1.MinimumSize = New Size(100, 42)
        NightForm1.Name = "NightForm1"
        NightForm1.Padding = New Padding(18, 40, 18, 18)
        NightForm1.Size = New Size(500, 790)
        NightForm1.TabIndex = 0
        NightForm1.Text = "ANIMIT - REGISTER"
        NightForm1.TextAlignment = NightForm.Alignment.Left
        NightForm1.TitleBarTextColor = Color.FromArgb(CByte(83), CByte(107), CByte(138))
        ' 
        ' lblLoginPrompt
        ' 
        lblLoginPrompt.AutoSize = True
        lblLoginPrompt.BackColor = Color.Transparent
        lblLoginPrompt.Font = New Font("Segoe UI Semibold", 10F)
        lblLoginPrompt.ForeColor = Color.FromArgb(CByte(150), CByte(158), CByte(171))
        lblLoginPrompt.Location = New Point(58, 740)
        lblLoginPrompt.Name = "lblLoginPrompt"
        lblLoginPrompt.Size = New Size(162, 23)
        lblLoginPrompt.TabIndex = 17
        lblLoginPrompt.Text = "Sudah punya akun?"
        ' 
        ' lnkToLogin
        ' 
        lnkToLogin.ActiveLinkColor = Color.FromArgb(CByte(93), CByte(228), CByte(245))
        lnkToLogin.AutoSize = True
        lnkToLogin.BackColor = Color.Transparent
        lnkToLogin.Cursor = Cursors.Hand
        lnkToLogin.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lnkToLogin.LinkBehavior = LinkBehavior.HoverUnderline
        lnkToLogin.LinkColor = Color.FromArgb(CByte(93), CByte(228), CByte(245))
        lnkToLogin.Location = New Point(388, 740)
        lnkToLogin.Name = "lnkToLogin"
        lnkToLogin.Size = New Size(66, 23)
        lnkToLogin.TabIndex = 16
        lnkToLogin.TabStop = True
        lnkToLogin.Text = "Sign In"
        lnkToLogin.VisitedLinkColor = Color.FromArgb(CByte(93), CByte(228), CByte(245))
        ' 
        ' pnlSecurity
        ' 
        pnlSecurity.BackColor = Color.FromArgb(CByte(10), CByte(17), CByte(31))
        pnlSecurity.Controls.Add(lblSecurityText)
        pnlSecurity.Controls.Add(lblSecurityIcon)
        pnlSecurity.Location = New Point(58, 686)
        pnlSecurity.Name = "pnlSecurity"
        pnlSecurity.Size = New Size(384, 40)
        pnlSecurity.TabIndex = 15
        ' 
        ' lblSecurityText
        ' 
        lblSecurityText.AutoSize = True
        lblSecurityText.BackColor = Color.Transparent
        lblSecurityText.Font = New Font("Segoe UI Semibold", 9F)
        lblSecurityText.ForeColor = Color.FromArgb(CByte(155), CByte(165), CByte(183))
        lblSecurityText.Location = New Point(105, 10)
        lblSecurityText.Name = "lblSecurityText"
        lblSecurityText.Size = New Size(205, 20)
        lblSecurityText.TabIndex = 1
        lblSecurityText.Text = "Password minimal 8 karakter"
        ' 
        ' lblSecurityIcon
        ' 
        lblSecurityIcon.AutoSize = True
        lblSecurityIcon.Font = New Font("Segoe UI Symbol", 10F, FontStyle.Bold)
        lblSecurityIcon.ForeColor = Color.FromArgb(CByte(84), CByte(234), CByte(255))
        lblSecurityIcon.Location = New Point(86, 8)
        lblSecurityIcon.Name = "lblSecurityIcon"
        lblSecurityIcon.Size = New Size(21, 23)
        lblSecurityIcon.TabIndex = 0
        lblSecurityIcon.Text = "o"
        ' 
        ' btnSignup
        ' 
        btnSignup.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSignup.BackColor = Color.FromArgb(CByte(44), CByte(186), CByte(210))
        btnSignup.Cursor = Cursors.Hand
        btnSignup.FlatAppearance.BorderColor = Color.FromArgb(CByte(18), CByte(160), CByte(184))
        btnSignup.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(26), CByte(168), CByte(192))
        btnSignup.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(56), CByte(198), CByte(222))
        btnSignup.FlatStyle = FlatStyle.Flat
        btnSignup.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        btnSignup.ForeColor = Color.FromArgb(CByte(10), CByte(48), CByte(62))
        btnSignup.Location = New Point(58, 618)
        btnSignup.Margin = New Padding(4, 6, 4, 6)
        btnSignup.MinimumSize = New Size(144, 47)
        btnSignup.Name = "btnSignup"
        btnSignup.Size = New Size(384, 56)
        btnSignup.TabIndex = 14
        btnSignup.Text = "Create Account"
        btnSignup.UseVisualStyleBackColor = False
        ' 
        ' pnlConfirmInput
        ' 
        pnlConfirmInput.BackColor = Color.FromArgb(CByte(19), CByte(24), CByte(37))
        pnlConfirmInput.Controls.Add(txtConfirmReg)
        pnlConfirmInput.Controls.Add(lblConfirmIcon)
        pnlConfirmInput.Location = New Point(58, 551)
        pnlConfirmInput.Name = "pnlConfirmInput"
        pnlConfirmInput.Size = New Size(384, 52)
        pnlConfirmInput.TabIndex = 13
        ' 
        ' txtConfirmReg
        ' 
        txtConfirmReg.BackColor = Color.FromArgb(CByte(19), CByte(24), CByte(37))
        txtConfirmReg.BorderStyle = BorderStyle.None
        txtConfirmReg.Font = New Font("Segoe UI Semibold", 11F)
        txtConfirmReg.ForeColor = Color.Gainsboro
        txtConfirmReg.Location = New Point(44, 14)
        txtConfirmReg.Name = "txtConfirmReg"
        txtConfirmReg.PlaceholderText = "Ulangi password"
        txtConfirmReg.Size = New Size(327, 25)
        txtConfirmReg.TabIndex = 1
        txtConfirmReg.UseSystemPasswordChar = True
        ' 
        ' lblConfirmIcon
        ' 
        lblConfirmIcon.AutoSize = True
        lblConfirmIcon.Font = New Font("Segoe UI Symbol", 11F)
        lblConfirmIcon.ForeColor = Color.FromArgb(CByte(130), CByte(139), CByte(157))
        lblConfirmIcon.Location = New Point(14, 12)
        lblConfirmIcon.Name = "lblConfirmIcon"
        lblConfirmIcon.Size = New Size(20, 25)
        lblConfirmIcon.TabIndex = 0
        lblConfirmIcon.Text = "*"
        ' 
        ' lblConfirm
        ' 
        lblConfirm.AutoSize = True
        lblConfirm.BackColor = Color.Transparent
        lblConfirm.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblConfirm.ForeColor = Color.FromArgb(CByte(143), CByte(153), CByte(171))
        lblConfirm.Location = New Point(58, 523)
        lblConfirm.Name = "lblConfirm"
        lblConfirm.Size = New Size(188, 23)
        lblConfirm.TabIndex = 12
        lblConfirm.Text = "CONFIRM PASSWORD"
        ' 
        ' pnlPasswordInput
        ' 
        pnlPasswordInput.BackColor = Color.FromArgb(CByte(19), CByte(24), CByte(37))
        pnlPasswordInput.Controls.Add(txtPassReg)
        pnlPasswordInput.Controls.Add(lblPasswordIcon)
        pnlPasswordInput.Location = New Point(58, 464)
        pnlPasswordInput.Name = "pnlPasswordInput"
        pnlPasswordInput.Size = New Size(384, 52)
        pnlPasswordInput.TabIndex = 11
        ' 
        ' txtPassReg
        ' 
        txtPassReg.BackColor = Color.FromArgb(CByte(19), CByte(24), CByte(37))
        txtPassReg.BorderStyle = BorderStyle.None
        txtPassReg.Font = New Font("Segoe UI Semibold", 11F)
        txtPassReg.ForeColor = Color.Gainsboro
        txtPassReg.Location = New Point(44, 14)
        txtPassReg.Name = "txtPassReg"
        txtPassReg.PlaceholderText = "Buat password"
        txtPassReg.Size = New Size(327, 25)
        txtPassReg.TabIndex = 1
        txtPassReg.UseSystemPasswordChar = True
        ' 
        ' lblPasswordIcon
        ' 
        lblPasswordIcon.AutoSize = True
        lblPasswordIcon.Font = New Font("Segoe UI Symbol", 11F)
        lblPasswordIcon.ForeColor = Color.FromArgb(CByte(130), CByte(139), CByte(157))
        lblPasswordIcon.Location = New Point(14, 12)
        lblPasswordIcon.Name = "lblPasswordIcon"
        lblPasswordIcon.Size = New Size(20, 25)
        lblPasswordIcon.TabIndex = 0
        lblPasswordIcon.Text = "*"
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.BackColor = Color.Transparent
        lblPass.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblPass.ForeColor = Color.FromArgb(CByte(143), CByte(153), CByte(171))
        lblPass.Location = New Point(58, 436)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(171, 23)
        lblPass.TabIndex = 10
        lblPass.Text = "CREATE PASSWORD"
        ' 
        ' pnlEmailInput
        ' 
        pnlEmailInput.BackColor = Color.FromArgb(CByte(19), CByte(24), CByte(37))
        pnlEmailInput.Controls.Add(txtEmailReg)
        pnlEmailInput.Controls.Add(lblEmailIcon)
        pnlEmailInput.Location = New Point(58, 377)
        pnlEmailInput.Name = "pnlEmailInput"
        pnlEmailInput.Size = New Size(384, 52)
        pnlEmailInput.TabIndex = 9
        ' 
        ' txtEmailReg
        ' 
        txtEmailReg.BackColor = Color.FromArgb(CByte(19), CByte(24), CByte(37))
        txtEmailReg.BorderStyle = BorderStyle.None
        txtEmailReg.Font = New Font("Segoe UI Semibold", 11F)
        txtEmailReg.ForeColor = Color.Gainsboro
        txtEmailReg.Location = New Point(44, 14)
        txtEmailReg.Name = "txtEmailReg"
        txtEmailReg.PlaceholderText = "Masukkan email aktif"
        txtEmailReg.Size = New Size(327, 25)
        txtEmailReg.TabIndex = 1
        ' 
        ' lblEmailIcon
        ' 
        lblEmailIcon.AutoSize = True
        lblEmailIcon.Font = New Font("Segoe UI Symbol", 11F)
        lblEmailIcon.ForeColor = Color.FromArgb(CByte(130), CByte(139), CByte(157))
        lblEmailIcon.Location = New Point(14, 12)
        lblEmailIcon.Name = "lblEmailIcon"
        lblEmailIcon.Size = New Size(30, 25)
        lblEmailIcon.TabIndex = 0
        lblEmailIcon.Text = "@"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.BackColor = Color.Transparent
        lblEmail.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblEmail.ForeColor = Color.FromArgb(CByte(143), CByte(153), CByte(171))
        lblEmail.Location = New Point(58, 349)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(61, 23)
        lblEmail.TabIndex = 8
        lblEmail.Text = "EMAIL"
        ' 
        ' pnlUserInput
        ' 
        pnlUserInput.BackColor = Color.FromArgb(CByte(19), CByte(24), CByte(37))
        pnlUserInput.Controls.Add(txtUserReg)
        pnlUserInput.Controls.Add(lblUserIcon)
        pnlUserInput.Location = New Point(58, 290)
        pnlUserInput.Name = "pnlUserInput"
        pnlUserInput.Size = New Size(384, 52)
        pnlUserInput.TabIndex = 7
        ' 
        ' txtUserReg
        ' 
        txtUserReg.BackColor = Color.FromArgb(CByte(19), CByte(24), CByte(37))
        txtUserReg.BorderStyle = BorderStyle.None
        txtUserReg.Font = New Font("Segoe UI Semibold", 11F)
        txtUserReg.ForeColor = Color.Gainsboro
        txtUserReg.Location = New Point(44, 14)
        txtUserReg.Name = "txtUserReg"
        txtUserReg.PlaceholderText = "Buat username kamu"
        txtUserReg.Size = New Size(327, 25)
        txtUserReg.TabIndex = 1
        ' 
        ' lblUserIcon
        ' 
        lblUserIcon.AutoSize = True
        lblUserIcon.Font = New Font("Segoe UI Symbol", 11F)
        lblUserIcon.ForeColor = Color.FromArgb(CByte(130), CByte(139), CByte(157))
        lblUserIcon.Location = New Point(14, 12)
        lblUserIcon.Name = "lblUserIcon"
        lblUserIcon.Size = New Size(23, 25)
        lblUserIcon.TabIndex = 0
        lblUserIcon.Text = "u"
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.BackColor = Color.Transparent
        lblUser.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblUser.ForeColor = Color.FromArgb(CByte(143), CByte(153), CByte(171))
        lblUser.Location = New Point(58, 262)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(102, 23)
        lblUser.TabIndex = 6
        lblUser.Text = "USERNAME"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.BackColor = Color.Transparent
        lblSubtitle.Font = New Font("Segoe UI Semibold", 11F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(130), CByte(139), CByte(157))
        lblSubtitle.Location = New Point(28, 222)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(451, 25)
        lblSubtitle.TabIndex = 5
        lblSubtitle.Text = "Buat akun untuk lanjut streaming anime favoritmu."
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.BackColor = Color.Transparent
        lblWelcome.Font = New Font("Segoe UI Semibold", 26F, FontStyle.Bold)
        lblWelcome.ForeColor = Color.FromArgb(CByte(238), CByte(242), CByte(250))
        lblWelcome.Location = New Point(78, 162)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(338, 60)
        lblWelcome.TabIndex = 4
        lblWelcome.Text = "Buat Akun Baru"
        ' 
        ' lblBadge
        ' 
        lblBadge.BackColor = Color.FromArgb(CByte(16), CByte(48), CByte(63))
        lblBadge.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblBadge.ForeColor = Color.FromArgb(CByte(84), CByte(234), CByte(255))
        lblBadge.Location = New Point(138, 112)
        lblBadge.Name = "lblBadge"
        lblBadge.Size = New Size(208, 28)
        lblBadge.TabIndex = 3
        lblBadge.Text = "GABUNG KE DUNIA ANIME"
        lblBadge.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblBrand
        ' 
        lblBrand.AutoSize = True
        lblBrand.BackColor = Color.Transparent
        lblBrand.Font = New Font("Segoe UI", 32F, FontStyle.Bold)
        lblBrand.ForeColor = Color.FromArgb(CByte(83), CByte(231), CByte(248))
        lblBrand.Location = New Point(133, 40)
        lblBrand.Name = "lblBrand"
        lblBrand.Size = New Size(229, 72)
        lblBrand.TabIndex = 2
        lblBrand.Text = "ANIMIT"
        lblBrand.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblClose
        ' 
        lblClose.AutoSize = True
        lblClose.BackColor = Color.Transparent
        lblClose.Font = New Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblClose.ForeColor = Color.FromArgb(CByte(83), CByte(107), CByte(138))
        lblClose.Location = New Point(472, 0)
        lblClose.Name = "lblClose"
        lblClose.Size = New Size(28, 28)
        lblClose.TabIndex = 18
        lblClose.Text = "✕"
        ' 
        ' RegisterPage
        ' 
        ClientSize = New Size(500, 790)
        Controls.Add(NightForm1)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(1920, 1080)
        MinimumSize = New Size(460, 700)
        Name = "RegisterPage"
        StartPosition = FormStartPosition.CenterScreen
        TransparencyKey = Color.Fuchsia
        NightForm1.ResumeLayout(False)
        NightForm1.PerformLayout()
        pnlSecurity.ResumeLayout(False)
        pnlSecurity.PerformLayout()
        pnlConfirmInput.ResumeLayout(False)
        pnlConfirmInput.PerformLayout()
        pnlPasswordInput.ResumeLayout(False)
        pnlPasswordInput.PerformLayout()
        pnlEmailInput.ResumeLayout(False)
        pnlEmailInput.PerformLayout()
        pnlUserInput.ResumeLayout(False)
        pnlUserInput.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents NightForm1 As NightForm
    Friend WithEvents lblBrand As NightLabel
    Friend WithEvents lblBadge As NightLabel
    Friend WithEvents lblWelcome As NightLabel
    Friend WithEvents lblSubtitle As NightLabel
    Friend WithEvents lblUser As NightLabel
    Friend WithEvents pnlUserInput As System.Windows.Forms.Panel
    Friend WithEvents lblUserIcon As System.Windows.Forms.Label
    Friend WithEvents txtUserReg As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As NightLabel
    Friend WithEvents pnlEmailInput As System.Windows.Forms.Panel
    Friend WithEvents txtEmailReg As System.Windows.Forms.TextBox
    Friend WithEvents lblEmailIcon As System.Windows.Forms.Label
    Friend WithEvents lblPass As NightLabel
    Friend WithEvents pnlPasswordInput As System.Windows.Forms.Panel
    Friend WithEvents txtPassReg As System.Windows.Forms.TextBox
    Friend WithEvents lblPasswordIcon As System.Windows.Forms.Label
    Friend WithEvents lblConfirm As NightLabel
    Friend WithEvents pnlConfirmInput As System.Windows.Forms.Panel
    Friend WithEvents txtConfirmReg As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmIcon As System.Windows.Forms.Label
    Friend WithEvents btnSignup As StableActionButton
    Friend WithEvents pnlSecurity As System.Windows.Forms.Panel
    Friend WithEvents lblSecurityText As NightLabel
    Friend WithEvents lblSecurityIcon As System.Windows.Forms.Label
    Friend WithEvents lnkToLogin As NightLinkLabel
    Friend WithEvents lblLoginPrompt As NightLabel
    Friend WithEvents lblClose As Label
End Class
