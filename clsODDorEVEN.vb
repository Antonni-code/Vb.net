Public Class clsODDorEVEN
    Function getEVENODD(input As Integer) As String
        Dim str As String
        str = Form2.txtOutputAA.Text
        input = Val(Form2.txtInputAA.Text)
        If (input Mod 2) = 0 Then
            str = "Even number"
        Else
            str = "Odd number"
        End If

        Return str
    End Function
End Class
