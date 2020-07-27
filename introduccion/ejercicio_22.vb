Public Class ejercicio_22
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Convert.ToDouble(TxtHipoteca.Text.Trim) < 1000000 Then
            LblMensaje.Text = "Su inversion total es: " + (Convert.ToDouble(TxtHipoteca.Text.Trim) / 2).ToString +
                ". Y la de su socio es " + (Convert.ToDouble(TxtHipoteca.Text.Trim) / 2).ToString
        Else
            LblMensaje.Text = "Su inversion total es: " + (Convert.ToDouble(TxtHipoteca.Text.Trim).ToString
                )
        End If
    End Sub
End Class