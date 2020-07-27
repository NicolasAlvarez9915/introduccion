Public Class ejercicio_25
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TxtP1.Text.Trim = "si" Or TxtP1.Text.Trim = "Si" Then
            TxtP3.Enabled = False
            MessageBox.Show("bien hecho,  siguiente pregunta.")
            TxtP2.Enabled = True
            TxtP1.Enabled = False
        Else
            TxtP3.Enabled = False
            MessageBox.Show("Respondiste mal, acabo el juego.")
            TxtP2.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TxtP2.Text.Trim = "si" Then
            TxtP3.Enabled = True
            MessageBox.Show("bien hecho,  siguiente pregunta.")
            TxtP2.Enabled = False
        Else
            TxtP3.Enabled = False
            TxtP2.Enabled = False
            MessageBox.Show("Respondiste mal, acabo el juego.")
            TxtP1.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TxtP3.Text.Trim = "si" Then
            TxtP3.Enabled = True
            MessageBox.Show("bien hecho,  gano el juego.")
            TxtP2.Enabled = False
        Else
            TxtP3.Enabled = False
            TxtP2.Enabled = False
            MessageBox.Show("Respondiste mal, acabo el juego.")
            TxtP1.Enabled = True
        End If
    End Sub
End Class