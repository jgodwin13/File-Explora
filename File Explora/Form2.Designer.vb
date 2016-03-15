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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommandPromptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PowershellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistryEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventViewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiskDefragmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiskManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerformanceMonitorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PathVariablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBarPanel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OptionalFeaturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(778, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CommandPromptToolStripMenuItem, Me.PowershellToolStripMenuItem, Me.RegistryEditorToolStripMenuItem, Me.EventViewerToolStripMenuItem, Me.DiskDefragmentToolStripMenuItem, Me.DiskManagementToolStripMenuItem, Me.ControlPanelToolStripMenuItem, Me.PerformanceMonitorToolStripMenuItem, Me.PathVariablesToolStripMenuItem, Me.TaskManagerToolStripMenuItem, Me.OptionalFeaturesToolStripMenuItem})
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'CommandPromptToolStripMenuItem
        '
        Me.CommandPromptToolStripMenuItem.Name = "CommandPromptToolStripMenuItem"
        Me.CommandPromptToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CommandPromptToolStripMenuItem.Text = "Command Prompt"
        '
        'PowershellToolStripMenuItem
        '
        Me.PowershellToolStripMenuItem.Name = "PowershellToolStripMenuItem"
        Me.PowershellToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.PowershellToolStripMenuItem.Text = "Powershell"
        '
        'RegistryEditorToolStripMenuItem
        '
        Me.RegistryEditorToolStripMenuItem.Name = "RegistryEditorToolStripMenuItem"
        Me.RegistryEditorToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.RegistryEditorToolStripMenuItem.Text = "Registry Editor"
        '
        'EventViewerToolStripMenuItem
        '
        Me.EventViewerToolStripMenuItem.Name = "EventViewerToolStripMenuItem"
        Me.EventViewerToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.EventViewerToolStripMenuItem.Text = "Event Viewer"
        '
        'DiskDefragmentToolStripMenuItem
        '
        Me.DiskDefragmentToolStripMenuItem.Name = "DiskDefragmentToolStripMenuItem"
        Me.DiskDefragmentToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.DiskDefragmentToolStripMenuItem.Text = "Disk Defragmenter"
        '
        'DiskManagementToolStripMenuItem
        '
        Me.DiskManagementToolStripMenuItem.Name = "DiskManagementToolStripMenuItem"
        Me.DiskManagementToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.DiskManagementToolStripMenuItem.Text = "Disk Management"
        '
        'ControlPanelToolStripMenuItem
        '
        Me.ControlPanelToolStripMenuItem.Name = "ControlPanelToolStripMenuItem"
        Me.ControlPanelToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ControlPanelToolStripMenuItem.Text = "Control Panel"
        '
        'PerformanceMonitorToolStripMenuItem
        '
        Me.PerformanceMonitorToolStripMenuItem.Name = "PerformanceMonitorToolStripMenuItem"
        Me.PerformanceMonitorToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.PerformanceMonitorToolStripMenuItem.Text = "Performance Monitor"
        '
        'PathVariablesToolStripMenuItem
        '
        Me.PathVariablesToolStripMenuItem.Name = "PathVariablesToolStripMenuItem"
        Me.PathVariablesToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.PathVariablesToolStripMenuItem.Text = "Path Variables"
        '
        'TaskManagerToolStripMenuItem
        '
        Me.TaskManagerToolStripMenuItem.Name = "TaskManagerToolStripMenuItem"
        Me.TaskManagerToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.TaskManagerToolStripMenuItem.Text = "Task Manager"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.StatusBarPanel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 239)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(778, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(34, 17)
        Me.ToolStripStatusLabel1.Text = "Time"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.ToolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(31, 17)
        Me.ToolStripStatusLabel2.Text = "Date"
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StatusBarPanel3.Name = "StatusBarPanel3"
        Me.StatusBarPanel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusBarPanel3.Size = New System.Drawing.Size(39, 17)
        Me.StatusBarPanel3.Text = "Status"
        Me.StatusBarPanel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(778, 215)
        Me.SplitContainer1.SplitterDistance = 259
        Me.SplitContainer1.TabIndex = 2
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(259, 215)
        Me.TreeView1.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(515, 215)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 186
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Type"
        Me.ColumnHeader2.Width = 194
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Last Modified"
        Me.ColumnHeader3.Width = 234
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox1.Location = New System.Drawing.Point(0, 219)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(778, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(263, 0)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(359, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(628, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 19)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Search the Web"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        '
        'OptionalFeaturesToolStripMenuItem
        '
        Me.OptionalFeaturesToolStripMenuItem.Name = "OptionalFeaturesToolStripMenuItem"
        Me.OptionalFeaturesToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.OptionalFeaturesToolStripMenuItem.Text = "Optional Features"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "File Explora"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommandPromptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PowershellToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents RegistryEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventViewerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiskDefragmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiskManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlPanelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerformanceMonitorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PathVariablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TaskManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents OptionalFeaturesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
