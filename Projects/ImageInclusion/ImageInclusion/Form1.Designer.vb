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
        Me.picMyImage = New System.Windows.Forms.PictureBox()
        Me.buttonpic27 = New System.Windows.Forms.Button()
        CType(Me.picMyImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMyImage
        '
        Me.picMyImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picMyImage.Image = Global.ImageInclusion.My.Resources.Resources.pic26
        Me.picMyImage.Location = New System.Drawing.Point(33, 12)
        Me.picMyImage.Name = "picMyImage"
        Me.picMyImage.Size = New System.Drawing.Size(218, 213)
        Me.picMyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMyImage.TabIndex = 0
        Me.picMyImage.TabStop = False
        '
        'buttonpic27
        '
        Me.buttonpic27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonpic27.Location = New System.Drawing.Point(85, 231)
        Me.buttonpic27.Name = "buttonpic27"
        Me.buttonpic27.Size = New System.Drawing.Size(79, 55)
        Me.buttonpic27.TabIndex = 1
        Me.buttonpic27.Text = "Image 27"
        Me.buttonpic27.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 350)
        Me.Controls.Add(Me.buttonpic27)
        Me.Controls.Add(Me.picMyImage)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picMyImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picMyImage As System.Windows.Forms.PictureBox
    Friend WithEvents buttonpic27 As System.Windows.Forms.Button

End Class
