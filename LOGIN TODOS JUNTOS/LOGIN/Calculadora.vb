Public Class Calculadora
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NUM1, NUM2, RES As Double
        NUM1 = Val(TextBox1.Text)
        NUM2 = Val(TextBox2.Text)
        RES = TextBox1.Text + TextBox2.Text

        RES = NUM1 + NUM2
        TextBox3.Text = RES
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim NUM1, NUM2, RES As Double
        NUM1 = Val(TextBox1.Text)
        NUM2 = Val(TextBox2.Text)
        RES = TextBox1.Text - TextBox2.Text

        RES = NUM1 - NUM2
        TextBox3.Text = RES
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim NUM1, NUM2, RES As Integer

        NUM1 = Val(TextBox1.Text)
        NUM2 = Val(TextBox2.Text)

        RES = NUM1 * NUM2

        TextBox3.Text = RES.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim NUM1, NUM2, RES As Double
        NUM1 = Val(TextBox1.Text)
        NUM2 = Val(TextBox2.Text)
        RES = TextBox1.Text / TextBox2.Text

        RES = NUM1 / NUM2
        TextBox3.Text = RES
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

        TextBox1.Focus()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("COMFIRME SI EN REALIDAD QUIERE SALIR", "CALCULADORA DE LEANDRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (opcion = Windows.Forms.DialogResult.Yes) Then
            Me.Close()

        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Bienvenida.Show()
        Me.Close()

    End Sub
End Class