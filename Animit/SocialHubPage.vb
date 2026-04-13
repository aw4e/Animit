Imports System.ComponentModel

Public Class SocialHubPage
    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property CurrentUserId As String = String.Empty
    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property CurrentUsername As String = String.Empty
    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property CurrentUserEmail As String = String.Empty
    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property UpdatedUsername As String = String.Empty

    Private _firebase As FirebaseRealtimeDbClient
    Private ReadOnly _dragger As New FormDragger()

    Private Async Sub SocialHubPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NightForm1.Cursor = Cursors.Hand
        lblBrand.Cursor = Cursors.Hand
        lblBadge.Cursor = Cursors.Hand
        lblTitle.Cursor = Cursors.Hand
        ApplyHeaderAlignment()

        ShowStatus("Memuat data sosial...", False)
        lblProfileUserId.Text = $"User ID: {If(String.IsNullOrWhiteSpace(CurrentUserId), "-", CurrentUserId)}"

        If String.IsNullOrWhiteSpace(CurrentUserId) Then
            ToggleFeatureGroups(False)
            ShowStatus("User ID tidak ditemukan. Silakan login ulang.", True)
            Return
        End If

        If Not EnsureFirebaseClient() Then
            ToggleFeatureGroups(False)
            Return
        End If

        Try
            Await LoadProfileAsync()
            Await RefreshFollowingAsync()
            ShowStatus("Social hub siap dipakai.", False)
        Catch ex As Exception
            ToggleFeatureGroups(False)
            ShowStatus($"Gagal memuat data sosial: {ex.Message}", True)
        End Try
    End Sub

    Private Sub SocialHubPage_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ApplyHeaderAlignment()
    End Sub

    Private Sub SocialHubPage_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ApplyHeaderAlignment()
    End Sub

    Private Sub NightForm1_SizeChanged(sender As Object, e As EventArgs) Handles NightForm1.SizeChanged
        ApplyHeaderAlignment()
    End Sub

    Private Sub ApplyHeaderAlignment()
        If grpProfile Is Nothing OrElse grpFollow Is Nothing Then
            Return
        End If

        lblBadge.Left = lblBrand.Right + 8
    End Sub

    ' --- Drag ---
    Private Sub Drag_MouseDown(sender As Object, e As MouseEventArgs) Handles NightForm1.MouseDown, lblBrand.MouseDown, lblBadge.MouseDown, lblTitle.MouseDown
        _dragger.StartDrag(Me, NightForm1, e)
    End Sub

    Private Sub Drag_MouseMove(sender As Object, e As MouseEventArgs) Handles NightForm1.MouseMove
        _dragger.UpdateDrag(Me)
    End Sub

    Private Sub Drag_MouseUp(sender As Object, e As MouseEventArgs) Handles NightForm1.MouseUp
        _dragger.StopDrag(NightForm1)
    End Sub

    Private Function EnsureFirebaseClient() As Boolean
        If _firebase IsNot Nothing Then
            Return True
        End If

        Dim errorMessage As String = Nothing
        If FirebaseRealtimeDbClient.TryGetSharedClient(_firebase, errorMessage) Then
            Return True
        End If

        ShowStatus(errorMessage, True)
        Return False
    End Function

    Private Sub ToggleFeatureGroups(isEnabled As Boolean)
        grpProfile.Enabled = isEnabled
        grpFollow.Enabled = isEnabled
        grpMessage.Enabled = isEnabled
    End Sub

    Private Sub ShowStatus(message As String, isError As Boolean)
        lblStatus.Text = message
        lblStatus.ForeColor = If(isError, Color.FromArgb(255, 140, 140), Color.Gainsboro)
    End Sub

    Private Async Function LoadProfileAsync() As Task
        Dim profile As FirebaseProfile = Await _firebase.GetUserProfileAsync(CurrentUserId)

        txtProfileUsername.Text = If(profile?.username, CurrentUsername)
        txtProfileEmail.Text = If(profile?.email, CurrentUserEmail)
        txtProfileBio.Text = If(profile?.bio, String.Empty)

        If String.IsNullOrWhiteSpace(txtProfileEmail.Text) Then
            txtProfileEmail.Text = CurrentUserEmail
        End If

        If String.IsNullOrWhiteSpace(txtProfileUsername.Text) Then
            txtProfileUsername.Text = CurrentUsername
        End If
    End Function

    Private Async Function RefreshFollowingAsync() As Task
        lbFollowing.Items.Clear()
        Dim follows As List(Of FirebaseFollowEntry) = Await _firebase.GetFollowingAsync(CurrentUserId)

        If follows.Count = 0 Then
            lbFollowing.Items.Add("(Belum follow siapa pun)")
            Return
        End If

        For Each row In follows
            lbFollowing.Items.Add($"@{row.Username}")
        Next
    End Function

    Private Async Sub btnSaveProfile_Click(sender As Object, e As EventArgs) Handles btnSaveProfile.Click
        Dim username As String = txtProfileUsername.Text.Trim()
        Dim bio As String = txtProfileBio.Text.Trim()

        If String.IsNullOrWhiteSpace(username) Then
            ShowStatus("Username tidak boleh kosong.", True)
            Return
        End If

        btnSaveProfile.Enabled = False
        Try
            Await _firebase.UpdateUserProfileAsync(CurrentUserId, username, bio)
            CurrentUsername = username
            UpdatedUsername = username
            ShowStatus("Profil berhasil disimpan.", False)
        Catch ex As Exception
            ShowStatus($"Gagal simpan profil: {ex.Message}", True)
        Finally
            btnSaveProfile.Enabled = True
        End Try
    End Sub

    Private Async Sub btnFollow_Click(sender As Object, e As EventArgs) Handles btnFollow.Click
        Dim targetUsername As String = txtFollowUsername.Text.Trim()
        If String.IsNullOrWhiteSpace(targetUsername) Then
            ShowStatus("Isi username target dulu.", True)
            Return
        End If

        btnFollow.Enabled = False
        Try
            Dim row As FirebaseFollowEntry = Await _firebase.FollowUserByUsernameAsync(CurrentUserId, targetUsername)
            ShowStatus($"Berhasil follow {row.Username} ({row.Relationship}).", False)
            txtFollowUsername.Clear()
            Await RefreshFollowingAsync()
        Catch ex As Exception
            ShowStatus($"Gagal follow: {ex.Message}", True)
        Finally
            btnFollow.Enabled = True
        End Try
    End Sub

    Private Async Sub btnRefreshFollowing_Click(sender As Object, e As EventArgs) Handles btnRefreshFollowing.Click
        Try
            Await RefreshFollowingAsync()
            ShowStatus("Daftar following diperbarui.", False)
        Catch ex As Exception
            ShowStatus($"Gagal refresh following: {ex.Message}", True)
        End Try
    End Sub

    Private Async Function LoadConversationAsync() As Task
        Dim targetUsername As String = txtMessageTo.Text.Trim()
        lbConversation.Items.Clear()

        If String.IsNullOrWhiteSpace(targetUsername) Then
            lblTitle.Text = "# Social Room"
            lblStatus.Text = "Pilih teman di kiri untuk mulai chat."
            lbConversation.Items.Add("(Isi username tujuan dulu)")
            Return
        End If

        lblTitle.Text = $"# {targetUsername}"
        lblStatus.Text = "Direct Message aktif."

        Dim rows As List(Of FirebaseChatMessagePreview) = Await _firebase.GetDirectMessagesByUsernameAsync(CurrentUserId, targetUsername, 50)
        If rows.Count = 0 Then
            lbConversation.Items.Add("(Belum ada pesan)")
            Return
        End If

        For Each row In rows
            Dim timeText As String = If(row.Timestamp > 0, DateTimeOffset.FromUnixTimeSeconds(row.Timestamp).ToLocalTime().ToString("HH:mm"), "--:--")
            lbConversation.Items.Add($"{timeText}  {row.Sender}: {row.Text}")
        Next

        lbConversation.TopIndex = lbConversation.Items.Count - 1
    End Function

    Private Async Sub btnLoadConversation_Click(sender As Object, e As EventArgs) Handles btnLoadConversation.Click
        Try
            Await LoadConversationAsync()
            ShowStatus("Percakapan dimuat.", False)
        Catch ex As Exception
            ShowStatus($"Gagal muat percakapan: {ex.Message}", True)
        End Try
    End Sub

    Private Async Sub btnSendMessage_Click(sender As Object, e As EventArgs) Handles btnSendMessage.Click
        Dim targetUsername As String = txtMessageTo.Text.Trim()
        Dim messageText As String = txtMessageBody.Text.Trim()

        If String.IsNullOrWhiteSpace(targetUsername) Then
            ShowStatus("Isi username tujuan dulu.", True)
            Return
        End If

        If String.IsNullOrWhiteSpace(messageText) Then
            ShowStatus("Pesan tidak boleh kosong.", True)
            Return
        End If

        btnSendMessage.Enabled = False
        Try
            Dim senderName As String = If(String.IsNullOrWhiteSpace(CurrentUsername), txtProfileUsername.Text.Trim(), CurrentUsername)
            Await _firebase.SendDirectMessageByUsernameAsync(CurrentUserId, senderName, targetUsername, messageText)
            txtMessageBody.Clear()
            Await LoadConversationAsync()
            ShowStatus($"Pesan ke @{targetUsername} terkirim.", False)
        Catch ex As Exception
            ShowStatus($"Gagal kirim pesan: {ex.Message}", True)
        Finally
            btnSendMessage.Enabled = True
        End Try
    End Sub

    Private Async Sub lbFollowing_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbFollowing.SelectedIndexChanged
        Dim selected As String = ExtractUsernameFromFollowingList()
        If String.IsNullOrWhiteSpace(selected) Then
            Return
        End If

        txtMessageTo.Text = selected
        Await LoadConversationAsync()
    End Sub

    Private Function ExtractUsernameFromFollowingList() As String
        Dim selected As String = TryCast(lbFollowing.SelectedItem, String)
        If String.IsNullOrWhiteSpace(selected) Then
            Return String.Empty
        End If

        If selected.StartsWith("("c) Then
            Return String.Empty
        End If

        If selected.StartsWith("@"c) Then
            Return selected.Substring(1).Trim()
        End If

        Return selected.Trim()
    End Function

    Private Sub txtMessageBody_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMessageBody.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnSendMessage.PerformClick()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Close()
    End Sub
End Class
