Public Class Edad
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim an, aa, edad As Integer
        an = TextBox1.Text
        aa = TextBox2.Text
        edad = aa - an
        TextBox3.Text = edad
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Bienvenida.Show()
        Me.Close()

    End Sub
End Class