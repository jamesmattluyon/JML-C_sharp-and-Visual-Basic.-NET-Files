Imports System.Data.OleDb
Imports System.Data

Public Class StudentsLoginPage

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Username2TableAdapter.Fill(Me.StudentsDataSet.Username2)
        'TODO: This line of code loads data into the 'AdminUSERSDataSet.Username' table. You can move, or remove it, as needed.



    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Username2BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Username2BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Username2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentsDataSet)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        Me.Close()
        End


    End Sub
End Class