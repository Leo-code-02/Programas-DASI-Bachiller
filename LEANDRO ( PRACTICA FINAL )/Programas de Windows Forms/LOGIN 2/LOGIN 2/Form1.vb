Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Usuario As String
        Dim Contraseña As String

        Usuario = TextBox1.Text
        Contraseña = TextBox2.Text
        If (Usuario = "leandro") And (Contraseña = "0987") Then
            Bienvenida.Show()


        Else

            MsgBox("Revise su nombre o Contraseña")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub
End Class
