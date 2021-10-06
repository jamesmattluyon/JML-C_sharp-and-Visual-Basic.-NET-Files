Public Class Form1
   

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, i, f As Integer


        n = Val(TextBox1.Text)
        i = 1
        f = 1
        While (i <= n)
            f = f * i
            i = i + 1
        End While
        TextBox2.Text = f


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim n As Integer
        Dim isEven As Boolean

        n = Val(TextBox1.Text)
        If n Mod 2 = 0 Then
            isEven = True
            MsgBox(" The entered value is Odd")
        Else
            MsgBox(" The entered value is Even ")

        End If

        



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim n, i As Integer
        Dim x As Double = 12.045
        Dim y As Integer = 12


        n = Val(TextBox1.Text)

        For i = 1 To 10
            Dim a As Integer
            a = n * i
            TextBox2.Text = TextBox2.Text & n & " * " & i & " = " & a
            TextBox2.Text = TextBox2.Text & vbCrLf



        Next

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
