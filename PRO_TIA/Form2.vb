Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        'TODO: This line of code loads data into the 'MY_INSPDataSet.MY_DATA' table. You can move, or remove it, as needed.
        Me.MY_DATATableAdapter.Fill(Me.MY_INSPDataSet.MY_DATA)
        MY_DATABindingSource.MoveFirst()

    End Sub

    Private Sub MY_DATABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MY_DATABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MY_DATABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MY_INSPDataSet)

    End Sub

    Private Sub CMD_ADD_Click(sender As Object, e As EventArgs) Handles CMD_ADD.Click
        MY_DATABindingSource.AddNew()
    End Sub

    Private Sub CMD_SAVE_Click(sender As Object, e As EventArgs) Handles CMD_SAVE.Click
        Try
            Me.Validate()
            MY_DATABindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Me.MY_INSPDataSet)
            MsgBox("DATA IS SAVED")

        Catch EX As Exception
            MsgBox("DATA HAS NOT BEEN SAVED")
        End Try
    End Sub

    Private Sub CMD_DELETE_Click(sender As Object, e As EventArgs) Handles CMD_DELETE.Click
        MY_DATABindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(Me.MY_INSPDataSet)
    End Sub

    Private Sub DOATextBox_LostFocus(sender As Object, e As EventArgs) Handles DOATextBox.LostFocus
        Dim DT As Date = CDate(DateAdd("yyyy", 60, DOBTextBox.Text))
        DORTextBox.Text = CStr(DT)
    End Sub
End Class