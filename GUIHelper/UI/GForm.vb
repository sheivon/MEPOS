Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports GUIHelper.WinApi

Public Class GForm

#Region "Window Behavior"

#Region "Fields"
    Private dwmMargins As Dwm.MARGINS
    Private _marginOk As Boolean
    Private _aeroEnabled As Boolean = False
#End Region
#Region "Ctor"
    Public Sub New()
        SetStyle(ControlStyles.ResizeRedraw, True)

        InitializeComponent()

        DoubleBuffered = True

    End Sub
#End Region
#Region "Props"
    Public ReadOnly Property AeroEnabled() As Boolean
        Get
            Return _aeroEnabled
        End Get
    End Property
#End Region
#Region "Methods"
    Public Shared Function LoWord(ByVal dwValue As Integer) As Integer
        Return dwValue And &HFFFF
    End Function
    ''' <summary>
    ''' Equivalent to the HiWord C Macro
    ''' </summary>
    ''' <param name="dwValue"></param>
    ''' <returns></returns>
    Public Shared Function HiWord(ByVal dwValue As Integer) As Integer
        Return (dwValue >> 16) And &HFFFF
    End Function
#End Region

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Dwm.DwmExtendFrameIntoClientArea(Me.Handle, dwmMargins)
        SetStyle(ControlStyles.ResizeRedraw, True)
    End Sub

    Protected Overloads Overrides Sub WndProc(ByRef m As Message)
        Dim WM_NCCALCSIZE As Integer = &H83
        Dim WM_NCHITTEST As Integer = &H84
        Dim result As IntPtr

        Dim dwmHandled As Integer = Dwm.DwmDefWindowProc(m.HWnd, m.Msg, m.WParam, m.LParam, result)

        If dwmHandled = 1 Then
            m.Result = result
            Exit Sub
        End If

        If m.Msg = WM_NCCALCSIZE AndAlso CInt(m.WParam) = 1 Then
            Dim nccsp As NCCALCSIZE_PARAMS =
              DirectCast(Marshal.PtrToStructure(m.LParam,
              GetType(NCCALCSIZE_PARAMS)), NCCALCSIZE_PARAMS)

            ' Adjust (shrink) the client rectangle to accommodate the border:
            nccsp.rect0.Top += 0
            nccsp.rect0.Bottom += 0
            nccsp.rect0.Left += 0
            nccsp.rect0.Right += 0

            If Not _marginOk Then
                'Set what client area would be for passing to DwmExtendIntoClientArea. Also remember that at least one of these values NEEDS TO BE > 1, else it won't work.
                dwmMargins.cyTopHeight = 3
                dwmMargins.cxLeftWidth = 0
                dwmMargins.cyBottomHeight = 0
                dwmMargins.cxRightWidth = 0
                _marginOk = True
            End If

            Marshal.StructureToPtr(nccsp, m.LParam, False)

            m.Result = IntPtr.Zero
        ElseIf m.Msg = WM_NCHITTEST AndAlso CInt(m.Result) = 0 Then
            m.Result = HitTestNCA(m.HWnd, m.WParam, m.LParam)
        Else
            MyBase.WndProc(m)
        End If
        SetStyle(ControlStyles.ResizeRedraw, True)
    End Sub

    Private Function HitTestNCA(ByVal hwnd As IntPtr, ByVal wparam _
                                      As IntPtr, ByVal lparam As IntPtr) As IntPtr
        Dim HTNOWHERE As Integer = 0
        Dim HTCLIENT As Integer = 1
        Dim HTCAPTION As Integer = 2
        Dim HTGROWBOX As Integer = 4
        Dim HTSIZE As Integer = HTGROWBOX
        Dim HTMINBUTTON As Integer = 8
        Dim HTMAXBUTTON As Integer = 9
        Dim HTLEFT As Integer = 10
        Dim HTRIGHT As Integer = 11
        Dim HTTOP As Integer = 12
        Dim HTTOPLEFT As Integer = 13
        Dim HTTOPRIGHT As Integer = 14
        Dim HTBOTTOM As Integer = 15
        Dim HTBOTTOMLEFT As Integer = 16
        Dim HTBOTTOMRIGHT As Integer = 17
        Dim HTREDUCE As Integer = HTMINBUTTON
        Dim HTZOOM As Integer = HTMAXBUTTON
        Dim HTSIZEFIRST As Integer = HTLEFT
        Dim HTSIZELAST As Integer = HTBOTTOMRIGHT

        Dim p As New Point(LoWord(CInt(lparam)), HiWord(CInt(lparam)))

        Dim topleft As Rectangle = RectangleToScreen(New Rectangle(0, 0,
                                   dwmMargins.cxLeftWidth, dwmMargins.cxLeftWidth))

        If topleft.Contains(p) Then
            Return New IntPtr(HTTOPLEFT)
        End If

        Dim topright As Rectangle =
          RectangleToScreen(New Rectangle(Width - dwmMargins.cxRightWidth, 0,
          dwmMargins.cxRightWidth, dwmMargins.cxRightWidth))

        If topright.Contains(p) Then
            Return New IntPtr(HTTOPRIGHT)
        End If

        Dim botleft As Rectangle =
           RectangleToScreen(New Rectangle(0, Height - dwmMargins.cyBottomHeight,
           dwmMargins.cxLeftWidth, dwmMargins.cyBottomHeight))

        If botleft.Contains(p) Then
            Return New IntPtr(HTBOTTOMLEFT)
        End If

        Dim botright As Rectangle =
            RectangleToScreen(New Rectangle(Width - dwmMargins.cxRightWidth,
            Height - dwmMargins.cyBottomHeight,
            dwmMargins.cxRightWidth, dwmMargins.cyBottomHeight))

        If botright.Contains(p) Then
            Return New IntPtr(HTBOTTOMRIGHT)
        End If

        Dim top As Rectangle =
            RectangleToScreen(New Rectangle(0, 0, Width, dwmMargins.cxLeftWidth))

        If top.Contains(p) Then
            Return New IntPtr(HTTOP)
        End If

        Dim cap As Rectangle =
            RectangleToScreen(New Rectangle(0, dwmMargins.cxLeftWidth,
            Width, dwmMargins.cyTopHeight - dwmMargins.cxLeftWidth))

        If cap.Contains(p) Then
            Return New IntPtr(HTCAPTION)
        End If

        Dim left As Rectangle =
            RectangleToScreen(New Rectangle(0, 0, dwmMargins.cxLeftWidth, Height))

        If left.Contains(p) Then
            Return New IntPtr(HTLEFT)
        End If

        Dim right As Rectangle =
            RectangleToScreen(New Rectangle(Width - dwmMargins.cxRightWidth,
            0, dwmMargins.cxRightWidth, Height))

        If right.Contains(p) Then
            Return New IntPtr(HTRIGHT)
        End If

        Dim bottom As Rectangle =
            RectangleToScreen(New Rectangle(0, Height - dwmMargins.cyBottomHeight,
            Width, dwmMargins.cyBottomHeight))

        If bottom.Contains(p) Then
            Return New IntPtr(HTBOTTOM)
        End If

        Return New IntPtr(HTCLIENT)
    End Function

    Private Const BorderWidth As Integer = 5

    Private _resizeDir As ResizeDirection = ResizeDirection.None

    Private Sub Form1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            If Me.Width - BorderWidth > e.Location.X AndAlso e.Location.X > BorderWidth AndAlso e.Location.Y > BorderWidth Then
                MoveControl(Me.Handle)
            Else
                If Me.WindowState <> FormWindowState.Maximized Then
                    ResizeForm(resizeDir)
                End If
            End If
        End If
    End Sub

    Public Enum ResizeDirection
        None = 0
        Left = 1
        TopLeft = 2
        Top = 4
        TopRight = 8
        Right = 16
        BottomRight = 32
        Bottom = 64
        BottomLeft = 128
    End Enum

    Private Property resizeDir() As ResizeDirection
        Get
            Return _resizeDir
        End Get
        Set(ByVal value As ResizeDirection)
            _resizeDir = value

            'Change cursor
            Select Case value
                Case ResizeDirection.Left
                    Me.Cursor = Cursors.SizeWE

                Case ResizeDirection.Right
                    Me.Cursor = Cursors.SizeWE

                Case ResizeDirection.Top
                    Me.Cursor = Cursors.SizeNS

                Case ResizeDirection.Bottom
                    Me.Cursor = Cursors.SizeNS

                Case ResizeDirection.BottomLeft
                    Me.Cursor = Cursors.SizeNESW

                Case ResizeDirection.TopRight
                    Me.Cursor = Cursors.SizeNESW

                Case ResizeDirection.BottomRight
                    Me.Cursor = Cursors.SizeNWSE

                Case ResizeDirection.TopLeft
                    Me.Cursor = Cursors.SizeNWSE

                Case Else
                    Me.Cursor = Cursors.Default
            End Select
        End Set
    End Property

    Private Sub Form1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        'Calculate which direction to resize based on mouse position

        If e.Location.X < BorderWidth And e.Location.Y < BorderWidth Then
            resizeDir = ResizeDirection.TopLeft

        ElseIf e.Location.X < BorderWidth And e.Location.Y > Me.Height - BorderWidth Then
            resizeDir = ResizeDirection.BottomLeft

        ElseIf e.Location.X > Me.Width - BorderWidth And e.Location.Y > Me.Height - BorderWidth Then
            resizeDir = ResizeDirection.BottomRight

        ElseIf e.Location.X > Me.Width - BorderWidth And e.Location.Y < BorderWidth Then
            resizeDir = ResizeDirection.TopRight

        ElseIf e.Location.X < BorderWidth Then
            resizeDir = ResizeDirection.Left

        ElseIf e.Location.X > Me.Width - BorderWidth Then
            resizeDir = ResizeDirection.Right

        ElseIf e.Location.Y < BorderWidth Then
            resizeDir = ResizeDirection.Top

        ElseIf e.Location.Y > Me.Height - BorderWidth Then
            resizeDir = ResizeDirection.Bottom

        Else
            resizeDir = ResizeDirection.None
        End If
    End Sub

    Private Sub MoveControl(ByVal hWnd As IntPtr)
        ReleaseCapture()
        SendMessage(hWnd, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub ResizeForm(ByVal direction As ResizeDirection)
        Dim dir As Integer = -1
        Select Case direction
            Case ResizeDirection.Left
                dir = HTLEFT
            Case ResizeDirection.TopLeft
                dir = HTTOPLEFT
            Case ResizeDirection.Top
                dir = HTTOP
            Case ResizeDirection.TopRight
                dir = HTTOPRIGHT
            Case ResizeDirection.Right
                dir = HTRIGHT
            Case ResizeDirection.BottomRight
                dir = HTBOTTOMRIGHT
            Case ResizeDirection.Bottom
                dir = HTBOTTOM
            Case ResizeDirection.BottomLeft
                dir = HTBOTTOMLEFT
        End Select

        If dir <> -1 Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, dir, 0)
        End If

    End Sub
    Private Sub GForm_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) _
        Handles Me.Paint
        If Me.BORDERED = True Then
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                                           Color.Lime, ButtonBorderStyle.Solid)
        End If
    End Sub

    <DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    <DllImport("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTBORDER As Integer = 18
    Private Const HTBOTTOM As Integer = 15
    Private Const HTBOTTOMLEFT As Integer = 16
    Private Const HTBOTTOMRIGHT As Integer = 17
    Private Const HTCAPTION As Integer = 2
    Private Const HTLEFT As Integer = 10
    Private Const HTRIGHT As Integer = 11
    Private Const HTTOP As Integer = 12
    Private Const HTTOPLEFT As Integer = 13
    Private Const HTTOPRIGHT As Integer = 14
#End Region

    '#Region "Override remove prop"
    '    Protected MustInherit Class GShadowNase
    '        Inherits GForm
    '        ' Methods
    '        Protected Sub New(ByVal targetForm As Form, ByVal shadowSize As Integer, ByVal wsExStyle As Integer)
    '            Me.TargetForm = targetForm
    '            Me.shadowSize = shadowSize
    '            Me.wsExStyle = wsExStyle
    '            AddHandler Me.TargetForm.Activated, New EventHandler(AddressOf Me.OnTargetFormActivated)
    '            AddHandler Me.TargetForm.ResizeBegin, New EventHandler(AddressOf Me.OnTargetFormResizeBegin)
    '            AddHandler Me.TargetForm.ResizeEnd, New EventHandler(AddressOf Me.OnTargetFormResizeEnd)
    '            AddHandler Me.TargetForm.VisibleChanged, New EventHandler(AddressOf Me.OnTargetFormVisibleChanged)
    '            AddHandler Me.TargetForm.SizeChanged, New EventHandler(AddressOf Me.OnTargetFormSizeChanged)
    '            AddHandler Me.TargetForm.Move, New EventHandler(AddressOf Me.OnTargetFormMove)
    '            AddHandler Me.TargetForm.Resize, New EventHandler(AddressOf Me.OnTargetFormResize)
    '            If (Not Me.TargetForm.Owner Is Nothing) Then
    '                MyBase.Owner = Me.TargetForm.Owner
    '            End If
    '            Me.TargetForm.Owner = Me
    '            MyBase.MaximizeBox = False
    '            MyBase.MinimizeBox = False
    '            MyBase.ShowInTaskbar = False
    '            MyBase.ShowIcon = False
    '            MyBase.FormBorderStyle = FormBorderStyle.None
    '            MyBase.Bounds = Me.GetShadowBounds
    '        End Sub

    '        Protected MustOverride Sub ClearShadow()

    '        Private Function GetShadowBounds() As Rectangle
    '            Dim bounds As Rectangle = Me.TargetForm.Bounds
    '            bounds.Inflate(Me.shadowSize, Me.shadowSize)
    '            Return bounds
    '        End Function

    '        Protected Overrides Sub OnDeactivate(ByVal e As EventArgs)
    '            MyBase.OnDeactivate(e)
    '            Me.isBringingToFront = True
    '        End Sub

    '        Private Sub OnTargetFormActivated(ByVal sender As Object, ByVal e As EventArgs)
    '            If MyBase.Visible Then
    '                MyBase.Update()
    '            End If
    '            If Me.isBringingToFront Then
    '                MyBase.Visible = True
    '                Me.isBringingToFront = False
    '            Else
    '                MyBase.BringToFront()
    '            End If
    '        End Sub

    '        Private Sub OnTargetFormMove(ByVal sender As Object, ByVal e As EventArgs)
    '            If (Me.TargetForm.Visible AndAlso (Me.TargetForm.WindowState = FormWindowState.Normal)) Then
    '                MyBase.Bounds = Me.GetShadowBounds
    '            Else
    '                MyBase.Visible = False
    '            End If
    '        End Sub

    '        Private Sub OnTargetFormResize(ByVal sender As Object, ByVal e As EventArgs)
    '            Me.ClearShadow()
    '        End Sub

    '        Private Sub OnTargetFormResizeBegin(ByVal sender As Object, ByVal e As EventArgs)
    '            Me.lastResizedOn = DateTime.Now.Ticks
    '        End Sub

    '        Private Sub OnTargetFormResizeEnd(ByVal sender As Object, ByVal e As EventArgs)
    '            Me.lastResizedOn = 0
    '            Me.PaintShadowIfVisible()
    '        End Sub

    '        Private Sub OnTargetFormSizeChanged(ByVal sender As Object, ByVal e As EventArgs)
    '            MyBase.Bounds = Me.GetShadowBounds
    '            If Not Me.IsResizing Then
    '                Me.PaintShadowIfVisible()
    '            End If
    '        End Sub

    '        Private Sub OnTargetFormVisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
    '            MyBase.Visible = (Me.TargetForm.Visible AndAlso (Me.TargetForm.WindowState <> FormWindowState.Minimized))
    '            MyBase.Update()
    '        End Sub

    '        Protected MustOverride Sub PaintShadow()

    '        Private Sub PaintShadowIfVisible()
    '            If (Me.TargetForm.Visible AndAlso (Me.TargetForm.WindowState <> FormWindowState.Minimized)) Then
    '                Me.PaintShadow()
    '            End If
    '        End Sub


    '        ' Properties
    '        Protected Overrides ReadOnly Property CreateParams As CreateParams
    '            Get
    '                Dim createParam As CreateParams = MyBase.CreateParams
    '                createParam.ExStyle = (createParam.ExStyle Or Me.wsExStyle)
    '                Return createParam
    '            End Get
    '        End Property

    '        Private ReadOnly Property IsResizing As Boolean
    '            Get
    '                Return (Me.lastResizedOn > 0)
    '            End Get
    '        End Property

    '        Property TargetForm As GForm
    '            Get
    '                Return Me
    '            End Get
    '            Set(ByVal value As GForm)

    '            End Set
    '        End Property

    '        ' Fields
    '        Private isBringingToFront As Boolean
    '        Private lastResizedOn As Long
    '        Private Const RESIZE_REDRAW_INTERVAL As Long = &H989680
    '        Private ReadOnly shadowSize As Integer = 5
    '        Private Const TICKS_PER_MS As Integer = &H2710
    '        Protected Const WS_EX_LAYERED As Integer = &H80000
    '        Protected Const WS_EX_NOACTIVATE As Integer = &H8000000
    '        Protected Const WS_EX_TRANSPARENT As Integer = &H20
    '        Private ReadOnly wsExStyle As Integer
    '    End Class
    '#End Region
    <Description("GET OR SET BORDER PAINT"), Category("Appearance"), Bindable(False), DefaultValue(GetType(Boolean), "TRUE")>
    Property BORDERED As Boolean
        Get
            Return _BORDERED
        End Get
        Set(value As Boolean)
            If value <> _BORDERED Then
                _BORDERED = value
            End If
        End Set
    End Property
    Private _BORDERED As Boolean
End Class