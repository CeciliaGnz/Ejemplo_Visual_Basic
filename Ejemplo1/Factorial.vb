Public Class Factorial
    Private num As Integer
    Public Sub asignar(ByVal valor As Integer)
        num = valor
    End Sub

    Public Function calcularFactorial() As Integer
        Dim cont As Integer
        calcularFactorial = 1
        For cont = 1 To num
            calcularFactorial *= cont
        Next
    End Function
End Class
