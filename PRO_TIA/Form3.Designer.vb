<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim WEEK_ENDINGLabel As System.Windows.Forms.Label
        Dim DATE_OF_JOURNEYLabel As System.Windows.Forms.Label
        Dim DAY_OF_JOURNEYLabel As System.Windows.Forms.Label
        Dim TRAINLabel As System.Windows.Forms.Label
        Dim DEPLabel As System.Windows.Forms.Label
        Dim ARRLabel As System.Windows.Forms.Label
        Dim ST_FROMLabel As System.Windows.Forms.Label
        Dim ST_TOLabel As System.Windows.Forms.Label
        Dim ST_WORKED_ATLabel As System.Windows.Forms.Label
        Dim REASON_OF_CHANGELabel As System.Windows.Forms.Label
        Dim IR_CASE_NOLabel As System.Windows.Forms.Label
        Dim Insp_compLabel As System.Windows.Forms.Label
        Dim REPORT_SUBMISSIONLabel As System.Windows.Forms.Label
        Dim ROUNDLabel As System.Windows.Forms.Label
        Dim _2RODLabel As System.Windows.Forms.Label
        Dim _3RODLabel As System.Windows.Forms.Label
        Dim _1R0DLabel As System.Windows.Forms.Label
        Dim LINSPLabel As System.Windows.Forms.Label
        Dim NDUELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.MY_INSPDataSet = New PRO_TIA.MY_INSPDataSet()
        Me.JOMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOMTableAdapter = New PRO_TIA.MY_INSPDataSetTableAdapters.JOMTableAdapter()
        Me.TableAdapterManager = New PRO_TIA.MY_INSPDataSetTableAdapters.TableAdapterManager()
        Me.BEAT__PTableAdapter = New PRO_TIA.MY_INSPDataSetTableAdapters.BEAT__PTableAdapter()
        Me.JOMBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.JOMBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.WEEK_ENDINGTextBox = New System.Windows.Forms.TextBox()
        Me.DATE_OF_JOURNEYTextBox = New System.Windows.Forms.TextBox()
        Me.DAY_OF_JOURNEYTextBox = New System.Windows.Forms.TextBox()
        Me.TRAINTextBox = New System.Windows.Forms.TextBox()
        Me.DEPTextBox = New System.Windows.Forms.TextBox()
        Me.ARRTextBox = New System.Windows.Forms.TextBox()
        Me.ST_FROMTextBox = New System.Windows.Forms.TextBox()
        Me.ST_TOTextBox = New System.Windows.Forms.TextBox()
        Me.ST_WORKED_ATComboBox = New System.Windows.Forms.ComboBox()
        Me.REASON_OF_CHANGETextBox = New System.Windows.Forms.TextBox()
        Me.IR_CASE_NOTextBox = New System.Windows.Forms.TextBox()
        Me.Insp_compCheckBox = New System.Windows.Forms.CheckBox()
        Me.REPORT_SUBMISSIONTextBox = New System.Windows.Forms.TextBox()
        Me.ROUNDTextBox = New System.Windows.Forms.TextBox()
        Me._2RODTextBox = New System.Windows.Forms.TextBox()
        Me._3RODTextBox = New System.Windows.Forms.TextBox()
        Me._1R0DTextBox = New System.Windows.Forms.TextBox()
        Me.LINSPTextBox = New System.Windows.Forms.TextBox()
        Me.NDUETextBox = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BEATPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOMDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IDLabel = New System.Windows.Forms.Label()
        WEEK_ENDINGLabel = New System.Windows.Forms.Label()
        DATE_OF_JOURNEYLabel = New System.Windows.Forms.Label()
        DAY_OF_JOURNEYLabel = New System.Windows.Forms.Label()
        TRAINLabel = New System.Windows.Forms.Label()
        DEPLabel = New System.Windows.Forms.Label()
        ARRLabel = New System.Windows.Forms.Label()
        ST_FROMLabel = New System.Windows.Forms.Label()
        ST_TOLabel = New System.Windows.Forms.Label()
        ST_WORKED_ATLabel = New System.Windows.Forms.Label()
        REASON_OF_CHANGELabel = New System.Windows.Forms.Label()
        IR_CASE_NOLabel = New System.Windows.Forms.Label()
        Insp_compLabel = New System.Windows.Forms.Label()
        REPORT_SUBMISSIONLabel = New System.Windows.Forms.Label()
        ROUNDLabel = New System.Windows.Forms.Label()
        _2RODLabel = New System.Windows.Forms.Label()
        _3RODLabel = New System.Windows.Forms.Label()
        _1R0DLabel = New System.Windows.Forms.Label()
        LINSPLabel = New System.Windows.Forms.Label()
        NDUELabel = New System.Windows.Forms.Label()
        CType(Me.MY_INSPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOMBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JOMBindingNavigator.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BEATPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOMDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(15, 45)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'WEEK_ENDINGLabel
        '
        WEEK_ENDINGLabel.AutoSize = True
        WEEK_ENDINGLabel.Location = New System.Drawing.Point(15, 71)
        WEEK_ENDINGLabel.Name = "WEEK_ENDINGLabel"
        WEEK_ENDINGLabel.Size = New System.Drawing.Size(87, 13)
        WEEK_ENDINGLabel.TabIndex = 3
        WEEK_ENDINGLabel.Text = "WEEK ENDING:"
        '
        'DATE_OF_JOURNEYLabel
        '
        DATE_OF_JOURNEYLabel.AutoSize = True
        DATE_OF_JOURNEYLabel.Location = New System.Drawing.Point(15, 97)
        DATE_OF_JOURNEYLabel.Name = "DATE_OF_JOURNEYLabel"
        DATE_OF_JOURNEYLabel.Size = New System.Drawing.Size(110, 13)
        DATE_OF_JOURNEYLabel.TabIndex = 5
        DATE_OF_JOURNEYLabel.Text = "DATE OF JOURNEY:"
        '
        'DAY_OF_JOURNEYLabel
        '
        DAY_OF_JOURNEYLabel.AutoSize = True
        DAY_OF_JOURNEYLabel.Location = New System.Drawing.Point(15, 123)
        DAY_OF_JOURNEYLabel.Name = "DAY_OF_JOURNEYLabel"
        DAY_OF_JOURNEYLabel.Size = New System.Drawing.Size(103, 13)
        DAY_OF_JOURNEYLabel.TabIndex = 7
        DAY_OF_JOURNEYLabel.Text = "DAY OF JOURNEY:"
        '
        'TRAINLabel
        '
        TRAINLabel.AutoSize = True
        TRAINLabel.Location = New System.Drawing.Point(15, 149)
        TRAINLabel.Name = "TRAINLabel"
        TRAINLabel.Size = New System.Drawing.Size(43, 13)
        TRAINLabel.TabIndex = 9
        TRAINLabel.Text = "TRAIN:"
        '
        'DEPLabel
        '
        DEPLabel.AutoSize = True
        DEPLabel.Location = New System.Drawing.Point(15, 175)
        DEPLabel.Name = "DEPLabel"
        DEPLabel.Size = New System.Drawing.Size(32, 13)
        DEPLabel.TabIndex = 11
        DEPLabel.Text = "DEP:"
        '
        'ARRLabel
        '
        ARRLabel.AutoSize = True
        ARRLabel.Location = New System.Drawing.Point(15, 201)
        ARRLabel.Name = "ARRLabel"
        ARRLabel.Size = New System.Drawing.Size(33, 13)
        ARRLabel.TabIndex = 13
        ARRLabel.Text = "ARR:"
        '
        'ST_FROMLabel
        '
        ST_FROMLabel.AutoSize = True
        ST_FROMLabel.Location = New System.Drawing.Point(15, 227)
        ST_FROMLabel.Name = "ST_FROMLabel"
        ST_FROMLabel.Size = New System.Drawing.Size(58, 13)
        ST_FROMLabel.TabIndex = 15
        ST_FROMLabel.Text = "ST FROM:"
        '
        'ST_TOLabel
        '
        ST_TOLabel.AutoSize = True
        ST_TOLabel.Location = New System.Drawing.Point(15, 253)
        ST_TOLabel.Name = "ST_TOLabel"
        ST_TOLabel.Size = New System.Drawing.Size(42, 13)
        ST_TOLabel.TabIndex = 17
        ST_TOLabel.Text = "ST TO:"
        '
        'ST_WORKED_ATLabel
        '
        ST_WORKED_ATLabel.AutoSize = True
        ST_WORKED_ATLabel.Location = New System.Drawing.Point(238, 42)
        ST_WORKED_ATLabel.Name = "ST_WORKED_ATLabel"
        ST_WORKED_ATLabel.Size = New System.Drawing.Size(93, 13)
        ST_WORKED_ATLabel.TabIndex = 19
        ST_WORKED_ATLabel.Text = "ST WORKED AT:"
        '
        'REASON_OF_CHANGELabel
        '
        REASON_OF_CHANGELabel.AutoSize = True
        REASON_OF_CHANGELabel.Location = New System.Drawing.Point(238, 126)
        REASON_OF_CHANGELabel.Name = "REASON_OF_CHANGELabel"
        REASON_OF_CHANGELabel.Size = New System.Drawing.Size(120, 13)
        REASON_OF_CHANGELabel.TabIndex = 21
        REASON_OF_CHANGELabel.Text = "REASON OF CHANGE:"
        '
        'IR_CASE_NOLabel
        '
        IR_CASE_NOLabel.AutoSize = True
        IR_CASE_NOLabel.Location = New System.Drawing.Point(238, 152)
        IR_CASE_NOLabel.Name = "IR_CASE_NOLabel"
        IR_CASE_NOLabel.Size = New System.Drawing.Size(73, 13)
        IR_CASE_NOLabel.TabIndex = 23
        IR_CASE_NOLabel.Text = "IR/CASE NO:"
        '
        'Insp_compLabel
        '
        Insp_compLabel.AutoSize = True
        Insp_compLabel.Location = New System.Drawing.Point(554, 17)
        Insp_compLabel.Name = "Insp_compLabel"
        Insp_compLabel.Size = New System.Drawing.Size(58, 13)
        Insp_compLabel.TabIndex = 25
        Insp_compLabel.Text = "insp comp:"
        '
        'REPORT_SUBMISSIONLabel
        '
        REPORT_SUBMISSIONLabel.AutoSize = True
        REPORT_SUBMISSIONLabel.Location = New System.Drawing.Point(554, 45)
        REPORT_SUBMISSIONLabel.Name = "REPORT_SUBMISSIONLabel"
        REPORT_SUBMISSIONLabel.Size = New System.Drawing.Size(125, 13)
        REPORT_SUBMISSIONLabel.TabIndex = 27
        REPORT_SUBMISSIONLabel.Text = "REPORT SUBMISSION:"
        '
        'ROUNDLabel
        '
        ROUNDLabel.AutoSize = True
        ROUNDLabel.Location = New System.Drawing.Point(238, 100)
        ROUNDLabel.Name = "ROUNDLabel"
        ROUNDLabel.Size = New System.Drawing.Size(50, 13)
        ROUNDLabel.TabIndex = 29
        ROUNDLabel.Text = "ROUND:"
        '
        '_2RODLabel
        '
        _2RODLabel.AutoSize = True
        _2RODLabel.Location = New System.Drawing.Point(238, 203)
        _2RODLabel.Name = "_2RODLabel"
        _2RODLabel.Size = New System.Drawing.Size(40, 13)
        _2RODLabel.TabIndex = 31
        _2RODLabel.Text = "2ROD:"
        '
        '_3RODLabel
        '
        _3RODLabel.AutoSize = True
        _3RODLabel.Location = New System.Drawing.Point(238, 229)
        _3RODLabel.Name = "_3RODLabel"
        _3RODLabel.Size = New System.Drawing.Size(40, 13)
        _3RODLabel.TabIndex = 33
        _3RODLabel.Text = "3ROD:"
        '
        '_1R0DLabel
        '
        _1R0DLabel.AutoSize = True
        _1R0DLabel.Location = New System.Drawing.Point(238, 178)
        _1R0DLabel.Name = "_1R0DLabel"
        _1R0DLabel.Size = New System.Drawing.Size(38, 13)
        _1R0DLabel.TabIndex = 35
        _1R0DLabel.Text = "1R0D:"
        '
        'LINSPLabel
        '
        LINSPLabel.AutoSize = True
        LINSPLabel.Location = New System.Drawing.Point(554, 83)
        LINSPLabel.Name = "LINSPLabel"
        LINSPLabel.Size = New System.Drawing.Size(41, 13)
        LINSPLabel.TabIndex = 37
        LINSPLabel.Text = "LINSP:"
        '
        'NDUELabel
        '
        NDUELabel.AutoSize = True
        NDUELabel.Location = New System.Drawing.Point(238, 256)
        NDUELabel.Name = "NDUELabel"
        NDUELabel.Size = New System.Drawing.Size(41, 13)
        NDUELabel.TabIndex = 39
        NDUELabel.Text = "NDUE:"
        '
        'MY_INSPDataSet
        '
        Me.MY_INSPDataSet.DataSetName = "MY_INSPDataSet"
        Me.MY_INSPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JOMBindingSource
        '
        Me.JOMBindingSource.DataMember = "JOM"
        Me.JOMBindingSource.DataSource = Me.MY_INSPDataSet
        '
        'JOMTableAdapter
        '
        Me.JOMTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BEAT__PTableAdapter = Me.BEAT__PTableAdapter
        Me.TableAdapterManager.FORCASTTableAdapter = Nothing
        Me.TableAdapterManager.JOMTableAdapter = Me.JOMTableAdapter
        Me.TableAdapterManager.MY_DATATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PRO_TIA.MY_INSPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete
        '
        'BEAT__PTableAdapter
        '
        Me.BEAT__PTableAdapter.ClearBeforeFill = True
        '
        'JOMBindingNavigator
        '
        Me.JOMBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.JOMBindingNavigator.BindingSource = Me.JOMBindingSource
        Me.JOMBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.JOMBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.JOMBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.JOMBindingNavigatorSaveItem})
        Me.JOMBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.JOMBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.JOMBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.JOMBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.JOMBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.JOMBindingNavigator.Name = "JOMBindingNavigator"
        Me.JOMBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.JOMBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.JOMBindingNavigator.TabIndex = 0
        Me.JOMBindingNavigator.Text = "BindingNavigator1"
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
        'JOMBindingNavigatorSaveItem
        '
        Me.JOMBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.JOMBindingNavigatorSaveItem.Image = CType(resources.GetObject("JOMBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.JOMBindingNavigatorSaveItem.Name = "JOMBindingNavigatorSaveItem"
        Me.JOMBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.JOMBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(146, 42)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(77, 20)
        Me.IDTextBox.TabIndex = 1
        '
        'WEEK_ENDINGTextBox
        '
        Me.WEEK_ENDINGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "WEEK ENDING", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "dd-MMM-yyyy"))
        Me.WEEK_ENDINGTextBox.Location = New System.Drawing.Point(146, 68)
        Me.WEEK_ENDINGTextBox.Name = "WEEK_ENDINGTextBox"
        Me.WEEK_ENDINGTextBox.Size = New System.Drawing.Size(77, 20)
        Me.WEEK_ENDINGTextBox.TabIndex = 2
        '
        'DATE_OF_JOURNEYTextBox
        '
        Me.DATE_OF_JOURNEYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "DATE OF JOURNEY", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "dd-MMM-yyyy"))
        Me.DATE_OF_JOURNEYTextBox.Location = New System.Drawing.Point(146, 94)
        Me.DATE_OF_JOURNEYTextBox.Name = "DATE_OF_JOURNEYTextBox"
        Me.DATE_OF_JOURNEYTextBox.Size = New System.Drawing.Size(77, 20)
        Me.DATE_OF_JOURNEYTextBox.TabIndex = 3
        '
        'DAY_OF_JOURNEYTextBox
        '
        Me.DAY_OF_JOURNEYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "DAY OF JOURNEY", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "dd-MMM-yyyy"))
        Me.DAY_OF_JOURNEYTextBox.Location = New System.Drawing.Point(146, 120)
        Me.DAY_OF_JOURNEYTextBox.Name = "DAY_OF_JOURNEYTextBox"
        Me.DAY_OF_JOURNEYTextBox.Size = New System.Drawing.Size(77, 20)
        Me.DAY_OF_JOURNEYTextBox.TabIndex = 4
        '
        'TRAINTextBox
        '
        Me.TRAINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "TRAIN", True))
        Me.TRAINTextBox.Location = New System.Drawing.Point(146, 146)
        Me.TRAINTextBox.Name = "TRAINTextBox"
        Me.TRAINTextBox.Size = New System.Drawing.Size(77, 20)
        Me.TRAINTextBox.TabIndex = 5
        '
        'DEPTextBox
        '
        Me.DEPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "DEP", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "t"))
        Me.DEPTextBox.Location = New System.Drawing.Point(146, 172)
        Me.DEPTextBox.Name = "DEPTextBox"
        Me.DEPTextBox.Size = New System.Drawing.Size(77, 20)
        Me.DEPTextBox.TabIndex = 6
        '
        'ARRTextBox
        '
        Me.ARRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "ARR", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "t"))
        Me.ARRTextBox.Location = New System.Drawing.Point(146, 198)
        Me.ARRTextBox.Name = "ARRTextBox"
        Me.ARRTextBox.Size = New System.Drawing.Size(77, 20)
        Me.ARRTextBox.TabIndex = 7
        '
        'ST_FROMTextBox
        '
        Me.ST_FROMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "ST FROM", True))
        Me.ST_FROMTextBox.Location = New System.Drawing.Point(146, 224)
        Me.ST_FROMTextBox.Name = "ST_FROMTextBox"
        Me.ST_FROMTextBox.Size = New System.Drawing.Size(77, 20)
        Me.ST_FROMTextBox.TabIndex = 8
        '
        'ST_TOTextBox
        '
        Me.ST_TOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "ST TO", True))
        Me.ST_TOTextBox.Location = New System.Drawing.Point(146, 250)
        Me.ST_TOTextBox.Name = "ST_TOTextBox"
        Me.ST_TOTextBox.Size = New System.Drawing.Size(77, 20)
        Me.ST_TOTextBox.TabIndex = 9
        '
        'ST_WORKED_ATComboBox
        '
        Me.ST_WORKED_ATComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "ST WORKED AT", True))
        Me.ST_WORKED_ATComboBox.FormattingEnabled = True
        Me.ST_WORKED_ATComboBox.Location = New System.Drawing.Point(369, 39)
        Me.ST_WORKED_ATComboBox.Name = "ST_WORKED_ATComboBox"
        Me.ST_WORKED_ATComboBox.Size = New System.Drawing.Size(77, 21)
        Me.ST_WORKED_ATComboBox.TabIndex = 10
        '
        'REASON_OF_CHANGETextBox
        '
        Me.REASON_OF_CHANGETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "REASON OF CHANGE", True))
        Me.REASON_OF_CHANGETextBox.Location = New System.Drawing.Point(369, 123)
        Me.REASON_OF_CHANGETextBox.Name = "REASON_OF_CHANGETextBox"
        Me.REASON_OF_CHANGETextBox.Size = New System.Drawing.Size(77, 20)
        Me.REASON_OF_CHANGETextBox.TabIndex = 13
        '
        'IR_CASE_NOTextBox
        '
        Me.IR_CASE_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "IR/CASE NO", True))
        Me.IR_CASE_NOTextBox.Location = New System.Drawing.Point(369, 149)
        Me.IR_CASE_NOTextBox.Name = "IR_CASE_NOTextBox"
        Me.IR_CASE_NOTextBox.Size = New System.Drawing.Size(77, 20)
        Me.IR_CASE_NOTextBox.TabIndex = 14
        '
        'Insp_compCheckBox
        '
        Me.Insp_compCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.JOMBindingSource, "insp comp", True))
        Me.Insp_compCheckBox.Location = New System.Drawing.Point(685, 12)
        Me.Insp_compCheckBox.Name = "Insp_compCheckBox"
        Me.Insp_compCheckBox.Size = New System.Drawing.Size(77, 24)
        Me.Insp_compCheckBox.TabIndex = 26
        Me.Insp_compCheckBox.Text = "CheckBox1"
        Me.Insp_compCheckBox.UseVisualStyleBackColor = True
        '
        'REPORT_SUBMISSIONTextBox
        '
        Me.REPORT_SUBMISSIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "REPORT SUBMISSION", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "dd-MMM-yyyy"))
        Me.REPORT_SUBMISSIONTextBox.Location = New System.Drawing.Point(685, 42)
        Me.REPORT_SUBMISSIONTextBox.Name = "REPORT_SUBMISSIONTextBox"
        Me.REPORT_SUBMISSIONTextBox.Size = New System.Drawing.Size(77, 20)
        Me.REPORT_SUBMISSIONTextBox.TabIndex = 28
        '
        'ROUNDTextBox
        '
        Me.ROUNDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "ROUND", True))
        Me.ROUNDTextBox.Location = New System.Drawing.Point(369, 97)
        Me.ROUNDTextBox.Name = "ROUNDTextBox"
        Me.ROUNDTextBox.Size = New System.Drawing.Size(77, 20)
        Me.ROUNDTextBox.TabIndex = 12
        '
        '_2RODTextBox
        '
        Me._2RODTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "2ROD", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "dd-MMM-yyyy"))
        Me._2RODTextBox.Location = New System.Drawing.Point(369, 201)
        Me._2RODTextBox.Name = "_2RODTextBox"
        Me._2RODTextBox.Size = New System.Drawing.Size(77, 20)
        Me._2RODTextBox.TabIndex = 16
        '
        '_3RODTextBox
        '
        Me._3RODTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "3ROD", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "dd-MMM-yyyy"))
        Me._3RODTextBox.Location = New System.Drawing.Point(369, 226)
        Me._3RODTextBox.Name = "_3RODTextBox"
        Me._3RODTextBox.Size = New System.Drawing.Size(77, 20)
        Me._3RODTextBox.TabIndex = 17
        '
        '_1R0DTextBox
        '
        Me._1R0DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "1R0D", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "dd-MMM-yyyy"))
        Me._1R0DTextBox.Location = New System.Drawing.Point(369, 175)
        Me._1R0DTextBox.Name = "_1R0DTextBox"
        Me._1R0DTextBox.Size = New System.Drawing.Size(77, 20)
        Me._1R0DTextBox.TabIndex = 15
        '
        'LINSPTextBox
        '
        Me.LINSPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "LINSP", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "dd-MMM-yyyy"))
        Me.LINSPTextBox.Location = New System.Drawing.Point(685, 80)
        Me.LINSPTextBox.Name = "LINSPTextBox"
        Me.LINSPTextBox.Size = New System.Drawing.Size(77, 20)
        Me.LINSPTextBox.TabIndex = 38
        '
        'NDUETextBox
        '
        Me.NDUETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "NDUE", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "MMM-yyyy"))
        Me.NDUETextBox.Location = New System.Drawing.Point(369, 253)
        Me.NDUETextBox.Name = "NDUETextBox"
        Me.NDUETextBox.Size = New System.Drawing.Size(77, 20)
        Me.NDUETextBox.TabIndex = 18
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(369, 71)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(77, 20)
        Me.NumericUpDown1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(242, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 40)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(131, 303)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 40)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(232, 303)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 40)
        Me.Button3.TabIndex = 45
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.BEATPBindingSource
        Me.ListBox1.DisplayMember = "STATION"
        Me.ListBox1.Enabled = False
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(512, 106)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(176, 95)
        Me.ListBox1.TabIndex = 46
        '
        'BEATPBindingSource
        '
        Me.BEATPBindingSource.DataMember = "BEAT­_P"
        Me.BEATPBindingSource.DataSource = Me.MY_INSPDataSet
        '
        'JOMDataGridView
        '
        Me.JOMDataGridView.AutoGenerateColumns = False
        Me.JOMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.JOMDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.JOMDataGridView.DataSource = Me.JOMBindingSource
        Me.JOMDataGridView.Location = New System.Drawing.Point(0, 397)
        Me.JOMDataGridView.Name = "JOMDataGridView"
        Me.JOMDataGridView.Size = New System.Drawing.Size(800, 220)
        Me.JOMDataGridView.TabIndex = 47
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "WEEK ENDING"
        Me.DataGridViewTextBoxColumn2.HeaderText = "WEEK ENDING"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DATE OF JOURNEY"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DATE OF JOURNEY"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DAY OF JOURNEY"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DAY OF JOURNEY"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TRAIN"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TRAIN"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DEP"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DEP"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ARR"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ARR"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ST FROM"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ST FROM"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ST TO"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ST TO"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ST WORKED AT"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ST WORKED AT"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "REASON OF CHANGE"
        Me.DataGridViewTextBoxColumn11.HeaderText = "REASON OF CHANGE"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "IR/CASE NO"
        Me.DataGridViewTextBoxColumn12.HeaderText = "IR/CASE NO"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "insp comp"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "insp comp"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "REPORT SUBMISSION"
        Me.DataGridViewTextBoxColumn13.HeaderText = "REPORT SUBMISSION"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "ROUND"
        Me.DataGridViewTextBoxColumn14.HeaderText = "ROUND"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "2ROD"
        Me.DataGridViewTextBoxColumn15.HeaderText = "2ROD"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "3ROD"
        Me.DataGridViewTextBoxColumn16.HeaderText = "3ROD"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "1R0D"
        Me.DataGridViewTextBoxColumn17.HeaderText = "1R0D"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "LINSP"
        Me.DataGridViewTextBoxColumn18.HeaderText = "LINSP"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "NDUE"
        Me.DataGridViewTextBoxColumn19.HeaderText = "NDUE"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(800, 637)
        Me.Controls.Add(Me.JOMDataGridView)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(WEEK_ENDINGLabel)
        Me.Controls.Add(Me.WEEK_ENDINGTextBox)
        Me.Controls.Add(DATE_OF_JOURNEYLabel)
        Me.Controls.Add(Me.DATE_OF_JOURNEYTextBox)
        Me.Controls.Add(DAY_OF_JOURNEYLabel)
        Me.Controls.Add(Me.DAY_OF_JOURNEYTextBox)
        Me.Controls.Add(TRAINLabel)
        Me.Controls.Add(Me.TRAINTextBox)
        Me.Controls.Add(DEPLabel)
        Me.Controls.Add(Me.DEPTextBox)
        Me.Controls.Add(ARRLabel)
        Me.Controls.Add(Me.ARRTextBox)
        Me.Controls.Add(ST_FROMLabel)
        Me.Controls.Add(Me.ST_FROMTextBox)
        Me.Controls.Add(ST_TOLabel)
        Me.Controls.Add(Me.ST_TOTextBox)
        Me.Controls.Add(ST_WORKED_ATLabel)
        Me.Controls.Add(Me.ST_WORKED_ATComboBox)
        Me.Controls.Add(REASON_OF_CHANGELabel)
        Me.Controls.Add(Me.REASON_OF_CHANGETextBox)
        Me.Controls.Add(IR_CASE_NOLabel)
        Me.Controls.Add(Me.IR_CASE_NOTextBox)
        Me.Controls.Add(Insp_compLabel)
        Me.Controls.Add(Me.Insp_compCheckBox)
        Me.Controls.Add(REPORT_SUBMISSIONLabel)
        Me.Controls.Add(Me.REPORT_SUBMISSIONTextBox)
        Me.Controls.Add(ROUNDLabel)
        Me.Controls.Add(Me.ROUNDTextBox)
        Me.Controls.Add(_2RODLabel)
        Me.Controls.Add(Me._2RODTextBox)
        Me.Controls.Add(_3RODLabel)
        Me.Controls.Add(Me._3RODTextBox)
        Me.Controls.Add(_1R0DLabel)
        Me.Controls.Add(Me._1R0DTextBox)
        Me.Controls.Add(LINSPLabel)
        Me.Controls.Add(Me.LINSPTextBox)
        Me.Controls.Add(NDUELabel)
        Me.Controls.Add(Me.NDUETextBox)
        Me.Controls.Add(Me.JOMBindingNavigator)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.MY_INSPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOMBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JOMBindingNavigator.ResumeLayout(False)
        Me.JOMBindingNavigator.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BEATPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOMDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MY_INSPDataSet As MY_INSPDataSet
    Friend WithEvents JOMBindingSource As BindingSource
    Friend WithEvents JOMTableAdapter As MY_INSPDataSetTableAdapters.JOMTableAdapter
    Friend WithEvents TableAdapterManager As MY_INSPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents JOMBindingNavigator As BindingNavigator
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
    Friend WithEvents JOMBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents WEEK_ENDINGTextBox As TextBox
    Friend WithEvents DATE_OF_JOURNEYTextBox As TextBox
    Friend WithEvents DAY_OF_JOURNEYTextBox As TextBox
    Friend WithEvents TRAINTextBox As TextBox
    Friend WithEvents DEPTextBox As TextBox
    Friend WithEvents ARRTextBox As TextBox
    Friend WithEvents ST_FROMTextBox As TextBox
    Friend WithEvents ST_TOTextBox As TextBox
    Friend WithEvents ST_WORKED_ATComboBox As ComboBox
    Friend WithEvents REASON_OF_CHANGETextBox As TextBox
    Friend WithEvents IR_CASE_NOTextBox As TextBox
    Friend WithEvents Insp_compCheckBox As CheckBox
    Friend WithEvents REPORT_SUBMISSIONTextBox As TextBox
    Friend WithEvents ROUNDTextBox As TextBox
    Friend WithEvents _2RODTextBox As TextBox
    Friend WithEvents _3RODTextBox As TextBox
    Friend WithEvents _1R0DTextBox As TextBox
    Friend WithEvents LINSPTextBox As TextBox
    Friend WithEvents NDUETextBox As TextBox
    Friend WithEvents BEAT__PTableAdapter As MY_INSPDataSetTableAdapters.BEAT__PTableAdapter
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents BEATPBindingSource As BindingSource
    Friend WithEvents JOMDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
End Class
