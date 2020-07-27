Public Class ejercicio_8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Convert.ToInt32(TxtNumero.Text) >= 0 Then
            LblMensaje.Text = "Numero positivo o 0"
        Else
            LblMensaje.Text = "Numero negativo"
        End If
    End Sub
End Class