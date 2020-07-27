Public Class ejercicio19
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Double
        total = Convert.ToDouble(TxtCantMateria.Text) * Convert.ToDouble(TxtValPorMateria.Text)
        If Convert.ToDouble(TxtProemdio.Text) < 9 Then
            LblMensaje.Text = total + total * 0.19
        Else
            LblMensaje.Text = total - total * 0.3
        End If
    End Sub
End Class