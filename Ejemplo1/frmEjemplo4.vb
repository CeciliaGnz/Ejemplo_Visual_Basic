Public Class frmEjemplo4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sumatoria As Integer
        Call multiplosDeTres(Val(txtInicial.Text), Val(txtFinal.Text), sumatoria)
        txtResp.Text = sumatoria
    End Sub
End Class