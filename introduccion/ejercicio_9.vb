Public Class ejercicio_9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Convert.ToInt32(TxtNumero.Text) = Convert.ToInt32(TxtNumero2.Text) Then
            LblMensaje.Text = "Numeros iguales"
        Else
            If Convert.ToInt32(TxtNumero.Text) > Convert.ToInt32(TxtNumero2.Text) Then
                LblMensaje.Text = "Numero mayor " + TxtNumero.Text
            Else
                LblMensaje.Text = "Numero mayor " + TxtNumero2.Text
            End If
        End If
    End Sub
End Class