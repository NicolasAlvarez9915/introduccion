Public Class ejercicio_18
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Decimal
        Select Case Convert.ToDouble(TxtMonto.Text)
            Case < 50001
                total = 0.03
            Case > 50000
                total = 0.02
        End Select
        LblMensaje.Text = Convert.ToDouble(TxtMonto.Text) * total
    End Sub
End Class