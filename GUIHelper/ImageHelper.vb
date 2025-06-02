Imports System.Drawing
Imports System.Drawing.Imaging

Public Class ImageHelper
    ' Methods
    Shared Sub New()

        Dim numArray As Single()() = New Single(5 - 1)() {}
        numArray(0) = New Single() {0.299!, 0.299!, 0.299!, 0.0!, 0.0!}
        numArray(1) = New Single() {0.587!, 0.587!, 0.587!, 0.0!, 0.0!}
        numArray(2) = New Single() {0.114!, 0.114!, 0.114!, 0.0!, 0.0!}
        Dim numArray2 As Single() = New Single(5 - 1) {}
        numArray2(3) = 1.0!
        numArray(3) = numArray2
        Dim numArray3 As Single() = New Single(5 - 1) {}
        numArray3(4) = 1.0!
        numArray(4) = numArray3
        ImageHelper._colorMatrixElements = numArray
        ImageHelper._grayscaleColorMatrix = New ColorMatrix(ImageHelper._colorMatrixElements)
    End Sub

    Public Shared Function GetGrayscaleAttributes() As ImageAttributes
        Dim attributes As New ImageAttributes
        attributes.SetColorMatrix(ImageHelper._grayscaleColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap)
        Return attributes
    End Function

    Public Shared Function RescaleImageToFit(ByVal imageSize As Size, ByVal canvasSize As Size) As Size
        Dim num As Double = (CDbl(canvasSize.Width) / CDbl(imageSize.Width))
        Dim num2 As Double = (CDbl(canvasSize.Height) / CDbl(imageSize.Height))
        Dim num3 As Double = Math.Min(num, num2)
        Dim height As Integer = System.Convert.ToInt32(CDbl((imageSize.Height * num3)))
        Dim width As Integer = System.Convert.ToInt32(CDbl((imageSize.Width * num3)))
        Dim size As New Size(width, height)
        If ((size.Width > canvasSize.Width) OrElse (size.Height > canvasSize.Height)) Then
            Throw New Exception("ImageHelper.RescaleImageToFit - Resize failed!")
        End If
        Return size
    End Function


    ' Fields
    Private Shared _colorMatrixElements As Single()()
    Private Shared _grayscaleColorMatrix As ColorMatrix
End Class
