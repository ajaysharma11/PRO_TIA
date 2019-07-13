Public Class Form3
    Dim WDT As Date
    Dim DTOJ As Date
    Dim DAYOJ As Date
    Dim INT As Integer
    Dim STR1 As String
    Dim STR2 As String

    Private Sub JOMBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles JOMBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.JOMBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MY_INSPDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MY_INSPDataSet._BEAT__P' table. You can move, or remove it, as needed.
        Me.BEAT__PTableAdapter.Fill(Me.MY_INSPDataSet._BEAT__P)
        'TODO: This line of code loads data into the 'MY_INSPDataSet.JOM' table. You can move, or remove it, as needed.
        Me.JOMTableAdapter.Fill(Me.MY_INSPDataSet.JOM)
        JOMBindingSource.MoveLast()
        WDT = WEEK_ENDINGTextBox.Text
        DTOJ = DATE_OF_JOURNEYTextBox.Text
        INT = IDTextBox.Text + 1
        WEEK_ENDINGTextBox.Select()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        JOMBindingSource.AddNew()

        If Weekday(WDT) = 7 Then
            WEEK_ENDINGTextBox.Text = DateAdd(DateInterval.Day, 7, WDT)
        Else
            WEEK_ENDINGTextBox.Text = WDT
        End If
        IDTextBox.Text = INT
        DATE_OF_JOURNEYTextBox.Text = DateAdd("d", 1, DTOJ)
        DAY_OF_JOURNEYTextBox.Text = DTOJ.ToString("dddd")
        TRAINTextBox.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WDT = WEEK_ENDINGTextBox.Text
        DTOJ = DATE_OF_JOURNEYTextBox.Text
        INT = IDTextBox.Text + 1
        Me.Validate()
        Me.JOMBindingSource.EndEdit()
        Me.JOMTableAdapter.Update(MY_INSPDataSet.JOM)
        Me.TableAdapterManager.UpdateAll(MY_INSPDataSet)
        Me.JOMTableAdapter.GetData()

    End Sub

    Private Sub JOMDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles JOMDataGridView.CellContentClick

    End Sub
End Class