Public Class ejercicio_3
    Dim precio, total As Double
    Private Sub comprar_Click(sender As Object, e As EventArgs) Handles comprar.Click
        precio = 11000 * npc.Text
        If (npc.Text < 5) Then
            total = precio
            MessageBox.Show("total es igual a " & total * 0.1)
        End If
        If (npc.Text < 10) And (npc.Text > 4) Then
            total = precio
            MessageBox.Show("total es igual a " & total * 0.2)
        End If
        If (npc.Text > 10) Then
            total = precio
            MessageBox.Show("total es igual a " & total * 0.4)
        End If
    End Sub
End Class