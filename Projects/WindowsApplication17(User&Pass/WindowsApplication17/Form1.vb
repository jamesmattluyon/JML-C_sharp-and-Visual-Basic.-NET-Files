Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUser.Text = "" And txtPass.Text = "" Then
            MsgBox("Username and Password must not be blank", vbCritical, "WARNING")
            txtUser.Focus()
        ElseIf (txtUser.Text = "Admin") And (txtPass.Text = "Admin") Or (txtUser.Text = "Guest") And (txtPass.Text = "Guest") Or
            (txtUser.Text = "parent") And (txtPass.Text = "parent") Or (txtUser.Text = "student") And (txtPass.Text = "student") Or
            (txtUser.Text = "teacher") And (txtPass.Text = "teacher") Then
            MsgBox("Success", vbOK, "Welcome")
            Me.Hide()
            Form2.Show()
        Else
            MsgBox("Incorrect username....", vbOKCancel, "WARNING")
            txtUser.Text = ""
            txtPass.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    
End Class
