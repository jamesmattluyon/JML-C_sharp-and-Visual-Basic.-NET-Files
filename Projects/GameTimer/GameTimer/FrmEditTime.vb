Public Class FrmEditTime

    Private Sub FrmEditTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dx As Integer

        Reset = True

        For dx = 0 To 59
            ComboBox1.Items.Add(dx)
            ComboBox2.Items.Add(dx)
        Next dx

        For dx = 0 To 59
            ComboBox3.Items.Add(Format(dx, "00"))
        Next dx

        For dx = 0 To 24
            ComboBox4.Items.Add(dx)
        Next dx

        ComboBox1.Text = MNTE
        ComboBox2.Text = SCND
        ComboBox3.Text = Format(MS, "00")
        ComboBox4.Text = S24

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text <> "" And ComboBox2.Text <> "" And ComboBox3.Text <> "" And ComboBox4.Text <> "" Then
            MNTE = Val(ComboBox1.Text)
            SCND = Val(ComboBox2.Text)
            MS = Val(ComboBox3.Text)
            S24 = Val(ComboBox4.Text)

            BasketballGameTimer.Label17.Text = Format(MNTE, "00") & ":" & Format(SCND, "00")
            BasketballGameTimer.Label22.Text = Format(MS, "00")

            BasketballGameTimer.Label30.Text = S24
            Me.Close()
            Me.Dispose()
        Else
            MsgBox("Error: Please complete all the fields...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End If
    End Sub
End Class