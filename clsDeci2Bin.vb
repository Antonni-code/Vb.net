Public Class clsDeci2Bin
    Function getBin(input As Integer) As String
        Dim lentext, mods As Integer
        Dim text, resultbin As String
        Dim chars As Char
        mods = input Mod 2

        While (input > 0)
            text &= mods
            input = input \ 2
            mods = input Mod 2
        End While

        lentext = Len(text)
        For i As Integer = lentext To 1 Step -1
            chars = Mid(text, i, 1)
            resultbin += chars
        Next
        Return resultbin
    End Function

    'Function Deci2Bin(input as integer) as string
    'input, div as integer
    'text, result, output as string
    '
    'input = txtinput
    'output = txtoutput

    'while (input > 0)
    '
    'text = input mod 2
    'div = input \ 2 
    'input = div 
    'result = text + output
    'output = result
    '
    'end while 
    'return output

End Class
