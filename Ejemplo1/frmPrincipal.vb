Public Class frmPrincipal
    Private Sub rdbOpc1_CheckedChanged(sender As Object, e As EventArgs) Handles rdbOpc1.CheckedChanged
        Form1.Show()
        Form2.Close()
        frmEjemplo3.Close()
        frmEjemplo4.Close()
        frmEjemplo5.Close()
        frmEjemplo6.Close()
    End Sub
    Private Sub rdbOpc2_CheckedChanged(sender As Object, e As EventArgs) Handles rdbOpc2.CheckedChanged
        Form2.Show()
        Form1.Close()
        frmEjemplo3.Close()
        frmEjemplo4.Close()
        frmEjemplo5.Close()
        frmEjemplo6.Close()
    End Sub
    Private Sub rdbOpc3_CheckedChanged(sender As Object, e As EventArgs) Handles rdbOpc3.CheckedChanged
        Form1.Close()
        Form2.Close()
        frmEjemplo3.Show()
        frmEjemplo4.Close()
        frmEjemplo5.Close()
        frmEjemplo6.Close()
    End Sub

    Private Sub rdbOpc4_CheckedChanged(sender As Object, e As EventArgs) Handles rdbOpc4.CheckedChanged
        Form1.Close()
        Form2.Close()
        frmEjemplo3.Close()
        frmEjemplo4.Show()
        frmEjemplo5.Close()
        frmEjemplo6.Close()
    End Sub

    Private Sub rdbOpc5_CheckedChanged(sender As Object, e As EventArgs) Handles rdbOpc5.CheckedChanged
        Form1.Close()
        Form2.Close()
        frmEjemplo3.Close()
        frmEjemplo4.Close()
        frmEjemplo5.Show()
        frmEjemplo6.Close()
    End Sub

    Private Sub rdbOpc6_CheckedChanged(sender As Object, e As EventArgs) Handles rdbOpc6.CheckedChanged
        Form1.Close()
        Form2.Close()
        frmEjemplo3.Close()
        frmEjemplo4.Close()
        frmEjemplo5.Close()
        frmEjemplo6.Show()
    End Sub
End Class