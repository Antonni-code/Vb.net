Public Class clsSeriesby2
    Function getSby2(u As ULong) As String
        Dim n, n2 As ULong
        Dim str As String

        n = 1
        For i As ULong = 1 To u
            n2 = n + n
            n = n2
            str = str & " " & n
        Next
        Return str
    End Function
End Class
