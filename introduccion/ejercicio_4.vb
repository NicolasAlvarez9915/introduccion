Public Class ejercicio_4
    Private Sub total_Click(sender As Object, e As EventArgs) Handles total.Click
        Dim i As Integer
        Dim total, precio, subtotal As Double
        total = 0
        For i = 0 To llantas.RowCount - 1
            subtotal = llantas.Rows(i).Cells("can_llantas").Value * llantas.Rows(i).Cells("precio").Value
            If llantas.Rows(i).Cells("can_llantas").Value = 0 Then
                llantas.Rows(i).Cells("precio").Value = 0
            Else
                If llantas.Rows(i).Cells("can_llantas").Value < 5 Then
                    llantas.Rows(i).Cells("precio").Value = 300
                Else
                    If llantas.Rows(i).Cells("can_llantas").Value > 4 And llantas.Rows(i).Cells("can_llantas").Value < 11 Then
                        llantas.Rows(i).Cells("precio").Value = 250
                    Else
                        If llantas.Rows(i).Cells("can_llantas").Value > 10 Then
                            llantas.Rows(i).Cells("precio").Value = 200
                        End If
                    End If
                End If
            End If

            total += llantas.Rows(i).Cells("precio").Value
            resultado.Text = total

        Next
    End Sub
End Class