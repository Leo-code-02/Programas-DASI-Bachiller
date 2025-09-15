Public Class Form1
    Private Sub ProgrmasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgrmasToolStripMenuItem.Click

    End Sub

    Private Sub SumaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumaToolStripMenuItem.Click
        Dim frmsuma As New suma
        frmsuma.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmsuma)
        frmsuma.Show()
    End Sub
End Class
