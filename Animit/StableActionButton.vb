Imports System.ComponentModel
Imports ReaLTaiizor.Controls
Imports ReaLTaiizor.Helper

Public Class StableActionButton
    Inherits System.Windows.Forms.Button

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property Density As MaterialButton.MaterialButtonDensity = MaterialButton.MaterialButtonDensity.Default

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property Depth As Integer

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property HighEmphasis As Boolean = True

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property Icon As Image

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property IconType As MaterialButton.MaterialIconType = MaterialButton.MaterialIconType.Rebase

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property MouseState As MaterialDrawHelper.MaterialMouseState = MaterialDrawHelper.MaterialMouseState.HOVER

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property NoAccentTextColor As Color = Color.Empty

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property [Type] As MaterialButton.MaterialButtonType = MaterialButton.MaterialButtonType.Contained

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property UseAccentColor As Boolean

    Public Sub New()
        Me.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UseVisualStyleBackColor = False
        Me.FlatAppearance.BorderSize = 1
        UpdateStateColors()
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        UpdateStateColors()
    End Sub

    Protected Overrides Sub OnBackColorChanged(e As EventArgs)
        MyBase.OnBackColorChanged(e)
        UpdateStateColors()
    End Sub

    Private Sub UpdateStateColors()
        Me.FlatAppearance.BorderColor = ShiftColor(Me.BackColor, -26)
        Me.FlatAppearance.MouseOverBackColor = ShiftColor(Me.BackColor, 12)
        Me.FlatAppearance.MouseDownBackColor = ShiftColor(Me.BackColor, -18)
    End Sub

    Private Shared Function ShiftColor(source As Color, delta As Integer) As Color
        Return Color.FromArgb(source.A, Clamp(source.R + delta), Clamp(source.G + delta), Clamp(source.B + delta))
    End Function

    Private Shared Function Clamp(value As Integer) As Integer
        If value < 0 Then
            Return 0
        End If

        If value > 255 Then
            Return 255
        End If

        Return value
    End Function
End Class
