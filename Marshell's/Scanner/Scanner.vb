Imports GUIHelper
Imports MessagingToolkit
Imports MessagingToolkit.Barcode

Imports MarshellsSettings

Public Class Scanner
    Shared Property GMESSAGE As New GMessage
    Shared Property TITLE As String = "Marshell's"

    Shared Property bct As BarcodeFormat = MSetting.GetBarcodeType()
    ''' <summary>
    ''' Make a Barcode with provided text
    ''' </summary>
    ''' <param name="lb"></param>
    ''' <returns></returns>
    Public Shared Function Generate(lb As String) As Image
        Dim a As New BarcodeEncoder
        bct = MSetting.GetBarcodeType()
        Try

            a.Encode(bct, lb)
            a.Height = 500
            a.Width = 500
            a.ImageFormat = Imaging.ImageFormat.Jpeg
            a.Alignment = AlignmentPositions.Center
            a.LabelPosition = LabelPositions.BottomCenter
            a.IncludeLabel = True
        Catch ex As Exception
#If DEBUG Then
            GMESSAGE.Show(Form1, ex.Message, TITLE)
#End If
        End Try

        ''' 
        ''' return the redered barcode
        '''
        Return a.EncodedImage
    End Function
    Public Shared Function Generate(lb As String, bct As BarcodeFormat) As Image
        Dim a As New BarcodeEncoder
        Try

            a.Encode(bct, lb)
            a.Height = 500
            a.Width = 500
            a.ImageFormat = Imaging.ImageFormat.Jpeg
            a.Alignment = AlignmentPositions.Center
            a.LabelPosition = LabelPositions.BottomCenter
            a.IncludeLabel = True
        Catch ex As Exception
#If DEBUG Then
            GMESSAGE.Show(Form1, ex.Message, TITLE)
#End If
        End Try

        ''' 
        ''' return the redered barcode
        '''
        Return a.EncodedImage
    End Function
    ''' <summary>
    ''' Decode the barcode 
    ''' </summary>
    ''' <param name="pik"></param>
    ''' <returns></returns> 
    Public Shared Function DecodeToText(pik As Image) As String
        Dim a As New BarcodeDecoder
        Return a.Decode(pik).Text
    End Function
    Private Function GetBarcodeFormat(BNC As String) As BarcodeFormat
        Dim bc As BarcodeFormat
        If (BNC = "Codabar") Then
            bc = BarcodeFormat.Codabar
        ElseIf (BNC = "Code11") Then
            bc = BarcodeFormat.Code11
        ElseIf (BNC = "Code128") Then
            bc = BarcodeFormat.Code128
        ElseIf (BNC = "Code39") Then
            bc = BarcodeFormat.Code39
        ElseIf (BNC = "Code39Ext") Then
            bc = BarcodeFormat.Code39Extended
        ElseIf (BNC = "Code93") Then
            bc = BarcodeFormat.Code93
        ElseIf (BNC = "EAN13") Then
            bc = BarcodeFormat.EAN13
        ElseIf (BNC = "EAN8") Then
            bc = BarcodeFormat.EAN8
        ElseIf (BNC = "ITF14") Then
            bc = BarcodeFormat.ITF14
        ElseIf (BNC = "Postnet") Then
            bc = BarcodeFormat.PostNet
        ElseIf (BNC = "S2of5") Then
            bc = BarcodeFormat.Standard2of5
        ElseIf (BNC = "UPCA") Then
            bc = BarcodeFormat.UPCA
        ElseIf (BNC = "UPCE") Then
            bc = BarcodeFormat.UPCE
        ElseIf (BNC = "QRCode") Then
            bc = BarcodeFormat.QRCode
        End If
        Return bc
    End Function
End Class
