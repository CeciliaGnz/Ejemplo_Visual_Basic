Public Class frmEjemplo5
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        'If IsNumeric(txtNum.Text) Then
        'MsgBox("Es un número")
        'Else
        'MsgBox("Es un String")

        Dim numero As Integer
        Dim objFactorial As New Factorial
        numero = Val(txtNum.Text)
        lstimpresion.Items.Clear()
        If numero >= 0 Then
            For z = 0 To numero
                objFactorial.asignar(z)
                lstimpresion.Items.Add(z & "!= " & objFactorial.calcularFactorial())
            Next
        End If
    End Sub
End Class