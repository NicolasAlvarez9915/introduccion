Public Class ejercicio_17
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Decimal
        Select Case TxtGenero.Text
            Case "M" 
                total = (210 - Convert.ToInt32(TxtEdad.Text)) / 10
            Case "F"
                total = (220 - Convert.ToInt32(TxtEdad.Text)) / 10
            Case "m"
                total = (210 - Convert.ToInt32(TxtEdad.Text)) / 10
            Case "f"
                total = (220 - Convert.ToInt32(TxtEdad.Text)) / 10
        End Select
        LblMensaje.Text = total
    End Sub
End Class