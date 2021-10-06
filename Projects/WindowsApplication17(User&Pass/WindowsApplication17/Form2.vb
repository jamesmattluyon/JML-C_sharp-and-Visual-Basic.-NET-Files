Public Class Form2


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAbout.Text = " Luyon , James Matthew P."
        lblDesc.Text = " I'am Deviant"

    End Sub


End Class