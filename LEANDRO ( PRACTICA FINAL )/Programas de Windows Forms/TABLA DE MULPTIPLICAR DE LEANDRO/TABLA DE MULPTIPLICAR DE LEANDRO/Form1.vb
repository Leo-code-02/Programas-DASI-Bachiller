Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LEO.Click
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
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
