Imports System.Drawing

Public Class Theme
    ''' <summary>
    ''' This is the color for Dark themes
    ''' </summary>
    ''' <returns>dark color</returns>
    Public Shared Property D = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
    ''' <summary>
    ''' This is the color for the white or light themes
    ''' </summary>
    ''' <returns>white color</returns>
    Public Shared Property L = Color.WhiteSmoke

    Public Shared Function Dark() As Color
        Return D
    End Function
    Public Shared Function Light() As Color
        Return L
    End Function
    Public Shared Function Indigo() As Color
        Return Color.Indigo
    End Function
End Class
