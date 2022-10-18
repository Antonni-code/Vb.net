Public Class clsSeriesadd1
    Function getSeriesby1(n As Integer) As String
        Dim a, b, c, d As Integer
        Dim str As String
        a = 2
        c = 3
        For i = 1 To n
            a += 1
            b = a
            a = b
            d = c + b
            c = d
            str &= " " & c
        Next

        Return str
    End Function

End Class
