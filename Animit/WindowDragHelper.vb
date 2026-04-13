Imports System.Runtime.InteropServices

Friend Module WindowDragHelper
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = 2

    <DllImport("user32.dll")>
    Private Function ReleaseCapture() As Boolean
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As Integer, lParam As Integer) As IntPtr
    End Function

    Public Sub BeginWindowDrag(owner As Form, e As MouseEventArgs)
        If owner Is Nothing OrElse e Is Nothing OrElse e.Button <> MouseButtons.Left Then
            Return
        End If

        ReleaseCapture()
        SendMessage(owner.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub
End Module
