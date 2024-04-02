Imports System.Windows.Forms
Imports GUIHelper


Public Class MSettings
    Private Property title As String = "Marshell's"
    Private Property GMessage As New GMessage
    Private Sub GButton1_Click(sender As Object, e As EventArgs) Handles GButton1.Click
        Me.Panel1.Controls.Clear()
        Me.Panel1.Controls.Add(New Barcode With {.Dock = DockStyle.Fill, .AutoScaleMode = Windows.Forms.AutoScaleMode.None})
    End Sub

    Private Sub GButton2_Click(sender As Object, e As EventArgs) Handles GButton2.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub GButton3_Click(sender As Object, e As EventArgs) Handles GButton3.Click
        Me.Panel1.Controls.Clear()
        Me.Panel1.Controls.Add(New BottomBar With {.Dock = DockStyle.Fill, .AutoScaleMode = Windows.Forms.AutoScaleMode.None})
    End Sub

    Private Sub GButton4_Click(sender As Object, e As EventArgs) Handles GButton4.Click
        Panel1.Controls.Clear()
        Panel1.Controls.Add(New LoginColorSettings With {.Dock = DockStyle.Fill, .AutoScaleMode = Windows.Forms.AutoScaleMode.None})
    End Sub

    Private Sub GButton5_Click(sender As Object, e As EventArgs) Handles GButton5.Click
        If GMessage.Show("Are you sure Reset to Default", title) = 1 Then
            My.Settings.Reset()
            My.Settings.Save()
        End If
    End Sub

    Private Sub GButton6_Click(sender As Object, e As EventArgs) Handles GButton6.Click
        Panel1.Controls.Clear()
        Panel1.Controls.Add(New PrntPagae With {.Dock = DockStyle.Fill, .AutoScaleMode = Windows.Forms.AutoScaleMode.None})
    End Sub

    Private Sub MSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Panel1.Controls.Clear()
        Me.Panel1.Controls.Add(New Barcode With {.Dock = DockStyle.Fill, .AutoScaleMode = Windows.Forms.AutoScaleMode.None})
    End Sub

    Private Sub GButton7_Click(sender As Object, e As EventArgs) Handles GButton7.Click
        Panel1.Controls.Clear()
        Panel1.Controls.Add(New MoneyfrmSettings With {.Dock = DockStyle.Fill, .AutoScaleMode = Windows.Forms.AutoScaleMode.None})
    End Sub

    Private Sub GButton8_Click(sender As Object, e As EventArgs) Handles GButton8.Click
        Panel1.Controls.Clear()
        Panel1.Controls.Add(New ConnectionDiag With {.Dock = DockStyle.Fill, .AutoScaleMode = Windows.Forms.AutoScaleMode.None})
    End Sub
End Class
