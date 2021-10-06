Public Class FrmSETTeamNames

    Private Sub FrmSETTeamNames_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = BasketballGameTimer.Label18.Text
        TextBox2.Text = BasketballGameTimer.Label20.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            BasketballGameTimer.Label18.Text = UCase(TextBox1.Text)
        Else
            BasketballGameTimer.Label18.Text = "Team A"
        End If

        If TextBox2.Text <> "" Then
            BasketballGameTimer.Label20.Text = UCase(TextBox2.Text)
        Else
            BasketballGameTimer.Label20.Text = "Team B"
        End If
        Me.Close()
        Me.Dispose()
    End Sub
End Class