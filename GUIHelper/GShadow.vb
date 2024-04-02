Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Windows.Forms

Public Shared Class GShadow
    Private Offset As Point
    Public Sub New(ByVal targetForm As Form)
        MyBase.New(targetForm, 6, &H8080020)
        Me.Offset = New Point(-6, -6)
    End Sub
    Protected Sub ClearShadow()
        Dim image As New Bitmap(MyBase.Width, MyBase.Height, PixelFormat.Format32bppArgb)
        Dim graphics As Graphics = graphics.FromImage(image)
        graphics.Clear(Color.Transparent)
        graphics.Flush()
        graphics.Dispose()
        Me.SetBitmap(image, &HFF)
        image.Dispose()
    End Sub
    Private Function DrawOutsetShadow(ByVal color As Color, ByVal shadowCanvasArea As Rectangle) As Image
        Dim rect As Rectangle = shadowCanvasArea
        Dim rectangle2 As New Rectangle((shadowCanvasArea.X + (-Me.Offset.X - 1)), (shadowCanvasArea.Y + (-Me.Offset.Y - 1)), (shadowCanvasArea.Width - ((-Me.Offset.X * 2) - 1)), (shadowCanvasArea.Height - ((-Me.Offset.Y * 2) - 1)))
        Dim image As New Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb)
        Dim graphics As Graphics = graphics.FromImage(image)
        graphics.SmoothingMode = SmoothingMode.AntiAlias
        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        Using brush As Brush = New SolidBrush(color.FromArgb(30, color.Black))
            graphics.FillRectangle(brush, rect)
        End Using
        Using brush2 As Brush = New SolidBrush(color.FromArgb(60, color.Black))
            graphics.FillRectangle(brush2, rectangle2)
        End Using
        graphics.Flush()
        graphics.Dispose()
        Return image
    End Function
    Protected Overrides Sub PaintShadow()
        Using bitmap As Bitmap = Me.DrawBlurBorder
            Me.SetBitmap(bitmap, &HFF)
        End Using
    End Sub
End Class