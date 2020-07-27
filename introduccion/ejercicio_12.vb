Public Class ejercicio_12
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Convert.ToInt32(TxtNumero.Text) > 7 Or Convert.ToInt32(TxtNumero.Text) < 1 Then
            LblMensaje.Text = "Numero no asignado a un dia de la semana."
        End If

        Select Case Convert.ToInt32(TxtNumero.Text)
            Case 1
                LblMensaje.Text = "Lunes."
            Case 2
                LblMensaje.Text = "Martes."
            Case 3
                LblMensaje.Text = "Miercoles."
            Case 4
                LblMensaje.Text = "Jueves."
            Case 5
                LblMensaje.Text = "Viernes."
            Case 6
                LblMensaje.Text = "Sabado."
            Case 7
                LblMensaje.Text = "Domingo."
        End Select
    End Sub

    Private Sub TxtNumero_TextChanged(sender As Object, e As EventArgs) Handles TxtNumero.TextChanged

    End Sub

    Private Sub LblMensaje_Click(sender As Object, e As EventArgs) Handles LblMensaje.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class