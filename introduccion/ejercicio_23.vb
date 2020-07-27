Public Class ejercicio_23




    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim promedio As Double
        promedio = Convert.ToDouble(TxtP1.Text.Trim) + Convert.ToDouble(TxtP2.Text.Trim) +
            Convert.ToDouble(TxtP3.Text.Trim) + Convert.ToDouble(TxtP4.Text.Trim)
        promedio /= 4
        If promedio > 170 Then
            LblMensaje.Text = "La fabrica tiene una sansion por una semana. 
                Ademas tiene una multa del 50% de sus ganancias diarias."
            LblMensaje2.Text = "Su multa es " + (Convert.ToDouble(TxtGanancia.Text.Trim) * 7 / 2)
        Else
            LblMensaje.Text = "Usted no tiene multa"
        End If
    End Sub
End Class