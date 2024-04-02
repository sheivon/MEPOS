Imports System.Drawing
Imports System.Windows.Forms
Imports System
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Drawing.Drawing2D
Public Class GProgressBar
    Private Sub GProgressBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Panel2.Location = New Point(Me.Size.Width - Panel2.Size.Width, Panel2.Location.Y)
        Panel3.Location = New Point(0, Panel3.Location.Y)
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Panel2.Location.X >= CInt(Me.Size.Width - Panel2.Size.Width) Then
            Panel2.Location = New Point(0, Panel2.Location.Y)
        Else
			if Bk.isbusy() = true then
			else
            Bk.RunWorkerAsync()
			end if
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Panel3.Location.X <= 0 Then
            Panel3.Location = New Point(CInt(Me.Size.Width - Panel3.Width), Panel3.Location.Y)
        Else
           if Bk2.isbusy() = true then
			else
            Bk2.RunWorkerAsync()
			end if
        End If
    End Sub

    Private Sub Bk_DoWork(sender As Object, e As DoWorkEventArgs) Handles Bk.DoWork
        Panel2.Location = New Point(Panel2.Location.X + 30, Panel2.Location.Y)
    End Sub

    Private Sub Bk2_DoWork(sender As Object, e As DoWorkEventArgs) Handles Bk2.DoWork
        Panel3.Location = New Point(Panel3.Location.X - 30, Panel3.Location.Y)
    End Sub
End Class
