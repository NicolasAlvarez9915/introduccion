Public Class ejercicio_15
    Private Sub ejercicio_15_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Integer
        Select Case Convert.ToInt32(Txtllantas.Text)
            Case < 5
                total = 800
            Case > 4
                total = 700
        End Select
        LblMensaje.Text = Convert.ToDouble(Txtllantas.Text) * total
    End Sub

End Class