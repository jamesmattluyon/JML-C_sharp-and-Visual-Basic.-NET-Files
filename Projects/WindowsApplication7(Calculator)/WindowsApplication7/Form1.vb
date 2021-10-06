Public Class Calculator
    Public temp As Integer


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If (TextBox1.Text <> "") Then
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text <> "" Then
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        temp = (Val(TextBox1.Text) + Val(TextBox2.Text))
        Button5.Text = Val(temp)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Val(TextBox1.Text) > Val(TextBox2.Text)) Then
            temp = (Val(TextBox1.Text) - Val(TextBox2.Text))
            Button5.Text = Val(temp)
        Else
            temp = (Val(TextBox2.Text) - Val(TextBox1.Text))
            Button5.Text = Val(temp)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        temp = (Val(TextBox1.Text) * Val(TextBox2.Text))
        Button5.Text = Val(temp)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (Val(TextBox1.Text) > Val(TextBox2.Text)) Then
            temp = (Val(TextBox1.Text) / Val(TextBox2.Text))
            Button5.Text = Val(temp)
        Else
            temp = (Val(TextBox2.Text) / Val(TextBox1.Text))
            Button5.Text = Val(temp)
        End If
    End Sub
End Class
