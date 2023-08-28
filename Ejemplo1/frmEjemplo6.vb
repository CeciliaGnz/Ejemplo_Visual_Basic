Public Class frmEjemplo6
    Private Sub frmEjemplo6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cantidad, z, vectorNumeros() As Integer
        cantidad = Val(txtCantidad.Text)
        ReDim vectorNumeros(cantidad - 1)
    End Sub
End Class