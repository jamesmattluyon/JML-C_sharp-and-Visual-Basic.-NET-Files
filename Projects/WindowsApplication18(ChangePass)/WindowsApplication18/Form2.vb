Public Class Form2
    Dim setting As New My.MySettings()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (currentpass.Text = setting.pass) Then
            setting.pass = newpass.Text
        ElseIf (newpass.Text = confirmpass.Text) Then
            setting.Save()
            MsgBox("Your password have been changed")
            Me.Close()
            Application.Restart()

        Else
            MsgBox("Error", MsgBoxStyle.Critical)
        End If
    End Sub
End Class