Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Imports GUIHelper.ToggleSwitch

Public MustInherit Class ToggleSwitchRendererBase
    ' Methods
    Protected Sub New()
    End Sub

    Public Sub FillBackground(ByVal g As Graphics, ByVal controlRectangle As Rectangle)
        Dim color As Color = If((Me.ToggleSwitch.Enabled OrElse Not Me.ToggleSwitch.GrayWhenDisabled), Me.ToggleSwitch.BackColor, Me.ToggleSwitch.BackColor.ToGrayScale())
        Using brush As Brush = New SolidBrush(color)
            g.FillRectangle(brush, controlRectangle)
        End Using
    End Sub

    Public MustOverride Function GetButtonRectangle() As Rectangle

    Public MustOverride Function GetButtonRectangle(ByVal buttonWidth As Integer) As Rectangle

    Public MustOverride Function GetButtonWidth() As Integer

    Public Sub RenderBackground(ByVal e As PaintEventArgs)
        If (Not Me._toggleSwitch Is Nothing) Then
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            Dim controlRectangle As New Rectangle(0, 0, Me._toggleSwitch.Width, Me._toggleSwitch.Height)
            Me.FillBackground(e.Graphics, controlRectangle)
            Me.RenderBorder(e.Graphics, controlRectangle)
        End If
    End Sub

    Public MustOverride Sub RenderBorder(ByVal g As Graphics, ByVal borderRectangle As Rectangle)

    Public MustOverride Sub RenderButton(ByVal g As Graphics, ByVal buttonRectangle As Rectangle)

    Public Sub RenderControl(ByVal e As PaintEventArgs)
        If (Not Me._toggleSwitch Is Nothing) Then
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            Dim buttonRectangle As Rectangle = Me.GetButtonRectangle
            Dim totalToggleFieldWidth As Integer = (Me.ToggleSwitch.Width - buttonRectangle.Width)
            If (buttonRectangle.X > 0) Then
                Dim leftRectangle As New Rectangle(0, 0, buttonRectangle.X, Me.ToggleSwitch.Height)
                If (leftRectangle.Width > 0) Then
                    Me.RenderLeftToggleField(e.Graphics, leftRectangle, totalToggleFieldWidth)
                End If
            End If
            If ((buttonRectangle.X + buttonRectangle.Width) < e.ClipRectangle.Width) Then
                Dim rightRectangle As New Rectangle((buttonRectangle.X + buttonRectangle.Width), 0, ((Me.ToggleSwitch.Width - buttonRectangle.X) - buttonRectangle.Width), Me.ToggleSwitch.Height)
                If (rightRectangle.Width > 0) Then
                    Me.RenderRightToggleField(e.Graphics, rightRectangle, totalToggleFieldWidth)
                End If
            End If
            Me.RenderButton(e.Graphics, buttonRectangle)
        End If
    End Sub

    Public MustOverride Sub RenderLeftToggleField(ByVal g As Graphics, ByVal leftRectangle As Rectangle, ByVal totalToggleFieldWidth As Integer)

    Public MustOverride Sub RenderRightToggleField(ByVal g As Graphics, ByVal rightRectangle As Rectangle, ByVal totalToggleFieldWidth As Integer)

    Friend Sub SetToggleSwitch(ByVal toggleSwitch As ToggleSwitch)
        Me._toggleSwitch = toggleSwitch
    End Sub


    ' Properties
    Friend ReadOnly Property ToggleSwitch As ToggleSwitch
        Get
            Return Me._toggleSwitch
        End Get
    End Property


    ' Fields
    Private _toggleSwitch As ToggleSwitch
End Class
