Imports System.Windows.Forms.Message
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Media
Imports System.Threading

<ComVisible(False)>
Public Class GMessage
    Inherits Form
    Implements IDisposable

    Private Time
    Private DTime = 0
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Shadows Function Show(ByVal Message As String,
                                 Optional ByVal Title As String = "Marshell's",
                                 Optional ByVal Timer As Int32 = 0) As DialogResult
        Me.Message.Text = Message
        Me.Title_lb.Text = Title
        Time = Timer
        Me.ShowDialog()
        Return DialogResult
    End Function
    Public Shadows Function Show(Owner As Form, ByVal Message As String,
                                 Optional ByVal Title As String = "Marshell's",
                                 Optional ByVal Timer As Int32 = 0) As DialogResult
        Me.Message.Text = Message
        Me.Title_lb.Text = Title
        Time = Timer
        Me.Size = New Size(Owner.Size.Width, Owner.Size.Height / 2)
        ''' 2024 Update to direct from where to start
        ''' and asign parent form to DX
        'Me.Parent = Owner
        Me.StartPosition = FormStartPosition.CenterParent
        Me.ShowDialog()
        Return DialogResult
    End Function
    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        DTime += 1
        If Time = 0 Then
            Timer1.Stop()
        Else
            If (Time = DTime) Then
                Me.DialogResult = DialogResult.Cancel
                Me.Dispose()
            End If
        End If
    End Sub
    ''''Public Shared Shadows Function Show(ByVal owner As IWin32Window, ByVal message As String, ByVal title As String, ByVal buttons As MessageBoxButtons, ByVal icon As MessageBoxIcon, ByVal defaultbutton As MessageBoxDefaultButton, ByVal Optional height As Integer = &HD3) As DialogResult
    ''''    Dim none As DialogResult = DialogResult.None
    ''''    If (owner IsNot Nothing) Then
    ''''        Dim form As Form = DirectCast(owner, Form)
    ''''        Dim width As Integer = 500
    ''''        Dim num2 As Integer = 350
    ''''        If ((form.Size.Width < width) OrElse (form.Size.Height < num2)) Then
    ''''            If ((form.Size.Width < width) AndAlso (form.Size.Height < num2)) Then
    ''''                form.Size = New Size(width, num2)
    ''''            ElseIf (form.Size.Width < width) Then
    ''''                form.Size = New Size(width, form.Size.Height)
    ''''            Else
    ''''                form.Size = New Size(form.Size.Width, num2)
    ''''            End If
    ''''            Dim x As Integer = Convert.ToInt32(Math.Ceiling(CDec(((Screen.PrimaryScreen.WorkingArea.Size.Width / 2) - (form.Size.Width / 2)))))
    ''''            Dim y As Integer = Convert.ToInt32(Math.Ceiling(CDec(((Screen.PrimaryScreen.WorkingArea.Size.Height / 2) - (form.Size.Height / 2)))))
    ''''            form.Location = New Point(x, y)
    ''''        End If
    ''''        Select Case icon
    ''''            Case MessageBoxIcon.Hand
    ''''                SystemSounds.Hand.Play()
    ''''                Exit Select
    ''''            Case MessageBoxIcon.Question
    ''''                SystemSounds.Beep.Play()
    ''''                Exit Select
    ''''            Case MessageBoxIcon.Exclamation
    ''''                SystemSounds.Exclamation.Play()
    ''''                Exit Select
    ''''            Case Else
    ''''                SystemSounds.Asterisk.Play()
    ''''                Exit Select
    ''''        End Select
    ''''        Dim control As New GMessage With {
    ''''              .BackColor = form.BackColor
    ''''               }
    ''''        '   control.Properties.Buttons = buttons
    ''''        '  control.Properties.DefaultButton = defaultbutton
    ''''        '   control.Properties.Icon = icon
    ''''        '   control.Properties.Message = message
    ''''        '    control.Properties.Title = title
    ''''        control.Padding = New Padding(0, 0, 0, 0)
    ''''        control.ControlBox = False
    ''''        control.ShowInTaskbar = False
    ''''        control.Size = New Size(form.Size.Width, height)
    ''''        control.Location = New Point(form.Location.X, (form.Location.Y + ((form.Height - control.Height) / 2)))
    ''''        ' control.ArrangeApperance
    ''''        Dim num5 As Integer = Convert.ToInt32(Math.Floor(CDbl((control.Size.Height * 0.28))))
    ''''        control.ShowDialog()
    ''''        control.BringToFront()
    ''''        ' control.SetDefaultButton
    ''''        '  Dim action As Action(Of Control) = New Action(Of Control)(AddressOf ModalState)
    ''''        '   Dim result2 As IAsyncResult = action.BeginInvoke(control, Nothing, action)
    ''''        Dim flag5 As Boolean = False
    ''''        'Try
    ''''        '    'Do While Not GMessage.Control.IsCompleted
    ''''        '    '    Thread.Sleep(1)
    ''''        '    '    Application.DoEvents()
    ''''        '    'Loop
    ''''        'Catch obj1 As Object
    ''''        '    flag5 = True
    ''''        '    If Not result2.IsCompleted Then
    ''''        '        Try
    ''''        '            result2 = Nothing
    ''''        '        Catch obj2 As Object
    ''''        '        End Try
    ''''        '    End If
    ''''        '    action = Nothing
    ''''        'End Try
    ''''        'If Not flag5 Then
    ''''        '    'none = control.Result
    ''''        '    control.Dispose()
    ''''        '    control = Nothing
    ''''        'End If
    ''''    End If
    ''''    Return none
    ''''End Function
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        Dispose(False)
        GC.SuppressFinalize(Me)
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class