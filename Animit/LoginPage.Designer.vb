Imports ReaLTaiizor.Forms
Imports ReaLTaiizor.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginPage
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
        lblClose = New Label()
        lblCreatePrompt = New NightLabel()
        pnlSecurity = New System.Windows.Forms.Panel()
        lblSecurityText = New NightLabel()
        lblSecurityIcon = New Label()
        btnLogin = New StableActionButton()
        pnlPasswordInput = New System.Windows.Forms.Panel()
        txtPass = New TextBox()
        lblPasswordIcon = New Label()
        lnkForgot = New NightLinkLabel()
        lblPass = New NightLabel()
        pnlEmailInput = New System.Windows.Forms.Panel()
        txtEmail = New TextBox()
        lblUserIcon = New Label()
        lblEmail = New NightLabel()
        lblSubtitle = New NightLabel()
        lblWelcome = New NightLabel()
        lblBadge = New NightLabel()
        lblBrand = New NightLabel()
        lnkToSignup = New NightLinkLabel()
        NightForm1.SuspendLayout()
        pnlSecurity.SuspendLayout()
        pnlPasswordInput.SuspendLayout()
        pnlEmailInput.SuspendLayout()
        SuspendLayout()
        ' 
        ' NightForm1
        ' 
        NightForm1.BackColor = Color.FromArgb(CByte(8), CByte(14), CByte(26))
        NightForm1.Controls.Add(lblClose)
        NightForm1.Controls.Add(lblCreatePrompt)
        NightForm1.Controls.Add(pnlSecurity)
        NightForm1.Controls.Add(btnLogin)
        NightForm1.Controls.Add(pnlPasswordInput)
        NightForm1.Controls.Add(lnkForgot)
        NightForm1.Controls.Add(lblPass)
        NightForm1.Controls.Add(pnlEmailInput)
        NightForm1.Controls.Add(lblEmail)
        NightForm1.Controls.Add(lblSubtitle)
        NightForm1.Controls.Add(lblWelcome)
        NightForm1.Controls.Add(lblBadge)
        NightForm1.Controls.Add(lblBrand)
        NightForm1.Controls.Add(lnkToSignup)
        NightForm1.Dock = DockStyle.Fill
        NightForm1.DrawIcon = False
        NightForm1.Font = New Font("Segoe UI", 9F)
        NightForm1.HeadColor = Color.FromArgb(CByte(8), CByte(14), CByte(26))
        NightForm1.Location = New Point(0, 0)
        NightForm1.MinimumSize = New Size(100, 42)
        NightForm1.Name = "NightForm1"
        NightForm1.Padding = New Padding(18, 40, 18, 18)
        NightForm1.Size = New Size(500, 700)
        NightForm1.TabIndex = 0
        NightForm1.Text = "ANIMIT - LOGIN"
        NightForm1.TextAlignment = NightForm.Alignment.Left
        NightForm1.TitleBarTextColor = Color.FromArgb(CByte(83), CByte(107), CByte(138))
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
        lblClose.TabIndex = 15
        lblClose.Text = "✕"
        ' 
        ' lblCreatePrompt
        ' 
        lblCreatePrompt.AutoSize = True
        lblCreatePrompt.BackColor = Color.Transparent
        lblCreatePrompt.Font = New Font("Segoe UI Semibold", 10F)
        lblCreatePrompt.ForeColor = Color.FromArgb(CByte(150), CByte(158), CByte(171))
        lblCreatePrompt.Location = New Point(58, 645)
        lblCreatePrompt.Name = "lblCreatePrompt"
        lblCreatePrompt.Size = New Size(150, 23)
        lblCreatePrompt.TabIndex = 13
        lblCreatePrompt.Text = "New to the stage?"
        ' 
        ' pnlSecurity
        ' 
        pnlSecurity.BackColor = Color.FromArgb(CByte(10), CByte(17), CByte(31))
        pnlSecurity.Controls.Add(lblSecurityText)
        pnlSecurity.Controls.Add(lblSecurityIcon)
        pnlSecurity.Location = New Point(58, 591)
        pnlSecurity.Name = "pnlSecurity"
        pnlSecurity.Size = New Size(384, 40)
        pnlSecurity.TabIndex = 11
        ' 
        ' lblSecurityText
        ' 
        lblSecurityText.AutoSize = True
        lblSecurityText.BackColor = Color.Transparent
        lblSecurityText.Font = New Font("Segoe UI Semibold", 9F)
        lblSecurityText.ForeColor = Color.FromArgb(CByte(155), CByte(165), CByte(183))
        lblSecurityText.Location = New Point(114, 10)
        lblSecurityText.Name = "lblSecurityText"
        lblSecurityText.Size = New Size(200, 20)
        lblSecurityText.TabIndex = 1
        lblSecurityText.Text = "HWID Authentication Active"
        ' 
        ' lblSecurityIcon
        ' 
        lblSecurityIcon.AutoSize = True
        lblSecurityIcon.Font = New Font("Segoe UI Symbol", 10F, FontStyle.Bold)
        lblSecurityIcon.ForeColor = Color.FromArgb(CByte(84), CByte(234), CByte(255))
        lblSecurityIcon.Location = New Point(93, 8)
        lblSecurityIcon.Name = "lblSecurityIcon"
        lblSecurityIcon.Size = New Size(21, 23)
        lblSecurityIcon.TabIndex = 0
        lblSecurityIcon.Text = "o"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(44), CByte(186), CByte(210))
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatAppearance.BorderColor = Color.FromArgb(CByte(18), CByte(160), CByte(184))
        btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(26), CByte(168), CByte(192))
        btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(56), CByte(198), CByte(222))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        btnLogin.ForeColor = Color.FromArgb(CByte(10), CByte(48), CByte(62))
        btnLogin.Location = New Point(58, 511)
        btnLogin.MinimumSize = New Size(144, 47)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(384, 56)
        btnLogin.TabIndex = 8
        btnLogin.Text = "Sign In"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' pnlPasswordInput
        ' 
        pnlPasswordInput.BackColor = Color.FromArgb(CByte(19), CByte(24), CByte(37))
        pnlPasswordInput.Controls.Add(txtPass)
        pnlPasswordInput.Controls.Add(lblPasswordIcon)
        pnlPasswordInput.Location = New Point(58, 432)
        pnlPasswordInput.Name = "pnlPasswordInput"
        pnlPasswordInput.Size = New Size(384, 52)
        pnlPasswordInput.TabIndex = 7
        ' 
        ' txtPass
        ' 
        txtPass.BackColor = Color.FromArgb(CByte(19), CByte(24), CByte(37))
        txtPass.BorderStyle = BorderStyle.None
        txtPass.Font = New Font("Segoe UI Semibold", 11F)
        txtPass.ForeColor = Color.Gainsboro
        txtPass.Location = New Point(44, 14)
        txtPass.Name = "txtPass"
        txtPass.PlaceholderText = "Enter your password"
        txtPass.Size = New Size(327, 25)
        txtPass.TabIndex = 1
        txtPass.UseSystemPasswordChar = True
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
        ' lnkForgot
        ' 
        lnkForgot.ActiveLinkColor = Color.FromArgb(CByte(93), CByte(228), CByte(245))
        lnkForgot.AutoSize = True
        lnkForgot.BackColor = Color.Transparent
        lnkForgot.Cursor = Cursors.Hand
        lnkForgot.Font = New Font("Segoe UI Semibold", 9F)
        lnkForgot.LinkBehavior = LinkBehavior.HoverUnderline
        lnkForgot.LinkColor = Color.FromArgb(CByte(93), CByte(228), CByte(245))
        lnkForgot.Location = New Point(386, 406)
        lnkForgot.Name = "lnkForgot"
        lnkForgot.Size = New Size(72, 20)
        lnkForgot.TabIndex = 6
        lnkForgot.TabStop = True
        lnkForgot.Text = "FORGOT?"
        lnkForgot.VisitedLinkColor = Color.FromArgb(CByte(93), CByte(228), CByte(245))
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.BackColor = Color.Transparent
        lblPass.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblPass.ForeColor = Color.FromArgb(CByte(143), CByte(153), CByte(171))
        lblPass.Location = New Point(58, 404)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(105, 23)
        lblPass.TabIndex = 5
        lblPass.Text = "PASSWORD"
        ' 
        ' pnlEmailInput
        ' 
        pnlEmailInput.BackColor = Color.FromArgb(CByte(19), CByte(24), CByte(37))
        pnlEmailInput.Controls.Add(txtEmail)
        pnlEmailInput.Controls.Add(lblUserIcon)
        pnlEmailInput.Location = New Point(58, 330)
        pnlEmailInput.Name = "pnlEmailInput"
        pnlEmailInput.Size = New Size(384, 52)
        pnlEmailInput.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FromArgb(CByte(19), CByte(24), CByte(37))
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.Font = New Font("Segoe UI Semibold", 11F)
        txtEmail.ForeColor = Color.Gainsboro
        txtEmail.Location = New Point(44, 14)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Enter your credentials"
        txtEmail.Size = New Size(327, 25)
        txtEmail.TabIndex = 1
        ' 
        ' lblUserIcon
        ' 
        lblUserIcon.AutoSize = True
        lblUserIcon.Font = New Font("Segoe UI Symbol", 11F)
        lblUserIcon.ForeColor = Color.FromArgb(CByte(130), CByte(139), CByte(157))
        lblUserIcon.Location = New Point(14, 12)
        lblUserIcon.Name = "lblUserIcon"
        lblUserIcon.Size = New Size(30, 25)
        lblUserIcon.TabIndex = 0
        lblUserIcon.Text = "@"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.BackColor = Color.Transparent
        lblEmail.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblEmail.ForeColor = Color.FromArgb(CByte(143), CByte(153), CByte(171))
        lblEmail.Location = New Point(58, 302)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(187, 23)
        lblEmail.TabIndex = 3
        lblEmail.Text = "USERNAME OR EMAIL"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.BackColor = Color.Transparent
        lblSubtitle.Font = New Font("Segoe UI Semibold", 11F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(130), CByte(139), CByte(157))
        lblSubtitle.Location = New Point(29, 216)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(451, 25)
        lblSubtitle.TabIndex = 2
        lblSubtitle.Text = "Streaming anime favoritmu, kapan saja tanpa ribet."
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.BackColor = Color.Transparent
        lblWelcome.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold)
        lblWelcome.ForeColor = Color.FromArgb(CByte(238), CByte(242), CByte(250))
        lblWelcome.Location = New Point(22, 162)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(466, 54)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "Selamat Datang Kembali"
        ' 
        ' lblBadge
        ' 
        lblBadge.BackColor = Color.FromArgb(CByte(16), CByte(48), CByte(63))
        lblBadge.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblBadge.ForeColor = Color.FromArgb(CByte(84), CByte(234), CByte(255))
        lblBadge.Location = New Point(134, 122)
        lblBadge.Name = "lblBadge"
        lblBadge.Size = New Size(226, 28)
        lblBadge.TabIndex = 14
        lblBadge.Text = "PORTAL STREAMING ANIME"
        lblBadge.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblBrand
        ' 
        lblBrand.AutoSize = True
        lblBrand.BackColor = Color.Transparent
        lblBrand.Font = New Font("Segoe UI", 32F, FontStyle.Bold)
        lblBrand.ForeColor = Color.FromArgb(CByte(83), CByte(231), CByte(248))
        lblBrand.Location = New Point(134, 50)
        lblBrand.Name = "lblBrand"
        lblBrand.Size = New Size(229, 72)
        lblBrand.TabIndex = 0
        lblBrand.Text = "ANIMIT"
        lblBrand.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lnkToSignup
        ' 
        lnkToSignup.ActiveLinkColor = Color.FromArgb(CByte(93), CByte(228), CByte(245))
        lnkToSignup.AutoSize = True
        lnkToSignup.BackColor = Color.Transparent
        lnkToSignup.Cursor = Cursors.Hand
        lnkToSignup.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lnkToSignup.LinkBehavior = LinkBehavior.HoverUnderline
        lnkToSignup.LinkColor = Color.FromArgb(CByte(93), CByte(228), CByte(245))
        lnkToSignup.Location = New Point(331, 645)
        lnkToSignup.Name = "lnkToSignup"
        lnkToSignup.Size = New Size(132, 23)
        lnkToSignup.TabIndex = 12
        lnkToSignup.TabStop = True
        lnkToSignup.Text = "Create Account"
        lnkToSignup.VisitedLinkColor = Color.FromArgb(CByte(93), CByte(228), CByte(245))
        ' 
        ' LoginPage
        ' 
        ClientSize = New Size(500, 700)
        Controls.Add(NightForm1)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(1920, 1080)
        MinimumSize = New Size(460, 640)
        Name = "LoginPage"
        StartPosition = FormStartPosition.CenterScreen
        TransparencyKey = Color.Fuchsia
        NightForm1.ResumeLayout(False)
        NightForm1.PerformLayout()
        pnlSecurity.ResumeLayout(False)
        pnlSecurity.PerformLayout()
        pnlPasswordInput.ResumeLayout(False)
        pnlPasswordInput.PerformLayout()
        pnlEmailInput.ResumeLayout(False)
        pnlEmailInput.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents NightForm1 As NightForm
    Friend WithEvents lblBrand As NightLabel
    Friend WithEvents lblBadge As NightLabel
    Friend WithEvents lblWelcome As NightLabel
    Friend WithEvents lblSubtitle As NightLabel
    Friend WithEvents lblEmail As NightLabel
    Friend WithEvents pnlEmailInput As System.Windows.Forms.Panel
    Friend WithEvents lblUserIcon As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblPass As NightLabel
    Friend WithEvents lnkForgot As NightLinkLabel
    Friend WithEvents pnlPasswordInput As System.Windows.Forms.Panel
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents lblPasswordIcon As System.Windows.Forms.Label
    Friend WithEvents btnLogin As StableActionButton
    Friend WithEvents pnlSecurity As System.Windows.Forms.Panel
    Friend WithEvents lblSecurityIcon As System.Windows.Forms.Label
    Friend WithEvents lblSecurityText As NightLabel
    Friend WithEvents lblCreatePrompt As NightLabel
    Friend WithEvents lnkToSignup As NightLinkLabel
    Friend WithEvents lblClose As Label
End Class
