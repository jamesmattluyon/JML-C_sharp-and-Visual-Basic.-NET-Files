Public Class Form1
    Private attempts = 0
    Dim setting As New My.MySettings()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtUser.Text = "Admin" And txtPass.Text = setting.pass Then
            Me.Hide()
            Form2.Show()

        Else
            attempts += 1

            If attempts = 3 Then
                MsgBox("Mali yan")
                Me.Close()

            Else : MsgBox("Incorrect username and password.", vbOKCancel, "WARNING")
                txtUser.Text = ""
                txtPass.Text = ""

                If attempts = 1 Then
                    MsgBox("Login attempts left:2", vbOKCancel, "WARNING")

                End If

                If attempts = 2 Then
                    MsgBox("Login attempts left:1", vbOKCancel, "WARNING")

                End If
                If attempts = 3 Then
                    MsgBox("You can't log in", vbOKCancel, "WARNING")

                    If txtPass.Text = True And txtUser.Text = "Admin" And txtPass.Text = setting.pass Then
                        Form2.Close()
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
