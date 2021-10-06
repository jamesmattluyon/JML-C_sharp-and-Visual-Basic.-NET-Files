Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = " ") Then
            MsgBox("Password must not be Blank", MsgBoxStyle.Critical)
            TextBox1.Text = " "
        ElseIf (TextBox1.Text = "luyon") Then
            MsgBox("SUCCESS", MsgBoxStyle.OkOnly, "Welcome")
            Me.Hide()
            AboutBox1.Show()
        Else
            MsgBox("YOUR PASSWORD IS INCORRECT", MsgBoxStyle.Critical)
            TextBox1.Text = " "
        End If
    End Sub
End Class
