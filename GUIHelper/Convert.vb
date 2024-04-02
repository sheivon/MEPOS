Public Class Convert
    Public Shared Function ToInt(s As String) As Integer
        Dim n = CInt((s))
        Return n
    End Function

    Public Shared Function ToFloat(S As String) As Single
        Dim f As Single = S
        Return f
    End Function
    Public Shared Function ToDouble(S As String) As Double
        Return CDbl(Val(S))
    End Function
End Class
