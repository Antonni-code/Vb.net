Public Class clsReverse
    Function REVERSE(input As String) As String
        Dim reversestr, result As String
        Dim chars As Char()

        For i As Integer = input.Length To 1 Step -1
            chars = Mid(input, i, 1)
            reversestr += chars
            result = reversestr
        Next
        Return result
    End Function

End Class
