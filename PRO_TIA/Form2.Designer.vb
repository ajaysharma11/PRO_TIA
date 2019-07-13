<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim NAMELabel As System.Windows.Forms.Label
        Dim HQLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim DOALabel As System.Windows.Forms.Label
        Dim DORLabel As System.Windows.Forms.Label
        Dim BASICLabel As System.Windows.Forms.Label
        Dim BANKLabel As System.Windows.Forms.Label
        Dim ACCOUNTLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MY_INSPDataSet = New PRO_TIA.MY_INSPDataSet()
        Me.MY_DATABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MY_DATATableAdapter = New PRO_TIA.MY_INSPDataSetTableAdapters.MY_DATATableAdapter()
        Me.TableAdapterManager = New PRO_TIA.MY_INSPDataSetTableAdapters.TableAdapterManager()
        Me.MY_DATABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MY_DATABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NAMETextBox = New System.Windows.Forms.TextBox()
        Me.HQTextBox = New System.Windows.Forms.TextBox()
        Me.DOBTextBox = New System.Windows.Forms.TextBox()
        Me.DOATextBox = New System.Windows.Forms.TextBox()
        Me.DORTextBox = New System.Windows.Forms.TextBox()
        Me.BASICTextBox = New System.Windows.Forms.TextBox()
        Me.BANKTextBox = New System.Windows.Forms.TextBox()
        Me.ACCOUNTTextBox = New System.Windows.Forms.TextBox()
        Me.CMD_ADD = New System.Windows.Forms.Button()
        Me.CMD_SAVE = New System.Windows.Forms.Button()
        Me.CMD_DELETE = New System.Windows.Forms.Button()
        NAMELabel = New System.Windows.Forms.Label()
        HQLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        DOALabel = New System.Windows.Forms.Label()
        DORLabel = New System.Windows.Forms.Label()
        BASICLabel = New System.Windows.Forms.Label()
        BANKLabel = New System.Windows.Forms.Label()
        ACCOUNTLabel = New System.Windows.Forms.Label()
        CType(Me.MY_INSPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MY_DATABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MY_DATABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MY_DATABindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NAMELabel
        '
        NAMELabel.AutoSize = True
        NAMELabel.Location = New System.Drawing.Point(20, 61)
        NAMELabel.Name = "NAMELabel"
        NAMELabel.Size = New System.Drawing.Size(41, 13)
        NAMELabel.TabIndex = 3
        NAMELabel.Text = "NAME:"
        '
        'HQLabel
        '
        HQLabel.AutoSize = True
        HQLabel.Location = New System.Drawing.Point(20, 87)
        HQLabel.Name = "HQLabel"
        HQLabel.Size = New System.Drawing.Size(26, 13)
        HQLabel.TabIndex = 5
        HQLabel.Text = "HQ:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Location = New System.Drawing.Point(20, 113)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(33, 13)
        DOBLabel.TabIndex = 7
        DOBLabel.Text = "DOB:"
        '
        'DOALabel
        '
        DOALabel.AutoSize = True
        DOALabel.Location = New System.Drawing.Point(20, 139)
        DOALabel.Name = "DOALabel"
        DOALabel.Size = New System.Drawing.Size(33, 13)
        DOALabel.TabIndex = 9
        DOALabel.Text = "DOA:"
        '
        'DORLabel
        '
        DORLabel.AutoSize = True
        DORLabel.Location = New System.Drawing.Point(232, 58)
        DORLabel.Name = "DORLabel"
        DORLabel.Size = New System.Drawing.Size(34, 13)
        DORLabel.TabIndex = 11
        DORLabel.Text = "DOR:"
        '
        'BASICLabel
        '
        BASICLabel.AutoSize = True
        BASICLabel.Location = New System.Drawing.Point(232, 83)
        BASICLabel.Name = "BASICLabel"
        BASICLabel.Size = New System.Drawing.Size(41, 13)
        BASICLabel.TabIndex = 13
        BASICLabel.Text = "BASIC:"
        '
        'BANKLabel
        '
        BANKLabel.AutoSize = True
        BANKLabel.Location = New System.Drawing.Point(232, 109)
        BANKLabel.Name = "BANKLabel"
        BANKLabel.Size = New System.Drawing.Size(39, 13)
        BANKLabel.TabIndex = 15
        BANKLabel.Text = "BANK:"
        '
        'ACCOUNTLabel
        '
        ACCOUNTLabel.AutoSize = True
        ACCOUNTLabel.Location = New System.Drawing.Point(232, 135)
        ACCOUNTLabel.Name = "ACCOUNTLabel"
        ACCOUNTLabel.Size = New System.Drawing.Size(62, 13)
        ACCOUNTLabel.TabIndex = 17
        ACCOUNTLabel.Text = "ACCOUNT:"
        '
        'MY_INSPDataSet
        '
        Me.MY_INSPDataSet.DataSetName = "MY_INSPDataSet"
        Me.MY_INSPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MY_DATABindingSource
        '
        Me.MY_DATABindingSource.DataMember = "MY DATA"
        Me.MY_DATABindingSource.DataSource = Me.MY_INSPDataSet
        '
        'MY_DATATableAdapter
        '
        Me.MY_DATATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BEAT__PTableAdapter = Nothing
        Me.TableAdapterManager.FORCASTTableAdapter = Nothing
        Me.TableAdapterManager.JOMTableAdapter = Nothing
        Me.TableAdapterManager.MY_DATATableAdapter = Me.MY_DATATableAdapter
        Me.TableAdapterManager.UpdateOrder = PRO_TIA.MY_INSPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MY_DATABindingNavigator
        '
        Me.MY_DATABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MY_DATABindingNavigator.BindingSource = Me.MY_DATABindingSource
        Me.MY_DATABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MY_DATABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MY_DATABindingNavigator.Enabled = False
        Me.MY_DATABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MY_DATABindingNavigatorSaveItem})
        Me.MY_DATABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MY_DATABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MY_DATABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MY_DATABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MY_DATABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MY_DATABindingNavigator.Name = "MY_DATABindingNavigator"
        Me.MY_DATABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MY_DATABindingNavigator.Size = New System.Drawing.Size(626, 25)
        Me.MY_DATABindingNavigator.TabIndex = 0
        Me.MY_DATABindingNavigator.Text = "BindingNavigator1"
        Me.MY_DATABindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(39, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 25)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MY_DATABindingNavigatorSaveItem
        '
        Me.MY_DATABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MY_DATABindingNavigatorSaveItem.Image = CType(resources.GetObject("MY_DATABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MY_DATABindingNavigatorSaveItem.Name = "MY_DATABindingNavigatorSaveItem"
        Me.MY_DATABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MY_DATABindingNavigatorSaveItem.Text = "Save Data"
        '
        'NAMETextBox
        '
        Me.NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MY_DATABindingSource, "NAME", True))
        Me.NAMETextBox.Location = New System.Drawing.Point(88, 58)
        Me.NAMETextBox.Name = "NAMETextBox"
        Me.NAMETextBox.Size = New System.Drawing.Size(137, 20)
        Me.NAMETextBox.TabIndex = 4
        '
        'HQTextBox
        '
        Me.HQTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MY_DATABindingSource, "HQ", True))
        Me.HQTextBox.Location = New System.Drawing.Point(88, 84)
        Me.HQTextBox.Name = "HQTextBox"
        Me.HQTextBox.Size = New System.Drawing.Size(137, 20)
        Me.HQTextBox.TabIndex = 6
        '
        'DOBTextBox
        '
        Me.DOBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MY_DATABindingSource, "DOB", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "dd-MMM-yyyy"))
        Me.DOBTextBox.Location = New System.Drawing.Point(88, 110)
        Me.DOBTextBox.Name = "DOBTextBox"
        Me.DOBTextBox.Size = New System.Drawing.Size(137, 20)
        Me.DOBTextBox.TabIndex = 8
        '
        'DOATextBox
        '
        Me.DOATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MY_DATABindingSource, "DOA", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "dd-MMM-yyyy"))
        Me.DOATextBox.Location = New System.Drawing.Point(88, 136)
        Me.DOATextBox.Name = "DOATextBox"
        Me.DOATextBox.Size = New System.Drawing.Size(137, 20)
        Me.DOATextBox.TabIndex = 10
        '
        'DORTextBox
        '
        Me.DORTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MY_DATABindingSource, "DOR", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "dd-MMM-yyyy"))
        Me.DORTextBox.Location = New System.Drawing.Point(300, 54)
        Me.DORTextBox.Name = "DORTextBox"
        Me.DORTextBox.Size = New System.Drawing.Size(137, 20)
        Me.DORTextBox.TabIndex = 12
        '
        'BASICTextBox
        '
        Me.BASICTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MY_DATABindingSource, "BASIC", True))
        Me.BASICTextBox.Location = New System.Drawing.Point(300, 80)
        Me.BASICTextBox.Name = "BASICTextBox"
        Me.BASICTextBox.Size = New System.Drawing.Size(137, 20)
        Me.BASICTextBox.TabIndex = 14
        '
        'BANKTextBox
        '
        Me.BANKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MY_DATABindingSource, "BANK", True))
        Me.BANKTextBox.Location = New System.Drawing.Point(300, 106)
        Me.BANKTextBox.Name = "BANKTextBox"
        Me.BANKTextBox.Size = New System.Drawing.Size(137, 20)
        Me.BANKTextBox.TabIndex = 16
        '
        'ACCOUNTTextBox
        '
        Me.ACCOUNTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MY_DATABindingSource, "ACCOUNT", True))
        Me.ACCOUNTTextBox.Location = New System.Drawing.Point(300, 132)
        Me.ACCOUNTTextBox.Name = "ACCOUNTTextBox"
        Me.ACCOUNTTextBox.Size = New System.Drawing.Size(137, 20)
        Me.ACCOUNTTextBox.TabIndex = 18
        '
        'CMD_ADD
        '
        Me.CMD_ADD.Location = New System.Drawing.Point(493, 49)
        Me.CMD_ADD.Name = "CMD_ADD"
        Me.CMD_ADD.Size = New System.Drawing.Size(101, 28)
        Me.CMD_ADD.TabIndex = 19
        Me.CMD_ADD.Text = "ADD"
        Me.CMD_ADD.UseVisualStyleBackColor = True
        '
        'CMD_SAVE
        '
        Me.CMD_SAVE.Location = New System.Drawing.Point(493, 83)
        Me.CMD_SAVE.Name = "CMD_SAVE"
        Me.CMD_SAVE.Size = New System.Drawing.Size(101, 28)
        Me.CMD_SAVE.TabIndex = 20
        Me.CMD_SAVE.Text = "SAVE"
        Me.CMD_SAVE.UseVisualStyleBackColor = True
        '
        'CMD_DELETE
        '
        Me.CMD_DELETE.Location = New System.Drawing.Point(493, 117)
        Me.CMD_DELETE.Name = "CMD_DELETE"
        Me.CMD_DELETE.Size = New System.Drawing.Size(101, 28)
        Me.CMD_DELETE.TabIndex = 21
        Me.CMD_DELETE.Text = "DELETE"
        Me.CMD_DELETE.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(626, 201)
        Me.Controls.Add(Me.CMD_DELETE)
        Me.Controls.Add(Me.CMD_SAVE)
        Me.Controls.Add(Me.CMD_ADD)
        Me.Controls.Add(NAMELabel)
        Me.Controls.Add(Me.NAMETextBox)
        Me.Controls.Add(HQLabel)
        Me.Controls.Add(Me.HQTextBox)
        Me.Controls.Add(DOBLabel)
        Me.Controls.Add(Me.DOBTextBox)
        Me.Controls.Add(DOALabel)
        Me.Controls.Add(Me.DOATextBox)
        Me.Controls.Add(DORLabel)
        Me.Controls.Add(Me.DORTextBox)
        Me.Controls.Add(BASICLabel)
        Me.Controls.Add(Me.BASICTextBox)
        Me.Controls.Add(BANKLabel)
        Me.Controls.Add(Me.BANKTextBox)
        Me.Controls.Add(ACCOUNTLabel)
        Me.Controls.Add(Me.ACCOUNTTextBox)
        Me.Controls.Add(Me.MY_DATABindingNavigator)
        Me.Name = "Form2"
        Me.Text = "MY DATA"
        CType(Me.MY_INSPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MY_DATABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MY_DATABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MY_DATABindingNavigator.ResumeLayout(False)
        Me.MY_DATABindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MY_INSPDataSet As MY_INSPDataSet
    Friend WithEvents MY_DATABindingSource As BindingSource
    Friend WithEvents MY_DATATableAdapter As MY_INSPDataSetTableAdapters.MY_DATATableAdapter
    Friend WithEvents TableAdapterManager As MY_INSPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MY_DATABindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents MY_DATABindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NAMETextBox As TextBox
    Friend WithEvents HQTextBox As TextBox
    Friend WithEvents DOBTextBox As TextBox
    Friend WithEvents DOATextBox As TextBox
    Friend WithEvents DORTextBox As TextBox
    Friend WithEvents BASICTextBox As TextBox
    Friend WithEvents BANKTextBox As TextBox
    Friend WithEvents ACCOUNTTextBox As TextBox
    Friend WithEvents CMD_ADD As Button
    Friend WithEvents CMD_SAVE As Button
    Friend WithEvents CMD_DELETE As Button
End Class
