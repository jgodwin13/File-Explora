Imports System.IO
Imports System.Windows.Forms
Imports System.Diagnostics

Public Class Form2

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.ToolStripStatusLabel1.Text = Now.ToString("HH:mm:ss" & " tt")
        Me.ToolStripStatusLabel2.Text = Now.Day & " - " & Now.ToString("MMMM") & " - " & Now.Year
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Timer1.Enabled = True
        Me.StatusBarPanel3.Text = "Ready..."
    End Sub

    Private Sub PopulateTreeView()
        Dim rootNode As TreeNode

        Dim info As New DirectoryInfo("../..")
        If info.Exists Then
            rootNode = New TreeNode(info.Name)
            rootNode.Tag = info
            GetDirectories(info.GetDirectories(), rootNode)
            TreeView1.Nodes.Add(rootNode)
        End If

    End Sub

    Private Sub GetDirectories(ByVal subDirs() As DirectoryInfo, _
        ByVal nodeToAddTo As TreeNode)

        Dim aNode As TreeNode
        Dim subSubDirs() As DirectoryInfo
        Dim subDir As DirectoryInfo
        For Each subDir In subDirs
            aNode = New TreeNode(subDir.Name, 0, 0)
            aNode.Tag = subDir
            aNode.ImageKey = "folder"
            subSubDirs = subDir.GetDirectories()
            If subSubDirs.Length <> 0 Then
                GetDirectories(subSubDirs, aNode)
            End If
            nodeToAddTo.Nodes.Add(aNode)
        Next subDir

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        PopulateTreeView()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        TextBox1.Text = TreeView1.HasChildren



    End Sub


    ' NodeMouseClick event
    Private Sub treeView1_NodeMouseClick(ByVal sender As Object, _
    ByVal e As TreeNodeMouseClickEventArgs) _
        Handles TreeView1.NodeMouseClick

        Dim newSelected As TreeNode = e.Node
        ListView1.Items.Clear()
        Dim nodeDirInfo As DirectoryInfo = _
        CType(newSelected.Tag, DirectoryInfo)
        Dim subItems() As ListViewItem.ListViewSubItem
        Dim item As ListViewItem = Nothing

        Dim dir As DirectoryInfo
        For Each dir In nodeDirInfo.GetDirectories()
            item = New ListViewItem(dir.Name, 0)
            subItems = New ListViewItem.ListViewSubItem() _
                {New ListViewItem.ListViewSubItem(item, "Directory"), _
                New ListViewItem.ListViewSubItem(item, _
                dir.LastAccessTime.ToShortDateString())}

            item.SubItems.AddRange(subItems)
            ListView1.Items.Add(item)
        Next dir
        Dim file As FileInfo
        For Each file In nodeDirInfo.GetFiles()
            item = New ListViewItem(file.Name, 1)
            subItems = New ListViewItem.ListViewSubItem() _
                {New ListViewItem.ListViewSubItem(item, "File"), _
                New ListViewItem.ListViewSubItem(item, _
                file.LastAccessTime.ToShortDateString())}

            item.SubItems.AddRange(subItems)
            ListView1.Items.Add(item)
        Next file

        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("iexplore", "http://www.google.com/search?hl=en&q=" + TextBox2.Text + "&aq=f&oq=")
        Me.StatusBarPanel3.Text = "Searching the Web..."

    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Close me
        Dim result As DialogResult
        result = MsgBox("Are you sure to Quit application !", MsgBoxStyle.Information, "Exit Message")
        If Windows.Forms.DialogResult.Yes Then
            Me.Close()
            'Application closed...
        End If
    End Sub

    Private Sub CommandPromptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommandPromptToolStripMenuItem.Click
        'Carries out the command specified by string but CMD still remains open
        Process.Start("CMD", "/K CD C:\")
        Me.StatusBarPanel3.Text = "Command Prompt Intialized"
    End Sub

    Private Sub PowershellToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PowershellToolStripMenuItem.Click
        Process.Start(New ProcessStartInfo() With {.UseShellExecute = True, _
                .FileName = "powershell", _
                .WorkingDirectory = "C:\"})
        Me.StatusBarPanel3.Text = "Powershell Intialized"
    End Sub

    Private Sub RegistryEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistryEditorToolStripMenuItem.Click
        Try
            Process.Start("Regedit.exe")
            Me.StatusBarPanel3.Text = "Registry Editor Intialized"
        Catch ex As Exception
            MsgBox("Registry Editor aborted!")
        End Try


    End Sub

    Private Sub EventViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventViewerToolStripMenuItem.Click
        Process.Start("eventvwr.exe")
        Me.StatusBarPanel3.Text = "Event Viewer Intialized"
    End Sub

    Private Sub DiskDefragmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiskDefragmentToolStripMenuItem.Click
        Process.Start("dfrgui.exe")
        Me.StatusBarPanel3.Text = "Disk Defragmenter Intialized"
    End Sub

    Private Sub DiskManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiskManagementToolStripMenuItem.Click
        Process.Start("diskmgmt.msc")
        Me.StatusBarPanel3.Text = "Disk Management Intialized"
    End Sub

    Private Sub ControlPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlPanelToolStripMenuItem.Click
        Process.Start("control.exe")
        Me.StatusBarPanel3.Text = "Control Panel Intialized"
    End Sub

    Private Sub PerformanceMonitorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerformanceMonitorToolStripMenuItem.Click
        Process.Start("perfmon.msc")
        Me.StatusBarPanel3.Text = "Performance Monitor Intialized"
    End Sub

    Private Sub PathVariablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PathVariablesToolStripMenuItem.Click
        Process.Start("SystemPropertiesAdvanced.exe")
        Me.StatusBarPanel3.Text = "Path Variables Intialized"
    End Sub


    Private Sub TaskManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaskManagerToolStripMenuItem.Click
        Dim osInfo As System.OperatingSystem = System.Environment.OSVersion
        If osInfo.Version.Major <= 5 Then
            'XP or Lower 
            Process.Start("taskman")
        Else 'Vista / 2008 Server / Win 8 / Win 8.1 / Win 10
            Process.Start("taskmgr")
        End If
        Me.StatusBarPanel3.Text = "Task Manager Intialized"
    End Sub

    Private Sub OptionalFeaturesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionalFeaturesToolStripMenuItem.Click
        Process.Start("C:\Windows\System32\OptionalFeatures.exe")
        Me.StatusBarPanel3.Text = "Path Variables Intialized"
    End Sub
End Class

