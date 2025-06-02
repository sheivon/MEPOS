Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports GUIHelper.ToggleSwitch

Public Class ToggleSwitchIOS5Renderer

    Inherits ToggleSwitchRendererBase
    ' Methods
    Public Sub New()
        Me.BorderColor = Color.FromArgb(&HFF, &HCA, &HCA, &HCA)
        Me.LeftSideUpperColor1 = Color.FromArgb(&HFF, &H30, &H73, &HBD)
        Me.LeftSideUpperColor2 = Color.FromArgb(&HFF, &H11, &H7B, 220)
        Me.LeftSideLowerColor1 = Color.FromArgb(&HFF, &H41, &H8F, &HDA)
        Me.LeftSideLowerColor2 = Color.FromArgb(&HFF, 130, 190, &HF3)
        Me.LeftSideUpperBorderColor = Color.FromArgb(150, &H7B, &H9D, &HC4)
        Me.LeftSideLowerBorderColor = Color.FromArgb(150, &HAE, &HD0, &HF1)
        Me.RightSideUpperColor1 = Color.FromArgb(&HFF, &HBF, &HBF, &HBF)
        Me.RightSideUpperColor2 = Color.FromArgb(&HFF, &HE5, &HE5, &HE5)
        Me.RightSideLowerColor1 = Color.FromArgb(&HFF, &HE8, &HE8, &HE8)
        Me.RightSideLowerColor2 = Color.FromArgb(&HFF, &HFB, &HFB, &HFB)
        Me.RightSideUpperBorderColor = Color.FromArgb(150, &HAF, &HAF, &HAF)
        Me.RightSideLowerBorderColor = Color.FromArgb(150, &HE5, 230, &HE9)
        Me.ButtonShadowColor = Color.Transparent
        Me.ButtonNormalOuterBorderColor = Color.FromArgb(&HFF, &H95, &HAC, &HC2)
        Me.ButtonNormalInnerBorderColor = Color.FromArgb(&HFF, &HEB, &HEB, &HEB)
        Me.ButtonNormalSurfaceColor1 = Color.FromArgb(&HFF, &HD8, &HD7, &HD8)
        Me.ButtonNormalSurfaceColor2 = Color.FromArgb(&HFF, &HFB, 250, &HFB)
        Me.ButtonHoverOuterBorderColor = Color.FromArgb(&HFF, &H8D, &HA3, &HB8)
        Me.ButtonHoverInnerBorderColor = Color.FromArgb(&HFF, &HDF, &HDF, &HDF)
        Me.ButtonHoverSurfaceColor1 = Color.FromArgb(&HFF, &HCD, &HCC, &HCD)
        Me.ButtonHoverSurfaceColor2 = Color.FromArgb(&HFF, &HEF, &HEE, &HEF)
        Me.ButtonPressedOuterBorderColor = Color.FromArgb(&HFF, &H6F, &H80, &H91)
        Me.ButtonPressedInnerBorderColor = Color.FromArgb(&HFF, &HB0, &HB0, &HB0)
        Me.ButtonPressedSurfaceColor1 = Color.FromArgb(&HFF, &HA2, &HA1, &HA2)
        Me.ButtonPressedSurfaceColor2 = Color.FromArgb(&HFF, &HBB, &HBB, &HBB)
    End Sub

    Public Function GetButtonClipPath() As GraphicsPath
        Dim buttonRectangle As Rectangle = Me.GetButtonRectangle
        Dim path As New GraphicsPath
        path.AddArc(buttonRectangle.X, buttonRectangle.Y, buttonRectangle.Height, buttonRectangle.Height, 0!, 360.0!)
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

    Public Function GetControlClipPath(ByVal controlRectangle As Rectangle) As GraphicsPath
        Dim path As New GraphicsPath
        path.AddArc(controlRectangle.X, controlRectangle.Y, controlRectangle.Height, controlRectangle.Height, 90.0!, 180.0!)
        path.AddArc((controlRectangle.Width - controlRectangle.Height), controlRectangle.Y, controlRectangle.Height, controlRectangle.Height, 270.0!, 180.0!)
        path.CloseFigure
        Return path
    End Function

    Public Overrides Sub RenderBorder(ByVal g As Graphics, ByVal borderRectangle As Rectangle)
    End Sub

    Public Overrides Sub RenderButton(ByVal g As Graphics, ByVal buttonRectangle As Rectangle)
        Dim rectangle3 As Rectangle
        If MyBase.ToggleSwitch.IsButtonOnLeftSide Then
            buttonRectangle.X += 1
        ElseIf MyBase.ToggleSwitch.IsButtonOnRightSide Then
            buttonRectangle.X -= 1
        End If
        g.SmoothingMode = SmoothingMode.HighQuality
        g.PixelOffsetMode = PixelOffsetMode.HighQuality
        buttonRectangle.Inflate(1, 1)
        Dim rect As New Rectangle(buttonRectangle.Location, buttonRectangle.Size)
        rect.Inflate(0, -1)
        If MyBase.ToggleSwitch.IsButtonOnLeftSide Then
            rect.X = (rect.X + (rect.Width / 2))
            rect.Width = (rect.Width / 2)
        ElseIf MyBase.ToggleSwitch.IsButtonOnRightSide Then
            rect.Width = (rect.Width / 2)
        End If
        g.SetClip(rect)
        Dim color As Color = If((MyBase.ToggleSwitch.Enabled OrElse Not MyBase.ToggleSwitch.GrayWhenDisabled), Me.ButtonShadowColor, Me.ButtonShadowColor.ToGrayScale())
        Using pen As Pen = New Pen(color)
            g.DrawEllipse(pen, buttonRectangle)
        End Using
        g.ResetClip
        buttonRectangle.Inflate(-1, -1)
        Dim buttonNormalOuterBorderColor As Color = Me.ButtonNormalOuterBorderColor
        If MyBase.ToggleSwitch.IsButtonPressed Then
            buttonNormalOuterBorderColor = Me.ButtonPressedOuterBorderColor
        ElseIf MyBase.ToggleSwitch.IsButtonHovered Then
            buttonNormalOuterBorderColor = Me.ButtonHoverOuterBorderColor
        End If
        If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
            buttonNormalOuterBorderColor = buttonNormalOuterBorderColor.ToGrayScale()
        End If
        Using brush As Brush = New SolidBrush(buttonNormalOuterBorderColor)
            g.FillEllipse(brush, buttonRectangle)
        End Using
        buttonRectangle.Inflate(-1, -1)
        Dim buttonNormalInnerBorderColor As Color = Me.ButtonNormalInnerBorderColor
        If MyBase.ToggleSwitch.IsButtonPressed Then
            buttonNormalInnerBorderColor = Me.ButtonPressedInnerBorderColor
        ElseIf MyBase.ToggleSwitch.IsButtonHovered Then
            buttonNormalInnerBorderColor = Me.ButtonHoverInnerBorderColor
        End If
        If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
            buttonNormalInnerBorderColor = buttonNormalInnerBorderColor.ToGrayScale()
        End If
        Using brush2 As Brush = New SolidBrush(buttonNormalInnerBorderColor)
            g.FillEllipse(brush2, buttonRectangle)
        End Using
        buttonRectangle.Inflate(-1, -1)
        Dim originalColor As Color = Me.ButtonNormalSurfaceColor1
        If MyBase.ToggleSwitch.IsButtonPressed Then
            originalColor = Me.ButtonPressedSurfaceColor1
        ElseIf MyBase.ToggleSwitch.IsButtonHovered Then
            originalColor = Me.ButtonHoverSurfaceColor1
        End If
        If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
            originalColor = originalColor.ToGrayScale()
        End If
        Dim color5 As Color = Me.ButtonNormalSurfaceColor2
        If MyBase.ToggleSwitch.IsButtonPressed Then
            color5 = Me.ButtonPressedSurfaceColor2
        ElseIf MyBase.ToggleSwitch.IsButtonHovered Then
            color5 = Me.ButtonHoverSurfaceColor2
        End If
        If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
            color5 = color5.ToGrayScale()
        End If
        Using brush3 As Brush = New LinearGradientBrush(buttonRectangle, originalColor, color5, LinearGradientMode.Vertical)
            g.FillEllipse(brush3, buttonRectangle)
        End Using
        g.CompositingMode = CompositingMode.SourceOver
        g.CompositingQuality = CompositingQuality.HighQuality
        Dim controlRectangle As New Rectangle(0, 0, MyBase.ToggleSwitch.Width, MyBase.ToggleSwitch.Height)
        Using path As GraphicsPath = Me.GetControlClipPath(controlRectangle)
            Dim color6 As Color = If((MyBase.ToggleSwitch.Enabled OrElse Not MyBase.ToggleSwitch.GrayWhenDisabled), Me.BorderColor, Me.BorderColor.ToGrayScale())
            Using pen2 As Pen = New Pen(color6)
                g.DrawPath(pen2, path)
            End Using
        End Using
        g.ResetClip
        Dim image As Image = If(MyBase.ToggleSwitch.ButtonImage IsNot Nothing, MyBase.ToggleSwitch.ButtonImage, If(MyBase.ToggleSwitch.Checked, MyBase.ToggleSwitch.OnButtonImage, MyBase.ToggleSwitch.OffButtonImage))
        If (image Is Nothing) Then
            Return
        End If
        g.SetClip(Me.GetButtonClipPath)
        Dim alignment As ToggleSwitchButtonAlignment = If((Not MyBase.ToggleSwitch.ButtonImage Is Nothing), MyBase.ToggleSwitch.ButtonAlignment, If(MyBase.ToggleSwitch.Checked, MyBase.ToggleSwitch.OnButtonAlignment, MyBase.ToggleSwitch.OffButtonAlignment))
        Dim imageSize As Size = image.Size
        Dim x As Integer = buttonRectangle.X
        If Not If((Not MyBase.ToggleSwitch.ButtonImage Is Nothing), MyBase.ToggleSwitch.ButtonScaleImageToFit, If(MyBase.ToggleSwitch.Checked, MyBase.ToggleSwitch.OnButtonScaleImageToFit, MyBase.ToggleSwitch.OffButtonScaleImageToFit)) Then
            Select Case alignment
                Case ToggleSwitchButtonAlignment.Center
                    x = (buttonRectangle.X + CInt(((buttonRectangle.Width - imageSize.Width) / 2.0!)))
                    Exit Select
                Case ToggleSwitchButtonAlignment.Right
                    x = ((buttonRectangle.X + buttonRectangle.Width) - imageSize.Width)
                    Exit Select
            End Select
        Else
            Dim size As Size = buttonRectangle.Size
            Dim size3 As Size = ImageHelper.RescaleImageToFit(imageSize, size)
            Select Case alignment
                Case ToggleSwitchButtonAlignment.Center
                    x = (buttonRectangle.X + CInt(((buttonRectangle.Width - size3.Width) / 2.0!)))
                    Exit Select
                Case ToggleSwitchButtonAlignment.Right
                    x = ((buttonRectangle.X + buttonRectangle.Width) - size3.Width)
                    Exit Select
            End Select
            rectangle3 = New Rectangle(x, (buttonRectangle.Y + CInt(((buttonRectangle.Height - size3.Height) / 2.0!))), size3.Width, size3.Height)
            If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
                g.DrawImage(image, rectangle3, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes)
            Else
                g.DrawImage(image, rectangle3)
            End If
            GoTo Label_0618
        End If
        rectangle3 = New Rectangle(x, (buttonRectangle.Y + CInt(((buttonRectangle.Height - imageSize.Height) / 2.0!))), imageSize.Width, imageSize.Height)
        If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
            g.DrawImage(image, rectangle3, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes)
        Else
            g.DrawImageUnscaled(image, rectangle3)
        End If
Label_0618:
        g.ResetClip
    End Sub

    Public Overrides Sub RenderLeftToggleField(ByVal g As Graphics, ByVal leftRectangle As Rectangle, ByVal totalToggleFieldWidth As Integer)
        g.SmoothingMode = SmoothingMode.HighQuality
        g.PixelOffsetMode = PixelOffsetMode.HighQuality
        Dim buttonWidth As Integer = Me.GetButtonWidth
        Dim width As Integer = (leftRectangle.Width + (buttonWidth / 2))
        Dim num3 As Integer = CInt((0.8 * (leftRectangle.Height - 2)))
        Dim controlRectangle As New Rectangle(0, 0, MyBase.ToggleSwitch.Width, MyBase.ToggleSwitch.Height)
        Dim controlClipPath As GraphicsPath = Me.GetControlClipPath(controlRectangle)
        Dim rect As New Rectangle(leftRectangle.X, (leftRectangle.Y + 1), width, (num3 - 1))
        g.SetClip(controlClipPath)
        g.IntersectClip(rect)
        Using path2 As GraphicsPath = New GraphicsPath
            path2.AddArc(rect.X, rect.Y, MyBase.ToggleSwitch.Height, MyBase.ToggleSwitch.Height, 135.0!, 135.0!)
            path2.AddLine(rect.X, rect.Y, (rect.X + rect.Width), rect.Y)
            path2.AddLine((rect.X + rect.Width), rect.Y, (rect.X + rect.Width), (rect.Y + rect.Height))
            path2.AddLine(rect.X, (rect.Y + rect.Height), (rect.X + rect.Width), (rect.Y + rect.Height))
            Dim color As Color = If((MyBase.ToggleSwitch.Enabled OrElse Not MyBase.ToggleSwitch.GrayWhenDisabled), Me.LeftSideUpperColor1, Me.LeftSideUpperColor1.ToGrayScale())
            Dim color2 As Color = If((MyBase.ToggleSwitch.Enabled OrElse Not MyBase.ToggleSwitch.GrayWhenDisabled), Me.LeftSideUpperColor2, Me.LeftSideUpperColor2.ToGrayScale())
            Using brush As Brush = New LinearGradientBrush(rect, color, color2, LinearGradientMode.Vertical)
                g.FillPath(brush, path2)
            End Using
        End Using
        g.ResetClip
        Dim height As Integer = CInt(Math.Ceiling(CDbl((0.5 * (leftRectangle.Height - 2)))))
        Dim rectangle3 As New Rectangle(leftRectangle.X, (leftRectangle.Y + (leftRectangle.Height / 2)), width, height)
        g.SetClip(controlClipPath)
        g.IntersectClip(rectangle3)
        Using path3 As GraphicsPath = New GraphicsPath
            path3.AddArc(1, rectangle3.Y, CInt((0.75 * (MyBase.ToggleSwitch.Height - 1))), (MyBase.ToggleSwitch.Height - 1), 215.0!, 45.0!)
            path3.AddLine(CInt(rectangle3.X + (buttonWidth / 2)), rectangle3.Y, (rectangle3.X + rectangle3.Width), rectangle3.Y)
            path3.AddLine((rectangle3.X + rectangle3.Width), rectangle3.Y, (rectangle3.X + rectangle3.Width), (rectangle3.Y + rectangle3.Height))
            path3.AddLine(CInt((rectangle3.X + (buttonWidth / 4))), CInt((rectangle3.Y + rectangle3.Height)), CInt((rectangle3.X + rectangle3.Width)), CInt((rectangle3.Y + rectangle3.Height)))
            path3.AddArc(1, 1, (MyBase.ToggleSwitch.Height - 1), (MyBase.ToggleSwitch.Height - 1), 90.0!, 70.0!)
            Dim color3 As Color = If((MyBase.ToggleSwitch.Enabled OrElse Not MyBase.ToggleSwitch.GrayWhenDisabled), Me.LeftSideLowerColor1, Me.LeftSideLowerColor1.ToGrayScale())
            Dim color4 As Color = If((MyBase.ToggleSwitch.Enabled OrElse Not MyBase.ToggleSwitch.GrayWhenDisabled), Me.LeftSideLowerColor2, Me.LeftSideLowerColor2.ToGrayScale())
            Using brush2 As Brush = New LinearGradientBrush(rectangle3, color3, color4, LinearGradientMode.Vertical)
                g.FillPath(brush2, path3)
            End Using
        End Using
        g.ResetClip
        controlRectangle = New Rectangle(0, 0, MyBase.ToggleSwitch.Width, MyBase.ToggleSwitch.Height)
        controlClipPath = Me.GetControlClipPath(controlRectangle)
        g.SetClip(controlClipPath)
        Dim leftSideUpperBorderColor As Color = Me.LeftSideUpperBorderColor
        If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
            leftSideUpperBorderColor = leftSideUpperBorderColor.ToGrayScale()
        End If
        Using pen As Pen = New Pen(leftSideUpperBorderColor)
            g.DrawLine(pen, leftRectangle.X, CSng(leftRectangle.Y + 1), CSng((leftRectangle.X + leftRectangle.Width) + (buttonWidth / 2)), (leftRectangle.Y + 1))
        End Using
        Dim leftSideLowerBorderColor As Color = Me.LeftSideLowerBorderColor
        If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
            leftSideLowerBorderColor = leftSideLowerBorderColor.ToGrayScale()
        End If
        Using pen2 As Pen = New Pen(leftSideLowerBorderColor)
            g.DrawLine(pen2, CSng(leftRectangle.X), CSng((leftRectangle.Y + leftRectangle.Height) - 1), CSng((leftRectangle.X + leftRectangle.Width) + (buttonWidth / 2)), ((leftRectangle.Y + leftRectangle.Height) - 1))
        End Using
        If ((Not MyBase.ToggleSwitch.OnSideImage Is Nothing) OrElse Not String.IsNullOrEmpty(MyBase.ToggleSwitch.OnText)) Then
            Dim ef As New RectangleF(CSng(((leftRectangle.X + 2) - (totalToggleFieldWidth - leftRectangle.Width))), 2.0!, CSng((totalToggleFieldWidth - 2)), CSng((MyBase.ToggleSwitch.Height - 4)))
            g.IntersectClip(ef)
            If (Not MyBase.ToggleSwitch.OnSideImage Is Nothing) Then
                Dim rectangle4 As Rectangle
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
                    rectangle4 = New Rectangle(x, CInt((ef.Y + ((ef.Height - size3.Height) / 2.0!))), size3.Width, size3.Height)
                    If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
                        g.DrawImage(MyBase.ToggleSwitch.OnSideImage, rectangle4, 0, 0, MyBase.ToggleSwitch.OnSideImage.Width, MyBase.ToggleSwitch.OnSideImage.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes)
                    Else
                        g.DrawImage(MyBase.ToggleSwitch.OnSideImage, rectangle4)
                    End If
                Else
                    If (MyBase.ToggleSwitch.OnSideAlignment = ToggleSwitchAlignment.Center) Then
                        x = CInt((ef.X + ((ef.Width - imageSize.Width) / 2.0!)))
                    ElseIf (MyBase.ToggleSwitch.OnSideAlignment = ToggleSwitchAlignment.Near) Then
                        x = (CInt((ef.X + ef.Width)) - imageSize.Width)
                    End If
                    rectangle4 = New Rectangle(x, CInt((ef.Y + ((ef.Height - imageSize.Height) / 2.0!))), imageSize.Width, imageSize.Height)
                    If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
                        g.DrawImage(MyBase.ToggleSwitch.OnSideImage, rectangle4, 0, 0, MyBase.ToggleSwitch.OnSideImage.Width, MyBase.ToggleSwitch.OnSideImage.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes)
                    Else
                        g.DrawImageUnscaled(MyBase.ToggleSwitch.OnSideImage, rectangle4)
                    End If
                End If
            ElseIf Not String.IsNullOrEmpty(MyBase.ToggleSwitch.OnText) Then
                Dim ef2 As SizeF = g.MeasureString(MyBase.ToggleSwitch.OnText, MyBase.ToggleSwitch.OnFont)
                Dim num6 As Single = ef.X
                If (MyBase.ToggleSwitch.OnSideAlignment = ToggleSwitchAlignment.Center) Then
                    num6 = (ef.X + ((ef.Width - ef2.Width) / 2.0!))
                ElseIf (MyBase.ToggleSwitch.OnSideAlignment = ToggleSwitchAlignment.Near) Then
                    num6 = ((ef.X + ef.Width) - ef2.Width)
                End If
                Dim layoutRectangle As New RectangleF(num6, (ef.Y + ((ef.Height - ef2.Height) / 2.0!)), ef2.Width, ef2.Height)
                Dim onForeColor As Color = MyBase.ToggleSwitch.OnForeColor
                If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
                    onForeColor = onForeColor.ToGrayScale()
                End If
                Using brush3 As Brush = New SolidBrush(onForeColor)
                    g.DrawString(MyBase.ToggleSwitch.OnText, MyBase.ToggleSwitch.OnFont, brush3, layoutRectangle)
                End Using
            End If
        End If
        g.ResetClip
    End Sub

    Public Overrides Sub RenderRightToggleField(ByVal g As Graphics, ByVal rightRectangle As Rectangle, ByVal totalToggleFieldWidth As Integer)
        g.SmoothingMode = SmoothingMode.HighQuality
        g.PixelOffsetMode = PixelOffsetMode.HighQuality
        Dim buttonRectangle As Rectangle = Me.GetButtonRectangle
        Dim controlRectangle As New Rectangle(0, 0, MyBase.ToggleSwitch.Width, MyBase.ToggleSwitch.Height)
        Dim controlClipPath As GraphicsPath = Me.GetControlClipPath(controlRectangle)
        Dim num As Integer = (rightRectangle.Width + (buttonRectangle.Width / 2))
        Dim num2 As Integer = CInt((0.8 * (rightRectangle.Height - 2)))
        Dim rect As New Rectangle((rightRectangle.X - (buttonRectangle.Width / 2)), (rightRectangle.Y + 1), (num - 1), (num2 - 1))
        g.SetClip(controlClipPath)
        g.IntersectClip(rect)
        Using path2 As GraphicsPath = New GraphicsPath
            path2.AddLine(rect.X, rect.Y, (rect.X + rect.Width), rect.Y)
            path2.AddArc((((rect.X + rect.Width) - MyBase.ToggleSwitch.Height) + 1), (rect.Y - 1), MyBase.ToggleSwitch.Height, MyBase.ToggleSwitch.Height, 270.0!, 115.0!)
            path2.AddLine((rect.X + rect.Width), (rect.Y + rect.Height), rect.X, (rect.Y + rect.Height))
            path2.AddLine(rect.X, (rect.Y + rect.Height), rect.X, rect.Y)
            Dim color As Color = If((MyBase.ToggleSwitch.Enabled OrElse Not MyBase.ToggleSwitch.GrayWhenDisabled), Me.RightSideUpperColor1, Me.RightSideUpperColor1.ToGrayScale())
            Dim color2 As Color = If((MyBase.ToggleSwitch.Enabled OrElse Not MyBase.ToggleSwitch.GrayWhenDisabled), Me.RightSideUpperColor2, Me.RightSideUpperColor2.ToGrayScale())
            Using brush As Brush = New LinearGradientBrush(rect, color, color2, LinearGradientMode.Vertical)
                g.FillPath(brush, path2)
            End Using
        End Using
        g.ResetClip
        Dim height As Integer = CInt(Math.Ceiling(CDbl((0.5 * (rightRectangle.Height - 2)))))
        Dim rectangle4 As New Rectangle((rightRectangle.X - (buttonRectangle.Width / 2)), (rightRectangle.Y + (rightRectangle.Height / 2)), (num - 1), height)
        g.SetClip(controlClipPath)
        g.IntersectClip(rectangle4)
        Using path3 As GraphicsPath = New GraphicsPath
            path3.AddLine(rectangle4.X, rectangle4.Y, (rectangle4.X + rectangle4.Width), rectangle4.Y)
            path3.AddArc(((rectangle4.X + rectangle4.Width) - CInt((0.75 * (MyBase.ToggleSwitch.Height - 1)))), rectangle4.Y, CInt((0.75 * (MyBase.ToggleSwitch.Height - 1))), (MyBase.ToggleSwitch.Height - 1), 270.0!, 45.0!)
            path3.AddArc((MyBase.ToggleSwitch.Width - MyBase.ToggleSwitch.Height), 0, MyBase.ToggleSwitch.Height, MyBase.ToggleSwitch.Height, 20.0!, 70.0!)
            path3.AddLine((rectangle4.X + rectangle4.Width), (rectangle4.Y + rectangle4.Height), rectangle4.X, (rectangle4.Y + rectangle4.Height))
            path3.AddLine(rectangle4.X, (rectangle4.Y + rectangle4.Height), rectangle4.X, rectangle4.Y)
            Dim color3 As Color = If((MyBase.ToggleSwitch.Enabled OrElse Not MyBase.ToggleSwitch.GrayWhenDisabled), Me.RightSideLowerColor1, Me.RightSideLowerColor1.ToGrayScale())
            Dim color4 As Color = If((MyBase.ToggleSwitch.Enabled OrElse Not MyBase.ToggleSwitch.GrayWhenDisabled), Me.RightSideLowerColor2, Me.RightSideLowerColor2.ToGrayScale())
            Using brush2 As Brush = New LinearGradientBrush(rectangle4, color3, color4, LinearGradientMode.Vertical)
                g.FillPath(brush2, path3)
            End Using
        End Using
        g.ResetClip
        controlRectangle = New Rectangle(0, 0, MyBase.ToggleSwitch.Width, MyBase.ToggleSwitch.Height)
        controlClipPath = Me.GetControlClipPath(controlRectangle)
        g.SetClip(controlClipPath)
        Dim rightSideUpperBorderColor As Color = Me.RightSideUpperBorderColor
        If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
            rightSideUpperBorderColor = rightSideUpperBorderColor.ToGrayScale()
        End If
        Using pen As Pen = New Pen(rightSideUpperBorderColor)
            g.DrawLine(pen, CInt((rightRectangle.X - (buttonRectangle.Width / 2))), CInt((rightRectangle.Y + 1)), CInt((rightRectangle.X + rightRectangle.Width)), CInt((rightRectangle.Y + 1)))
        End Using
        Dim rightSideLowerBorderColor As Color = Me.RightSideLowerBorderColor
        If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
            rightSideLowerBorderColor = rightSideLowerBorderColor.ToGrayScale()
        End If
        Using pen2 As Pen = New Pen(rightSideLowerBorderColor)
            g.DrawLine(pen2, CInt((rightRectangle.X - (buttonRectangle.Width / 2))), CInt(((rightRectangle.Y + rightRectangle.Height) - 1)), CInt((rightRectangle.X + rightRectangle.Width)), CInt(((rightRectangle.Y + rightRectangle.Height) - 1)))
        End Using
        If ((Not MyBase.ToggleSwitch.OffSideImage Is Nothing) OrElse Not String.IsNullOrEmpty(MyBase.ToggleSwitch.OffText)) Then
            Dim ef As New RectangleF(CSng(rightRectangle.X), 2.0!, CSng((totalToggleFieldWidth - 2)), CSng((MyBase.ToggleSwitch.Height - 4)))
            g.IntersectClip(ef)
            If (Not MyBase.ToggleSwitch.OffSideImage Is Nothing) Then
                Dim rectangle5 As Rectangle
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
                    rectangle5 = New Rectangle(x, CInt((ef.Y + ((ef.Height - size3.Height) / 2.0!))), size3.Width, size3.Height)
                    If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
                        g.DrawImage(MyBase.ToggleSwitch.OnSideImage, rectangle5, 0, 0, MyBase.ToggleSwitch.OnSideImage.Width, MyBase.ToggleSwitch.OnSideImage.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes)
                    Else
                        g.DrawImage(MyBase.ToggleSwitch.OnSideImage, rectangle5)
                    End If
                Else
                    If (MyBase.ToggleSwitch.OffSideAlignment = ToggleSwitchAlignment.Center) Then
                        x = CInt((ef.X + ((ef.Width - imageSize.Width) / 2.0!)))
                    ElseIf (MyBase.ToggleSwitch.OffSideAlignment = ToggleSwitchAlignment.Far) Then
                        x = (CInt((ef.X + ef.Width)) - imageSize.Width)
                    End If
                    rectangle5 = New Rectangle(x, CInt((ef.Y + ((ef.Height - imageSize.Height) / 2.0!))), imageSize.Width, imageSize.Height)
                    If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
                        g.DrawImage(MyBase.ToggleSwitch.OnSideImage, rectangle5, 0, 0, MyBase.ToggleSwitch.OnSideImage.Width, MyBase.ToggleSwitch.OnSideImage.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes)
                    Else
                        g.DrawImageUnscaled(MyBase.ToggleSwitch.OffSideImage, rectangle5)
                    End If
                End If
            ElseIf Not String.IsNullOrEmpty(MyBase.ToggleSwitch.OffText) Then
                Dim ef2 As SizeF = g.MeasureString(MyBase.ToggleSwitch.OffText, MyBase.ToggleSwitch.OffFont)
                Dim num5 As Single = ef.X
                If (MyBase.ToggleSwitch.OffSideAlignment = ToggleSwitchAlignment.Center) Then
                    num5 = (ef.X + ((ef.Width - ef2.Width) / 2.0!))
                ElseIf (MyBase.ToggleSwitch.OffSideAlignment = ToggleSwitchAlignment.Far) Then
                    num5 = ((ef.X + ef.Width) - ef2.Width)
                End If
                Dim layoutRectangle As New RectangleF(num5, (ef.Y + ((ef.Height - ef2.Height) / 2.0!)), ef2.Width, ef2.Height)
                Dim offForeColor As Color = MyBase.ToggleSwitch.OffForeColor
                If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
                    offForeColor = offForeColor.ToGrayScale()
                End If
                Using brush3 As Brush = New SolidBrush(offForeColor)
                    g.DrawString(MyBase.ToggleSwitch.OffText, MyBase.ToggleSwitch.OffFont, brush3, layoutRectangle)
                End Using
            End If
        End If
        g.ResetClip
    End Sub

    ' Properties
    Public Property BorderColor As Color
    Public Property ButtonHoverInnerBorderColor As Color
    Public Property ButtonHoverOuterBorderColor As Color
    Public Property ButtonHoverSurfaceColor1 As Color
    Public Property ButtonHoverSurfaceColor2 As Color
    Public Property ButtonNormalInnerBorderColor As Color
    Public Property ButtonNormalOuterBorderColor As Color
    Public Property ButtonNormalSurfaceColor1 As Color
    Public Property ButtonNormalSurfaceColor2 As Color
    Public Property ButtonPressedInnerBorderColor As Color
    Public Property ButtonPressedOuterBorderColor As Color
    Public Property ButtonPressedSurfaceColor1 As Color
    Public Property ButtonPressedSurfaceColor2 As Color
    Public Property ButtonShadowColor As Color
    Public Property LeftSideLowerBorderColor As Color
    Public Property LeftSideLowerColor1 As Color
    Public Property LeftSideLowerColor2 As Color
    Public Property LeftSideUpperBorderColor As Color
    Public Property LeftSideUpperColor1 As Color
    Public Property LeftSideUpperColor2 As Color
    Public Property RightSideLowerBorderColor As Color
    Public Property RightSideLowerColor1 As Color
    Public Property RightSideLowerColor2 As Color
    Public Property RightSideUpperBorderColor As Color
    Public Property RightSideUpperColor1 As Color
    Public Property RightSideUpperColor2 As Color
End Class
