Public Class ejercico_1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim subtotal, total As Double
        total = 0
        For i = 0 To dtproducto.RowCount - 1
            subtotal = dtproducto.Rows(i).Cells("cant").Value * dtproducto.Rows(i).Cells("val_unitit").Value
            If dtproducto.Rows(i).Cells("etiqueta").Value = "roja" Then
                dtproducto.Rows(i).Cells("descuento").Value = subtotal * 0.2
            Else
                dtproducto.Rows(i).Cells("descuento").Value = 0
            End If
            dtproducto.Rows(i).Cells("total").Value = subtotal - dtproducto.Rows(i).Cells("descuento").Value
            total += dtproducto.Rows(i).Cells("total").Value
            Txttotal.Text = total
        Next
    End Sub

   
   
   
  
End Class