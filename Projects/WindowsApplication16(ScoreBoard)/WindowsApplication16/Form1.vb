Public Class Form1
    Public num As Integer

    Private Sub ok_button_Click(sender As Object, e As EventArgs) Handles ok_button.Click
        If seconds_textbox.Text = "00" Then
            If minutes_textbox.Text = "00" Then
                If hours_textbox.Text = "00" Then
                    Start_pause.Enabled = False
                    MsgBox("Please enter a value heigher then 0")
                End If
            End If
        End If
        If seconds_textbox.Text = "0" Then
            If minutes_textbox.Text = "0" Then
                If hours_textbox.Text = "0" Then
                    Start_pause.Enabled = False
                    MsgBox("Please enter a value heigher then 0")

                End If
            End If
        End If
        If seconds_textbox.Text = "" Then
            minutes_textbox.Text = ""
            hours_textbox.Text = ""
            Start_pause.Enabled = False
            MsgBox("Please enter a value")

        End If
        ok_button.Enabled = True
        hours_label.Text = hours_textbox.Text
        minutes_label.Text = minutes_textbox.Text
        seconds_label.Text = seconds_textbox.Text
        If hours_label.Text > "0" Then
            Start_pause.Enabled = True
        End If
        If minutes_label.Text > "0" Then
            Start_pause.Enabled = True
        End If
        If seconds_label.Text > "0" Then
            Start_pause.Enabled = True
        End If
    End Sub

    Private Sub Start_pause_Click(sender As Object, e As EventArgs) Handles Start_pause.Click

        If Start_pause.Text = "Start" Then
            Timer1.Enabled = True
            ok_button.Enabled = False
            Start_pause.Text = "Pause"
        ElseIf Start_pause.Text = "Pause" Then
            Timer1.Enabled = False
            Restart.Enabled = True
            ok_button.Enabled = True
            Start_pause.Text = "Start"
        End If
    End Sub

    Private Sub Restart_Click(sender As Object, e As EventArgs) Handles Restart.Click

        hours_label.Text = "00"
        minutes_label.Text = "00"
        seconds_label.Text = "00"
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 1000
        If hours_label.Text = "" Then
            hours_label.Text = "0"
        End If
        If minutes_label.Text = "" Then
            minutes_label.Text = "0"
        End If
        If seconds_label.Text = "" Then
            seconds_label.Text = "0"
        End If
        If hours_label.Text = "00" Then
            hours_label.Text = "0"
        End If
        If minutes_label.Text = "00" Then
            minutes_label.Text = "0"
        End If
        If seconds_label.Text = "00" Then
            seconds_label.Text = "0"
        End If
        If seconds_label.Text > "0" Then
            seconds_label.Text = seconds_label.Text - 1
        End If
        If minutes_label.Text > "0" Then
            If seconds_label.Text = "0" Then
                minutes_label.Text = minutes_label.Text - 1
                seconds_label.Text = "59"
            End If
        End If
        If hours_label.Text > "0" Then
            If minutes_label.Text = "0" Then
                If seconds_label.Text = "0" Then
                    hours_label.Text = hours_label.Text - 1
                    minutes_label.Text = "59"
                    seconds_label.Text = "59"
                End If
            End If
        End If

        If seconds_label.Text = "0" Then
            If minutes_label.Text = "0" Then
                If hours_label.Text = "0" Then
                    Timer1.Enabled = False
                    MsgBox("Time is up")
                    Start_pause.Text = "Start"
                    Restart.Enabled = False
                    Label4.Text = Val(Label4.Text) + 1
                    If Label4.Text > 4 Then
                        MsgBox("Overtime")
                        Label4.Text = "OT"
                    Else
                            If Val(TextBox1.Text) > Val(TextBox2.Text) Then
                                MsgBox("GameOver")
                                MsgBox("Team Sawi Wins")
                                If Val(TextBox1.Text) < Val(TextBox2.Text) Then
                                    MsgBox("GameOver")
                                    MsgBox("Team Iyak Wins")
                                    If Val(TextBox1.Text) = Val(TextBox2.Text) Then
                                        MsgBox("Overtime")
                                        Label4.Text = "OT"
                                    End If
                                End If
                            End If
                End If
            End If
            End If
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num = (Val(1) + Val(TextBox1.Text))
        TextBox1.Text = Val(num)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        num = (Val(2) + Val(TextBox1.Text))
        TextBox1.Text = Val(num)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        num = (Val(3) + Val(TextBox1.Text))
        TextBox1.Text = Val(num)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        num = (Val(1) + Val(TextBox2.Text))
        TextBox2.Text = Val(num)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        num = (Val(2) + Val(TextBox2.Text))
        TextBox2.Text = Val(num)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        num = (Val(3) + Val(TextBox2.Text))
        TextBox2.Text = Val(num)
    End Sub

End Class
