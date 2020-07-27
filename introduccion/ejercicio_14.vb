Public Class ejercicio_14
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case Convert.ToInt32(TxtEdad.Text)
            Case < 11
                LblMensaje.Text = "Niñes."
            Case < 15
                LblMensaje.Text = "Puber."
            Case < 19
                LblMensaje.Text = "Adolecente."
            Case < 26
                LblMensaje.Text = "Joven."
            Case < 66
                LblMensaje.Text = "Adulto."
            Case > 65
                LblMensaje.Text = "Anciano."
        End Select
    End Sub
End Class