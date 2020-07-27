Public Class ejercicio_29
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim precioFinal As Double
        precioFinal = (Convert.ToDouble(TxtPeso.Text.Trim) * Convert.ToDouble(TxtValor.Text.Trim))
        Select Case Convert.ToDouble(TxtPeso.Text.Trim)
            Case < 2.01
                precioFinal -= precioFinal * 0
            Case < 5.01
                precioFinal -= precioFinal * 0.1
            Case < 10.01
                precioFinal -= precioFinal * 0.15
            Case > 10
                precioFinal -= precioFinal * 0.2
        End Select
        LblMensaje.Text = "El valor a pagar: " + (precioFinal).ToString
    End Sub
End Class