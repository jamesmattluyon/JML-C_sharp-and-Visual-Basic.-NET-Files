Public Class Form1

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = (Val(TextBox1.Text) + Val(Button4.Text))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = (Val(TextBox1.Text) + Val(Button5.Text))
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = (Val(TextBox1.Text) + Val(Button6.Text))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = (Val(TextBox2.Text) + Val(Button1.Text))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = (Val(TextBox2.Text) + Val(Button2.Text))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text = (Val(TextBox2.Text) + Val(Button3.Text))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Restart_Click(sender As Object, e As EventArgs) Handles Restart.Click
        hours_label.Text = "00"
        minutes_label.Text = "00"
        seconds_label.Text = "00"
        Timer1.Enabled = False
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs)
        If start_pause.Text = "Start" Then
            Timer1.Enabled = True
            ok_button.Enabled = False
            start_pause.Text = "Pause"
        ElseIf start_pause.Text = "Pause" Then
            Timer1.Enabled = False
            restart.Enabled = True
            ok_button.Enabled = True
            start_pause.Text = "Start"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 100
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
                    Start_pause.text = "Start"
                    Restart.Enabled = False
                End If
            End If
        End If
    End Sub

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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub restart_Click_1(sender As Object, e As EventArgs) Handles restart.Click
        hours_label.Text = "00"
        minutes_label.Text = "00"
        seconds_label.Text = "00"
        Timer1.Enabled = False
    End Sub

   

  
    Private Sub Start_pause_Click(sender As Object, e As EventArgs) Handles Start_pause.Click

        If Start_pause.Text = "Start" Then
            Timer1.Enabled = True
            ok_button.Enabled = False
            Start_pause.Text = "Pause"
        ElseIf Start_pause.Text = "Pause" Then
            Timer1.Enabled = False
            restart.Enabled = True
            ok_button.Enabled = True
            Start_pause.Text = "Start"
        End If
    End Sub

    Private Sub seconds_label_Click(sender As Object, e As EventArgs) Handles seconds_label.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub seconds_textbox_TextChanged(sender As Object, e As EventArgs) Handles seconds_textbox.TextChanged

    End Sub

    Private Sub minutes_textbox_TextChanged(sender As Object, e As EventArgs) Handles minutes_textbox.TextChanged

    End Sub

    Private Sub hours_label_Click(sender As Object, e As EventArgs) Handles hours_label.Click

    End Sub

    Private Sub minutes_label_Click(sender As Object, e As EventArgs) Handles minutes_label.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class
