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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MYDATAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FEEDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STDATAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INSPDATAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DAILYINSPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SEARCHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
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
        Me.DAILYINSPToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "MY INSPECTIONS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
End Class
