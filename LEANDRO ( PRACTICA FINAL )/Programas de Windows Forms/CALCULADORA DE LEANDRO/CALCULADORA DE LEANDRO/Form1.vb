Public Class Form1
    Private Sub SVJ_Click(sender As Object, e As EventArgs) Handles SVJ.Click
        Dim NUM1, NUM2, RES As Double
        NUM1 = Val(TextBox1.Text)
        NUM2 = Val(TextBox2.Text)
        RES = TextBox1.Text + TextBox2.Text

        RES = NUM1 + NUM2
        TextBox3.Text = RES

    End Sub

    Private Sub GTR_Click(sender As Object, e As EventArgs) Handles GTR.Click
        Dim NUM1, NUM2, RES As Double
        NUM1 = Val(TextBox1.Text)
        NUM2 = Val(TextBox2.Text)
        RES = TextBox1.Text - TextBox2.Text

        RES = NUM1 - NUM2
        TextBox3.Text = RES

    End Sub

    Private Sub M3_Click(sender As Object, e As EventArgs) Handles M3.Click
        Dim NUM1, NUM2, RES As Double
        NUM1 = Val(TextBox1.Text)
        NUM2 = Val(TextBox2.Text)
        RES = TextBox1.Text * TextBox2.Text

        RES = NUM1 * NUM2
        TextBox3.Text = RES

    End Sub

    Private Sub GT3_Click(sender As Object, e As EventArgs) Handles GT3.Click
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
End Class
