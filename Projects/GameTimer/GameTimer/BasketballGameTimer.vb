Imports MediaPlayer
Public Class BasketballGameTimer
    Dim MP As New MediaPlayer.MediaPlayer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub Label19_DoubleClick(sender As Object, e As EventArgs) Handles Label19.DoubleClick
        ColorDialog1.ShowDialog(Me)

        Label18.ForeColor = ColorDialog1.Color
        Label19.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        ColorDialog2.ShowDialog(Me)

        Label20.ForeColor = ColorDialog2.Color
        Label21.ForeColor = ColorDialog2.Color
    End Sub

    Private Sub BasketballGameTimer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub StartTimer()
        If Started = False Then
            If Reset = False Then
                CNTR = 0
                If Overtime > 0 Then
                    MNTE = 5
                Else
                    MNTE = 9
                End If

                SCND = 59
                MS = 60
            Else

            End If
            Started = True
        Else

        End If
        Timer1.Start()
    End Sub

    Private Sub BasketballGameTimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Started = False
        Reset = False

        Timer1.Stop()
        Timer2.Stop()

        CNTR = 0
        MNTE = 10
        SCND = 0
        MS = 0
        S24 = 24
        Quarter = 1
        APF = 0
        BPF = 0
        Overtime = 0

        Label17.Text = Format(MNTE, "00") & ":" & Format(SCND, "00")
        Label22.Text = MS
        Label30.Text = S24
        Label23.Text = Quarter
        Label26.Text = APF
        Label28.Text = BPF

    End Sub

    Private Sub RestartTime()
        Started = False
        Reset = False

        Timer1.Stop()
        Timer2.Stop()

        CNTR = 0
        MNTE = 10
        SCND = 0
        MS = 0
        S24 = 24
        Quarter = 1
        APF = 0
        BPF = 0
        Overtime = 0

        Label17.Text = Format(MNTE, "00") & ":" & Format(SCND, "00")
        Label22.Text = MS
        Label30.Text = S24
        Label23.Text = Quarter
        Label26.Text = APF
        Label28.Text = BPF

        Label19.Text = "0"
        Label21.Text = "0"
        Label18.Text = "Team A"
        Label20.Text = "Team B"

    End Sub


    Private Sub KeyBoardCodes(KBCODE As Integer)
        Select Case KBCODE
            Case 81 'Q
                Label19.Text = Val(Label19.Text) + 1
            Case 65 'A
                If Val(Label19.Text) > 0 Then
                    Label19.Text = Val(Label19.Text) - 1
                Else

                End If
            Case 87 'W
                Label21.Text = Val(Label21.Text) + 1
            Case 83 'S
                If Val(Label21.Text) > 0 Then
                    Label21.Text = Val(Label21.Text) - 1
                Else

                End If
            Case 90 'Z
                PictureBox1.ImageLocation = Application.StartupPath & "\RES\left.jpg"
            Case 88 'X
                PictureBox1.ImageLocation = Application.StartupPath & "\RES\right.jpg"
            Case 69 'E
                If Val(Label23.Text) >= 1 And Val(Label23.Text) < 4 Then
                    Label23.Text = Val(Label23.Text) + 1
                Else
                    Label23.Text = "OT"
                End If
            Case 68 'D
                If Val(Label23.Text) > 1 Then
                    Label23.Text = Val(Label23.Text) - 1
                Else
                    Label23.Text = "4"
                End If
            Case 82 'R
                If Val(Label26.Text) >= 0 And Val(Label26.Text) < 4 Then
                    Label26.Text = Val(Label26.Text) + 1
                    Label26.ForeColor = Color.Black
                Else
                    Label26.Text = "P"
                    Label26.ForeColor = Color.Red
                End If
            Case 70 'F
                Label26.ForeColor = Color.Black
                If Val(Label26.Text) > 0 Then
                    Label26.Text = Val(Label26.Text) - 1
                Else
                    Label26.Text = "4"
                End If
            Case 84 'T
                If Val(Label28.Text) >= 0 And Val(Label28.Text) < 4 Then
                    Label28.Text = Val(Label28.Text) + 1
                    Label28.ForeColor = Color.Black
                Else
                    Label28.Text = "P"
                    Label28.ForeColor = Color.Red
                End If
            Case 71 'G
                Label28.ForeColor = Color.Black
                If Val(Label28.Text) > 0 Then
                    Label28.Text = Val(Label28.Text) - 1
                Else
                    Label28.Text = "4"
                End If
            Case 49 '1
                If Started = False Then
                    S24 = 23
                    Label30.Text = S24
                    StartTimer()
                Else
                    StartTimer()
                End If

            Case 50 '2
                Timer1.Stop()
                Timer2.Stop()
            Case 51 '3
                MP.Open(Application.StartupPath & "\RES\Air Horn.wav")
                FrmTimeOutTimer.ShowDialog(Me)
            Case 52 '4
                MP.Open(Application.StartupPath & "\RES\Air Horn.wav")
                MsgBox("Info: Commiting Player/s Substitution, press OK to Continue...", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Player/s Substitution")
            Case 53 '5
                MP.Open(Application.StartupPath & "\RES\Air Horn.wav")
            Case 54 '6
                S24 = 24
                Label30.Text = S24
                Label30.ForeColor = Color.Black
            Case 55 '7
                S24 = 14
                Label30.Text = S24
                Label30.ForeColor = Color.Black
        End Select
    End Sub

    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown
        KeyBoardCodes(e.KeyCode)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FrmSETTeamNames.ShowDialog(Me)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmEditTime.ShowDialog(Me)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If MS > 0 Then
            MS = MS - 1
        Else
            If MS = 0 Then
                MS = 60
                Count24()
                SCND = SCND - 1
            Else

            End If
        End If

        If SCND < 0 Then
            SCND = 59
            MNTE = MNTE - 1            
        Else

        End If
        Label17.Text = Format(MNTE, "00") & ":" & Format(SCND, "00")
        Label22.Text = Format(MS, "00")

        'Count24()

        If MNTE = 0 And SCND = 0 And MS = 0 Then
            'If MNTE = 0 And SCND = 0 Then
            If Quarter = 1 Then
                MP.Open(Application.StartupPath & "\RES\ElectricRazor - Trimmed.wav")
                Timer1.Stop()
                Timer2.Stop()

                Started = False
                Reset = False

                CNTR = 0
                If Overtime >= 1 Then
                    MNTE = 5
                Else
                    MNTE = 10
                End If

                SCND = 0
                MS = 0
                S24 = 24

                Label17.Text = Format(MNTE, "00") & ":" & Format(SCND, "00")
                Label22.Text = Format(MS, "00")
                Label30.Text = S24
                MsgBox("Info: End of 1st Quarter...", MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly)
                Quarter = Quarter + 1
                Label23.Text = Quarter
                APF = 0
                BPF = 0
                Label26.Text = "0"
                Label28.Text = "0"

            ElseIf Quarter = 2 Then

                MP.Open(Application.StartupPath & "\RES\ElectricRazor - Trimmed.wav")
                Timer1.Stop()
                Timer2.Stop()

                Started = False
                Reset = False

                CNTR = 0
                MNTE = 10
                SCND = 0
                MS = 0
                S24 = 24

                Label17.Text = Format(MNTE, "00") & ":" & Format(SCND, "00")
                Label22.Text = Format(MS, "00")
                Label30.Text = S24

                MsgBox("Info: End of 2nd Quarter...", MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly)
                Quarter = Quarter + 1
                Label23.Text = Quarter
                APF = 0
                BPF = 0
                Label26.Text = "0"
                Label28.Text = "0"

            ElseIf Quarter = 3 Then
                MP.Open(Application.StartupPath & "\RES\ElectricRazor - Trimmed.wav")
                Timer1.Stop()
                Timer2.Stop()

                Started = False
                Reset = False

                CNTR = 0
                MNTE = 10
                SCND = 0
                MS = 0
                S24 = 24

                Label17.Text = Format(MNTE, "00") & ":" & Format(SCND, "00")
                Label22.Text = Format(MS, "00")
                Label30.Text = S24

                MsgBox("Info: End of 3rd Quarter...", MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly)
                Quarter = Quarter + 1
                Label23.Text = Quarter
                APF = 0
                BPF = 0
                Label26.Text = "0"
                Label28.Text = "0"
            ElseIf Quarter = 4 Then
                If Val(Label19.Text) = Val(Label21.Text) Then
                    MP.Open(Application.StartupPath & "\RES\ElectricRazor - Trimmed.wav")
                    Timer1.Stop()
                    Timer2.Stop()

                    Started = False
                    Reset = False

                    CNTR = 0
                    MNTE = 5
                    SCND = 0
                    MS = 0
                    S24 = 24

                    Label17.Text = Format(MNTE, "00") & ":" & Format(SCND, "00")
                    Label22.Text = Format(MS, "00")
                    Label30.Text = S24
                    MsgBox("Overtime...", MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly)
                    Overtime = 1
                    Label23.Text = "OT" & Overtime
                    APF = 0
                    BPF = 0
                    Label26.Text = "0"
                    Label28.Text = "0"
                Else
                    MP.Open(Application.StartupPath & "\RES\ElectricRazor - Trimmed.wav")

                    If Val(Label19.Text) > Val(Label21.Text) Then
                        'RestartTime()
                        Timer1.Stop()
                        MsgBox("GAME OVER... " & Label18.Text & " wins...", MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly)
                        RestartTime()
                    Else
                        Timer1.Stop()
                        MsgBox("GAME OVER... " & Label20.Text & " wins...", MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly)
                        RestartTime()
                    End If
                End If

            ElseIf Overtime = 1 Then

                If Val(Label19.Text) = Val(Label21.Text) Then
                    MP.Open(Application.StartupPath & "\RES\ElectricRazor - Trimmed.wav")
                    Timer1.Stop()
                    Timer2.Stop()

                    Started = False
                    Reset = False

                    CNTR = 0
                    MNTE = 5
                    SCND = 0
                    MS = 0
                    S24 = 24

                    Label17.Text = Format(MNTE, "00") & ":" & Format(SCND, "00")
                    Label22.Text = Format(MS, "00")
                    Label30.Text = S24
                    MsgBox("Overtime 2...", MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly)
                    Overtime = 2
                    Label23.Text = "OT" & Overtime
                    APF = 0
                    BPF = 0
                    Label26.Text = "0"
                    Label28.Text = "0"
                Else
                    MP.Open(Application.StartupPath & "\RES\ElectricRazor - Trimmed.wav")
                    If Val(Label19.Text) > Val(Label21.Text) Then
                        'RestartTime()
                        Timer1.Stop()
                        MsgBox("GAME OVER... " & Label18.Text & " wins...", MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly)
                        RestartTime()
                    Else
                        Timer1.Stop()
                        MsgBox("GAME OVER... " & Label20.Text & " wins...", MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly)
                        RestartTime()
                    End If
                End If

            ElseIf Overtime = 2 Then
                If Val(Label19.Text) = Val(Label21.Text) Then
                    MP.Open(Application.StartupPath & "\RES\ElectricRazor - Trimmed.wav")
                    Timer1.Stop()
                    Timer2.Stop()

                    Started = False
                    Reset = False

                    CNTR = 0
                    MNTE = 5
                    SCND = 0
                    MS = 0
                    S24 = 24

                    Label17.Text = Format(MNTE, "00") & ":" & Format(SCND, "00")
                    Label22.Text = Format(MS, "00")
                    Label30.Text = S24

                    MsgBox("Overtime 3...", vbInformation + vbOKOnly + vbApplicationModal)
                    Overtime = 3
                    Label23.Text = "OT" & Overtime
                    APF = 0
                    BPF = 0
                    Label26.Text = "0"
                    Label28.Text = "0"
                Else
                    MP.Open(Application.StartupPath & "\RES\ElectricRazor - Trimmed.wav")
                    If Val(Label19.Text) > Val(Label21.Text) Then
                        'RestartTime()
                        Timer1.Stop()
                        MsgBox("GAME OVER... " & Label18.Text & " wins...", MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly)
                        RestartTime()
                    Else
                        Timer1.Stop()
                        MsgBox("GAME OVER... " & Label20.Text & " wins...", MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly)
                        RestartTime()
                    End If
                End If

            ElseIf Overtime = 3 Then
                If Val(Label19.Text) = Val(Label21.Text) Then
                    MP.Open(Application.StartupPath & "\RES\ElectricRazor - Trimmed.wav")
                    Timer1.Stop()
                    Timer2.Stop()

                    Started = False
                    Reset = False

                    CNTR = 0
                    MNTE = 5
                    SCND = 0
                    MS = 0
                    S24 = 24

                    Label17.Text = Format(MNTE, "00") & ":" & Format(SCND, "00")
                    Label22.Text = Format(MS, "00")
                    Label30.Text = S24
                    MsgBox("Overtime 4...", MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly)
                    Overtime = 4
                    Label23.Text = "OT" & Overtime
                    APF = 0
                    BPF = 0
                    Label26.Text = "0"
                    Label28.Text = "0"
                Else
                    MP.Open(Application.StartupPath & "\RES\ElectricRazor - Trimmed.wav")
                    If Val(Label19.Text) > Val(Label21.Text) Then
                        'RestartTime()
                        Timer1.Stop()
                        MsgBox("GAME OVER... " & Label18.Text & " wins...", MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly)
                        RestartTime()
                    Else
                        Timer1.Stop()
                        MsgBox("GAME OVER... " & Label20.Text & " wins...", MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly)
                        RestartTime()
                    End If
                End If

            ElseIf Overtime = 4 Then
                If Val(Label19.Text) = Val(Label21.Text) Then
                    MP.Open(Application.StartupPath & "\RES\ElectricRazor - Trimmed.wav")
                    Timer1.Stop()
                    Timer2.Stop()

                    Started = False
                    Reset = False

                    CNTR = 0
                    MNTE = 5
                    SCND = 0
                    MS = 0
                    S24 = 24

                    Label17.Text = Format(MNTE, "00") & ":" & Format(SCND, "00")
                    Label22.Text = Format(MS, "00")
                    Label30.Text = S24
                    If Val(Label19.Text) > Val(Label21.Text) Then
                        MsgBox("GAME OVER... " & Label18.Text & " wins...", MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly)
                    Else
                        MsgBox("GAME OVER... " & Label20.Text & " wins...", MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly)
                    End If

                    Overtime = 5
                    Label23.Text = "OT" & Overtime
                    APF = 0
                    BPF = 0
                    Label26.Text = "0"
                    Label28.Text = "0"
                Else
                    MP.Open(Application.StartupPath & "\RES\ElectricRazor - Trimmed.wav")
                    If Val(Label19.Text) > Val(Label21.Text) Then
                        RestartTime()
                        MsgBox("GAME OVER... " & Label18.Text & " wins...", MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly)
                    Else
                        RestartTime()
                        MsgBox("GAME OVER... " & Label20.Text & " wins...", MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly)
                    End If
                End If
            Else
                MP.Open(Application.StartupPath & "\RES\ElectricRazor - Trimmed.wav")
                If Val(Label19.Text) > Val(Label21.Text) Then
                    'RestartTime()
                    Timer1.Stop()
                    MsgBox("GAME OVER... " & Label18.Text & " wins...", MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly)
                    RestartTime()
                Else
                    Timer1.Stop()
                    MsgBox("GAME OVER... " & Label20.Text & " wins...", MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly)
                    RestartTime()
                End If
            End If

        Else

        End If
    End Sub

    Private Sub Count24()
        If CheckBox1.Checked = True Then
            S24 = S24 - 1
            Label30.Text = S24

            If S24 > 0 Then
                Select Case Val(Label30.Text)
                    Case 1 To 5
                        Label30.ForeColor = Color.Red
                    Case Else
                        Label30.ForeColor = Color.Black
                End Select

                Select Case S24
                    Case 1
                        MP.Open(Application.StartupPath & "\RES\beep-9.wav")
                    Case 2
                        MP.Open(Application.StartupPath & "\RES\beep-9.wav")
                    Case 3
                        MP.Open(Application.StartupPath & "\RES\beep-9.wav")
                    Case 4
                        MP.Open(Application.StartupPath & "\RES\beep-9.wav")
                    Case 5
                        MP.Open(Application.StartupPath & "\RES\beep-9.wav")
                End Select

            Else
                S24 = 24
                Label30.Text = S24
                Label30.ForeColor = Color.Black
                MP.Open(Application.StartupPath & "\RES\ElectricRazor - Trimmed.wav")
                Timer1.Stop()
                Timer2.Stop()
                MsgBox("24 Seconds Shot-clock Violation...", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            End If
        Else
            S24 = 24
            Label30.Text = S24
            Label30.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Button4_KeyDown(sender As Object, e As KeyEventArgs) Handles Button4.KeyDown
        KeyBoardCodes(e.KeyCode)
    End Sub

    Private Sub Button3_KeyDown(sender As Object, e As KeyEventArgs) Handles Button3.KeyDown
        KeyBoardCodes(e.KeyCode)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles CheckBox1.KeyDown
        KeyBoardCodes(e.KeyCode)
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub
End Class
