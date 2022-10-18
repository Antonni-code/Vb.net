Public Class clsFactorial
    Function getFactor(input As Long) As String
        Dim factor, i As Long

        factor = 1
        If (input < 0) Then
            MsgBox("There is no Factorial for -negative numbers")
        Else
            For i = 1 To input
                factor = factor * i
            Next i
            Return factor
        End If
    End Function
End Class
