Imports MessagingToolkit.Barcode
Imports System

Public Class Barcode
    Private Property GetBCfromSetting As String = My.Settings.Barcode
    Private bc As String
    Private bcname As String = My.Settings.BCName

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        GetBCfromSetting = My.Settings.Barcode
        If (String.IsNullOrEmpty(GetBCfromSetting) = False) Then
            GetImage(GetBCfromSetting)
            ComboBox1.Text = GetBCfromSetting
        End If
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim Item As String = ComboBox1.Text
        'MsgBox(Item)
        GetImage(Item)
    End Sub

    Private Sub GetImage(BNC As String)
        bcname = BNC
        If (BNC = "Codabar") Then
            bc = BarcodeFormat.Codabar
            PictureBox1.Image = My.Resources.Codabar
        ElseIf (BNC = "Code11") Then
            bc = BarcodeFormat.Code11
            PictureBox1.Image = My.Resources.Code11
        ElseIf (BNC = "Code128") Then
            bc = BarcodeFormat.Code128
            PictureBox1.Image = My.Resources.Code128
        ElseIf (BNC = "Code39") Then
            bc = BarcodeFormat.Code39
            PictureBox1.Image = My.Resources.Code39
        ElseIf (BNC = "Code39Ext") Then
            bc = BarcodeFormat.Code39Extended
            PictureBox1.Image = My.Resources.Code39Ext
        ElseIf (BNC = "Code93") Then
            bc = BarcodeFormat.Code93
            PictureBox1.Image = My.Resources.Code93Ext
        ElseIf (BNC = "EAN13") Then
            bc = BarcodeFormat.EAN13
            PictureBox1.Image = My.Resources.EAN13
        ElseIf (BNC = "EAN8") Then
            bc = BarcodeFormat.EAN8
            PictureBox1.Image = My.Resources.EAN8
        ElseIf (BNC = "ITF14") Then
            bc = BarcodeFormat.ITF14
            PictureBox1.Image = My.Resources.ITF14
        ElseIf (BNC = "Postnet") Then
            bc = BarcodeFormat.PostNet
            PictureBox1.Image = My.Resources.Postnet
        ElseIf (BNC = "S2of5") Then
            bc = BarcodeFormat.Standard2of5
            PictureBox1.Image = My.Resources.S2of5
        ElseIf (BNC = "UPCA") Then
            bc = BarcodeFormat.UPCA
            PictureBox1.Image = My.Resources.UPCA
        ElseIf (BNC = "UPCE") Then
            bc = BarcodeFormat.UPCE
            PictureBox1.Image = My.Resources.UPCE
        ElseIf (BNC = "QRCode") Then
            bc = BarcodeFormat.QRCode
            PictureBox1.Image = My.Resources.QRCode
        End If
    End Sub

    Private Sub Barcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GButton1_Click(sender As Object, e As EventArgs) Handles GButton1.Click
        My.Settings.BCName = bcname
        My.Settings.Barcode = ComboBox1.Text
        My.Settings.Save()
    End Sub
End Class
