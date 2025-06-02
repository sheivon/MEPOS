Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

<DefaultValue("Checked"), DefaultEvent("CheckedChanged"), ToolboxBitmap(GetType(CheckBox))> _
Public Class ToggleSwitch
    Inherits Control
    ' Events
    <Description("Raised when the Switch has changed state")>
    Public Event CheckedChanged As CheckedChangedDelegate

    ' Methods
    Public Sub New()
        MyBase.SetStyle((ControlStyles.OptimizedDoubleBuffer Or (ControlStyles.DoubleBuffer Or (ControlStyles.AllPaintingInWmPaint Or (ControlStyles.SupportsTransparentBackColor Or (ControlStyles.ResizeRedraw Or ControlStyles.UserPaint))))), True)
        Me.OnFont = MyBase.Font
        Me.OffFont = MyBase.Font
        Me.SetRenderer(New ToggleSwitchBrushedMetalRenderer)
        Me._animationTimer.Enabled = False
        Me._animationTimer.Interval = Me._animationInterval
        AddHandler Me._animationTimer.Tick, New EventHandler(AddressOf Me.AnimationTimer_Tick)
    End Sub

    Private Sub AnimationComplete()
        Me._animating = False
        Me._moving = False
        Me._checked = Me._animationResult
        Me._isButtonHovered = False
        Me._isButtonPressed = False
        Me._isLeftFieldHovered = False
        Me._isLeftFieldPressed = False
        Me._isRightFieldHovered = False
        Me._isRightFieldPressed = False
        Me.Refresh()
        Dim Sender As New Object
        RaiseEvent CheckedChanged(Sender, New EventArgs)
        'If (Not Me.CheckedChanged Is Nothing) Then
        'Me.CheckedChanged.Invoke(Me, New EventArgs)
        'End If
        RaiseEvent CheckedChanged(Me, New EventArgs)

        If (Not Me._lastMouseEventArgs Is Nothing) Then
            Me.OnMouseMove(Me._lastMouseEventArgs)
        End If
        Me._lastMouseEventArgs = Nothing
    End Sub

    Private Sub AnimationTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        Dim num As Integer
        Me._animationTimer.Enabled = False
        Dim flag As Boolean = False
        If Me.IsButtonMovingRight Then
            num = (Me.ButtonValue + Me._animationStep)
            If (num > Me._animationTarget) Then
                num = Me._animationTarget
            End If
            Me.ButtonValue = num
            flag = (Me.ButtonValue >= Me._animationTarget)
        Else
            num = (Me.ButtonValue - Me._animationStep)
            If (num < Me._animationTarget) Then
                num = Me._animationTarget
            End If
            Me.ButtonValue = num
            flag = (Me.ButtonValue <= Me._animationTarget)
        End If
        If flag Then
            Me.AnimationComplete()
        Else
            Me._animationTimer.Enabled = True
        End If
    End Sub

    Private Sub BeginAnimation(ByVal checkedValue As Boolean)
        Me._animating = True
        Me._animationResult = checkedValue
        If ((Not Me._animationTimer Is Nothing) AndAlso Me._useAnimation) Then
            Me._animationTimer.Interval = Me._animationInterval
            Me._animationTimer.Enabled = True
        Else
            Me.AnimationComplete()
        End If
    End Sub

    Protected Overrides Sub OnEnabledChanged(ByVal e As EventArgs)
        MyBase.OnEnabledChanged(e)
        Me.Refresh()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        If (Not Me._animating AndAlso Me.AllowUserChange) Then
            Dim buttonWidth As Integer = Me._renderer.GetButtonWidth
            Dim buttonRectangle As Rectangle = Me._renderer.GetButtonRectangle(buttonWidth)
            Me._savedButtonValue = Me.ButtonValue
            If buttonRectangle.Contains(e.Location) Then
                Me._isButtonPressed = True
                Me._isLeftFieldPressed = False
                Me._isRightFieldPressed = False
                Me._moving = True
                Me._xOffset = e.Location.X
                Me._buttonValue = buttonRectangle.X
                Me._xValue = Me.ButtonValue
            ElseIf (e.Location.X > (buttonRectangle.X + buttonRectangle.Width)) Then
                Me._isButtonPressed = False
                Me._isLeftFieldPressed = False
                Me._isRightFieldPressed = True
            ElseIf (e.Location.X < buttonRectangle.X) Then
                Me._isButtonPressed = False
                Me._isLeftFieldPressed = True
                Me._isRightFieldPressed = False
            End If
            Me.Refresh()
        End If
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        Me._isButtonHovered = False
        Me._isLeftFieldHovered = False
        Me._isRightFieldHovered = False
        Me._isButtonPressed = False
        Me._isLeftFieldPressed = False
        Me._isRightFieldPressed = False
        Me.Refresh()
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        Me._lastMouseEventArgs = e
        Dim buttonWidth As Integer = Me._renderer.GetButtonWidth
        Dim buttonRectangle As Rectangle = Me._renderer.GetButtonRectangle(buttonWidth)
        If Me._moving Then
            Dim num2 As Integer = (Me._xValue + (e.Location.X - Me._xOffset))
            If (num2 < 0) Then
                num2 = 0
            End If
            If (num2 > (MyBase.Width - buttonWidth)) Then
                num2 = (MyBase.Width - buttonWidth)
            End If
            Me.ButtonValue = num2
            Me.Refresh()
        Else
            If buttonRectangle.Contains(e.Location) Then
                Me._isButtonHovered = True
                Me._isLeftFieldHovered = False
                Me._isRightFieldHovered = False
            ElseIf (e.Location.X > (buttonRectangle.X + buttonRectangle.Width)) Then
                Me._isButtonHovered = False
                Me._isLeftFieldHovered = False
                Me._isRightFieldHovered = True
            ElseIf (e.Location.X < buttonRectangle.X) Then
                Me._isButtonHovered = False
                Me._isLeftFieldHovered = True
                Me._isRightFieldHovered = False
            End If
            Me.Refresh()
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        If (Not Me._animating AndAlso Me.AllowUserChange) Then
            Dim buttonWidth As Integer = Me._renderer.GetButtonWidth
            Dim isLeftSidePressed As Boolean = Me.IsLeftSidePressed
            Dim isRightSidePressed As Boolean = Me.IsRightSidePressed
            Me._isButtonPressed = False
            Me._isLeftFieldPressed = False
            Me._isRightFieldPressed = False
            If Me._moving Then
                Dim num2 As Integer = CInt(((100 * Me.ButtonValue) / (MyBase.Width - buttonWidth)))
                If Me._checked Then
                    If (num2 <= (100 - Me._thresholdPercentage)) Then
                        Me._animationTarget = 0
                        Me.BeginAnimation(False)
                    ElseIf (Me.ToggleOnButtonClick AndAlso (Me._savedButtonValue = Me.ButtonValue)) Then
                        Me._animationTarget = 0
                        Me.BeginAnimation(False)
                    Else
                        Me._animationTarget = (MyBase.Width - buttonWidth)
                        Me.BeginAnimation(True)
                    End If
                ElseIf (num2 >= Me._thresholdPercentage) Then
                    Me._animationTarget = (MyBase.Width - buttonWidth)
                    Me.BeginAnimation(True)
                ElseIf (Me.ToggleOnButtonClick AndAlso (Me._savedButtonValue = Me.ButtonValue)) Then
                    Me._animationTarget = (MyBase.Width - buttonWidth)
                    Me.BeginAnimation(True)
                Else
                    Me._animationTarget = 0
                    Me.BeginAnimation(False)
                End If
                Me._moving = False
            Else
                If Me.IsButtonOnRightSide Then
                    Me._buttonValue = (MyBase.Width - buttonWidth)
                    Me._animationTarget = 0
                Else
                    Me._buttonValue = 0
                    Me._animationTarget = (MyBase.Width - buttonWidth)
                End If
                If (isLeftSidePressed AndAlso Me.ToggleOnSideClick) Then
                    Me.SetValueInternal(False)
                ElseIf (isRightSidePressed AndAlso Me.ToggleOnSideClick) Then
                    Me.SetValueInternal(True)
                End If
                Me.Refresh()
            End If
        End If
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        e.Graphics.ResetClip()
        MyBase.OnPaint(e)
        If (Not Me._renderer Is Nothing) Then
            Me._renderer.RenderControl(e)
        End If
    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal pevent As PaintEventArgs)
        pevent.Graphics.ResetClip()
        MyBase.OnPaintBackground(pevent)
        If (Not Me._renderer Is Nothing) Then
            Me._renderer.RenderBackground(pevent)
        End If
    End Sub

    Protected Overrides Sub OnRegionChanged(ByVal e As EventArgs)
        MyBase.OnRegionChanged(e)
        Me.Refresh()
    End Sub

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        If (Me._animationTarget > 0) Then
            Dim buttonWidth As Integer = Me._renderer.GetButtonWidth
            Me._animationTarget = (MyBase.Width - buttonWidth)
        End If
        MyBase.OnSizeChanged(e)
    End Sub

    Public Sub SetRenderer(ByVal renderer As ToggleSwitchRendererBase)
        renderer.SetToggleSwitch(Me)
        Me._renderer = renderer
        If (Not Me._renderer Is Nothing) Then
            Me.Refresh()
        End If
    End Sub

    Private Sub SetValueInternal(ByVal checkedValue As Boolean)
        If (checkedValue <> Me._checked) Then
            Do While Me._animating
                Application.DoEvents()
            Loop
            Me.BeginAnimation(checkedValue)
        End If
    End Sub


    ' Properties
    <Bindable(True), Category("Behavior"), DefaultValue(True), Description("Gets or sets whether the user can change the value of the button or not")> _
    Public Property AllowUserChange As Boolean
        Get
            Return Me._allowUserChange
        End Get
        Set(ByVal value As Boolean)
            Me._allowUserChange = value
        End Set
    End Property

    <Category("Behavior"), DefaultValue(1), Bindable(False), Description("Gets or sets the interval in ms between animation frames")> _
    Public Property AnimationInterval As Integer
        Get
            Return Me._animationInterval
        End Get
        Set(ByVal value As Integer)
            If (value <= 0) Then
                Throw New ArgumentOutOfRangeException("AnimationInterval must larger than zero!")
            End If
            Me._animationInterval = value
        End Set
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Friend ReadOnly Property AnimationResult As Boolean
        Get
            Return Me._animationResult
        End Get
    End Property

    <Category("Behavior"), Bindable(False), Description("Gets or sets the step in pixes the button shouldbe moved between each animation interval"), DefaultValue(10)> _
    Public Property AnimationStep As Integer
        Get
            Return Me._animationStep
        End Get
        Set(ByVal value As Integer)
            If (value <= 0) Then
                Throw New ArgumentOutOfRangeException("AnimationStep must larger than zero!")
            End If
            Me._animationStep = value
        End Set
    End Property

    <Description("Gets or sets how the button image should be aligned"), Bindable(False), Category("Appearance"), DefaultValue(GetType(ToggleSwitchButtonAlignment), "Center")> _
    Public Property ButtonAlignment As ToggleSwitchButtonAlignment
        Get
            Return Me._buttonAlignment
        End Get
        Set(ByVal value As ToggleSwitchButtonAlignment)
            If (value <> Me._buttonAlignment) Then
                Me._buttonAlignment = value
                Me.Refresh()
            End If
        End Set
    End Property

    <Description("Gets or sets the button image"), Category("Appearance"), Bindable(False), DefaultValue(CStr(Nothing))> _
    Public Property ButtonImage As Image
        Get
            Return Me._buttonImage
        End Get
        Set(ByVal value As Image)
            If (Not value Is Me._buttonImage) Then
                Me._buttonImage = value
                Me.Refresh()
            End If
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(False)> _
    Public ReadOnly Property ButtonRectangle As Rectangle
        Get
            Return Me._renderer.GetButtonRectangle
        End Get
    End Property

    <Category("Behavior"), Bindable(False), Description("Gets or sets whether the button image should be scaled to fit"), DefaultValue(False)> _
    Public Property ButtonScaleImageToFit As Boolean
        Get
            Return Me._buttonScaleImage
        End Get
        Set(ByVal value As Boolean)
            If (value <> Me._buttonScaleImage) Then
                Me._buttonScaleImage = value
                Me.Refresh()
            End If
        End Set
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Friend Property ButtonValue As Integer
        Get
            If (Me._animating OrElse Me._moving) Then
                Return Me._buttonValue
            End If
            If Me._checked Then
                Return (MyBase.Width - Me._renderer.GetButtonWidth)
            End If
            Return 0
        End Get
        Set(ByVal value As Integer)
            If (value <> Me._buttonValue) Then
                Me._buttonValue = value
                Me.Refresh()
            End If
        End Set
    End Property

    <Category("Data"), Description("Gets or sets the Checked value of the ToggleSwitch"), Bindable(True), DefaultValue(False)> _
    Public Property Checked As Boolean
        Get
            Return Me._checked
        End Get
        Set(ByVal value As Boolean)
            If (value <> Me._checked) Then
                Do While Me._animating
                    Application.DoEvents()
                Loop
                If value Then
                    Dim buttonWidth As Integer = Me._renderer.GetButtonWidth
                    Me._animationTarget = (MyBase.Width - buttonWidth)
                    Me.BeginAnimation(True)
                Else
                    Me._animationTarget = 0
                    Me.BeginAnimation(False)
                End If
            End If
        End Set
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property CheckedString As String
        Get
            If Not Me.Checked Then
                If Not String.IsNullOrEmpty(Me.OffText) Then
                    Return Me.OffText
                End If
                Return "OFF"
            End If
            If Not String.IsNullOrEmpty(Me.OnText) Then
                Return Me.OnText
            End If
            Return "ON"
        End Get
    End Property

    Protected Overrides ReadOnly Property DefaultSize As Size
        Get
            Return New Size(50, &H13)
        End Get
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = New Font(MyBase.Font, FontStyle.Regular)
        End Set
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Overrides Property ForeColor As Color
        Get
            Return Color.Black
        End Get
        Set(ByVal value As Color)
            MyBase.ForeColor = Color.Black
        End Set
    End Property

    <Bindable(False), Category("Appearance"), Description("Gets or sets if the ToggleSwitch should be grayed out when disabled"), DefaultValue(True)> _
    Public Property GrayWhenDisabled As Boolean
        Get
            Return Me._grayWhenDisabled
        End Get
        Set(ByVal value As Boolean)
            If (value <> Me._grayWhenDisabled) Then
                Me._grayWhenDisabled = value
                If Not MyBase.Enabled Then
                    Me.Refresh()
                End If
            End If
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(False)> _
    Friend ReadOnly Property IsButtonHovered As Boolean
        Get
            Return (Me._isButtonHovered AndAlso Not Me._isButtonPressed)
        End Get
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Friend ReadOnly Property IsButtonMovingLeft As Boolean
        Get
            Return ((Me._animating AndAlso Not Me.IsButtonOnLeftSide) AndAlso Not Me._animationResult)
        End Get
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Friend ReadOnly Property IsButtonMovingRight As Boolean
        Get
            Return ((Me._animating AndAlso Not Me.IsButtonOnRightSide) AndAlso Me._animationResult)
        End Get
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Friend ReadOnly Property IsButtonOnLeftSide As Boolean
        Get
            Return (Me.ButtonValue <= 0)
        End Get
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(False)> _
    Friend ReadOnly Property IsButtonOnRightSide As Boolean
        Get
            Return (Me.ButtonValue >= (MyBase.Width - Me._renderer.GetButtonWidth))
        End Get
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Friend ReadOnly Property IsButtonPressed As Boolean
        Get
            Return Me._isButtonPressed
        End Get
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Friend ReadOnly Property IsLeftSideHovered As Boolean
        Get
            Return (Me._isLeftFieldHovered AndAlso Not Me._isLeftFieldPressed)
        End Get
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Friend ReadOnly Property IsLeftSidePressed As Boolean
        Get
            Return Me._isLeftFieldPressed
        End Get
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(False)> _
    Friend ReadOnly Property IsRightSideHovered As Boolean
        Get
            Return (Me._isRightFieldHovered AndAlso Not Me._isRightFieldPressed)
        End Get
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Friend ReadOnly Property IsRightSidePressed As Boolean
        Get
            Return Me._isRightFieldPressed
        End Get
    End Property

    <DefaultValue(GetType(ToggleSwitchButtonAlignment), "Center"), Bindable(False), Category("Appearance"), Description("Gets or sets how the button image visible when Checked=false should be aligned")> _
    Public Property OffButtonAlignment As ToggleSwitchButtonAlignment
        Get
            Return Me._offButtonAlignment
        End Get
        Set(ByVal value As ToggleSwitchButtonAlignment)
            If (value <> Me._offButtonAlignment) Then
                Me._offButtonAlignment = value
                Me.Refresh()
            End If
        End Set
    End Property

    <DefaultValue(CStr(Nothing)), Bindable(False), Category("Appearance"), Description("Gets or sets the button image when Checked=false and ButtonImage is not set")> _
    Public Property OffButtonImage As Image
        Get
            Return Me._offButtonImage
        End Get
        Set(ByVal value As Image)
            If (Not value Is Me._offButtonImage) Then
                Me._offButtonImage = value
                Me.Refresh()
            End If
        End Set
    End Property

    <Category("Behavior"), DefaultValue(False), Description("Gets or sets whether the button image visible when Checked=false should be scaled to fit"), Bindable(False)> _
    Public Property OffButtonScaleImageToFit As Boolean
        Get
            Return Me._offButtonScaleImage
        End Get
        Set(ByVal value As Boolean)
            If (value <> Me._offButtonScaleImage) Then
                Me._offButtonScaleImage = value
                Me.Refresh()
            End If
        End Set
    End Property

    <Description("Gets or sets the font of the text when Checked=false"), Bindable(False), Category("Appearance"), DefaultValue(GetType(Font), "Microsoft Sans Serif, 8.25pt")> _
    Public Property OffFont As Font
        Get
            Return Me._offFont
        End Get
        Set(ByVal value As Font)
            If Not value.Equals(Me._offFont) Then
                Me._offFont = value
                Me.Refresh()
            End If
        End Set
    End Property

    <Category("Appearance"), Bindable(False), DefaultValue(GetType(Color), "Black"), Description("Gets or sets the forecolor of the text when Checked=false")> _
    Public Property OffForeColor As Color
        Get
            Return Me._offForeColor
        End Get
        Set(ByVal value As Color)
            If (value <> Me._offForeColor) Then
                Me._offForeColor = value
                Me.Refresh()
            End If
        End Set
    End Property

    <DefaultValue(GetType(ToggleSwitchAlignment), "Center"), Bindable(False), Category("Appearance"), Description("Gets or sets how the text or side image visible when Checked=false should be aligned")> _
    Public Property OffSideAlignment As ToggleSwitchAlignment
        Get
            Return Me._offSideAlignment
        End Get
        Set(ByVal value As ToggleSwitchAlignment)
            If (value <> Me._offSideAlignment) Then
                Me._offSideAlignment = value
                Me.Refresh()
            End If
        End Set
    End Property

    <Description("Gets or sets the side image when Checked=false - Note: Settings the OffSideImage overrules the OffText property. Only the image will be shown"), Bindable(False), DefaultValue(CStr(Nothing)), Category("Appearance")> _
    Public Property OffSideImage As Image
        Get
            Return Me._offSideImage
        End Get
        Set(ByVal value As Image)
            If (Not value Is Me._offSideImage) Then
                Me._offSideImage = value
                Me.Refresh()
            End If
        End Set
    End Property

    <Category("Behavior"), DefaultValue(False), Bindable(False), Description("Gets or sets whether the side image visible when Checked=false should be scaled to fit")> _
    Public Property OffSideScaleImageToFit As Boolean
        Get
            Return Me._offSideScaleImage
        End Get
        Set(ByVal value As Boolean)
            If (value <> Me._offSideScaleImage) Then
                Me._offSideScaleImage = value
                Me.Refresh()
            End If
        End Set
    End Property

    <DefaultValue(""), Category("Appearance"), Description("Gets or sets the text when Checked=true"), Bindable(False)> _
    Public Property OffText As String
        Get
            Return Me._offText
        End Get
        Set(ByVal value As String)
            If (value <> Me._offText) Then
                Me._offText = value
                Me.Refresh()
            End If
        End Set
    End Property

    <Bindable(False), DefaultValue(GetType(ToggleSwitchButtonAlignment), "Center"), Category("Appearance"), Description("Gets or sets how the button image visible when Checked=true should be aligned")> _
    Public Property OnButtonAlignment As ToggleSwitchButtonAlignment
        Get
            Return Me._onButtonAlignment
        End Get
        Set(ByVal value As ToggleSwitchButtonAlignment)
            If (value <> Me._onButtonAlignment) Then
                Me._onButtonAlignment = value
                Me.Refresh()
            End If
        End Set
    End Property

    <Description("Gets or sets the button image visible when Checked=true and ButtonImage is not set"), Bindable(False), DefaultValue(CStr(Nothing)), Category("Appearance")> _
    Public Property OnButtonImage As Image
        Get
            Return Me._onButtonImage
        End Get
        Set(ByVal value As Image)
            If (Not value Is Me._onButtonImage) Then
                Me._onButtonImage = value
                Me.Refresh()
            End If
        End Set
    End Property

    <Bindable(False), Description("Gets or sets whether the button image visible when Checked=true should be scaled to fit"), Category("Behavior"), DefaultValue(False)> _
    Public Property OnButtonScaleImageToFit As Boolean
        Get
            Return Me._onButtonScaleImage
        End Get
        Set(ByVal value As Boolean)
            If (value <> Me._onButtonScaleImage) Then
                Me._onButtonScaleImage = value
                Me.Refresh()
            End If
        End Set
    End Property

    <Description("Gets or sets the font of the text when Checked=true"), DefaultValue(GetType(Font), "Microsoft Sans Serif, 8,25pt"), Category("Appearance"), Bindable(False)> _
    Public Property OnFont As Font
        Get
            Return Me._onFont
        End Get
        Set(ByVal value As Font)
            If Not value.Equals(Me._onFont) Then
                Me._onFont = value
                Me.Refresh()
            End If
        End Set
    End Property

    <Bindable(False), Category("Appearance"), Description("Gets or sets the forecolor of the text when Checked=true"), DefaultValue(GetType(Color), "Black")> _
    Public Property OnForeColor As Color
        Get
            Return Me._onForeColor
        End Get
        Set(ByVal value As Color)
            If (value <> Me._onForeColor) Then
                Me._onForeColor = value
                Me.Refresh()
            End If
        End Set
    End Property

    <Category("Appearance"), Bindable(False), Description("Gets or sets how the text or side image visible when Checked=true should be aligned"), DefaultValue(GetType(ToggleSwitchAlignment), "Center")> _
    Public Property OnSideAlignment As ToggleSwitchAlignment
        Get
            Return Me._onSideAlignment
        End Get
        Set(ByVal value As ToggleSwitchAlignment)
            If (value <> Me._onSideAlignment) Then
                Me._onSideAlignment = value
                Me.Refresh()
            End If
        End Set
    End Property

    <Description("Gets or sets the side image visible when Checked=true - Note: Settings the OnSideImage overrules the OnText property. Only the image will be shown."), Bindable(False), Category("Appearance"), DefaultValue(CStr(Nothing))> _
    Public Property OnSideImage As Image
        Get
            Return Me._onSideImage
        End Get
        Set(ByVal value As Image)
            If (Not value Is Me._onSideImage) Then
                Me._onSideImage = value
                Me.Refresh()
            End If
        End Set
    End Property

    <Description("Gets or sets whether the side image visible when Checked=true should be scaled to fit"), DefaultValue(False), Category("Behavior"), Bindable(False)> _
    Public Property OnSideScaleImageToFit As Boolean
        Get
            Return Me._onSideScaleImage
        End Get
        Set(ByVal value As Boolean)
            If (value <> Me._onSideScaleImage) Then
                Me._onSideScaleImage = value
                Me.Refresh()
            End If
        End Set
    End Property

    <DefaultValue(""), Bindable(False), Description("Gets or sets the text when Checked=true"), Category("Appearance")> _
    Public Property OnText As String
        Get
            Return Me._onText
        End Get
        Set(ByVal value As String)
            If (value <> Me._onText) Then
                Me._onText = value
                Me.Refresh()
            End If
        End Set
    End Property

    <Description("Gets or sets the style of the ToggleSwitch"), Category("Appearance"), Bindable(False), DefaultValue(GetType(ToggleSwitchStyle), "Metro")> _
    Public Property Style As ToggleSwitchStyle
        Get
            Return Me._style
        End Get
        Set(ByVal value As ToggleSwitchStyle)
            If (value <> Me._style) Then
                Me._style = value
                Select Case Me._style
                    Case ToggleSwitchStyle.Metro
                        Me.SetRenderer(New ToggleSwitchMetroRenderer)
                        Exit Select
                    'Case ToggleSwitchStyle.Android
                    '    Me.SetRenderer(New ToggleSwitchAndroidRenderer)
                    '    Exit Select
                    Case ToggleSwitchStyle.IOS
                        Me.SetRenderer(New ToggleSwitchIOS5Renderer)
                        Exit Select
                    Case ToggleSwitchStyle.BrushedMetal
                        Me.SetRenderer(New ToggleSwitchBrushedMetalRenderer)
                        Exit Select
                        'Case ToggleSwitchStyle.Carbon
                        '    Me.SetRenderer(New ToggleSwitchCarbonRenderer)
                        '    Exit Select 
                        '    Case ToggleSwitchStyle.Fancy
                        '        Me.SetRenderer(New ToggleSwitchFancyRenderer)
                        '        Exit Select
                        '    Case ToggleSwitchStyle.Modern
                        '        Me.SetRenderer(New ToggleSwitchModernRenderer)
                        '        Exit Select
                End Select
            End If
            Me.Refresh()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(False)>
    Public Overrides Property [Text] As String
        Get
            Return ""
        End Get
        Set(ByVal value As String)
            MyBase.Text = ""
        End Set
    End Property

    <DefaultValue(50), Bindable(False), Category("Behavior"), Description("Gets or sets how much the button need to be on the other side (in peercept) before it snaps")> _
    Public Property ThresholdPercentage As Integer
        Get
            Return Me._thresholdPercentage
        End Get
        Set(ByVal value As Integer)
            Me._thresholdPercentage = value
        End Set
    End Property

    <DefaultValue(True), Bindable(False), Description("Gets or sets if the ToggleSwitch should toggle when the button is clicked"), Category("Behavior")> _
    Public Property ToggleOnButtonClick As Boolean
        Get
            Return Me._toggleOnButtonClick
        End Get
        Set(ByVal value As Boolean)
            Me._toggleOnButtonClick = value
        End Set
    End Property

    <DefaultValue(True), Bindable(False), Description("Gets or sets if the ToggleSwitch should toggle when the track besides the button is clicked"), Category("Behavior")> _
    Public Property ToggleOnSideClick As Boolean
        Get
            Return Me._toggleOnSideClick
        End Get
        Set(ByVal value As Boolean)
            Me._toggleOnSideClick = value
        End Set
    End Property

    <Bindable(False), Category("Behavior"), Description("Gets or sets whether the toggle change should be animated or not"), DefaultValue(True)> _
    Public Property UseAnimation As Boolean
        Get
            Return Me._useAnimation
        End Get
        Set(ByVal value As Boolean)
            Me._useAnimation = value
        End Set
    End Property

    ' Fields
    Private _allowUserChange As Boolean = True
    Private _animating As Boolean
    Private _animationInterval As Integer = 1
    Private _animationResult As Boolean
    Private _animationStep As Integer = 10
    Private _animationTarget As Integer
    Private ReadOnly _animationTimer As System.Windows.Forms.Timer = New System.Windows.Forms.Timer
    Private _buttonAlignment As ToggleSwitchButtonAlignment = ToggleSwitchButtonAlignment.Center
    Private _buttonImage As Image
    Private _buttonScaleImage As Boolean
    Private _buttonValue As Integer
    Private _checked As Boolean
    Private _grayWhenDisabled As Boolean = True
    Private _isButtonHovered As Boolean
    Private _isButtonPressed As Boolean
    Private _isLeftFieldHovered As Boolean
    Private _isLeftFieldPressed As Boolean
    Private _isRightFieldHovered As Boolean
    Private _isRightFieldPressed As Boolean
    Private _lastMouseEventArgs As MouseEventArgs
    Private _moving As Boolean
    Private _offButtonAlignment As ToggleSwitchButtonAlignment = ToggleSwitchButtonAlignment.Center
    Private _offButtonImage As Image
    Private _offButtonScaleImage As Boolean
    Private _offFont As Font
    Private _offForeColor As Color = Color.Black
    Private _offSideAlignment As ToggleSwitchAlignment = ToggleSwitchAlignment.Center
    Private _offSideImage As Image
    Private _offSideScaleImage As Boolean
    Private _offText As String = ""
    Private _onButtonAlignment As ToggleSwitchButtonAlignment = ToggleSwitchButtonAlignment.Center
    Private _onButtonImage As Image
    Private _onButtonScaleImage As Boolean
    Private _onFont As Font
    Private _onForeColor As Color = Color.Black
    Private _onSideAlignment As ToggleSwitchAlignment = ToggleSwitchAlignment.Center
    Private _onSideImage As Image
    Private _onSideScaleImage As Boolean
    Private _onText As String = ""
    Private _renderer As ToggleSwitchRendererBase
    Private _savedButtonValue As Integer
    Private _style As ToggleSwitchStyle
    Private _thresholdPercentage As Integer = 50
    Private _toggleOnButtonClick As Boolean = True
    Private _toggleOnSideClick As Boolean = True
    Private _useAnimation As Boolean = True
    Private _xOffset As Integer
    Private _xValue As Integer

    ' Nested Types
    Public Delegate Sub CheckedChangedDelegate(ByVal sender As Object, ByVal e As EventArgs)
    Public Enum ToggleSwitchAlignment
        ' Fields
        Center = 1
        Far = 2
        Near = 0
    End Enum

    Public Enum ToggleSwitchButtonAlignment
        ' Fields
        Center = 1
        Left = 0
        Right = 2
    End Enum

    Public Enum ToggleSwitchStyle
        ' Fields
        '  Android = 1
        BrushedMetal = 0
        IOS = 3
        '   Carbon = 5
        '   Fancy = 7
        Metro = 2
        '  Modern = 4
    End Enum
End Class
