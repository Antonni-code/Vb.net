Public Class clsOddSeries
    Function getODD(input As ULong) As String
        Dim n, n2 As ULong
        Dim str As String
        n = 1
        For i As Integer = 1 To input
            n2 = n + 2
            n = n2
            str = str & " " & n
        Next
        Return str
    End Function
End Class
