<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MYDATAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FEEDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STDATAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INSPDATAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DAILYINSPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SEARCHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMD_ME_DATA = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CMD_JOM = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MY_INSPDataSet1 = New PRO_TIA.MY_INSPDataSet1()
        Me.MY_DATABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MY_DATATableAdapter = New PRO_TIA.MY_INSPDataSet1TableAdapters.MY_DATATableAdapter()
        Me.TableAdapterManager = New PRO_TIA.MY_INSPDataSet1TableAdapters.TableAdapterManager()
        Me.MY_DATADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MY_DATADataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CMD_SAVE = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.MY_INSPDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MY_DATABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MY_DATADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MY_DATADataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MYDATAToolStripMenuItem, Me.STDATAToolStripMenuItem, Me.INSPDATAToolStripMenuItem, Me.REPORTSToolStripMenuItem, Me.SEARCHToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'MYDATAToolStripMenuItem
        '
        Me.MYDATAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FEEDToolStripMenuItem})
        Me.MYDATAToolStripMenuItem.Name = "MYDATAToolStripMenuItem"
        Me.MYDATAToolStripMenuItem.Size = New System.Drawing.Size(73, 21)
        Me.MYDATAToolStripMenuItem.Text = "MY DATA"
        '
        'FEEDToolStripMenuItem
        '
        Me.FEEDToolStripMenuItem.Name = "FEEDToolStripMenuItem"
        Me.FEEDToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.FEEDToolStripMenuItem.Text = "FEED"
        '
        'STDATAToolStripMenuItem
        '
        Me.STDATAToolStripMenuItem.Name = "STDATAToolStripMenuItem"
        Me.STDATAToolStripMenuItem.Size = New System.Drawing.Size(68, 21)
        Me.STDATAToolStripMenuItem.Text = "ST DATA"
        '
        'INSPDATAToolStripMenuItem
        '
        Me.INSPDATAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DAILYINSPToolStripMenuItem})
        Me.INSPDATAToolStripMenuItem.Name = "INSPDATAToolStripMenuItem"
        Me.INSPDATAToolStripMenuItem.Size = New System.Drawing.Size(81, 21)
        Me.INSPDATAToolStripMenuItem.Text = "INSP DATA"
        '
        'DAILYINSPToolStripMenuItem
        '
        Me.DAILYINSPToolStripMenuItem.Name = "DAILYINSPToolStripMenuItem"
        Me.DAILYINSPToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.DAILYINSPToolStripMenuItem.Text = "DAILY INSP"
        '
        'REPORTSToolStripMenuItem
        '
        Me.REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem"
        Me.REPORTSToolStripMenuItem.Size = New System.Drawing.Size(73, 21)
        Me.REPORTSToolStripMenuItem.Text = "REPORTS"
        '
        'SEARCHToolStripMenuItem
        '
        Me.SEARCHToolStripMenuItem.Name = "SEARCHToolStripMenuItem"
        Me.SEARCHToolStripMenuItem.Size = New System.Drawing.Size(67, 21)
        Me.SEARCHToolStripMenuItem.Text = "SEARCH"
        '
        'CMD_ME_DATA
        '
        Me.CMD_ME_DATA.BackColor = System.Drawing.Color.OrangeRed
        Me.CMD_ME_DATA.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CMD_ME_DATA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.CMD_ME_DATA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.CMD_ME_DATA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMD_ME_DATA.Location = New System.Drawing.Point(0, 65)
        Me.CMD_ME_DATA.Name = "CMD_ME_DATA"
        Me.CMD_ME_DATA.Size = New System.Drawing.Size(205, 42)
        Me.CMD_ME_DATA.TabIndex = 4
        Me.CMD_ME_DATA.Text = "MY DATA"
        Me.CMD_ME_DATA.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(500, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 37)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.CMD_JOM)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.CMD_ME_DATA)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(209, 490)
        Me.Panel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "TIA INSPECTIONS"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.OrangeRed
        Me.Button6.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(-3, 253)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(208, 40)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.OrangeRed
        Me.Button4.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(0, 159)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(205, 40)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'CMD_JOM
        '
        Me.CMD_JOM.BackColor = System.Drawing.Color.OrangeRed
        Me.CMD_JOM.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CMD_JOM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.CMD_JOM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.CMD_JOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMD_JOM.Location = New System.Drawing.Point(0, 113)
        Me.CMD_JOM.Name = "CMD_JOM"
        Me.CMD_JOM.Size = New System.Drawing.Size(205, 40)
        Me.CMD_JOM.TabIndex = 5
        Me.CMD_JOM.Text = "JOM FEDING"
        Me.CMD_JOM.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.OrangeRed
        Me.Button5.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(0, 205)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(205, 42)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Chocolate
        Me.Panel2.Controls.Add(Me.CMD_SAVE)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.MY_DATADataGridView1)
        Me.Panel2.Controls.Add(Me.MY_DATADataGridView)
        Me.Panel2.Location = New System.Drawing.Point(211, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(571, 523)
        Me.Panel2.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Orange
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Location = New System.Drawing.Point(211, -40)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(554, 107)
        Me.Panel3.TabIndex = 10
        '
        'MY_INSPDataSet1
        '
        Me.MY_INSPDataSet1.DataSetName = "MY_INSPDataSet1"
        Me.MY_INSPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MY_DATABindingSource
        '
        Me.MY_DATABindingSource.DataMember = "MY DATA"
        Me.MY_DATABindingSource.DataSource = Me.MY_INSPDataSet1
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
        Me.TableAdapterManager.UpdateOrder = PRO_TIA.MY_INSPDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MY_DATADataGridView
        '
        Me.MY_DATADataGridView.AutoGenerateColumns = False
        Me.MY_DATADataGridView.BackgroundColor = System.Drawing.Color.Chocolate
        Me.MY_DATADataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MY_DATADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MY_DATADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.MY_DATADataGridView.DataSource = Me.MY_DATABindingSource
        Me.MY_DATADataGridView.Location = New System.Drawing.Point(4, 123)
        Me.MY_DATADataGridView.Name = "MY_DATADataGridView"
        Me.MY_DATADataGridView.Size = New System.Drawing.Size(547, 62)
        Me.MY_DATADataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NAME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "HQ"
        Me.DataGridViewTextBoxColumn3.HeaderText = "HQ"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DOA"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DOA"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DOR"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DOR"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'MY_DATADataGridView1
        '
        Me.MY_DATADataGridView1.AutoGenerateColumns = False
        Me.MY_DATADataGridView1.BackgroundColor = System.Drawing.Color.Chocolate
        Me.MY_DATADataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MY_DATADataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MY_DATADataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.MY_DATADataGridView1.DataSource = Me.MY_DATABindingSource
        Me.MY_DATADataGridView1.Location = New System.Drawing.Point(79, 191)
        Me.MY_DATADataGridView1.Name = "MY_DATADataGridView1"
        Me.MY_DATADataGridView1.Size = New System.Drawing.Size(398, 220)
        Me.MY_DATADataGridView1.TabIndex = 1
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "BASIC"
        Me.DataGridViewTextBoxColumn12.HeaderText = "BASIC"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "BANK"
        Me.DataGridViewTextBoxColumn13.HeaderText = "BANK"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "ACCOUNT"
        Me.DataGridViewTextBoxColumn14.HeaderText = "ACCOUNT"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OrangeRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(327, 305)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 46)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "ADD/EDIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CMD_SAVE
        '
        Me.CMD_SAVE.BackColor = System.Drawing.Color.OrangeRed
        Me.CMD_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMD_SAVE.Location = New System.Drawing.Point(417, 305)
        Me.CMD_SAVE.Name = "CMD_SAVE"
        Me.CMD_SAVE.Size = New System.Drawing.Size(75, 46)
        Me.CMD_SAVE.TabIndex = 3
        Me.CMD_SAVE.Text = "SAVE"
        Me.CMD_SAVE.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AcceptButton = Me.Button2
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.CMD_ME_DATA
        Me.ClientSize = New System.Drawing.Size(782, 524)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MY INSPECTIONS"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.MY_INSPDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MY_DATABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MY_DATADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MY_DATADataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MYDATAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FEEDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents STDATAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INSPDATAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DAILYINSPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REPORTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SEARCHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CMD_ME_DATA As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents CMD_JOM As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MY_INSPDataSet1 As MY_INSPDataSet1
    Friend WithEvents MY_DATABindingSource As BindingSource
    Friend WithEvents MY_DATATableAdapter As MY_INSPDataSet1TableAdapters.MY_DATATableAdapter
    Friend WithEvents TableAdapterManager As MY_INSPDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Button1 As Button
    Friend WithEvents MY_DATADataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents MY_DATADataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents CMD_SAVE As Button
End Class
