Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class GControl
    Inherits UserControl
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Elipse.Apply(DirectCast(Me, Control), Me.int_0)
        MyBase.OnPaint(e)
    End Sub
    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        Elipse.Apply(DirectCast(Me, Control), Me.int_0)
        MyBase.OnResize(e)
    End Sub
    Private Sub roundconer(ByVal graphics_0 As Graphics, ByVal rectangle_0 As Rectangle, ByVal int_4 As Integer, ByVal pen_0 As Pen, ByVal color_6 As Color)
        graphics_0.Clear(Me.BackColor)
        Dim path As New GraphicsPath
        pen_0.StartCap = LineCap.Round
        pen_0.EndCap = LineCap.Round
        path.AddArc(rectangle_0.X, rectangle_0.Y, int_4, int_4, 180.0!, 90.0!)
        path.AddArc(((rectangle_0.X + rectangle_0.Width) - int_4), rectangle_0.Y, int_4, int_4, 270.0!, 90.0!)
        path.AddArc(((rectangle_0.X + rectangle_0.Width) - int_4), ((rectangle_0.Y + rectangle_0.Height) - int_4), int_4, int_4, 0!, 90.0!)
        path.AddArc(rectangle_0.X, ((rectangle_0.Y + rectangle_0.Height) - int_4), int_4, int_4, 90.0!, 90.0!)
        path.CloseAllFigures()
        graphics_0.FillPath(New SolidBrush(color_6), path)
        graphics_0.SmoothingMode = SmoothingMode.HighQuality
        graphics_0.DrawPath(pen_0, path)
        graphics_0.SmoothingMode = SmoothingMode.AntiAlias
    End Sub
    Public Overrides Sub Refresh()
        Dim image As New Bitmap(MyBase.Size.Width, MyBase.Size.Height)
        Dim graphics As Graphics = Graphics.FromImage(image)
        graphics.SmoothingMode = SmoothingMode.HighQuality
        graphics.Clear(Color.Transparent)
        Dim rectangle As New Rectangle(Me.int_1, (Me.int_1 + 5), (MyBase.Width - (Me.int_1 * 2)), ((MyBase.Height - (Me.int_1 * 2)) - 10))
        If Not MyBase.DesignMode Then
            Application.DoEvents()
        End If
        Me.roundconer(graphics, rectangle, Me.int_0, New Pen(Color.Fuchsia, CSng(Me.int_1)), Color.Pink)
        Me.BackgroundImage = image
    End Sub
    ' Properties
    Public Property BorderRadius As Integer
        Get
            Return Me.int_0
        End Get
        Set(ByVal value As Integer)
            Me.int_0 = value
            Elipse.Apply(DirectCast(Me, Control), Me.int_0)
        End Set
    End Property

    Private int_0 = 0, int_1 = 0, int_2 = 0, int_3 = 0

End Class
