Imports System.Drawing
Imports MessagingToolkit.Barcode

Public Module BC_DEC_ENC
    Public Function Decode(img As Image)
        Dim Dec As New BarcodeDecoder
        Return Dec.Decode(img).ToString()
    End Function
End Module
