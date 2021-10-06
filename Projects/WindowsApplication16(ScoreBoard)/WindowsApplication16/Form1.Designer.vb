<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.minutes_label = New System.Windows.Forms.Label()
        Me.Start_pause = New System.Windows.Forms.Button()
        Me.Restart = New System.Windows.Forms.Button()
        Me.minutes_textbox = New System.Windows.Forms.TextBox()
        Me.seconds_textbox = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ok_button = New System.Windows.Forms.Button()
        Me.seconds_label = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hours_textbox = New System.Windows.Forms.TextBox()
        Me.hours_label = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'minutes_label
        '
        Me.minutes_label.AutoSize = True
        Me.minutes_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutes_label.Location = New System.Drawing.Point(136, 112)
        Me.minutes_label.Name = "minutes_label"
        Me.minutes_label.Size = New System.Drawing.Size(38, 25)
        Me.minutes_label.TabIndex = 1
        Me.minutes_label.Text = "00"
        '
        'Start_pause
        '
        Me.Start_pause.Location = New System.Drawing.Point(80, 140)
        Me.Start_pause.Name = "Start_pause"
        Me.Start_pause.Size = New System.Drawing.Size(75, 23)
        Me.Start_pause.TabIndex = 3
        Me.Start_pause.Text = "Start"
        Me.Start_pause.UseVisualStyleBackColor = True
        '
        'Restart
        '
        Me.Restart.Location = New System.Drawing.Point(204, 140)
        Me.Restart.Name = "Restart"
        Me.Restart.Size = New System.Drawing.Size(75, 23)
        Me.Restart.TabIndex = 4
        Me.Restart.Text = "Restart"
        Me.Restart.UseVisualStyleBackColor = True
        '
        'minutes_textbox
        '
        Me.minutes_textbox.Location = New System.Drawing.Point(249, 295)
        Me.minutes_textbox.Multiline = True
        Me.minutes_textbox.Name = "minutes_textbox"
        Me.minutes_textbox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.minutes_textbox.Size = New System.Drawing.Size(35, 27)
        Me.minutes_textbox.TabIndex = 6
        '
        'seconds_textbox
        '
        Me.seconds_textbox.Location = New System.Drawing.Point(290, 295)
        Me.seconds_textbox.Multiline = True
        Me.seconds_textbox.Name = "seconds_textbox"
        Me.seconds_textbox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.seconds_textbox.Size = New System.Drawing.Size(35, 27)
        Me.seconds_textbox.TabIndex = 7
        '
        'Timer1
        '
        '
        'ok_button
        '
        Me.ok_button.Location = New System.Drawing.Point(264, 328)
        Me.ok_button.Name = "ok_button"
        Me.ok_button.Size = New System.Drawing.Size(55, 35)
        Me.ok_button.TabIndex = 8
        Me.ok_button.Text = "Ok"
        Me.ok_button.UseVisualStyleBackColor = True
        '
        'seconds_label
        '
        Me.seconds_label.AutoSize = True
        Me.seconds_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seconds_label.Location = New System.Drawing.Point(180, 112)
        Me.seconds_label.Name = "seconds_label"
        Me.seconds_label.Size = New System.Drawing.Size(38, 25)
        Me.seconds_label.TabIndex = 9
        Me.seconds_label.Text = "00"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(44, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 36)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(78, 258)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 36)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(207, 258)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(40, 36)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "1"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(244, 258)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(40, 36)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "2"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(279, 258)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(40, 36)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "3"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(115, 258)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 36)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(54, 36)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(95, 73)
        Me.TextBox1.TabIndex = 16
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(210, 36)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(95, 73)
        Me.TextBox2.TabIndex = 17
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 24)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "TEAM SAWI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 24)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "TEAM IYAK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(138, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 24)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Quarter"
        '
        'hours_textbox
        '
        Me.hours_textbox.Location = New System.Drawing.Point(219, 300)
        Me.hours_textbox.Multiline = True
        Me.hours_textbox.Name = "hours_textbox"
        Me.hours_textbox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.hours_textbox.Size = New System.Drawing.Size(10, 10)
        Me.hours_textbox.TabIndex = 5
        '
        'hours_label
        '
        Me.hours_label.AccessibleName = ""
        Me.hours_label.AutoSize = True
        Me.hours_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hours_label.Location = New System.Drawing.Point(97, 121)
        Me.hours_label.Name = "hours_label"
        Me.hours_label.Size = New System.Drawing.Size(21, 13)
        Me.hours_label.TabIndex = 0
        Me.hours_label.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(159, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 42)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(373, 365)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.hours_label)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.seconds_label)
        Me.Controls.Add(Me.ok_button)
        Me.Controls.Add(Me.seconds_textbox)
        Me.Controls.Add(Me.minutes_textbox)
        Me.Controls.Add(Me.hours_textbox)
        Me.Controls.Add(Me.Restart)
        Me.Controls.Add(Me.Start_pause)
        Me.Controls.Add(Me.minutes_label)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents minutes_label As System.Windows.Forms.Label
    Friend WithEvents Start_pause As System.Windows.Forms.Button
    Friend WithEvents Restart As System.Windows.Forms.Button
    Friend WithEvents minutes_textbox As System.Windows.Forms.TextBox
    Friend WithEvents seconds_textbox As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ok_button As System.Windows.Forms.Button
    Friend WithEvents seconds_label As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents hours_textbox As System.Windows.Forms.TextBox
    Friend WithEvents hours_label As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
