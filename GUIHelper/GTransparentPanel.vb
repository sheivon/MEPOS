Imports System.Drawing
Imports System.Windows.Forms

Public Class GTransparentPanel
    Inherits Panel

    Public Sub New()
        ' Enable transparency support
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
    End Sub

    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
        ' Do not call the base method to avoid painting the background
        ' MyBase.OnPaintBackground(e)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        ' Optionally, you can draw something on the transparent panel here
        MyBase.OnPaint(e)
    End Sub
End Class