Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListView1.Items.Add(TextBox1.Text)
        ListView1.Items.Add(TextBox2.Text)
        ListView1.Items.Add(TextBox3.Text)
        ListView1.Items.Add(TextBox4.Text)
        ListView1.Items.Add(TextBox5.Text)
    End Sub
End Class
