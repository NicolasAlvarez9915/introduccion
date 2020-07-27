Public Class ejercicio24
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Convert.ToInt32(TxtHoras.Text.Trim) < 41 Then
            LblMensaje.Text = "Su saldo es " + (Convert.ToInt32(TxtHoras.Text.Trim) * 16).ToString
        Else
            Dim horasExtras As Integer
            horasExtras = Convert.ToInt32(TxtHoras.Text.Trim) - 40
            LblMensaje.Text = "Su saldo es " + ((Convert.ToInt32(TxtHoras.Text.Trim) - horasExtras) * 16 + (horasExtras * 20)).ToString
        End If
    End Sub
End Class