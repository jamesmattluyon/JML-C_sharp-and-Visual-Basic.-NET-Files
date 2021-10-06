Public Class Form2

    Dim images(10) As Bitmap
    Dim pos As Integer = 0
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        images(0) = WindowsApplication17.My.Resources.pic51
        images(1) = WindowsApplication17.My.Resources.pic52
        images(2) = WindowsApplication17.My.Resources.pic53
        images(3) = WindowsApplication17.My.Resources.pic54
        images(4) = WindowsApplication17.My.Resources.pic55
        images(5) = WindowsApplication17.My.Resources.pic56
        images(6) = WindowsApplication17.My.Resources.pic57
        images(7) = WindowsApplication17.My.Resources.pic58
        images(8) = WindowsApplication17.My.Resources.pic59
        images(9) = WindowsApplication17.My.Resources.pic49

        PictureBox1.Image = images(0)
    End Sub



    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
       
        pos = pos - 1

        If pos >= 0 Then
            PictureBox1.Image = images(pos)
        Else
            pos = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pos = pos + 1

        If pos < images.Length - 1 Then
            PictureBox1.Image = images(pos)
        Else
            pos = images.Length
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class