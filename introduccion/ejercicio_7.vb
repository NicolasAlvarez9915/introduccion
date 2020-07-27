Public Class ejercicio_7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Convert.ToInt32(TxtVelocidad.Text) > 80 Then
            LblMensaje.Text = "Usted excedio el limite de velocidad"
        Else
            LblMensaje.Text = "."
        End If
    End Sub
End Class