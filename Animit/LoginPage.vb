Public Class LoginPage
    Private _firebase As FirebaseRealtimeDbClient
    Private _firebaseWarningShown As Boolean
    Private ReadOnly _dragger As New FormDragger()

    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If NightForm1 Is Nothing OrElse pnlEmailInput Is Nothing Then Return

        Dim contentLeft As Integer = pnlEmailInput.Left
        Dim contentWidth As Integer = pnlEmailInput.Width

        For Each lbl In {lblBrand, lblWelcome, lblSubtitle}
            lbl.AutoSize = False
            lbl.Left = contentLeft
            lbl.Width = contentWidth
            lbl.TextAlign = ContentAlignment.MiddleCenter
        Next

        lblBadge.AutoSize = False
        lblBadge.Width = 236
        lblBadge.Left = contentLeft + ((contentWidth - lblBadge.Width) \ 2)
        lblBadge.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Function EnsureFirebaseClient() As Boolean
        Dim errorMessage As String = Nothing
        If FirebaseRealtimeDbClient.TryGetSharedClient(_firebase, errorMessage) Then Return True
        If Not _firebaseWarningShown Then
            _firebaseWarningShown = True
            MessageBox.Show($"{errorMessage}{vbCrLf}{vbCrLf}PowerShell:{vbCrLf}$env:ANIMIT_FIREBASE_DB_KEY='ISI_KEY_FIREBASE_KAMU'",
                            "Konfigurasi Firebase", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Return False
    End Function

    ' --- Drag ---
    Private Sub Drag_MouseDown(sender As Object, e As MouseEventArgs) Handles NightForm1.MouseDown, lblBrand.MouseDown, lblBadge.MouseDown, lblWelcome.MouseDown, lblSubtitle.MouseDown
        _dragger.StartDrag(Me, NightForm1, e)
    End Sub

    Private Sub Drag_MouseMove(sender As Object, e As MouseEventArgs) Handles NightForm1.MouseMove
        _dragger.UpdateDrag(Me)
    End Sub

    Private Sub Drag_MouseUp(sender As Object, e As MouseEventArgs) Handles NightForm1.MouseUp
        _dragger.StopDrag(NightForm1)
    End Sub

    ' --- Actions ---
    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim credential As String = txtEmail.Text.Trim()
        Dim password As String = txtPass.Text

        If credential = "" OrElse password = "" Then
            MessageBox.Show("Masukkan username/email dan password terlebih dulu.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not EnsureFirebaseClient() Then Return

        btnLogin.Enabled = False
        Try
            Dim result As FirebaseAuthResult = Await _firebase.AuthenticateAsync(credential, password)
            If result Is Nothing Then
                MessageBox.Show("Login gagal. Cek lagi username/email dan password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim mainPage As New MainPage() With {
                .CurrentUsername = result.Username,
                .CurrentUserId = result.UserId,
                .CurrentUserEmail = result.Email
            }
            mainPage.Show()
            Hide()
        Catch ex As Exception
            MessageBox.Show($"Gagal login: {ex.Message}", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
