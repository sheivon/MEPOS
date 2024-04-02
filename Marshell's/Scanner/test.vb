Imports MessagingToolkit.Barcode

Public Class test

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            PictureBox1.Image = Scanner.Generate(TextBox1.Text)
            PictureBox2.Image = Scanner.Generate(TextBox1.Text, BarcodeFormat.Code128A)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Label1.Text = Scanner.DecodeToText(PictureBox1.Image)
            Label2.Text = Scanner.DecodeToText(PictureBox2.Image)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            PictureBox1.Image = Scanner.Generate(TextBox1.Text)
            PictureBox2.Image = Scanner.Generate(TextBox1.Text, BarcodeFormat.Code128A)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class