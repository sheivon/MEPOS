Imports GUIHelper
Imports System.Drawing.Printing
Imports System.Drawing
Imports System.Windows.Forms


Public Class PrntPagae
    Private Property PW As Boolean = My.Settings.PrintW
    Private Property Preview As Boolean = My.Settings.PrintPreview
    Private Sub CbxFont_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub PrntPagae_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If PW = False Then
            PS.Checked = False
        Else
            PS.Checked = True
        End If
        If Preview = True Then
            CbxPP.Checked = True
        Else
            CbxPP.Checked = False
        End If
    End Sub

    Private Sub PS_CheckedChanged(sender As Object, e As EventArgs) Handles PS.CheckedChanged
        If PS.Checked = True Then
            My.Settings.PrintW = True
        Else
            My.Settings.PrintW = False
        End If
        My.Settings.Save()
    End Sub

    Private Sub CbxPP_CheckedChanged(sender As Object, e As EventArgs) Handles CbxPP.CheckedChanged
        If CbxPP.CheckState = CheckState.Checked Then
            My.Settings.PrintPreview = True
        Else
            My.Settings.PrintPreview = False
        End If
        My.Settings.Save()
    End Sub
End Class
