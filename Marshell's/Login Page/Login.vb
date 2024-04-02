Imports System.IO
Imports System.Runtime.InteropServices
Imports GUIHelper
Imports MarshellsSettings
Imports InvoicePrinter
Imports MySql.Data.MySqlClient
Imports Entities
Imports DataBase

Public Class Login
    Private Property Title As String = "Marshell's"
    Private Property GMessage As New GMessage
    Private Property Melocation As Point
    Sub New(ByVal parent As System.Windows.Forms.Form)
        InitializeComponent()
        Melocation = New Point(parent.Width, parent.Height)
        SetUI(Melocation)
        Call GetUISettings()
    End Sub
    Sub New(parent As Panel)
        InitializeComponent()
        Melocation = New Point(parent.Width, parent.Height)
        Me.DoubleBuffered = True
        SetUI(Melocation)
        Call GetUISettings()
    End Sub
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim usr As Users
        ''load next 
        Dim username As String = ""
        Dim password As String = Pass.Text
        Dim login As String = Usrname.Text
        Try
            If String.IsNullOrEmpty(login) = True Or String.IsNullOrEmpty(password) = True Then
                GMessage.Show("Login Field's can't be empty", Title, 6)
                Exit Sub
            End If
            usr = DataModule.Login(login, password)

            Dim Fire = usr.Fired
            If usr.Name <> "" Then
                If Fire = 1 Or Fire = True Then
                    Usrname.ResetText()
                    Pass.ResetText()
                    GMessage.Show("THIS EMPLOYEE NO LONGER WORKS HERE." & vbLf & "!!FIRED!!")
                Else
                    Form1.AutenticatedUsers = True
                    If usr.Role = "SYSTEMADMINISTRATOR" Then
                        Form1.SystemAdmin = True
                    Else              'if worker role is cashier then call the form as non admin
                        Form1.SystemAdmin = False
                    End If
                    Form1.users = usr.Name
                    Form1.UsrID = usr.Id
                    Form1.Label1.Text = String.Format("LOGIN AS | {0} | {1}", usr.Name.ToUpper, usr.Role)
                    Form1.Tag = usr.Name
                    Call Form1.UnlocK(True, usr)
                End If
            Else
                'Usrname.ResetText()
                Pass.ResetText()
                GMessage.Show("! ACCESS DENIED !", Title, 5)
                Exit Sub
            End If
        Catch ex As Exception
#If DEBUG Then
            GMessage.Show(Me.ParentForm, "Reconfigure the Server Configuration in settings...." & Environment.NewLine & (ex.Message), Title, 9)
#End If
        End Try
    End Sub

    Private Sub Autenticated_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GetUISettings()
    End Sub
    Sub SetUI(L As Point)
        Me.MainUI.Location = New Point((L.X / 2) - (MainUI.Size.Width / 2), (L.Y / 2) - (MainUI.Height / 2))
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private Sub Pass_KeyDown(sender As Object, e As KeyEventArgs) Handles Usrname.KeyDown, Pass.KeyDown, MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSubmit.PerformClick()
        ElseIf e.KeyCode = Keys.Up Then
            Usrname.Focus()
        ElseIf e.KeyCode = Keys.Down Then
            Pass.Focus()
        End If
        Refresh()
    End Sub
    Private Sub Login_BackColorChanged(sender As Object, e As EventArgs) Handles MyBase.BackColorChanged
        Usrname.BackColor = Me.BackColor
        Pass.BackColor = Me.BackColor
    End Sub
    Private Sub GetUISettings()
        If MSetting.LoginIsGradient = True Then
            MainUI.GradientStartColor = MSetting.LoginStartColor
            MainUI.GradientEndColor = MSetting.LoginEndColor
            MainUI.PanelStyle = GGrandiantPanel.GPanelStyle.Gradiant
        Else
            MainUI.PanelStyle = GGrandiantPanel.GPanelStyle.Clasic
        End If
    End Sub

    Private Sub Pass_TextChanged(sender As Object, e As EventArgs) Handles Pass.TextChanged
        If Pass.TextLength > 0 Then
            BtnSubmit.Enabled = True
            BtnSubmit.Visible = True
        Else
            BtnSubmit.Visible = False
            BtnSubmit.Enabled = False
        End If
    End Sub

    Private Sub Login_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, MainUI.MouseDown
        Me.Refresh()
    End Sub

    Private Sub btnViewPass_MouseHover(sender As Object, e As EventArgs) Handles btnViewPass.MouseHover
        Pass.UseSystemPasswordChar = False
    End Sub

    Private Sub btnViewPass_MouseLeave(sender As Object, e As EventArgs) Handles btnViewPass.MouseLeave
        Pass.UseSystemPasswordChar = True
    End Sub
End Class
