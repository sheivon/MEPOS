Imports System
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports GUIHelper
Imports GUIHelper.ToggleSwitch

Public Class ToggleSwitchMetroRenderer
    Inherits ToggleSwitchRendererBase
    ' Methods
    Public Sub New()
        Me.BackColor = Color.White
        Me.LeftSideColor = Color.FromArgb(&HFF, &H17, &H99, 0)
        Me.LeftSideColorHovered = Color.FromArgb(&HFF, &H24, &HB6, 9)
        Me.LeftSideColorPressed = Color.FromArgb(&HFF, &H79, &HF5, 100)
        Me.RightSideColor = Color.FromArgb(&HFF, &HA6, &HA6, &HA6)
        Me.RightSideColorHovered = Color.FromArgb(&HFF, &HB5, &HB5, &HB5)
        Me.RightSideColorPressed = Color.FromArgb(&HFF, &HBD, &HBD, &HBD)
        Me.BorderColor = Color.FromArgb(&HFF, &HA6, &HA6, &HA6)
        Me.ButtonColor = Color.Black
        Me.ButtonColorHovered = Color.Black
        Me.ButtonColorPressed = Color.Black
    End Sub

    Public Overrides Function GetButtonRectangle() As Rectangle
        Dim buttonWidth As Integer = Me.GetButtonWidth
        Return Me.GetButtonRectangle(buttonWidth)
    End Function

    Public Overrides Function GetButtonRectangle(ByVal buttonWidth As Integer) As Rectangle
        Return New Rectangle(MyBase.ToggleSwitch.ButtonValue, 0, buttonWidth, MyBase.ToggleSwitch.Height)
    End Function

    Public Overrides Function GetButtonWidth() As Integer
        Return CInt(((CDbl(MyBase.ToggleSwitch.Height) / 3) * 2))
    End Function

    Public Overrides Sub RenderBorder(ByVal g As Graphics, ByVal borderRectangle As Rectangle)
        Dim color As Color = If((MyBase.ToggleSwitch.Enabled OrElse Not MyBase.ToggleSwitch.GrayWhenDisabled), Me.BorderColor, Me.BorderColor.ToGrayScale())
        g.SetClip(borderRectangle)
        Using pen As Pen = New Pen(color)
            g.DrawRectangle(pen, borderRectangle.X, borderRectangle.Y, (borderRectangle.Width - 1), (borderRectangle.Height - 1))
        End Using
        g.ResetClip()
    End Sub

    Public Overrides Sub RenderButton(ByVal g As Graphics, ByVal buttonRectangle As Rectangle)
        Dim buttonColor As Color = Me.ButtonColor
        If MyBase.ToggleSwitch.IsButtonPressed Then
            buttonColor = Me.ButtonColorPressed
        ElseIf MyBase.ToggleSwitch.IsButtonHovered Then
            buttonColor = Me.ButtonColorHovered
        End If
        If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
            buttonColor = buttonColor.ToGrayScale()
        End If
        g.SetClip(buttonRectangle)
        Using brush As Brush = New SolidBrush(buttonColor)
            g.FillRectangle(brush, buttonRectangle)
        End Using
        g.ResetClip()
    End Sub

    Public Overrides Sub RenderLeftToggleField(ByVal g As Graphics, ByVal leftRectangle As Rectangle, ByVal totalToggleFieldWidth As Integer)
        Dim rect As New Rectangle((leftRectangle.X + 2), 2, (leftRectangle.Width - 2), (leftRectangle.Height - 4))
        If (rect.Width > 0) Then
            Dim leftSideColor As Color = Me.LeftSideColor
            If MyBase.ToggleSwitch.IsLeftSidePressed Then
                leftSideColor = Me.LeftSideColorPressed
            ElseIf MyBase.ToggleSwitch.IsLeftSideHovered Then
                leftSideColor = Me.LeftSideColorHovered
            End If
            If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
                leftSideColor = leftSideColor.ToGrayScale()
            End If
            g.SetClip(rect)
            Using brush As Brush = New SolidBrush(leftSideColor)
                g.FillRectangle(brush, rect)
            End Using
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
                    Using brush2 As Brush = New SolidBrush(onForeColor)
                        g.DrawString(MyBase.ToggleSwitch.OnText, MyBase.ToggleSwitch.OnFont, brush2, layoutRectangle)
                    End Using
                End If
            End If
            g.ResetClip()
        End If
    End Sub

    Public Overrides Sub RenderRightToggleField(ByVal g As Graphics, ByVal rightRectangle As Rectangle, ByVal totalToggleFieldWidth As Integer)
        Dim rect As New Rectangle(rightRectangle.X, 2, (rightRectangle.Width - 2), (rightRectangle.Height - 4))
        If (rect.Width > 0) Then
            Dim rightSideColor As Color = Me.RightSideColor
            If MyBase.ToggleSwitch.IsRightSidePressed Then
                rightSideColor = Me.RightSideColorPressed
            ElseIf MyBase.ToggleSwitch.IsRightSideHovered Then
                rightSideColor = Me.RightSideColorHovered
            End If
            If (Not MyBase.ToggleSwitch.Enabled AndAlso MyBase.ToggleSwitch.GrayWhenDisabled) Then
                rightSideColor = rightSideColor.ToGrayScale()
            End If
            g.SetClip(rect)
            Using brush As Brush = New SolidBrush(rightSideColor)
                g.FillRectangle(brush, rect)
            End Using
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
                    Using brush2 As Brush = New SolidBrush(offForeColor)
                        g.DrawString(MyBase.ToggleSwitch.OffText, MyBase.ToggleSwitch.OffFont, brush2, layoutRectangle)
                    End Using
                End If
            End If
        End If
    End Sub


    ' Properties
    Public Property BackColor As Color 
    Public Property BorderColor As Color 
    Public Property ButtonColor As Color 
    Public Property ButtonColorHovered As Color 
    Public Property ButtonColorPressed As Color 
    Public Property LeftSideColor As Color 
    Public Property LeftSideColorHovered As Color 
    Public Property LeftSideColorPressed As Color 
    Public Property RightSideColor As Color 
    Public Property RightSideColorHovered As Color 
    Public Property RightSideColorPressed As Color 
End Class
