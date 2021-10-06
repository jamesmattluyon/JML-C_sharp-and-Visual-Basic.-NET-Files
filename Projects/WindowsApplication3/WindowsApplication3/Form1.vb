Public Class Form1
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As ListViewItem
        i = ListView1.Items.Add(TextBox1.Text)
        i.SubItems.Add(TextBox2.Text)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
