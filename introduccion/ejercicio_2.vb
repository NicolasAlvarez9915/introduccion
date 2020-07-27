Public Class ejercicio_2
    Private Sub escanear_Click(sender As Object, e As EventArgs) Handles escanear.Click
        Dim i As Integer
        Dim cantidad As Integer
        For i = 0 To dtcopia.RowCount - 2
            cantidad = dtcopia.Rows(i).Cells("cantidad").Value
            If dtcopia.Rows(i).Cells("tipo_copia").Value = "offset" Then
                If dtcopia.Rows(i).Cells("cantidad").Value > 10000 Then

                    dtcopia.Rows(i).Cells("observacion").Value = " ya no  hay copias para trabajar"
                Else
                    dtcopia.Rows(i).Cells("observacion").Value = " usted ha echo " & cantidad & " copias"
                End If
            Else
                dtcopia.Rows(i).Cells("tipo_copia").Value = "estándar"
                If dtcopia.Rows(i).Cells("cantidad").Value > 50000 Then
                    dtcopia.Rows(i).Cells("observacion").Value = " ya no  hay copias para trabajar"
                Else
                    dtcopia.Rows(i).Cells("observacion").Value = " usted ha echo " & cantidad & " copias"
                End If
            End If
        Next
    End Sub
    
End Class