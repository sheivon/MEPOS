Imports InvoicePrinter
Imports System.Runtime.InteropServices
Imports GUIHelper
Imports GUIHelper.WinApi
Imports MarshellsSettings
Imports System.ComponentModel
Imports System.Threading
Imports InvoicePrinter.Customer
Imports InvoicePrinter.Product
Imports InvoicePrinter.Employees
Imports Entities
Imports InvoicePrinter.Cart
Imports DataBase
Imports InvoicePrinter.Invoice

<ComVisible(False)>
<ToolboxItem(False)>
Public Class Form1
    ''' <summary>
    ''' Gmessage replace to default msgbox message dialog type
    ''' </summary>
    ''' <returns></returns>
    Public Property GMessaage As New GMessage
    ''' <summary>
    ''' Automate Querry control
    ''' </summary>
    Private SQ As New MySqlControl
    ''' <summary>
    ''' Get the current screen the app open on
    ''' </summary>
    Private scr As Screen = Screen.FromControl(Me)
    ''' <summary>
    ''' Wheter someone is log into system or not
    ''' </summary>
    ''' <returns></returns>
    Public Property AutenticatedUsers As Boolean
    ''' <summary>
    ''' System as Administrator or Cashier
    ''' </summary>
    ''' <returns></returns>
    Public Property SystemAdmin As Boolean
    ''' <summary>
    ''' LogIn user Id
    ''' </summary>
    ''' <returns></returns>
    Public Property UsrID As Integer
    ''' <summary>
    ''' LogIn UserName
    ''' </summary>
    ''' <returns></returns>
    Public Property users As String
    ''' <summary>
    ''' list of saling items
    ''' </summary> 
    Private Property Expand As Boolean = False
    Private Property Moving As Boolean = False

    Private Property Thems As Color = MSetting.Themes
#Region "Gamboa UI"
#Region "Window Behavior"

#Region "Fields"
    Private dwmMargins As Dwm.MARGINS
    Private _marginOk As Boolean
    Private _aeroEnabled As Boolean = False
#End Region
#Region "Ctor"
    Public Sub New()
        SetStyle(ControlStyles.ResizeRedraw, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        DoubleBuffered = True
        InitializeComponent()

        DoubleBuffered = True
        Elipse.Apply(PictureBox1, 130)
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
            Dim nccsp As WinApi.NCCALCSIZE_PARAMS =
              DirectCast(Marshal.PtrToStructure(m.LParam,
              GetType(NCCALCSIZE_PARAMS)), NCCALCSIZE_PARAMS)

            ' Adjust (shrink) the client rectangle to accommodate the border:
            nccsp.rect0.Top += 0
            nccsp.rect0.Bottom += 0
            nccsp.rect0.Left += 0
            nccsp.rect0.Right += 0

            If Not _marginOk Then
                'Set what client area would be for passing to DwmExtendIntoClientArea. Also remember that at least one of these values NEEDS TO BE > 1, else it won't work.
                dwmMargins.cyTopHeight = 0
                dwmMargins.cxLeftWidth = 0
                dwmMargins.cyBottomHeight = 1
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

    Private Sub Form1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown, ToolsPanel.MouseDown, PictureBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
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

    Private Sub Form1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove, ToolsPanel.MouseMove, PictureBox1.MouseMove
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
    Private Sub Xbtn_Click(sender As Object, e As EventArgs) Handles Xbtn.Click
        If Me.AutenticatedUsers = True Then
            If GMessaage.Show(Me, "Are you sure? System will End if you press [OK]") = DialogResult.OK Then
                End 'terminate the application
            End If
        Else
            End 'same if not logint then terminate
        End If
    End Sub
    ''' <summary>
    ''' load up main ui
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForIllegalCrossThreadCalls = False
        ''' TIMER SETUP
        Timer1.Start()
        '''' THEMES SETUP
        Try
            If Thems = Theme.Dark Then
                ThemONOFF.Checked = True
            Else
                ThemONOFF.Checked = False
            End If
            Me.BackColor = Thems
            lbstat.Text = String.Format("Status:{0}", DataModule.GetServerStatus())
        Catch es As Exception
            lbstat.Text = String.Format("Status:{0}", DataModule.GetServerStatus())
        End Try

        ''''
        '''' Load login
        '''' 
        Clear()
        OptionPanel.Controls.Add(New Login(Me.OptionPanel))
        '''
        ''' Load the Bottom Bar  
        '''
        Call GradiantSettings()

    End Sub
    Private Sub GradiantSettings()
        If MSetting.IsGradient = True Then
            Panel1.GradientEndColor = MSetting.EndColor
            Panel1.GradientStartColor = MSetting.StartColor
            Panel1.PanelStyle = GGrandiantPanel.GPanelStyle.Gradiant
        Else
            Panel1.PanelStyle = GGrandiantPanel.GPanelStyle.Clasic
        End If
        If AutenticatedUsers = False Then
            OptionPanel.Controls.Clear()
            OptionPanel.Controls.Add(New Login(Me.OptionPanel))
        End If
    End Sub

    Private Sub BTNMINI_Click(sender As Object, e As EventArgs) Handles BTNMINI.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub BTNMAX_Click(sender As Object, e As EventArgs) Handles BTNMAX.Click
        '''
        ''' Set the current screen rec when maximising
        '''
        scr = Screen.FromControl(Me)
        Me.MaximizedBounds = scr.WorkingArea

        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub
#End Region
#Region "Adding Controls when btnClicked"
    ''' <summary>
    ''' Clear controls from panel to add new ui
    ''' </summary>
    Public Sub Clear()
        OptionPanel.Controls.Clear()
        DoubleBuffered = True
    End Sub
    ''' <summary>
    ''' Show the control to the mainfrm container
    ''' </summary>
    ''' <param name="cn"></param>
    Private Sub ShowControl(cn As Object)
        Try
            Clear()
            OptionPanel.Controls.Add(cn)
        Catch ex As Exception
            OptionPanel.Controls.Add(cn)
        End Try

    End Sub

    ''' <summary>
    ''' load the home ui
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Home_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ShowControl(New HomeCotrols(users, UsrID) With {.Dock = DockStyle.Fill})
    End Sub

    Private Sub btnAUser_Click(sender As Object, e As EventArgs) Handles btnAUser.Click
        ShowControl(New Usersfrm With {.Dock = DockStyle.Fill})
    End Sub
    Private Sub BtnProduc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnProduct.Click
        ShowControl(New Productsfrm() With {.Dock = DockStyle.Fill})
    End Sub
    ''' <summary>
    ''' Show the customers owing invoices list
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnOwinCust_Click(sender As Object, e As EventArgs)
        ShowControl(New Invoicefrm With {.Dock = DockStyle.Fill})
    End Sub

    Private Sub btnInventry_Click(sender As Object, e As EventArgs) Handles btnInventry.Click
        ShowControl(New InventryPanel With {.Dock = DockStyle.Fill})
    End Sub

    ''' <summary>
    ''' Add new cart with loaded product
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCashier_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        ShowControl(New Cart.CartFrm(users, UsrID) With {.Dock = DockStyle.Fill})
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        ShowControl(New CostomersFrm(UsrID) With {.Dock = DockStyle.Fill})
    End Sub

#End Region
    ''' <summary>
    ''' true if users is cashier else call full admin ui
    ''' </summary>
    ''' <param name="bool"></param>
    Public Sub Casheir(bool As Boolean)
        btnExpandContract.Visible = True
        btnExpandContract.Enabled = True
        btnHome.Enabled = True
        btnHome.Visible = True
        btnAUser.Enabled = True
        btnAUser.Visible = True
        btnCustomer.Enabled = True
        btnCustomer.Visible = True
        btnOwinCustomers.Visible = True
        btnOwinCustomers.Enabled = True
        btnProduct.Enabled = True
        btnProduct.Visible = True
        Label1.Visible = True
        Label1.Enabled = True
        lblogout.Visible = True
        lblogout.Enabled = True
        sidemenu.Enabled = True
        sidemenu.Visible = True
        btnInvoices.Visible = True
        btnInvoices.Enabled = True
        btnInventry.Enabled = True
        btnInventry.Visible = True
        btnCart.Visible = True
        btnCart.Enabled = True
        Call MainLogin() 'full admin prev
    End Sub
    Public Sub UnlocK(ByVal B As Boolean, id As Users)
        UsrID = id.Id
        If B = True Then
            Call Casheir(Not SystemAdmin)
        Else
            Call Logout()
        End If
    End Sub
    ''' <summary>
    ''' Call the LogOut function
    ''' </summary>
    Private Sub Logout()
        UsrID = 0
        btnExpandContract.Visible = False
        btnExpandContract.Enabled = False
        btnHome.Enabled = False
        btnHome.Visible = False
        btnAUser.Enabled = False
        btnAUser.Visible = False
        btnCustomer.Enabled = False
        btnCustomer.Visible = False
        btnOwinCustomers.Visible = False
        btnOwinCustomers.Enabled = False
        btnProduct.Enabled = False
        btnProduct.Visible = False
        Label1.Visible = False
        Label1.Enabled = False
        lblogout.Visible = False
        lblogout.Enabled = False
        btnInvoices.Enabled = False
        btnInvoices.Visible = False
        sidemenu.Visible = False
        sidemenu.Enabled = False
        btnInventry.Enabled = False
        btnInventry.Visible = False
        btnCart.Visible = False
        btnCart.Enabled = False
    End Sub
    ''' <summary>
    ''' call home page for administrative log in
    ''' </summary>
    Public Sub MainLogin()
        Clear()
        OptionPanel.Controls.Add(New HomeCotrols(users, UsrID) With {.Dock = DockStyle.Fill})
    End Sub
    ''' <summary>
    ''' call login page as when user log out
    ''' </summary>
    Sub MLogin()
        Clear()
        OptionPanel.Controls.Add(New Login(Me.OptionPanel))
    End Sub
    ''' <summary>
    ''' when user click the logout button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lblogout_Click(sender As Object, e As EventArgs) Handles lblogout.Click
        Using Gm As New GMessage
            If Gm.Show(Me, "Are you sure you want to log out?", "Marshell's") = DialogResult.OK Then
                AutenticatedUsers = False
                Label1.Visible = False
                Label1.Enabled = False
                lblogout.Visible = True
                lblogout.Enabled = True
                Call UnlocK(False, New Users)
                Call MLogin()
            Else
                Exit Sub
            End If
        End Using
    End Sub

    Private Sub ThemONOFF_CheckedChanged(sender As Object, e As EventArgs) Handles ThemONOFF.CheckedChanged
        If ThemONOFF.CheckedString = "Light" Then
            If MSetting.Themes = Theme.Light Then
                MSetting.Themes = Theme.Dark
                Me.BackColor = Theme.Dark
            End If
            My.Settings.Save()
        ElseIf ThemONOFF.CheckedString = "Dark" Then
            MSetting.Themes = Theme.Light
            Me.BackColor = Theme.Light
            My.Settings.Save()
        Else
            If (MSetting.Themes <> Theme.Light) Or (MSetting.Themes <> Theme.Dark) Then
                ThemONOFF.Enabled = False
            Else
                ThemONOFF.Enabled = True
            End If
        End If
        Refresh()
        Me.Invalidate()
        Call Me.OnBackColorChanged(New EventArgs)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Try
            If AutenticatedUsers = False Then
                Call MLogin()
            End If
        Catch

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LTIME.Text = Date.Now
    End Sub
    Private Sub Form1_BackColorChanged(sender As Object, e As EventArgs) Handles Me.BackColorChanged
        'If Me.BackColor = Theme.Light Then
        '    LTIME.ForeColor = Color.MediumAquamarine
        '    Label1.ForeColor = Color.MediumAquamarine
        '    'Else
        '    '    LTIME.ForeColor = Color.BlueViolet
        '    '    Label1.ForeColor = Color.DarkOliveGreen
        'Else
        '    LTIME.ForeColor = Color.MediumAquamarine
        '    Label1.ForeColor = Color.MediumAquamarine
        'End If
        If Me.BackColor = Theme.Light Then
            LTIME.ForeColor = Color.MediumAquamarine
            Label1.ForeColor = Color.Indigo
        Else
            LTIME.ForeColor = Color.MediumAquamarine
            Label1.ForeColor = Color.Indigo
        End If
    End Sub
    ''' <summary>
    ''' context show
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub show_Click(sender As Object, e As EventArgs) Handles mnu.Click
        ContextMenuStrip1.BackColor = MSetting.Themes
        Dim mnu1 As GButton = mnu
        Dim c As ContextMenuStrip = ContextMenuStrip1
        ContextMenuStrip1.Show(Me, New Point(mnu1.Location + New Point(0, 0)))
    End Sub
    Private Sub btn_click(sender As Object, e As EventArgs) Handles btnAbout.Click
        AboutBox1.ShowDialog()
    End Sub
    Private Sub Users_Settings_Click(sender As Object, e As EventArgs) Handles Users_Settings.Click
        If (UsrID = 0) Then
            GMessaage.Show(Me, "Please login to Access Users settings", "Marshell's")
        Else
            Dim ED As New UsersDX(UsrID) ' UsersEdit(SystemAdmin, UsrID, True)
            ED.ShowDialog()
        End If

    End Sub
    Private Sub Expandmenu()
        Moving = True
        Dim w = sidemenu.Width
        If w = 50 Then
            sidemenu.Size = New Size(185, sidemenu.Size.Height)
            Moving = False
        ElseIf w = 185 Then
            sidemenu.Size = New Size(50, sidemenu.Size.Height)
            Moving = False
        End If

        If AutenticatedUsers = False Then
            Call MLogin()
        End If
    End Sub

    ''' <summary>
    ''' call the main settings
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Settingst_Click(sender As Object, e As EventArgs) Handles Settingst.Click
        Dim MSettings As New MSettings()
        MSettings.ShowDialog()
        Call GradiantSettings()
    End Sub

    Private Sub GGrandiantPanel1_MouseClick(sender As Object, e As MouseEventArgs) Handles sidemenu.MouseClick
        If Expand = False Then
            Call Expandmenu()
        End If
    End Sub

    Private Sub btnCheckforUpdate_Click(sender As Object, e As EventArgs) Handles btnCheckforUpdate.Click
        Try
            Dim p As New ProcessStartInfo
            p.FileName = ("Marshell Updater.exe")
            p.UseShellExecute = True
            p.WorkingDirectory = My.Application.Info.DirectoryPath

            Process.Start(p)
        Catch ex As Exception
            GMessaage.Show("Update Agent fails .... ")
        End Try
    End Sub
    Private Sub btnDash_Click(sender As Object, e As EventArgs)
        ShowControl(New Dashfrm())
    End Sub

    Private Sub btnOwinCustomers_Click(sender As Object, e As EventArgs) Handles btnOwinCustomers.Click
        ShowControl(New OwincCustomers() With {.Dock = DockStyle.Fill})
    End Sub


    Private Sub btnInvoices_Click(sender As Object, e As EventArgs) Handles btnInvoices.Click
        ShowControl(New Invoicefrm() With {.Dock = DockStyle.Fill})
    End Sub

    Private Sub btnExpandContract_Clicked(sender As Object, e As EventArgs) Handles btnExpandContract.Click
        If Not Moving Then
            Call Expandmenu()
        End If
    End Sub
End Class
