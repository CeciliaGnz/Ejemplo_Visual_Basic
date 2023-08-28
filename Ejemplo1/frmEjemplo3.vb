Public Class frmEjemplo3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim parcial1, parcial2, lab1, lab2, semestral As Integer
        Dim nota As Double
        Dim notaLetra As String = "F"
        parcial1 = Val(txtParcial1.Text)
        parcial2 = Val(txtParcial2.Text)
        lab1 = Val(txtLab1.Text)
        lab2 = Val(txtLab2.Text)
        semestral = Val(txtSemestral.Text)
        nota = ((parcial1 + parcial2) / 2) * 0.35 + ((lab1 + lab2) / 2) * 0.25 + semestral * 0.4
        If nota >= 91 And nota <= 100 Then
            notaLetra = "A"
        ElseIf nota >= 81 And nota < 91 Then
            notaLetra = "B"
        ElseIf nota >= 71 And nota < 81 Then
            notaLetra = "C"
        ElseIf nota >= 61 And nota < 71 Then
            notaLetra = "D"
        End If
        txtNota.Text = nota
        txtNotaL.Text = notaLetra
    End Sub
End Class