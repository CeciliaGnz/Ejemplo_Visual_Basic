Public Class Form1
    Dim contador As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valorA, valorB As Integer
        valorA = Val(txtValorA.Text)
        valorB = Val(txtValorB.Text)
        txtResp.Text = valorA + valorB
        contador += 1
        MsgBox(contador)
    End Sub
End Class
