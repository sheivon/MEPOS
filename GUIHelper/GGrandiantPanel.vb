Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System
Imports System.Drawing.Drawing2D

Public Class GGrandiantPanel
    Inherits Panel
    ' Methods
    Enum GPanelStyle
        Gradiant
        Clasic
    End Enum

    Public Sub New()
        DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        MyBase.SetStyle(ControlStyles.DoubleBuffer, True)
        MyBase.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        MyBase.SetStyle(ControlStyles.ResizeRedraw, True)
        MyBase.SetStyle(ControlStyles.UserPaint, True)
        MyBase.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        MyBase.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.InitializeComponent()
    End Sub

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If (disposing AndAlso (Not Me.components Is Nothing)) Then
            Me.components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        Me.components = New Container
    End Sub
    Friend Class A1PanelGlobals
        ' Fields
        Public Const A1Category As String = "G Style"
    End Class
    Friend Class A1PanelGraphics
        ' Methods
        Public Shared Function GetRoundPath(ByVal r As Rectangle, ByVal depth As Integer) As GraphicsPath
            Dim path As New GraphicsPath
            path.AddArc(r.X, r.Y, depth, depth, 180.0!, 90.0!)
            path.AddArc(((r.X + r.Width) - depth), r.Y, depth, depth, 270.0!, 90.0!)
            path.AddArc(((r.X + r.Width) - depth), ((r.Y + r.Height) - depth), depth, depth, 0!, 90.0!)
            path.AddArc(r.X, ((r.Y + r.Height) - depth), depth, depth, 90.0!, 90.0!)
            path.AddLine(CSng(r.X), CSng((r.Y + r.Height) - depth), r.X, CSng(r.Y + (depth / 2)))
            Return path
        End Function

    End Class
    Protected Overrides Sub OnPaintBackground(ByVal e As PaintEventArgs)
        MyBase.OnPaintBackground(e)
        If PanelStyle = GPanelStyle.Gradiant Then
            Dim x As Integer = Math.Min(Math.Min(Me._shadowOffSet, (MyBase.Width - 2)), (MyBase.Height - 2))
            Dim depth As Integer = Math.Min(Math.Min(Me._roundCornerRadius, (MyBase.Width - 2)), (MyBase.Height - 2))
            If ((MyBase.Width > 1) AndAlso (MyBase.Height > 1)) Then
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                Dim r As New Rectangle(0, 0, ((MyBase.Width - x) - 1), ((MyBase.Height - x) - 1))
                Dim rectangle2 As New Rectangle(x, x, ((MyBase.Width - x) - 1), ((MyBase.Height - x) - 1))
                Dim roundPath As GraphicsPath = A1PanelGraphics.GetRoundPath(rectangle2, depth)
                Dim path As GraphicsPath = A1PanelGraphics.GetRoundPath(r, depth)
                If (depth > 0) Then
                    Using brush As PathGradientBrush = New PathGradientBrush(roundPath)
                        brush.WrapMode = WrapMode.Clamp
                        Dim blend As New ColorBlend(3)
                        blend.Colors = New Color() {Color.Transparent, Color.FromArgb(180, Color.DimGray), Color.FromArgb(180, Color.Transparent)}
                        Dim numArray As Single() = New Single(3 - 1) {}
                        numArray(1) = 0.1!
                        numArray(2) = 1.0!
                        blend.Positions = numArray
                        brush.InterpolationColors = blend
                        e.Graphics.FillPath(brush, roundPath)
                    End Using
                End If
                Dim brush2 As New LinearGradientBrush(r, Me._gradientStartColor, Me._gradientEndColor, LinearGradientMode.Horizontal, True)
                e.Graphics.FillPath(brush2, path)
                e.Graphics.DrawPath(New Pen(Color.FromArgb(180, Me._borderColor), CSng(Me._borderWidth)), path)
                If (Not Me._image Is Nothing) Then
                    e.Graphics.DrawImageUnscaled(Me._image, Me._imageLocation)
                End If
            End If
        Else
        End If
    End Sub
    ' Properties
    <DefaultValue("Color.Gray"), Browsable(True), Category("G Style")>
    Public Property BorderColor As Color
        Get
            Return Me._borderColor
        End Get
        Set(ByVal value As Color)
            Me._borderColor = value
            MyBase.Invalidate()
        End Set
    End Property

    <Browsable(True), Category("G Style"), DefaultValue(1)>
    Public Property BorderWidth As Integer
        Get
            Return Me._borderWidth
        End Get
        Set(ByVal value As Integer)
            Me._borderWidth = value
            MyBase.Invalidate()
        End Set
    End Property

    <Category("G Style"), Browsable(True), DefaultValue("Color.Gray")>
    Public Property GradientEndColor As Color
        Get
            Return Me._gradientEndColor
        End Get
        Set(ByVal value As Color)
            Me._gradientEndColor = value
            MyBase.Invalidate()
        End Set
    End Property

    <Browsable(True), DefaultValue("Color.White"), Category("G Style")>
    Public Property GradientStartColor As Color
        Get
            Return Me._gradientStartColor
        End Get
        Set(ByVal value As Color)
            Me._gradientStartColor = value
            MyBase.Invalidate()
        End Set
    End Property

    <Category("G Style"), Browsable(True)>
    Public Property Image As Image
        Get
            Return Me._image
        End Get
        Set(ByVal value As Image)
            Me._image = value
            MyBase.Invalidate()
        End Set
    End Property
    <Category("G Style"), Browsable(True), DefaultValue("Gradiant")>
    Public Property PanelStyle As GPanelStyle
        Get
            Return Me._Panel
        End Get
        Set(value As GPanelStyle)
            Me._Panel = value
            MyBase.Invalidate()
        End Set
    End Property


    <Browsable(True), Category("G Style"), DefaultValue("4,4")>
    Public Property ImageLocation As Point
        Get
            Return Me._imageLocation
        End Get
        Set(ByVal value As Point)
            Me._imageLocation = value
            MyBase.Invalidate()
        End Set
    End Property

    <DefaultValue(4), Browsable(True), Category("G Style")>
    Public Property RoundCornerRadius As Integer
        Get
            Return Me._roundCornerRadius
        End Get
        Set(ByVal value As Integer)
            Me._roundCornerRadius = Math.Abs(value)
            MyBase.Invalidate()
        End Set
    End Property

    <Browsable(True), Category("G Style"), DefaultValue(5)>
    Public Property ShadowOffSet As Integer
        Get
            Return Me._shadowOffSet
        End Get
        Set(ByVal value As Integer)
            Me._shadowOffSet = Math.Abs(value)
            MyBase.Invalidate()
        End Set
    End Property


    ' Fields
    Private _Panel As GPanelStyle = GPanelStyle.Gradiant
    Private _borderColor As Color = Color.Gray
    Private _borderWidth As Integer = 1
    Private _gradientEndColor As Color = Color.Gray
    Private _gradientStartColor As Color = Color.White
    Private _image As Image
    Private _imageLocation As Point = New Point(4, 4)
    Private _roundCornerRadius As Integer = 5
    Private _shadowOffSet As Integer = 5
    Private components As IContainer = Nothing
    Private _Direction As LinearGradientMode = LinearGradientMode.Vertical
End Class