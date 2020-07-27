Public Class ejercicio_5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles total.Click
        Dim i As Integer
        Dim total, descu, descuento As Double
        total = 0
        For i = 0 To estereo.RowCount - 1
            descu = estereo.Rows(i).Cells("precio").Value - estereo.Rows(i).Cells("precio").Value * 0.05
            descuento = estereo.Rows(i).Cells("precio").Value - estereo.Rows(i).Cells("precio").Value * 0.19
            If estereo.Rows(i).Cells("precio").Value >= 2000 Then
                estereo.Rows(i).Cells("descuento").Value = descuento
            End If
            If estereo.Rows(i).Cells("marca").Value = "NOSY" Then
                estereo.Rows(i).Cells("descuento").Value = descu
            End If
            If estereo.Rows(i).Cells("marca").Value = "NOSY" And estereo.Rows(i).Cells("precio").Value >= 2000 Then
                estereo.Rows(i).Cells("descuento").Value = descu + descuento
            End If
            total += estereo.Rows(i).Cells("descuento").Value

            TextBox1.Text = total
        Next
    End Sub

End Class