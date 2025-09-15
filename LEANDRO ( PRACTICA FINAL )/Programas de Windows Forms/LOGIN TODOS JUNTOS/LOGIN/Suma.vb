Public Class Suma
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NUM1, NUM2, RES As Double
        NUM1 = Val(TextBox1.Text)
        NUM2 = Val(TextBox2.Text)
        RES = TextBox1.Text + TextBox2.Text

        RES = NUM1 + NUM2
        TextBox3.Text = RES
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Bienvenida.Show()
        Me.Close()
    End Sub
End Class