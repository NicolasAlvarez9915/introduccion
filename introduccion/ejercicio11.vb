Public Class ejercicio11
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Convert.ToDouble(TxtNota.Text) >= 3.0 Then
            LblMensaje.Text = "Gano "
        Else
            LblMensaje.Text = "Perdio"
        End If
    End Sub
End Class