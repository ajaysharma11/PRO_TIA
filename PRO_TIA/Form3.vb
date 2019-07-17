Public Class Form3
    Dim WDT As Date
    Dim DTOJ As Date
    Dim DAYOJ As Date
    Dim INT As Integer
    Dim INT2 As Integer
    Dim STR1 As String
    Dim STR2 As String

    Private Sub JOMBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles JOMBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.JOMBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MY_INSPDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MY_INSPDataSet1.JOM' table. You can move, or remove it, as needed.
        Me.JOMTableAdapter1.Fill(Me.MY_INSPDataSet1.JOM)

        '  Me.MdiParent = Form1

        'TODO: This line of code loads data into the 'MY_INSPDataSet._BEAT__P' table. You can move, or remove it, as needed.
        Me.BEAT__PTableAdapter.Fill(Me.MY_INSPDataSet._BEAT__P)
        'TODO: This line of code loads data into the 'MY_INSPDataSet.JOM' table. You can move, or remove it, as needed.
        Me.JOMTableAdapter.Fill(Me.MY_INSPDataSet.JOM)
        JOMBindingSource.MoveLast()
        WDT = WEEK_DT.Text
        DTOJ = dtojDT.Value
        INT = IDTextBox.Text + 1
        WEEK_DT.Select()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        JOMBindingSource.AddNew()

        If Weekday(WDT) = " 7 " Then
            WEEK_DT.Text = DateAdd("d", 7, WDT)
        Else
            WEEK_DT.Text = WDT
        End If
        IDTextBox.Text = INT
        dtojDT.Value = DateAdd("d", 1, DTOJ)
        DAYDT.Value = dtojDT.Value
        BEAT__PTableAdapter.FillST(Me.MY_INSPDataSet._BEAT__P)
        BEATPBindingSource.MoveFirst()
        Dim NN As Integer = BEATPBindingSource.Count
        For NN = 1 To NN - 1
            STR1 = BEAT__PTableAdapter.GetST(NN).STATION
            ST_WORKED_ATComboBox.Items.Add(STR1)
            BEATPBindingSource.MoveNext()
        Next NN
        'ST_WORKED_ATTextBox.Text = ""
        TRAINTextBox.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WDT = WEEK_DT.Text
        DTOJ = dtojDT.Text
        INT = IDTextBox.Text + 1
        Me.Validate()
        Me.JOMBindingSource.EndEdit()
        Me.JOMTableAdapter.Update(MY_INSPDataSet.JOM)
        Me.BEATPBindingSource.EndEdit()
        ' Me.BEAT__PTableAdapter.Update(Me.MY_INSPDataSet)
        ' Me.TableAdapterManager.UpdateAll(MY_INSPDataSet)
        Me.JOMTableAdapter.GetData()
        Button1.Select()

    End Sub

    Private Sub JOMDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles JOMDataGridView.CellContentClick

    End Sub

    Private Sub DEP_DTP_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub DEP_DTP_TextChanged(sender As Object, e As EventArgs)

    End Sub

    'Private Sub ST_WORKED_ATComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ST_WORKED_ATComboBox.SelectedIndexChanged
    '    ST_WORKED_ATTextBox.Text = ST_WORKED_ATComboBox.Text
    '    ST_WORKED_ATComboBox.Visible = False
    '    ST_WORKED_ATTextBox.Select()
    'End Sub

    Private Sub NumericUpDown1_TextChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.TextChanged
        'STR2 = ST_WORKED_ATTextBox.Text
        'INT2 = NumericUpDown1.Value
        'ST_WORKED_ATTextBox.Text = STR2 + CStr(INT2)
        ROUNDTextBox.Select()
    End Sub

    Private Sub ST_WORKED_ATComboBox_Click(sender As Object, e As EventArgs) Handles ST_WORKED_ATComboBox.Click

    End Sub

    'Private Sub ST_WORKED_ATComboBox_DoubleClick(sender As Object, e As EventArgs) Handles ST_WORKED_ATComboBox.DoubleClick
    '    ST_WORKED_ATTextBox.Text = ST_WORKED_ATComboBox.Text
    '    ST_WORKED_ATComboBox.Visible = False
    '    ST_WORKED_ATTextBox.Select()
    'End Sub
End Class