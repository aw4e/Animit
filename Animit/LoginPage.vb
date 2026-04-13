Public Class LoginPage
    Private _firebase As FirebaseRealtimeDbClient
    Private _firebaseWarningShown As Boolean

    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NightForm1.Cursor = Cursors.Hand
        lblBrand.Cursor = Cursors.Hand
        lblBadge.Cursor = Cursors.Hand
        lblWelcome.Cursor = Cursors.Hand
        lblSubtitle.Cursor = Cursors.Hand
        ApplyHeroAlignment()
    End Sub

    Private Sub LoginPage_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ApplyHeroAlignment()
    End Sub

    Private Sub LoginPage_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ApplyHeroAlignment()
    End Sub

    Private Sub NightForm1_SizeChanged(sender As Object, e As EventArgs) Handles NightForm1.SizeChanged
        ApplyHeroAlignment()
    End Sub

    Private Sub ApplyHeroAlignment()
        If NightForm1 Is Nothing OrElse pnlEmailInput Is Nothing Then
            Return
        End If

        Dim contentLeft As Integer = pnlEmailInput.Left
        Dim contentWidth As Integer = pnlEmailInput.Width

        lblBrand.AutoSize = False
        lblBrand.Left = contentLeft
        lblBrand.Width = contentWidth
        lblBrand.TextAlign = ContentAlignment.MiddleCenter

        lblWelcome.AutoSize = False
        lblWelcome.Left = contentLeft
        lblWelcome.Width = contentWidth
        lblWelcome.TextAlign = ContentAlignment.MiddleCenter

        lblSubtitle.AutoSize = False
        lblSubtitle.Left = contentLeft
        lblSubtitle.Width = contentWidth
        lblSubtitle.TextAlign = ContentAlignment.MiddleCenter

        lblBadge.AutoSize = False
        lblBadge.Width = 236
        lblBadge.Left = contentLeft + ((contentWidth - lblBadge.Width) \ 2)
        lblBadge.TextAlign = ContentAlignment.MiddleCenter
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
            MessageBox.Show($"{errorMessage}{Environment.NewLine}{Environment.NewLine}PowerShell:{Environment.NewLine}$env:ANIMIT_FIREBASE_DB_KEY='ISI_KEY_FIREBASE_KAMU'", "Konfigurasi Firebase", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Return False
    End Function

    Private Sub StartSimpleDrag(sender As Object, e As MouseEventArgs) Handles NightForm1.MouseDown, lblBrand.MouseDown, lblBadge.MouseDown, lblWelcome.MouseDown, lblSubtitle.MouseDown
        WindowDragHelper.BeginWindowDrag(Me, e)
    End Sub

    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim credential As String = txtEmail.Text.Trim()
        Dim password As String = txtPass.Text

        If credential = "" OrElse password = "" Then
            MessageBox.Show("Masukkan username/email dan password terlebih dulu.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not EnsureFirebaseClient() Then
            Return
        End If

        btnLogin.Enabled = False

        Try
            Dim authResult As FirebaseAuthResult = Await _firebase.AuthenticateAsync(credential, password)
            If authResult Is Nothing Then
                MessageBox.Show("Login gagal. Cek lagi username/email dan password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            MessageBox.Show($"Login berhasil. Selamat datang, {authResult.Username}.", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim mainPage As New MainPage() With {
                .CurrentUsername = authResult.Username,
                .CurrentUserId = authResult.UserId,
                .CurrentUserEmail = authResult.Email
            }
            mainPage.Show()
            Hide()
        Catch ex As Exception
            MessageBox.Show($"Gagal login ke Firebase: {ex.Message}", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnLogin.Enabled = True
        End Try
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Close()
    End Sub

    Private Sub lnkToSignup_Click(sender As Object, e As EventArgs) Handles lnkToSignup.Click
        Dim registerPage As New RegisterPage()
        registerPage.Show()
        Hide()
    End Sub

    Private Sub lnkForgot_Click(sender As Object, e As EventArgs) Handles lnkForgot.Click
        MessageBox.Show("Fitur lupa password sedang disiapkan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
