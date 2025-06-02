Imports System.Windows.Forms
Imports GUIHelper
Imports MySql.Data.MySqlClient

Public Class ConnectionDiag
    Private GMessage As New GMessage()
    Private Function ConnectionstringBuilder(sr As String, db As String, un As String, ps As String, Optional pr As Int32 = 0) As String
        Dim dbs As String = "server=" & sr & IIf(pr = 0, "", String.Format(";Port={0}", pr)) & ";database=" & db & ";user id=" & un & ";password=" & ps & ";"
        Return dbs
    End Function
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        If (String.IsNullOrEmpty(txtDatabase.Text) = False) Or
              (String.IsNullOrEmpty(txtServer.Text) = False) Or
              (String.IsNullOrEmpty(txtPass.Text) = False) Or
              (String.IsNullOrEmpty(txtUsername.Text) = False) Then
            Dim dbs As String = ConnectionstringBuilder(txtServer.Text, txtDatabase.Text, txtUsername.Text, txtPass.Text, txtPort.Text)
            If TestConnection(dbs) Then
                GMessage.Show("Connected!")
            Else
                GMessage.Show("Fail to Connect!")
            End If
        End If
    End Sub

    Private Sub btnSaveConn_Click(sender As Object, e As EventArgs) Handles btnSaveConn.Click
        Try
            If (String.IsNullOrEmpty(txtDatabase.Text) = False) Or
                (String.IsNullOrEmpty(txtServer.Text) = False) Or
                (String.IsNullOrEmpty(txtPass.Text) = False) Or
                (String.IsNullOrEmpty(txtUsername.Text) = False) Then
                Dim dbs As String = ConnectionstringBuilder(txtServer.Text, txtDatabase.Text, txtUsername.Text, txtPass.Text, txtPort.Text)
                If TestConnection(dbs) Then
                    MSetting.Server = txtServer.Text
                    MSetting.Database = txtDatabase.Text
                    MSetting.username = txtUsername.Text
                    MSetting.password = txtPass.Text
                    MSetting.port = txtPort.Text
                    GMessage.Show("Save Succesfull")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function TestConnection(dbs As String) As Boolean
        Try
            Using con As MySqlConnection = New MySqlConnection(dbs)
                con.Open()
                If con.State = Data.ConnectionState.Open Then
                    con.Close()
                    Return True
                Else
                    con.Close()
                    Return False
                End If
                con.Close()
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub ConnectionDiag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUIData()
    End Sub
    Private Sub LoadUIData()
        txtServer.Text = MSetting.Server
        txtDatabase.Text = MSetting.Database
        txtPort.Text = MSetting.port
        err.GetError(txtUsername)
        err.GetError(txtPass)
    End Sub

    Private Sub GButton1_Click(sender As Object, e As EventArgs) Handles GButton1.Click
        If TestConnection(MSetting.GetConnectionstring()) Then
            GMessage.Show("Connected!")
        Else
            GMessage.Show("Failled!")
        End If
    End Sub

    Private Sub txtPort_TextChanged(sender As Object, e As EventArgs) Handles txtPort.TextChanged

    End Sub

    Private Sub txtPort_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPort.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class