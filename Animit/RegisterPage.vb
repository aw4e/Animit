Imports System.Text.RegularExpressions

Public Class RegisterPage
    Private _firebase As FirebaseRealtimeDbClient
    Private _firebaseWarningShown As Boolean
    Private ReadOnly _dragger As New FormDragger()

    Private Sub RegisterPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyHeroAlignment()
        EnsureFirebaseClient()
    End Sub

    Private Sub RegisterPage_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ApplyHeroAlignment()
    End Sub

    Private Sub RegisterPage_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ApplyHeroAlignment()
    End Sub

    Private Sub NightForm1_SizeChanged(sender As Object, e As EventArgs) Handles NightForm1.SizeChanged
        ApplyHeroAlignment()
    End Sub

    Private Sub ApplyHeroAlignment()
        If NightForm1 Is Nothing OrElse pnlUserInput Is Nothing Then Return

        Dim contentLeft As Integer = pnlUserInput.Left
        Dim contentWidth As Integer = pnlUserInput.Width

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
    Private Async Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Dim username As String = txtUserReg.Text.Trim()
        Dim email As String = txtEmailReg.Text.Trim()
        Dim password As String = txtPassReg.Text
        Dim confirmPassword As String = txtConfirmReg.Text

        If username = "" OrElse email = "" OrElse password = "" OrElse confirmPassword = "" Then
            MessageBox.Show("Semua field wajib diisi untuk membuat akun.", "Registrasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Regex.IsMatch(email, "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then
            MessageBox.Show("Format email tidak valid.", "Registrasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If password.Length < 8 Then
            MessageBox.Show("Password minimal 8 karakter.", "Registrasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If password <> confirmPassword Then
            MessageBox.Show("Konfirmasi password tidak sama.", "Registrasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not EnsureFirebaseClient() Then Return

        btnSignup.Enabled = False
        Try
            Dim hwid As String = FirebaseRealtimeDbClient.CreateHardwareId()
            Await _firebase.RegisterUserAsync(username, email, password, hwid)
            MessageBox.Show("Akun berhasil dibuat. Silakan login.", "Registrasi Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            OpenLoginPage()
        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message, "Registrasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show($"Gagal registrasi: {ex.Message}", "Registrasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnSignup.Enabled = True
        End Try
    End Sub

    Private Sub lnkToLogin_Click(sender As Object, e As EventArgs) Handles lnkToLogin.Click
        OpenLoginPage()
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Close()
    End Sub

    Private Sub OpenLoginPage()
        Dim loginPage As New LoginPage()
        loginPage.Show()
        Hide()
    End Sub
End Class
