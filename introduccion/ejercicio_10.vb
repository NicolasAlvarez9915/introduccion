Public Class ejercicio_10
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Convert.ToInt32(TxtNumero.Text) < Convert.ToInt32(TxtNumero2.Text) And Convert.ToInt32(TxtNumero.Text) < Convert.ToInt32(TxtNumero3.Text) Then
            LblMensaje.Text = "Numero menor " + TxtNumero.Text
        Else
            If Convert.ToInt32(TxtNumero2.Text) < Convert.ToInt32(TxtNumero3.Text) And Convert.ToInt32(TxtNumero2.Text) < Convert.ToInt32(TxtNumero.Text) Then
                LblMensaje.Text = "Numero menor " + TxtNumero2.Text
            Else
                LblMensaje.Text = "Numero menor " + TxtNumero3.Text
            End If
        End If
    End Sub
End Class