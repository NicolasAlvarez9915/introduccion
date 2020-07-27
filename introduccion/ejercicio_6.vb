Public Class Ejercicio_6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Convert.ToInt32(TxtEdad.Text) < 18 Then
            LblMensaje.Text = "Usted va a la universidad"
        Else
            LblMensaje.Text = "Usted presta el sevicio militar"
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TxtEdad_TextChanged(sender As Object, e As EventArgs) Handles TxtEdad.TextChanged

    End Sub

    Private Sub LblMensaje_Click(sender As Object, e As EventArgs) Handles LblMensaje.Click

    End Sub
End Class