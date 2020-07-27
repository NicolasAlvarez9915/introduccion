Public Class ejercicio_13
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Convert.ToInt32(TxtLado.Text) = Convert.ToInt32(TxtLado2.Text) And Convert.ToInt32(TxtLado2.Text) = Convert.ToInt32(TxtLado3.Text) Then
            LblMensaje.Text = "Triangulo equilatero"
        Else
            If Convert.ToInt32(TxtLado.Text) = Convert.ToInt32(TxtLado2.Text) Or Convert.ToInt32(TxtLado2.Text) = Convert.ToInt32(TxtLado3.Text) Or Convert.ToInt32(TxtLado.Text) = Convert.ToInt32(TxtLado3.Text) Then
                LblMensaje.Text = "Triangulo isosceles"
            Else
                LblMensaje.Text = "Triangulo escaleno"
            End If
        End If
    End Sub
End Class