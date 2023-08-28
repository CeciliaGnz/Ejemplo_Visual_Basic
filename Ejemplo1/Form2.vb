Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inicio, fin, suma, contador As Integer
        inicio = Val(txtInicio.Text)
        fin = Val(txtFin.Text)
        If fin > inicio Then
            For contador = inicio To fin
                suma += contador
            Next contador
            txtResp.Text = suma
        Else
            '    txtResp.Text = ""
            MsgBox("Error ")
        End If
    End Sub
End Class