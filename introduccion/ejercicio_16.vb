Public Class ejercicio_16
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Decimal
        Select Case Convert.ToInt32(TxtNumero.Text)
            Case < 74
                total = 0.15
            Case > 73
                total = 0.2
        End Select
        LblMensaje.Text = Convert.ToDouble(TxtValor.Text) * total
    End Sub
End Class