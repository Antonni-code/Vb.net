Public Class clsEvenSeries
    Function getEVEN(input As ULong) As String
        Dim num, even As ULong
        Dim str As String
        num = 2
        For i As Integer = 0 To input - 2
            even = num + 2
            num = even
            str = str & " " & num
        Next
        Return str
    End Function
End Class
