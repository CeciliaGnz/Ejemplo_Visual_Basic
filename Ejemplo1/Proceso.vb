Module Proceso
    Public Sub multiplosDeTres(ByVal inicio As Integer, ByVal fin As Integer, ByRef total As Integer)
        Dim contador As Integer
        For contador = inicio To fin
            If contador Mod 3 = 0 Then
                total += 1
            End If
        Next
    End Sub
End Module
