Imports System.ComponentModel
Imports System.Net.Http

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
    Private Shared ReadOnly _httpAvatar As New HttpClient()
    Private _activeChatUsername As String = String.Empty
    Private _tmrChatPoll As System.Windows.Forms.Timer
    Private _lastMsgTimestamp As Long = 0


    Private ReadOnly _selfColor As Color = Color.FromArgb(28, 76, 104)
    Private ReadOnly _otherColor As Color = Color.FromArgb(18, 26, 44)
    Private ReadOnly _selfTextColor As Color = Color.FromArgb(210, 235, 255)
    Private ReadOnly _otherTextColor As Color = Color.FromArgb(195, 207, 228)

    ' ═══════════════════════════════════════════
    '  Load / Init
    ' ═══════════════════════════════════════════
    Private Async Sub SocialHubPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NightForm1.Cursor = Cursors.Default
        CenterAvatar()
        AdjustLayout()

        ShowStatus("Memuat data sosial...", False)
        lblProfileUserId.Text = $"uid: {If(String.IsNullOrWhiteSpace(CurrentUserId), "-", CurrentUserId)}"

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
            ShowStatus("Siap.", False)
        Catch ex As Exception
            ToggleFeatureGroups(False)
            ShowStatus($"Gagal memuat: {ex.Message}", True)
        End Try
    End Sub


    Private Sub CenterAvatar()
        If panelLeft Is Nothing Then Return
        panelAvatarBg.Left = (panelLeft.Width - panelAvatarBg.Width) \ 2
    End Sub

    Private Sub SocialHubPage_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CenterAvatar()
        AdjustLayout()
    End Sub

    Private Sub NightForm1_SizeChanged(sender As Object, e As EventArgs) Handles NightForm1.SizeChanged
        AdjustLayout()
    End Sub

    Private Sub AdjustLayout()
        If panelRight Is Nothing OrElse NightForm1 Is Nothing Then Return
        Dim h As Integer = NightForm1.Height - 53

        panelLeft.Height = h
        panelMiddle.Height = h
        lbFollowing.Height = h - lbFollowing.Top - 40
        btnClose.Top = h - btnClose.Height
        btnClose.Width = panelMiddle.Width

        panelRight.Height = h
        panelRight.Width = NightForm1.Width - panelLeft.Width - panelMiddle.Width

        ' Chat header
        panelChatHeader.Width = panelRight.Width
        lblTitle.Width = panelRight.Width - 40
        lblStatus.Width = panelRight.Width - 40

        ' Input bar
        Dim inputTop As Integer = h - 58
        panelChatInput.Top = inputTop
        panelChatInput.Width = panelRight.Width
        txtMessageBody.Width = panelChatInput.Width - 160
        btnSendMessage.Left = panelChatInput.Width - 148

        ' Chat messages
        panelChatArea.Size = New Size(panelRight.Width, h - 122)

    End Sub

    ' ═══════════════════════════════════════════
    '  Drag
    ' ═══════════════════════════════════════════
    Private Sub Drag_MouseDown(sender As Object, e As MouseEventArgs) Handles NightForm1.MouseDown, lblBrand.MouseDown, lblBadge.MouseDown
        _dragger.StartDrag(Me, NightForm1, e)
    End Sub
    Private Sub Drag_MouseMove(sender As Object, e As MouseEventArgs) Handles NightForm1.MouseMove
        _dragger.UpdateDrag(Me)
    End Sub
    Private Sub Drag_MouseUp(sender As Object, e As MouseEventArgs) Handles NightForm1.MouseUp
        _dragger.StopDrag(NightForm1)
    End Sub

    ' ═══════════════════════════════════════════
    '  Helpers
    ' ═══════════════════════════════════════════
    Private Function EnsureFirebaseClient() As Boolean
        If _firebase IsNot Nothing Then Return True
        Dim msg As String = Nothing
        If FirebaseRealtimeDbClient.TryGetSharedClient(_firebase, msg) Then Return True
        ShowStatus(msg, True)
        Return False
    End Function

    Private Sub ToggleFeatureGroups(isEnabled As Boolean)
        panelLeft.Enabled = isEnabled
        panelMiddle.Enabled = isEnabled
        panelRight.Enabled = isEnabled
    End Sub

    Private Sub ShowStatus(message As String, isError As Boolean)
        lblStatus.Text = message
        lblStatus.ForeColor = If(isError, Color.FromArgb(255, 110, 110), Color.FromArgb(83, 107, 138))
    End Sub

    ' ═══════════════════════════════════════════
    '  Profile
    ' ═══════════════════════════════════════════
    Private Async Function LoadProfileAsync() As Task
        Dim profile As FirebaseProfile = Await _firebase.GetUserProfileAsync(CurrentUserId)
        Dim uname As String = If(profile?.username, CurrentUsername)
        Dim email As String = If(profile?.email, CurrentUserEmail)
        Dim bio As String = If(profile?.bio, String.Empty)
        If String.IsNullOrWhiteSpace(uname) Then uname = CurrentUsername
        If String.IsNullOrWhiteSpace(email) Then email = CurrentUserEmail

        txtProfileUsername.Text = uname
        txtProfileEmail.Text = email
        txtProfileBio.Text = bio

        lblDisplayName.Text = If(String.IsNullOrWhiteSpace(uname), "—", $"@{uname}")
        lblDisplayBio.Text = If(String.IsNullOrWhiteSpace(bio), "No bio yet.", bio)
        lblAvatarInitial.Text = If(String.IsNullOrWhiteSpace(uname), "?", uname.Substring(0, 1).ToUpperInvariant())
        lblProfileUserId.Text = $"uid: {CurrentUserId}"

        Await LoadAvatarAsync(profile?.avatar_url)
        Await LoadProfileStatsAsync()
    End Function

    Private Async Function LoadProfileStatsAsync() As Task
        Try
            Dim tracker As FirebaseLimitTracker = Await _firebase.GetLimitTrackerAsync(CurrentUserId)
            Dim followerCount As Integer = Await _firebase.GetFollowerCountAsync(CurrentUserId)
            Dim followingCount As Integer = Await _firebase.GetFollowingCountAsync(CurrentUserId)

            lblProfileStats.Text = $"Following {followingCount}  ·  Followers {followerCount}"
        Catch
        End Try
    End Function

    Private Async Function LoadAvatarAsync(avatarUrl As String) As Task
        If String.IsNullOrWhiteSpace(avatarUrl) Then
            SetAvatarImage(CreateNoImageBitmap())
            Return
        End If
        Try
            Dim imgBytes As Byte() = Await _httpAvatar.GetByteArrayAsync(avatarUrl)
            Dim bmp As Bitmap
            Using ms As New System.IO.MemoryStream(imgBytes)
                Using loaded As Image = Image.FromStream(ms)
                    bmp = New Bitmap(loaded)
                End Using
            End Using
            SetAvatarImage(bmp)
        Catch
            SetAvatarImage(CreateNoImageBitmap())
        End Try
    End Function

    Private Sub SetAvatarImage(img As Image)
        Dim old As Image = picProfileAvatar.Image
        picProfileAvatar.Image = img
        picProfileAvatar.Visible = True
        lblAvatarInitial.Visible = False
        old?.Dispose()
    End Sub

    Private Function CreateNoImageBitmap() As Bitmap
        Dim bmp As New Bitmap(76, 76)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            g.Clear(Color.FromArgb(26, 72, 100))
            Using br As New SolidBrush(Color.FromArgb(100, 140, 170))
                g.FillEllipse(br, 23, 10, 30, 30)
                g.FillEllipse(br, 10, 46, 56, 44)
            End Using
        End Using
        Return bmp
    End Function

    Private Async Sub btnSaveProfile_Click(sender As Object, e As EventArgs) Handles btnSaveProfile.Click
        Dim username As String = txtProfileUsername.Text.Trim()
        Dim bio As String = txtProfileBio.Text.Trim()
        If String.IsNullOrWhiteSpace(username) Then
            ShowStatus("Username tidak boleh kosong.", True)
            Return
        End If
        btnSaveProfile.Enabled = False
        btnSaveProfile.Text = "Menyimpan..."
        Try
            Await _firebase.UpdateUserProfileAsync(CurrentUserId, username, bio)
            CurrentUsername = username
            UpdatedUsername = username
            lblDisplayName.Text = $"@{username}"
            lblDisplayBio.Text = If(String.IsNullOrWhiteSpace(bio), "No bio yet.", bio)
            lblAvatarInitial.Text = username.Substring(0, 1).ToUpperInvariant()
            ShowStatus("Profil disimpan.", False)
        Catch ex As Exception
            ShowStatus($"Gagal simpan: {ex.Message}", True)
        Finally
            btnSaveProfile.Enabled = True
            btnSaveProfile.Text = "Simpan Profil"
        End Try
    End Sub

    ' Following
    Private Async Function RefreshFollowingAsync() As Task
        lbFollowing.Items.Clear()
        Dim follows As List(Of FirebaseFollowEntry) = Await _firebase.GetFollowingAsync(CurrentUserId)
        Dim inboxSenders As List(Of FirebaseFollowEntry) = Await _firebase.GetDmInboxSendersAsync(CurrentUserId)

        Dim followingIds As New HashSet(Of String)(follows.Select(Function(f) f.UserId), StringComparer.OrdinalIgnoreCase)
        Dim pending As List(Of FirebaseFollowEntry) = inboxSenders.Where(Function(s) Not followingIds.Contains(s.UserId)).ToList()

        ' Section: PESAN MASUK
        If pending.Count > 0 Then
            lbFollowing.Items.Add("--- PESAN MASUK ---")
            For Each row In pending
                lbFollowing.Items.Add($"✉ @{row.Username}")
            Next
        End If

        ' Section: FOLLOWING
        If follows.Count = 0 AndAlso pending.Count = 0 Then
            lbFollowing.Items.Add("(Belum follow siapa pun)")
            Return
        End If
        If follows.Count > 0 Then
            If pending.Count > 0 Then
                lbFollowing.Items.Add("--- FOLLOWING ---")
            End If
            For Each row In follows
                lbFollowing.Items.Add($"@{row.Username}{If(row.Relationship = "mutual", " ⇌", "")}")
            Next
        End If
    End Function

    Private Async Sub btnFollow_Click(sender As Object, e As EventArgs) Handles btnFollow.Click
        Dim target As String = txtFollowUsername.Text.Trim()
        If String.IsNullOrWhiteSpace(target) Then
            ShowStatus("Isi username target.", True)
            Return
        End If
        btnFollow.Enabled = False
        Try
            Dim row As FirebaseFollowEntry = Await _firebase.FollowUserByUsernameAsync(CurrentUserId, target)
            ShowStatus($"Followed @{row.Username}  [{row.Relationship}]", False)
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
            ShowStatus("Following diperbarui.", False)
        Catch ex As Exception
            ShowStatus($"Gagal refresh: {ex.Message}", True)
        End Try
    End Sub

    Private Async Sub lbFollowing_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbFollowing.SelectedIndexChanged
        Dim sel As String = TryCast(lbFollowing.SelectedItem, String)
        If sel IsNot Nothing AndAlso sel.StartsWith("✉") Then
            Dim inboxUname As String = ExtractUsernameFromList()
            If Not String.IsNullOrWhiteSpace(inboxUname) Then
                txtFollowUsername.Text = inboxUname
            End If
        End If

        Dim uname As String = ExtractUsernameFromList()
        If String.IsNullOrWhiteSpace(uname) Then Return
        _activeChatUsername = uname
        _lastMsgTimestamp = 0
        lblTitle.Text = $"# {uname}"
        Await LoadConversationAsync()
        StartChatPolling()
    End Sub

    Private Function ExtractUsernameFromList() As String
        Dim sel As String = TryCast(lbFollowing.SelectedItem, String)
        If String.IsNullOrWhiteSpace(sel) Then Return String.Empty
        If sel.StartsWith("("c) OrElse sel.StartsWith("-"c) Then Return String.Empty
        Dim cleaned As String = If(sel.StartsWith("✉"), sel.Substring(1).TrimStart(), sel)
        Dim raw As String = cleaned.TrimStart("@"c)
        Dim sp As Integer = raw.IndexOf(" "c)
        Return If(sp > 0, raw.Substring(0, sp), raw).Trim()
    End Function

    Private Sub lbFollowing_DrawItem(sender As Object, e As DrawItemEventArgs) Handles lbFollowing.DrawItem
        If e.Index < 0 OrElse e.Index >= lbFollowing.Items.Count Then Return
        Dim text As String = TryCast(lbFollowing.Items(e.Index), String)
        If String.IsNullOrWhiteSpace(text) Then Return

        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim isSelected As Boolean = (e.State And DrawItemState.Selected) = DrawItemState.Selected

        If text.StartsWith("-"c) Then
            Using br As New SolidBrush(Color.FromArgb(11, 16, 28))
                e.Graphics.FillRectangle(br, e.Bounds)
            End Using
            Using hf As New Font("Segoe UI", 6.5F, FontStyle.Bold)
                Using hb As New SolidBrush(Color.FromArgb(65, 82, 110))
                    Dim sf As New StringFormat With {.LineAlignment = StringAlignment.Center}
                    e.Graphics.DrawString(text.Trim("-"c).Trim(), hf, hb,
                        New RectangleF(e.Bounds.X + 10, e.Bounds.Y, e.Bounds.Width - 10, e.Bounds.Height), sf)
                End Using
            End Using
            Return
        End If

        Dim isPlaceholder As Boolean = text.StartsWith("("c)
        Dim isInbox As Boolean = text.StartsWith("✉")

        Dim bg As Color
        If isInbox Then
            bg = If(isSelected, Color.FromArgb(54, 30, 6), Color.FromArgb(20, 12, 4))
        Else
            bg = If(isSelected, Color.FromArgb(20, 54, 80), Color.FromArgb(9, 15, 27))
        End If

        Dim fg As Color
        If isInbox Then
            fg = If(isSelected, Color.FromArgb(255, 190, 80), Color.FromArgb(200, 148, 52))
        ElseIf isSelected Then
            fg = Color.FromArgb(84, 234, 255)
        ElseIf isPlaceholder Then
            fg = Color.FromArgb(55, 68, 90)
        Else
            fg = Color.FromArgb(175, 188, 210)
        End If

        Using bgBrush As New SolidBrush(bg)
            e.Graphics.FillRectangle(bgBrush, e.Bounds)
        End Using

        If Not isPlaceholder Then
            Dim displayText As String = If(isInbox, text.Substring(1).TrimStart(), text)
            Dim rawForInitial As String = displayText.TrimStart("@"c)
            Dim initial As String = If(rawForInitial.Length > 0, rawForInitial.Substring(0, 1).ToUpperInvariant(), "?")

            Dim cx As Integer = e.Bounds.X + 10
            Dim cy As Integer = e.Bounds.Y + (e.Bounds.Height - 26) \ 2
            Dim circleRect As New Rectangle(cx, cy, 26, 26)

            Dim circleColor As Color = If(isInbox,
                If(isSelected, Color.FromArgb(140, 72, 10), Color.FromArgb(90, 48, 8)),
                If(isSelected, Color.FromArgb(38, 100, 130), Color.FromArgb(28, 72, 98)))

            Using circleBrush As New SolidBrush(circleColor)
                e.Graphics.FillEllipse(circleBrush, circleRect)
            End Using
            Using initFont As New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
                Dim sf As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
                e.Graphics.DrawString(initial, initFont, Brushes.White,
                    New RectangleF(circleRect.X, circleRect.Y, circleRect.Width, circleRect.Height), sf)
            End Using

            If isInbox Then
                Using badgeBrush As New SolidBrush(Color.FromArgb(230, 140, 20))
                    e.Graphics.FillEllipse(badgeBrush, New Rectangle(cx + 17, cy, 10, 10))
                End Using
            End If
        End If

        Dim textX As Integer = If(isPlaceholder, e.Bounds.X + 14, e.Bounds.X + 44)
        Dim renderText As String = If(isInbox, text.Substring(1).TrimStart(), text)
        Dim textRect As New RectangleF(textX, e.Bounds.Y, e.Bounds.Width - textX + e.Bounds.X, e.Bounds.Height)
        Using fgBrush As New SolidBrush(fg)
            Dim sf As New StringFormat With {.LineAlignment = StringAlignment.Center}
            e.Graphics.DrawString(renderText, lbFollowing.Font, fgBrush, textRect, sf)
        End Using
        e.DrawFocusRectangle()
    End Sub

    Private Sub txtFollowUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFollowUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnFollow.PerformClick()
        End If
    End Sub

    ' Chat Panel
    Private Async Function LoadConversationAsync() As Task
        If String.IsNullOrWhiteSpace(_activeChatUsername) Then
            lblTitle.Text = "# Social Room"
            ShowStatus("Pilih teman di kiri untuk mulai chat.", False)
            lbConversation.Items.Clear()
            lbConversation.Items.Add("(Pilih teman terlebih dahulu)")
            Return
        End If
        ShowStatus($"DM dengan @{_activeChatUsername}", False)
        Dim rows As List(Of FirebaseChatMessagePreview) = Await _firebase.GetDirectMessagesByUsernameAsync(CurrentUserId, _activeChatUsername, 50)
        lbConversation.Items.Clear()
        If rows.Count = 0 Then
            lbConversation.Items.Add("(Belum ada pesan – mulai percakapan!)")
            Return
        End If
        For Each row In rows
            Dim t As String = If(row.Timestamp > 0, DateTimeOffset.FromUnixTimeSeconds(row.Timestamp).ToLocalTime().ToString("HH:mm"), "--:--")
            lbConversation.Items.Add($"{row.Sender}|{t}|{row.Text}")
        Next
        _lastMsgTimestamp = rows.Max(Function(r) r.Timestamp)
        lbConversation.TopIndex = lbConversation.Items.Count - 1
    End Function

    Private Sub lbConversation_MeasureItem(sender As Object, e As MeasureItemEventArgs) Handles lbConversation.MeasureItem
        If e.Index < 0 OrElse e.Index >= lbConversation.Items.Count Then
            e.ItemHeight = 48
            Return
        End If
        Dim raw As String = TryCast(lbConversation.Items(e.Index), String)
        If String.IsNullOrWhiteSpace(raw) Then
            e.ItemHeight = 48
            Return
        End If

        Dim parts As String() = raw.Split("|"c, 3)
        If parts.Length < 3 Then
            e.ItemHeight = 36
            Return
        End If

        Dim msgText As String = parts(2)
        Dim isSelf As Boolean = String.Equals(parts(0), CurrentUsername, StringComparison.OrdinalIgnoreCase)

        Dim textW As Integer = CInt(lbConversation.ClientSize.Width * 0.68) - 24
        Using mf As New Font("Segoe UI", 10.0F)
            Dim textSize As SizeF = e.Graphics.MeasureString(msgText, mf, textW)
            Dim headerH As Integer = If(isSelf, 0, 18)
            e.ItemHeight = CInt(textSize.Height) + headerH + 24
        End Using
        If e.ItemHeight < 48 Then e.ItemHeight = 48
    End Sub

    Private Sub lbConversation_DrawItem(sender As Object, e As DrawItemEventArgs) Handles lbConversation.DrawItem
        If e.Index < 0 OrElse e.Index >= lbConversation.Items.Count Then Return
        Dim raw As String = TryCast(lbConversation.Items(e.Index), String)
        If String.IsNullOrWhiteSpace(raw) Then Return

        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim parts As String() = raw.Split("|"c, 3)
        If parts.Length < 3 Then
            e.DrawBackground()
            Using br As New SolidBrush(Color.FromArgb(55, 68, 90))
                Dim sf As New StringFormat With {.LineAlignment = StringAlignment.Center}
                e.Graphics.DrawString(raw, New Font("Segoe UI", 9.0F, FontStyle.Italic), br,
                    New RectangleF(e.Bounds.X + 16, e.Bounds.Y, e.Bounds.Width - 32, e.Bounds.Height), sf)
            End Using
            Return
        End If

        Dim senderName As String = parts(0)
        Dim timeStr As String = parts(1)
        Dim msgText As String = parts(2)
        Dim isSelf As Boolean = String.Equals(senderName, CurrentUsername, StringComparison.OrdinalIgnoreCase)

        Dim pad As Integer = 10
        Dim bubbleW As Integer = CInt(e.Bounds.Width * 0.68)
        Dim bubbleX As Integer = If(isSelf, e.Bounds.Right - bubbleW - pad, e.Bounds.X + pad)
        Dim bubbleRect As New Rectangle(bubbleX, e.Bounds.Y + 6, bubbleW, e.Bounds.Height - 12)

        Using bg As New SolidBrush(If(isSelf, _selfColor, _otherColor))
            e.Graphics.FillRectangle(bg, bubbleRect)
        End Using

        Dim padH As Integer = 12
        Dim tx As Single = bubbleRect.X + padH
        Dim tw As Single = bubbleRect.Width - padH * 2

        If Not isSelf Then
            Using sf As New Font("Segoe UI Semibold", 8.0F, FontStyle.Bold)
                Using sb As New SolidBrush(Color.FromArgb(84, 234, 255))
                    e.Graphics.DrawString($"@{senderName}  {timeStr}", sf, sb, New RectangleF(tx, bubbleRect.Y + 8, tw, 16))
                End Using
            End Using
        Else
            Using tf As New Font("Segoe UI", 7.5F, FontStyle.Italic)
                Using tb As New SolidBrush(Color.FromArgb(110, 170, 200))
                    e.Graphics.DrawString(timeStr, tf, tb, New RectangleF(tx, bubbleRect.Y + 8, tw, 16),
                        New StringFormat With {.Alignment = StringAlignment.Far})
                End Using
            End Using
        End If

        Dim msgOff As Integer = If(isSelf, 6, 24)
        Using mf As New Font("Segoe UI", 10.0F)
            Using mb As New SolidBrush(If(isSelf, _selfTextColor, _otherTextColor))
                e.Graphics.DrawString(msgText, mf, mb,
                    New RectangleF(tx, bubbleRect.Y + msgOff, tw, bubbleRect.Height - msgOff - 8))
            End Using
        End Using
    End Sub

    Private Async Sub btnSendMessage_Click(sender As Object, e As EventArgs) Handles btnSendMessage.Click
        Dim msgText As String = txtMessageBody.Text.Trim()
        If String.IsNullOrWhiteSpace(_activeChatUsername) Then
            ShowStatus("Pilih teman dulu.", True)
            Return
        End If
        If String.IsNullOrWhiteSpace(msgText) Then Return

        btnSendMessage.Enabled = False
        Try
            Dim sName As String = If(String.IsNullOrWhiteSpace(CurrentUsername), txtProfileUsername.Text.Trim(), CurrentUsername)
            Await _firebase.SendDirectMessageByUsernameAsync(CurrentUserId, sName, _activeChatUsername, msgText)
            txtMessageBody.Clear()
            Await LoadConversationAsync()
            ShowStatus($"Terkirim ke @{_activeChatUsername}.", False)
        Catch ex As Exception
            ShowStatus($"Gagal kirim: {ex.Message}", True)
        Finally
            btnSendMessage.Enabled = True
        End Try
    End Sub

    Private Sub txtMessageBody_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMessageBody.KeyDown
        If e.KeyCode = Keys.Enter AndAlso Not e.Shift Then
            e.SuppressKeyPress = True
            btnSendMessage.PerformClick()
        End If
    End Sub

    ' Realtime Chat Polling
    Private Sub StartChatPolling()
        If _tmrChatPoll Is Nothing Then
            _tmrChatPoll = New System.Windows.Forms.Timer() With {.Interval = 3000}
            AddHandler _tmrChatPoll.Tick, AddressOf ChatPollTick
        End If
        _tmrChatPoll.Start()
    End Sub

    Private Sub StopChatPolling()
        If _tmrChatPoll IsNot Nothing Then
            _tmrChatPoll.Stop()
        End If
    End Sub

    Private Async Sub ChatPollTick(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(_activeChatUsername) OrElse _firebase Is Nothing Then Return
        Try
            Dim rows As List(Of FirebaseChatMessagePreview) = Await _firebase.GetDirectMessagesByUsernameAsync(CurrentUserId, _activeChatUsername, 50)
            If rows.Count = 0 Then Return

            Dim latestTs As Long = rows.Max(Function(r) r.Timestamp)
            If latestTs <= _lastMsgTimestamp Then Return

            _lastMsgTimestamp = latestTs
            lbConversation.Items.Clear()
            For Each row In rows
                Dim t As String = If(row.Timestamp > 0, DateTimeOffset.FromUnixTimeSeconds(row.Timestamp).ToLocalTime().ToString("HH:mm"), "--:--")
                lbConversation.Items.Add($"{row.Sender}|{t}|{row.Text}")
            Next
            lbConversation.TopIndex = lbConversation.Items.Count - 1
        Catch
        End Try
    End Sub

    Private Sub SocialHubPage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        StopChatPolling()
        _tmrChatPoll?.Dispose()
    End Sub

    ' Close
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Close()
    End Sub
End Class
