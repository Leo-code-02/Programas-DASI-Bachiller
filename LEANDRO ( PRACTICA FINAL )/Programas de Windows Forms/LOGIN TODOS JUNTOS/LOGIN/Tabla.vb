Public Class Tabla
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NUM As Integer
        Dim L As Integer
        NUM = TextBox1.Text
        For L = 1 To 12
            ListBox1.Items.Add(NUM & " * " & L & " = " & NUM * L & vbCrLf)
        Next L

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        ListBox1.Items.Clear()
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