Public Class FrmTimeOutTimer
    Dim S40 As Integer
    Private Sub FrmTimeOutTimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        S40 = 40
        Label1.Text = "40"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        S40 = S40 - 1
        Label1.Text = Format(S40, "00")

        If S40 <= 0 Then
            Me.Close()
            Me.Dispose()
        Else

        End If
    End Sub
End Class