Imports System.Drawing
Imports System.Runtime.CompilerServices

Module GraphicsExtensionMethods
    ' Methods
    <Extension()>
    Public Function ToGrayScale(ByVal originalColor As Color) As Color
        If originalColor.Equals(Color.Transparent) Then
            Return originalColor
        End If
        Dim red As Integer = CInt((((originalColor.R * 0.299) + (originalColor.G * 0.587)) + (originalColor.B * 0.114)))
        Return Color.FromArgb(red, red, red)
    End Function
End Module
