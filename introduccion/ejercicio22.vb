Public Class ejercicio21
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SueldoMeses, descuento, descuentoAdicional, SueldoFinal As Double
        SueldoMeses = Convert.ToDouble(TxtSalario.Text.Trim) * Convert.ToInt32(TxtMeses.Text.Trim)
        descuento = SueldoMeses * 0.3
        descuentoAdicional = 0
        If ChckIngresoExtra.Checked Then
            descuentoAdicional = (SueldoMeses / 100) * Convert.ToDouble(TxtIngresosExtra.Text.Trim)
        End If
        SueldoFinal = SueldoMeses - descuento - descuentoAdicional
        LblMensaje.Text = "El acumulado de su deposito es " + (SueldoMeses - SueldoFinal).ToString
        LblMensaje2.Text = "El acumulado de su sueldo es " + (SueldoFinal).ToString
    End Sub
End Class