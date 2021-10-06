Imports System.Data.OleDb
Imports System.Data

Public Class Form2

    Dim username As String
    Dim password As String
    Dim message As String = "The user or password is incorrect. Please, try again."

    Dim attempt As Integer = 0

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click

        If (TextBox1.Text = "") And (TextBox2.Text = "") Then
            attempt += 1
            MsgBox("Please, enter your username and password.", vbOKCancel, "WARNING")

        ElseIf (TextBox1.Text = "") Then
            attempt += 1
            MsgBox("Please, enter your username.", vbOKCancel, "WARNING")

        ElseIf (TextBox2.Text = "") Then
            attempt += 1
            MsgBox("Please, enter your password.", vbOKCancel, "WARNING")

        End If

        username = TextBox1.Text
        password = TextBox2.Text

        If Me.UsernameTableAdapter.ScalarQueryAdmin(username, password) Then
            AdminLoginPage.Show()
            Me.Hide()
            MsgBox("Welcome! " + username, MsgBoxStyle.OkOnly)

            TextBox1.Clear()
            TextBox2.Clear()
        ElseIf (attempt = 3) Then
            MsgBox("You entered the incorrect username and password for the third time.")
            Me.Close()
            End

        Else
            attempt += 1
            MsgBox("You entered an incorrect username and password.", MsgBoxStyle.Critical)

        End If




    End Sub


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label5.Click

        If (TextBox1.Text = "") And (TextBox2.Text = "") Then
            attempt += 1
            MsgBox("Please, enter your username and password.", vbOKCancel, "WARNING")

        ElseIf (TextBox1.Text = "") Then
            attempt += 1
            MsgBox("Please, enter your username.", vbOKCancel, "WARNING")

        ElseIf (TextBox2.Text = "") Then
            attempt += 1
            MsgBox("Please, enter your password.", vbOKCancel, "WARNING")

        End If

        username = TextBox1.Text
        password = TextBox2.Text

        If Me.UsernameTableAdapter.ScalarQueryAdmin(username, password) Then
            AdminLoginPage.Show()
            Me.Hide()
            MsgBox("Login success. ", vbOK, "Information")

            TextBox1.Clear()
            TextBox2.Clear()
        ElseIf (attempt = 3) Then
            MsgBox("You entered the incorrect username and password for the third time.")
            Me.Close()
            End

        Else
            attempt += 1
            MsgBox("You entered an incorrect username and password.", MsgBoxStyle.Critical)

        End If

    End Sub

    Private Sub UsernameBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsernameBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsernameBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AdminDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdminDataSet.Username' table. You can move, or remove it, as needed.
        Me.UsernameTableAdapter.Fill(Me.AdminDataSet.Username)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        Me.Close()
        End


    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click

        TextBox2.UseSystemPasswordChar = True
        TextBox2.Clear()

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click

        TextBox1.Clear()


    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

        Me.Hide()
        Form1.Show()

    End Sub
End Class