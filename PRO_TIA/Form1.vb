Public Class Form1
    Public Sub FEEDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FEEDToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MY_INSPDataSet1.MY_DATA' table. You can move, or remove it, as needed.
        Me.MY_DATATableAdapter.Fill(Me.MY_INSPDataSet1.MY_DATA)

    End Sub

    Public Sub DAILYINSPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DAILYINSPToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CMD_ME_DATA.Click
        Form2.Show()
    End Sub



    Private Sub MY_DATABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MY_DATABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MY_INSPDataSet1)

    End Sub

    Private Sub CMD_JOM_Click(sender As Object, e As EventArgs) Handles CMD_JOM.Click
        Form3.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.MY_DATABindingSource.AddNew()
    End Sub

    Private Sub CMD_SAVE_Click(sender As Object, e As EventArgs) Handles CMD_SAVE.Click
        Me.Validate()
        MY_DATABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MY_INSPDataSet1)

    End Sub
End Class