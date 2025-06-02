Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms


Public Class GTxt
    Inherits TextBox


    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function



    ''Declare A Few Variables
    Private WaterText As String = "GTXT"
    'Dim WaterColor As Color
    ''Dim WaterFont As Font
    ''Dim WaterBrush As SolidBrush
    'Dim WaterTextAling As HorizontalAlignment
    'Dim WaterContainer As Panel
    ''new init
    'Public Sub New()
    '    MyBase.New()
    '    SetStyle(ControlStyles.AllPaintingInWmPaint, True)
    '    SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    '    SetStyle(ControlStyles.SupportsTransparentBackColor, True)
    '    StartProcess()
    'End Sub
    '''Init Comp
    'Private Sub StartProcess()
    '    'Assign Values To the Variables
    '    WaterText = "GText"
    '    WaterColor = Color.Gray
    '    WaterFont = New Font(Me.Font, FontStyle.Italic)
    '    WaterBrush = New SolidBrush(WaterColor)
    '    '
    '    ' create watermakr 
    '    '
    '    CreateWatermark()
    '    AddHandler TextChanged, AddressOf ChangeText
    '    AddHandler FontChanged, AddressOf ChangeFont
    '    AddHandler MyBase.Enter, AddressOf GotF
    '    AddHandler MyBase.Click, AddressOf Me.Clicked
    'End Sub

    'Private Sub CreateWatermark()
    '    WaterContainer = New Panel
    '    AddHandler WaterContainer.Paint, New PaintEventHandler(AddressOf Me.Painted)
    '    AddHandler Me.WaterContainer.Click, New EventHandler(AddressOf Me.Clicked)
    '    MyBase.Controls.Add(Me.WaterContainer)
    '    'AddHandler MyBase.Leave, AddressOf LostF 
    '    Refresh()
    'End Sub
    'Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
    '    MyBase.OnPaint(e)
    '    CreateWatermark()
    'End Sub
    'Protected Overrides Sub OnInvalidated(e As InvalidateEventArgs)
    '    MyBase.OnInvalidated(e)
    '    Me.WaterContainer.Invalidate()
    'End Sub
    'Private Sub GotF(sender As Object, e As EventArgs)
    '    Me.WaterBrush = New SolidBrush(Color.Gray)
    '    If (Me.TextLength <= 0) Then
    '        Me.RemoveWatermark()
    '        CreateWatermark()
    '    End If
    'End Sub

    ''Private Sub LostF(sender As Object, e As EventArgs)
    ''    If (Me.TextLength > 0) Then
    ''        Me.RemoveWaterMark()
    ''    Else
    ''        MyBase.Invalidate()
    ''    End If
    ''End Sub

    'Private Sub RemoveWatermark()
    '    Me.Controls.Remove(WaterContainer)
    '    Refresh()
    'End Sub

    'Private Sub ChangeText(sender As Object, e As EventArgs)
    '    If Me.TextLength <= 0 Then
    '        CreateWatermark()
    '    ElseIf Me.TextLength > 0 Then
    '        RemoveWaterMark()
    '    End If
    'End Sub

    'Private Sub ChangeFont(sender As Object, e As EventArgs)
    '    WaterFont = New Font(Me.Font, FontStyle.Italic)
    'End Sub

    'Private Sub Clicked(sender As Object, e As EventArgs)
    '    Me.Focus()
    'End Sub
    'Private Sub Painted(ByVal sender As Object, ByVal e As PaintEventArgs)
    '    MyBase.OnPaint(e)
    '    If WatermarkTextAling = HorizontalAlignment.Center Then
    '        WaterContainer.Location = New Point(CInt((WaterContainer.Width / 3) - 2), 0)
    '    ElseIf WatermarkTextAling = HorizontalAlignment.Right Then
    '        WaterContainer.Location = New Point(Me.ClientRectangle.Width, 0)
    '    Else
    '        WaterContainer.Location = New Point(1, 0)
    '    End If
    '    WaterContainer.Anchor = AnchorStyles.Left Or AnchorStyles.Right
    '    WaterContainer.Height = Me.Height
    '    WaterContainer.Width = Me.Width
    '    Try
    '        If Not MyBase.ContainsFocus Then
    '            WaterBrush = New SolidBrush(WaterColor)
    '        Else
    '            WaterBrush = New SolidBrush(Color.LightCoral)
    '        End If
    '        GC.Collect()
    '        GC.WaitForPendingFinalizers()
    '        e.Graphics.DrawString(WaterText, WaterFont, WaterBrush, New PointF(-2.0!, 1.0!))
    '    Catch ex As Exception

    '    End Try
    'End Sub
    'Protected Overrides Sub Finalize()
    '    MyBase.Finalize()
    'End Sub

    <Category("Watermark Attributes"), Description("Sets Watermark Text")>
    Public Property WatermarkText As String
        Get
            Return WaterText
        End Get
        Set(value As String)
            WaterText = value
            UpdateW()
            'Me.Invalidate()
        End Set
    End Property
    Private Sub UpdateW()
        If Me.IsHandleCreated AndAlso WaterText IsNot Nothing Then
            If BackColor = Theme.Dark Then
                ForeColor = Color.DarkOrchid
            ElseIf BackColor = Theme.Light Then
                ForeColor = Color.Maroon
            End If
            SendMessage(Me.Handle, &H1501, New IntPtr(1), WaterText)
        Else
            If BackColor = Theme.Light Then
                ForeColor = Color.LightCoral
            ElseIf BackColor = Theme.Dark Then
                ForeColor = Color.MediumAquamarine
            End If
        End If
    End Sub
    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)
        UpdateW()
    End Sub

    Private Sub GTxt_BackColorChanged(sender As Object, e As EventArgs) Handles Me.BackColorChanged
        If Me.BackColor = Theme.Dark Then
            Me.ForeColor = Theme.L
        ElseIf Me.BackColor = Theme.Light Then
            Me.ForeColor = Theme.Dark
        End If
        SendMessage(Me.Handle, &H1501, New IntPtr(1), WaterText)
    End Sub
End Class
