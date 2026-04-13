' FormDragger — simple, reliable form drag for frameless WinForms windows.
'
' How to use in any page:
'   1. Add field:   Private ReadOnly _dragger As New FormDragger()
'   2. MouseDown:   _dragger.StartDrag(Me, NightForm1, e)
'   3. MouseMove:   _dragger.UpdateDrag(Me)
'   4. MouseUp:     _dragger.StopDrag(NightForm1)
'
' StartDrag sets Capture on the given control so that MouseMove/MouseUp
' keep firing through NightForm1 even when the cursor moves over child controls.

Friend Class FormDragger
    Private _dragging As Boolean
    Private _originX As Integer ' cursor.X - form.X at drag start
    Private _originY As Integer ' cursor.Y - form.Y at drag start

    Public Sub StartDrag(form As Form, captureOn As Control, e As MouseEventArgs)
        If e.Button <> MouseButtons.Left Then Return
        _dragging = True
        _originX = Cursor.Position.X - form.Location.X
        _originY = Cursor.Position.Y - form.Location.Y
        captureOn.Capture = True
    End Sub

    Public Sub UpdateDrag(form As Form)
        If _dragging Then
            form.Location = New Point(Cursor.Position.X - _originX, Cursor.Position.Y - _originY)
        End If
    End Sub

    Public Sub StopDrag(captureOn As Control)
        If _dragging Then
            _dragging = False
            captureOn.Capture = False
        End If
    End Sub
End Class
