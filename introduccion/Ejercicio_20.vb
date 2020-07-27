Public Class Ejercicio_20
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Convert.ToDouble(TxtIngresos.Text.Trim) < 8000 Then
            LblMensaje.Text = "El enganche a pagar es " + (Convert.ToDouble(TxtIngresos.Text.Trim) * 0.15).ToString
            LblMensaje2.Text = "El pago parcial es  " + ((Convert.ToDouble(TxtIngresos.Text.Trim) - Convert.ToDouble(TxtIngresos.Text.Trim) * 0.15) / 10).ToString
        Else
            LblMensaje.Text = "El enganche a pagar es " + (Convert.ToDouble(TxtIngresos.Text.Trim) * 0.3).ToString
            LblMensaje2.Text = "El pago parcial es  " + ((Convert.ToDouble(TxtIngresos.Text.Trim) - Convert.ToDouble(TxtIngresos.Text.Trim) * 0.3) / 7).ToString
        End If
    End Sub
End Class