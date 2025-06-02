Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports GUIHelper
Imports GUIHelper.ToggleSwitch

Public Class ToggleSwitchBrushedMetalRenderer
    Inherits ToggleSwitchRendererBase
    ' Methods
    Public Sub New()
        Me.BorderColor1 = Color.FromArgb(&HFF, &H91, &H92, &H95)
        Me.BorderColor2 = Color.FromArgb(&HFF, &HE3, &HE5, &HE8)
        Me.BackColor1 = Color.FromArgb(&HFF, &H7D, &H7E, &H80)
        Me.BackColor2 = Color.FromArgb(&HFF, &HE0, &HE2, &HE4)
        Me.UpperShadowColor1 = Color.FromArgb(150, 0, 0, 0)
        Me.UpperShadowColor2 = Color.FromArgb(5, 0, 0, 0)
        Me.ButtonNormalBorderColor = Color.FromArgb(&HFF, &H90, &H90, &H91)
        Me.ButtonNormalSurfaceColor = Color.FromArgb(&HFF, &HFB, &HFB, &HFB)
        Me.ButtonHoverBorderColor = Color.FromArgb(&HFF, &HA6, &HA7, &HA8)
        Me.ButtonHoverSurfaceColor = Color.FromArgb(&HFF, &HEE, &HEE, &HEE)
        Me.ButtonPressedBorderColor = Color.FromArgb(&HFF, &H7B, &H7B, &H7B)
        Me.ButtonPressedSurfaceColor = Color.FromArgb(&HFF, &HB8, &HB8, &HB8)
        Me.UpperShadowHeight = 8
    End Sub

    Private Function GetBrush(ByVal Colors As Color(), ByVal r As RectangleF, ByVal centerPoint As PointF) As PathGradientBrush
        Dim index As Integer = (Colors.Length - 1)
        Dim points As PointF() = New PointF((index + 1) - 1) {}
        Dim num2 As Single = 0.0!
        Dim num3 As Integer = 0
        Dim num4 As Single = (r.Width / 2.0!)
        Dim num5 As Single = (r.Height / 2.0!)
        Dim num6 As Integer = CInt(Math.Floor(CDbl((((180 * (index - 2)) / CDbl(index)) / 2))))
        Dim a As Double = ((num6 * 3.1415926535897931) / 180)
        Dim num8 As Double = (1 / Math.Sin(a))
        Dim num9 As Single = CSng((num4 * num8))
        Dim num10 As Single = CSng((num5 * num8))
        Do While (num2 <= 6.2831853071795862)
            points(num3) = New PointF(((num4 + CSng((Math.Cos(CDbl(num2)) * num9))) + r.Left), ((num5 + CSng((Math.Sin(CDbl(num2)) * num10))) + r.Top))
            num3 += 1
            num2 = (num2 + CSng((6.2831853071795862 / CDbl(index))))
        Loop
        points(index) = points(0)
        Dim path As New GraphicsPath
        path.AddLines(points)
        Dim brush As New PathGradientBrush(path) With { _
            .CenterPoint = centerPoint, _
            .CenterColor = Color.Transparent _
        }
        brush.SurroundColors = New Color() {Color.White}
        Try
            brush.SurroundColors = Colors
        Catch exception As Exception
            Throw New Exception("Too may colors!", exception)
        End Try
        Return brush
    End Function

    Public Function GetButtonClipPath() As GraphicsPath
        Dim buttonRectangle As Rectangle = Me.GetButtonRectangle
        Dim path As New GraphicsPath
        path.AddArc(buttonRectangle.X, buttonRectangle.Y, buttonRectangle.Height, buttonRectangle.Height, 0.0!, 360.0!)
        Return path
    End Function

    Public Overrides Function GetButtonRectangle() As Rectangle
        Dim buttonWidth As Integer = Me.GetButtonWidth
        Return Me.GetButtonRectangle(buttonWidth)
    End Function

    Public Overrides Function GetButtonRectangle(ByVal buttonWidth As Integer) As Rectangle
        Return New Rectangle(MyBase.ToggleSwitch.ButtonValue, 1, buttonWidth, buttonWidth)
    End Function

    Public Overrides Function GetButtonWidth() As Integer
        Return (MyBase.ToggleSwitch.Height - 2)
    End Function

    Public Function GetRectangleClipPath(ByVal rect As Rectangle) As GraphicsPath
        Dim path As New GraphicsPath
        path.AddArc(rect.X, rect.Y, rect.Height, rect.Height, 90.0!, 180.0!)
        path.AddArc((rect.Width - rect.Height), rect.Y, rect.Height, rect.Height, 270.0!, 180.0!)
        path.CloseFigure()
        Return path
    End Function

    Public Overrides Sub RenderBorder(ByVal g As Graphics, ByVal borderRectangle As Rectangle)
        g.SmoothingMode = SmoothingMode.HighQuality
        g.PixelOffsetMode = PixelOffsetMode.HighQuality
        g.InterpolationMode = InterpolationMode.HighQualityBilinear
        Using path As GraphicsPath = Me.GetRectangleClipPath(borderRectangle)
            g.SetClip(path)
            Dim color As Color = If((MyBase.ToggleSwitch.Enabled OrElse Not MyBase.ToggleSwitch.GrayWhenDisabled), Me.BorderColor1, Me.BorderColor1.ToGrayScale())
            Dim color2 As Color = If((MyBase.ToggleSwitch.Enabled OrElse Not MyBase.ToggleSwitch.GrayWhenDisabled), Me.BorderColor2, Me.BorderColor2.ToGrayScale())
            Using brush As Brush = New LinearGradientBrush(borderRectangle, color, color2, LinearGradientMode.Vertical)
                g.FillPath(brush, path)
            End Using
            g.ResetClip()
        End Using
        Dim rect As New Rectangle((borderRectangle.X + 1), (borderRectangle.Y + 1), (borderRectangle.Width - 1), (borderRectangle.Height - 2))
        Using path2 As GraphicsPath = Me.GetRectangleClipPath(rect)
            g.SetClip(path2)
            Dim color3 As Color = If((MyBase.ToggleSwitch.Enabled OrElse Not MyBase.ToggleSwitch.GrayWhenDisabled), Me.BackColor1, Me.BackColor1.ToGrayScale())
            Dim color4 As Color = If((MyBase.ToggleSwitch.Enabled OrElse Not MyBase.ToggleSwitch.GrayWhenDisabled), Me.BackColor2, Me.BackColor2.ToGrayScale())
            Using brush2 As Brush = New LinearGradientBrush(borderRectangle, color3, color4, LinearGradientMode.Horizontal)
                g.FillPath(brush2, path2)
            End Using
            Dim rectangle2 As New Rectangle(rect.X, rect.Y, rect.Width, Me.UpperShadowHeight)
            g.IntersectClip(rectangle2)
            Using brush3 As Brush = New LinearGradientBrush(rectangle2, Me.UpperShadowColor1, Me.UpperShadowColor2, LinearGradientMode.Vertical)
                g.FillRectangle(brush3, rectangle2)
            End Using
            g.ResetClip()
        End Using
    End Sub

    Public Overrides Sub RenderButton(ByVal g As Graphics, ByVal buttonRectangle As Rectangle)
        g.SmoothingMode = SmoothingMode.HighQuality
        g.PixelOffsetMode = PixelOffsetMode.HighQuality
        g.InterpolationMode = InterpolationMode.HighQualityBilinear
        g.SetClip(buttonRectangle)
        Dim buttonNormalSurfaceColor As Color = Me.ButtonNormalSurfaceColor
        If MyBase.ToggleSwitch.IsButtonPressed Then
            buttonNormalSurfaceColor = Me.ButtonPressedSurfaceColor
        ElseIf MyBase.ToggleSwitch.IsButtonHovered Then
            buttonNormalSurfaceColor = Me.ButtonHoverSurfaceColor
        End If
        If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
            buttonNormalSurfaceColor = buttonNormalSurfaceColor.ToGrayScale()
        End If
        Using brush As Brush = New SolidBrush(buttonNormalSurfaceColor)
            g.FillEllipse(brush, buttonRectangle)
        End Using
        Dim centerPoint As New PointF((buttonRectangle.X + (CSng(buttonRectangle.Width) / 2.0!)), (buttonRectangle.Y + (1.2! * (CSng(buttonRectangle.Height) / 2.0!))))
        Dim colors As Color() = New Color() {Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.FromArgb(&HFF, 110, 110, 110), Color.Transparent, Color.Transparent, Color.Transparent}
        Using brush2 As PathGradientBrush = Me.GetBrush(colors, buttonRectangle, centerPoint)
            g.FillEllipse(brush2, buttonRectangle)
        End Using
        Dim tf2 As New PointF((buttonRectangle.X + (0.8! * (CSng(buttonRectangle.Width) / 2.0!))), (buttonRectangle.Y + (CSng(buttonRectangle.Height) / 2.0!)))
        Dim colorArray2 As Color() = New Color() {Color.FromArgb(&HFF, 110, 110, 110), Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.FromArgb(&HFF, 110, 110, 110)}
        Using brush3 As PathGradientBrush = Me.GetBrush(colorArray2, buttonRectangle, tf2)
            g.FillEllipse(brush3, buttonRectangle)
        End Using
        Dim tf3 As New PointF((buttonRectangle.X + (1.2! * (CSng(buttonRectangle.Width) / 2.0!))), (buttonRectangle.Y + (CSng(buttonRectangle.Height) / 2.0!)))
        Dim colorArray3 As Color() = New Color() {Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.FromArgb(&HFF, &H62, &H62, &H62), Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent}
        Using brush4 As PathGradientBrush = Me.GetBrush(colorArray3, buttonRectangle, tf3)
            g.FillEllipse(brush4, buttonRectangle)
        End Using
        Dim tf4 As New PointF((buttonRectangle.X + (0.9! * (CSng(buttonRectangle.Width) / 2.0!))), (buttonRectangle.Y + (0.9! * (CSng(buttonRectangle.Height) / 2.0!))))
        Dim colorArray4 As Color() = New Color() {Color.Transparent, Color.FromArgb(&HFF, &HBC, &HBC, &HBC), Color.FromArgb(&HFF, 110, 110, 110), Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent}
        Using brush5 As PathGradientBrush = Me.GetBrush(colorArray4, buttonRectangle, tf4)
            g.FillEllipse(brush5, buttonRectangle)
        End Using
        Dim buttonNormalBorderColor As Color = Me.ButtonNormalBorderColor
        If MyBase.ToggleSwitch.IsButtonPressed Then
            buttonNormalBorderColor = Me.ButtonPressedBorderColor
        ElseIf MyBase.ToggleSwitch.IsButtonHovered Then
            buttonNormalBorderColor = Me.ButtonHoverBorderColor
        End If
        If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
            buttonNormalBorderColor = buttonNormalBorderColor.ToGrayScale()
        End If
        Using pen As Pen = New Pen(buttonNormalBorderColor)
            g.DrawEllipse(pen, buttonRectangle)
        End Using
        g.ResetClip()
    End Sub

    Public Overrides Sub RenderLeftToggleField(ByVal g As Graphics, ByVal leftRectangle As Rectangle, ByVal totalToggleFieldWidth As Integer)
        g.SmoothingMode = SmoothingMode.HighQuality
        g.PixelOffsetMode = PixelOffsetMode.HighQuality
        g.InterpolationMode = InterpolationMode.HighQualityBilinear
        Dim rect As New Rectangle(1, 1, (MyBase.ToggleSwitch.Width - 1), (MyBase.ToggleSwitch.Height - 2))
        Using path As GraphicsPath = Me.GetRectangleClipPath(rect)
            g.SetClip(path)
            If ((Not MyBase.ToggleSwitch.OnSideImage Is Nothing) OrElse Not String.IsNullOrEmpty(MyBase.ToggleSwitch.OnText)) Then
                Dim ef As New RectangleF(CSng(((leftRectangle.X + 2) - (totalToggleFieldWidth - leftRectangle.Width))), 2.0!, CSng((totalToggleFieldWidth - 2)), CSng((MyBase.ToggleSwitch.Height - 4)))
                g.IntersectClip(ef)
                If (Not MyBase.ToggleSwitch.OnSideImage Is Nothing) Then
                    Dim rectangle2 As Rectangle
                    Dim imageSize As Size = MyBase.ToggleSwitch.OnSideImage.Size
                    Dim x As Integer = CInt(ef.X)
                    If MyBase.ToggleSwitch.OnSideScaleImageToFit Then
                        Dim canvasSize As New Size(CInt(ef.Width), CInt(ef.Height))
                        Dim size3 As Size = ImageHelper.RescaleImageToFit(imageSize, canvasSize)
                        If (MyBase.ToggleSwitch.OnSideAlignment = ToggleSwitchAlignment.Center) Then
                            x = CInt((ef.X + ((ef.Width - size3.Width) / 2.0!)))
                        ElseIf (MyBase.ToggleSwitch.OnSideAlignment = ToggleSwitchAlignment.Near) Then
                            x = (CInt((ef.X + ef.Width)) - size3.Width)
                        End If
                        rectangle2 = New Rectangle(x, CInt((ef.Y + ((ef.Height - size3.Height) / 2.0!))), size3.Width, size3.Height)
                        If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
                            g.DrawImage(MyBase.ToggleSwitch.OnSideImage, rectangle2, 0, 0, MyBase.ToggleSwitch.OnSideImage.Width, MyBase.ToggleSwitch.OnSideImage.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes)
                        Else
                            g.DrawImage(MyBase.ToggleSwitch.OnSideImage, rectangle2)
                        End If
                    Else
                        If (MyBase.ToggleSwitch.OnSideAlignment = ToggleSwitchAlignment.Center) Then
                            x = CInt((ef.X + ((ef.Width - imageSize.Width) / 2.0!)))
                        ElseIf (MyBase.ToggleSwitch.OnSideAlignment = ToggleSwitchAlignment.Near) Then
                            x = (CInt((ef.X + ef.Width)) - imageSize.Width)
                        End If
                        rectangle2 = New Rectangle(x, CInt((ef.Y + ((ef.Height - imageSize.Height) / 2.0!))), imageSize.Width, imageSize.Height)
                        If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
                            g.DrawImage(MyBase.ToggleSwitch.OnSideImage, rectangle2, 0, 0, MyBase.ToggleSwitch.OnSideImage.Width, MyBase.ToggleSwitch.OnSideImage.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes)
                        Else
                            g.DrawImageUnscaled(MyBase.ToggleSwitch.OnSideImage, rectangle2)
                        End If
                    End If
                ElseIf Not String.IsNullOrEmpty(MyBase.ToggleSwitch.OnText) Then
                    Dim ef2 As SizeF = g.MeasureString(MyBase.ToggleSwitch.OnText, MyBase.ToggleSwitch.OnFont)
                    Dim num2 As Single = ef.X
                    If (MyBase.ToggleSwitch.OnSideAlignment = ToggleSwitchAlignment.Center) Then
                        num2 = (ef.X + ((ef.Width - ef2.Width) / 2.0!))
                    ElseIf (MyBase.ToggleSwitch.OnSideAlignment = ToggleSwitchAlignment.Near) Then
                        num2 = ((ef.X + ef.Width) - ef2.Width)
                    End If
                    Dim layoutRectangle As New RectangleF(num2, (ef.Y + ((ef.Height - ef2.Height) / 2.0!)), ef2.Width, ef2.Height)
                    Dim onForeColor As Color = MyBase.ToggleSwitch.OnForeColor
                    If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
                        onForeColor = onForeColor.ToGrayScale()
                    End If
                    Using brush As Brush = New SolidBrush(onForeColor)
                        g.DrawString(MyBase.ToggleSwitch.OnText, MyBase.ToggleSwitch.OnFont, brush, layoutRectangle)
                    End Using
                End If
            End If
            g.ResetClip()
        End Using
    End Sub

    Public Overrides Sub RenderRightToggleField(ByVal g As Graphics, ByVal rightRectangle As Rectangle, ByVal totalToggleFieldWidth As Integer)
        g.SmoothingMode = SmoothingMode.HighQuality
        g.PixelOffsetMode = PixelOffsetMode.HighQuality
        g.InterpolationMode = InterpolationMode.HighQualityBilinear
        Dim rect As New Rectangle(1, 1, (MyBase.ToggleSwitch.Width - 1), (MyBase.ToggleSwitch.Height - 2))
        Using path As GraphicsPath = Me.GetRectangleClipPath(rect)
            g.SetClip(path)
            If ((Not MyBase.ToggleSwitch.OffSideImage Is Nothing) OrElse Not String.IsNullOrEmpty(MyBase.ToggleSwitch.OffText)) Then
                Dim ef As New RectangleF(CSng(rightRectangle.X), 2.0!, CSng((totalToggleFieldWidth - 2)), CSng((MyBase.ToggleSwitch.Height - 4)))
                g.IntersectClip(ef)
                If (Not MyBase.ToggleSwitch.OffSideImage Is Nothing) Then
                    Dim rectangle2 As Rectangle
                    Dim imageSize As Size = MyBase.ToggleSwitch.OffSideImage.Size
                    Dim x As Integer = CInt(ef.X)
                    If MyBase.ToggleSwitch.OffSideScaleImageToFit Then
                        Dim canvasSize As New Size(CInt(ef.Width), CInt(ef.Height))
                        Dim size3 As Size = ImageHelper.RescaleImageToFit(imageSize, canvasSize)
                        If (MyBase.ToggleSwitch.OffSideAlignment = ToggleSwitchAlignment.Center) Then
                            x = CInt((ef.X + ((ef.Width - size3.Width) / 2.0!)))
                        ElseIf (MyBase.ToggleSwitch.OffSideAlignment = ToggleSwitchAlignment.Far) Then
                            x = (CInt((ef.X + ef.Width)) - size3.Width)
                        End If
                        rectangle2 = New Rectangle(x, CInt((ef.Y + ((ef.Height - size3.Height) / 2.0!))), size3.Width, size3.Height)
                        If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
                            g.DrawImage(MyBase.ToggleSwitch.OnSideImage, rectangle2, 0, 0, MyBase.ToggleSwitch.OnSideImage.Width, MyBase.ToggleSwitch.OnSideImage.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes)
                        Else
                            g.DrawImage(MyBase.ToggleSwitch.OnSideImage, rectangle2)
                        End If
                    Else
                        If (MyBase.ToggleSwitch.OffSideAlignment = ToggleSwitchAlignment.Center) Then
                            x = CInt((ef.X + ((ef.Width - imageSize.Width) / 2.0!)))
                        ElseIf (MyBase.ToggleSwitch.OffSideAlignment = ToggleSwitchAlignment.Far) Then
                            x = (CInt((ef.X + ef.Width)) - imageSize.Width)
                        End If
                        rectangle2 = New Rectangle(x, CInt((ef.Y + ((ef.Height - imageSize.Height) / 2.0!))), imageSize.Width, imageSize.Height)
                        If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
                            g.DrawImage(MyBase.ToggleSwitch.OnSideImage, rectangle2, 0, 0, MyBase.ToggleSwitch.OnSideImage.Width, MyBase.ToggleSwitch.OnSideImage.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes)
                        Else
                            g.DrawImageUnscaled(MyBase.ToggleSwitch.OffSideImage, rectangle2)
                        End If
                    End If
                ElseIf Not String.IsNullOrEmpty(MyBase.ToggleSwitch.OffText) Then
                    Dim ef2 As SizeF = g.MeasureString(MyBase.ToggleSwitch.OffText, MyBase.ToggleSwitch.OffFont)
                    Dim num2 As Single = ef.X
                    If (MyBase.ToggleSwitch.OffSideAlignment = ToggleSwitchAlignment.Center) Then
                        num2 = (ef.X + ((ef.Width - ef2.Width) / 2.0!))
                    ElseIf (MyBase.ToggleSwitch.OffSideAlignment = ToggleSwitchAlignment.Far) Then
                        num2 = ((ef.X + ef.Width) - ef2.Width)
                    End If
                    Dim layoutRectangle As New RectangleF(num2, (ef.Y + ((ef.Height - ef2.Height) / 2.0!)), ef2.Width, ef2.Height)
                    Dim offForeColor As Color = MyBase.ToggleSwitch.OffForeColor
                    If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
                        offForeColor = offForeColor.ToGrayScale()
                    End If
                    Using brush As Brush = New SolidBrush(offForeColor)
                        g.DrawString(MyBase.ToggleSwitch.OffText, MyBase.ToggleSwitch.OffFont, brush, layoutRectangle)
                    End Using
                End If
            End If
            g.ResetClip()
        End Using
    End Sub


    ' Properties
    Public Property BackColor1 As Color
    Public Property BackColor2 As Color
    Public Property BorderColor1 As Color
    Public Property BorderColor2 As Color
    Public Property ButtonHoverBorderColor As Color
    Public Property ButtonHoverSurfaceColor As Color
    Public Property ButtonNormalBorderColor As Color
    Public Property ButtonNormalSurfaceColor As Color
    Public Property ButtonPressedBorderColor As Color
    Public Property ButtonPressedSurfaceColor As Color
    Public Property UpperShadowColor1 As Color
    Public Property UpperShadowColor2 As Color
    Public Property UpperShadowHeight As Integer
End Class
