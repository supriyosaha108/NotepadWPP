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
    	Me.components = New System.ComponentModel.Container()
    	Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
    	Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    	Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
    	Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.toolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
    	Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.toolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.toolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
    	Me.toolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.toolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.toolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.toolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.toolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    	Me.FindToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ReplaceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    	Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.toolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
    	Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.WordWrapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.Panel7 = New System.Windows.Forms.Panel()
    	Me.GroupBox3 = New System.Windows.Forms.GroupBox()
    	Me.Label1 = New System.Windows.Forms.Label()
    	Me.TextBox2 = New System.Windows.Forms.TextBox()
    	Me.TextBox3 = New System.Windows.Forms.TextBox()
    	Me.Label2 = New System.Windows.Forms.Label()
    	Me.OK_Button = New System.Windows.Forms.Button()
    	Me.Button7 = New System.Windows.Forms.Button()
    	Me.Cancel_Button = New System.Windows.Forms.Button()
    	Me.OFD1 = New System.Windows.Forms.OpenFileDialog()
    	Me.SFD1 = New System.Windows.Forms.SaveFileDialog()
    	Me.TextBox1 = New Notepad.MyRichTextBox()
    	Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
    	Me.cutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.copyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.pasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.toolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.toolStripMenuItem18 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.deleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
    	Me.selectAllToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.toolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator()
    	Me.insertLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.toggleBulletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.textBox4 = New System.Windows.Forms.TextBox()
    	Me.K = New System.Windows.Forms.FontDialog()
    	Me.MenuStrip1.SuspendLayout
    	Me.Panel7.SuspendLayout
    	Me.GroupBox3.SuspendLayout
    	Me.contextMenuStrip1.SuspendLayout
    	Me.SuspendLayout
    	'
    	'MenuStrip1
    	'
    	Me.MenuStrip1.AutoSize = false
    	Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
    	Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
    	Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    	Me.MenuStrip1.Name = "MenuStrip1"
    	Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
    	Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
    	Me.MenuStrip1.Size = New System.Drawing.Size(760, 20)
    	Me.MenuStrip1.TabIndex = 3
    	Me.MenuStrip1.Text = "MenuStrip1"
    	'
    	'FileToolStripMenuItem
    	'
    	Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.toolStripSeparator3, Me.SaveToolStripMenuItem, Me.toolStripMenuItem9, Me.ToolStripMenuItem2, Me.ExitToolStripMenuItem})
    	Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
    	Me.FileToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0, 0, 4, 0)
    	Me.FileToolStripMenuItem.Size = New System.Drawing.Size(33, 20)
    	Me.FileToolStripMenuItem.Text = "&File"
    	'
    	'NewToolStripMenuItem
    	'
    	Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
    	Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N),System.Windows.Forms.Keys)
    	Me.NewToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
    	Me.NewToolStripMenuItem.Text = "&New"
    	'
    	'OpenToolStripMenuItem
    	'
    	Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
    	Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O),System.Windows.Forms.Keys)
    	Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
    	Me.OpenToolStripMenuItem.Text = "&Open..."
    	'
    	'toolStripSeparator3
    	'
    	Me.toolStripSeparator3.Name = "toolStripSeparator3"
    	Me.toolStripSeparator3.Size = New System.Drawing.Size(174, 6)
    	'
    	'SaveToolStripMenuItem
    	'
    	Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
    	Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S),System.Windows.Forms.Keys)
    	Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
    	Me.SaveToolStripMenuItem.Text = "&Save"
    	'
    	'toolStripMenuItem9
    	'
    	Me.toolStripMenuItem9.Name = "toolStripMenuItem9"
    	Me.toolStripMenuItem9.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt)  _
    	    	    	Or System.Windows.Forms.Keys.S),System.Windows.Forms.Keys)
    	Me.toolStripMenuItem9.Size = New System.Drawing.Size(177, 22)
    	Me.toolStripMenuItem9.Text = "Save &As"
    	AddHandler Me.toolStripMenuItem9.Click, AddressOf Me.ToolStripMenuItem9Click
    	'
    	'ToolStripMenuItem2
    	'
    	Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
    	Me.ToolStripMenuItem2.Size = New System.Drawing.Size(174, 6)
    	'
    	'ExitToolStripMenuItem
    	'
    	Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
    	Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
    	Me.ExitToolStripMenuItem.Text = "&Exit"
    	'
    	'EditToolStripMenuItem
    	'
    	Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem15, Me.toolStripMenuItem16, Me.toolStripSeparator6, Me.toolStripMenuItem13, Me.toolStripMenuItem12, Me.toolStripMenuItem1, Me.toolStripMenuItem7, Me.toolStripMenuItem17, Me.toolStripMenuItem14, Me.toolStripSeparator2, Me.FindToolStripMenuItem1, Me.ToolStripMenuItem6, Me.ReplaceToolStripMenuItem1, Me.toolStripSeparator1, Me.ToolStripMenuItem5, Me.toolStripMenuItem8, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.SelectAllToolStripMenuItem})
    	Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
    	Me.EditToolStripMenuItem.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
    	Me.EditToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
    	Me.EditToolStripMenuItem.Text = "&Edit"
    	'
    	'toolStripMenuItem15
    	'
    	Me.toolStripMenuItem15.Name = "toolStripMenuItem15"
    	Me.toolStripMenuItem15.Size = New System.Drawing.Size(222, 22)
    	Me.toolStripMenuItem15.Text = "&Undo"
    	AddHandler Me.toolStripMenuItem15.Click, AddressOf Me.ToolStripMenuItem15Click
    	'
    	'toolStripMenuItem16
    	'
    	Me.toolStripMenuItem16.Name = "toolStripMenuItem16"
    	Me.toolStripMenuItem16.Size = New System.Drawing.Size(222, 22)
    	Me.toolStripMenuItem16.Text = "R&edo"
    	AddHandler Me.toolStripMenuItem16.Click, AddressOf Me.ToolStripMenuItem16Click
    	'
    	'toolStripSeparator6
    	'
    	Me.toolStripSeparator6.Name = "toolStripSeparator6"
    	Me.toolStripSeparator6.Size = New System.Drawing.Size(219, 6)
    	'
    	'toolStripMenuItem13
    	'
    	Me.toolStripMenuItem13.Name = "toolStripMenuItem13"
    	Me.toolStripMenuItem13.Size = New System.Drawing.Size(222, 22)
    	Me.toolStripMenuItem13.Text = "Cu&t"
    	AddHandler Me.toolStripMenuItem13.Click, AddressOf Me.ToolStripMenuItem13Click
    	'
    	'toolStripMenuItem12
    	'
    	Me.toolStripMenuItem12.Name = "toolStripMenuItem12"
    	Me.toolStripMenuItem12.Size = New System.Drawing.Size(222, 22)
    	Me.toolStripMenuItem12.Text = "C&opy"
    	AddHandler Me.toolStripMenuItem12.Click, AddressOf Me.ToolStripMenuItem12Click
    	'
    	'toolStripMenuItem1
    	'
    	Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
    	Me.toolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V),System.Windows.Forms.Keys)
    	Me.toolStripMenuItem1.Size = New System.Drawing.Size(222, 22)
    	Me.toolStripMenuItem1.Text = "&Paste"
    	AddHandler Me.toolStripMenuItem1.Click, AddressOf Me.ToolStripMenuItem1Click
    	'
    	'toolStripMenuItem7
    	'
    	Me.toolStripMenuItem7.Name = "toolStripMenuItem7"
    	Me.toolStripMenuItem7.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift)  _
    	    	    	Or System.Windows.Forms.Keys.V),System.Windows.Forms.Keys)
    	Me.toolStripMenuItem7.Size = New System.Drawing.Size(222, 22)
    	Me.toolStripMenuItem7.Text = "Paste &Image"
    	AddHandler Me.toolStripMenuItem7.Click, AddressOf Me.ToolStripMenuItem7Click
    	'
    	'toolStripMenuItem17
    	'
    	Me.toolStripMenuItem17.Name = "toolStripMenuItem17"
    	Me.toolStripMenuItem17.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt)  _
    	    	    	Or System.Windows.Forms.Keys.V),System.Windows.Forms.Keys)
    	Me.toolStripMenuItem17.Size = New System.Drawing.Size(222, 22)
    	Me.toolStripMenuItem17.Text = "Paste &Special"
    	AddHandler Me.toolStripMenuItem17.Click, AddressOf Me.ToolStripMenuItem17Click
    	'
    	'toolStripMenuItem14
    	'
    	Me.toolStripMenuItem14.Name = "toolStripMenuItem14"
    	Me.toolStripMenuItem14.Size = New System.Drawing.Size(222, 22)
    	Me.toolStripMenuItem14.Text = "Delete"
    	AddHandler Me.toolStripMenuItem14.Click, AddressOf Me.ToolStripMenuItem14Click
    	'
    	'toolStripSeparator2
    	'
    	Me.toolStripSeparator2.Name = "toolStripSeparator2"
    	Me.toolStripSeparator2.Size = New System.Drawing.Size(219, 6)
    	'
    	'FindToolStripMenuItem1
    	'
    	Me.FindToolStripMenuItem1.Name = "FindToolStripMenuItem1"
    	Me.FindToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F),System.Windows.Forms.Keys)
    	Me.FindToolStripMenuItem1.Size = New System.Drawing.Size(222, 22)
    	Me.FindToolStripMenuItem1.Text = "&Find..."
    	AddHandler Me.FindToolStripMenuItem1.Click, AddressOf Me.FindToolStripMenuItem1Click
    	'
    	'ToolStripMenuItem6
    	'
    	Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
    	Me.ToolStripMenuItem6.ShortcutKeys = System.Windows.Forms.Keys.F3
    	Me.ToolStripMenuItem6.Size = New System.Drawing.Size(222, 22)
    	Me.ToolStripMenuItem6.Text = "Find &Next"
    	'
    	'ReplaceToolStripMenuItem1
    	'
    	Me.ReplaceToolStripMenuItem1.Name = "ReplaceToolStripMenuItem1"
    	Me.ReplaceToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H),System.Windows.Forms.Keys)
    	Me.ReplaceToolStripMenuItem1.Size = New System.Drawing.Size(222, 22)
    	Me.ReplaceToolStripMenuItem1.Text = "&Replace All"
    	AddHandler Me.ReplaceToolStripMenuItem1.Click, AddressOf Me.ReplaceToolStripMenuItem1Click
    	'
    	'toolStripSeparator1
    	'
    	Me.toolStripSeparator1.Name = "toolStripSeparator1"
    	Me.toolStripSeparator1.Size = New System.Drawing.Size(219, 6)
    	'
    	'ToolStripMenuItem5
    	'
    	Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
    	Me.ToolStripMenuItem5.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B),System.Windows.Forms.Keys)
    	Me.ToolStripMenuItem5.Size = New System.Drawing.Size(222, 22)
    	Me.ToolStripMenuItem5.Text = "Insert &Line"
    	'
    	'toolStripMenuItem8
    	'
    	Me.toolStripMenuItem8.Name = "toolStripMenuItem8"
    	Me.toolStripMenuItem8.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift)  _
    	    	    	Or System.Windows.Forms.Keys.B),System.Windows.Forms.Keys)
    	Me.toolStripMenuItem8.Size = New System.Drawing.Size(222, 22)
    	Me.toolStripMenuItem8.Text = "&Toggle Bullet"
    	AddHandler Me.toolStripMenuItem8.Click, AddressOf Me.ToolStripMenuItem8Click
    	'
    	'ToolStripMenuItem3
    	'
    	Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
    	Me.ToolStripMenuItem3.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q),System.Windows.Forms.Keys)
    	Me.ToolStripMenuItem3.Size = New System.Drawing.Size(222, 22)
    	Me.ToolStripMenuItem3.Text = "Remove &Comments"
    	'
    	'ToolStripMenuItem4
    	'
    	Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
    	Me.ToolStripMenuItem4.Size = New System.Drawing.Size(219, 6)
    	'
    	'SelectAllToolStripMenuItem
    	'
    	Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
    	Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A),System.Windows.Forms.Keys)
    	Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
    	Me.SelectAllToolStripMenuItem.Text = "&Select All"
    	'
    	'ViewToolStripMenuItem
    	'
    	Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WordWrapToolStripMenuItem, Me.FontToolStripMenuItem})
    	Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
    	Me.ViewToolStripMenuItem.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
    	Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
    	Me.ViewToolStripMenuItem.Text = "&View"
    	'
    	'WordWrapToolStripMenuItem
    	'
    	Me.WordWrapToolStripMenuItem.Checked = true
    	Me.WordWrapToolStripMenuItem.CheckOnClick = true
    	Me.WordWrapToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
    	Me.WordWrapToolStripMenuItem.Name = "WordWrapToolStripMenuItem"
    	Me.WordWrapToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    	Me.WordWrapToolStripMenuItem.Text = "&Word Wrap"
    	'
    	'FontToolStripMenuItem
    	'
    	Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
    	Me.FontToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    	Me.FontToolStripMenuItem.Text = "&Font..."
    	'
    	'HelpToolStripMenuItem
    	'
    	Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
    	Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
    	Me.HelpToolStripMenuItem.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
    	Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
    	Me.HelpToolStripMenuItem.Text = "&Help"
    	'
    	'AboutToolStripMenuItem
    	'
    	Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
    	Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
    	Me.AboutToolStripMenuItem.Text = "&About Notepad"
    	'
    	'Panel7
    	'
    	Me.Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.Panel7.BackColor = System.Drawing.SystemColors.Control
    	Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    	Me.Panel7.Controls.Add(Me.GroupBox3)
    	Me.Panel7.Controls.Add(Me.OK_Button)
    	Me.Panel7.Controls.Add(Me.Button7)
    	Me.Panel7.Controls.Add(Me.Cancel_Button)
    	Me.Panel7.Location = New System.Drawing.Point(509, 392)
    	Me.Panel7.Name = "Panel7"
    	Me.Panel7.Size = New System.Drawing.Size(248, 121)
    	Me.Panel7.TabIndex = 109
    	Me.Panel7.Visible = false
    	'
    	'GroupBox3
    	'
    	Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
    	Me.GroupBox3.Controls.Add(Me.Label1)
    	Me.GroupBox3.Controls.Add(Me.TextBox2)
    	Me.GroupBox3.Controls.Add(Me.TextBox3)
    	Me.GroupBox3.Controls.Add(Me.Label2)
    	Me.GroupBox3.Location = New System.Drawing.Point(8, 0)
    	Me.GroupBox3.Name = "GroupBox3"
    	Me.GroupBox3.Size = New System.Drawing.Size(232, 81)
    	Me.GroupBox3.TabIndex = 7
    	Me.GroupBox3.TabStop = false
    	'
    	'Label1
    	'
    	Me.Label1.AutoSize = true
    	Me.Label1.BackColor = System.Drawing.SystemColors.Control
    	Me.Label1.Location = New System.Drawing.Point(8, 20)
    	Me.Label1.Name = "Label1"
    	Me.Label1.Size = New System.Drawing.Size(44, 13)
    	Me.Label1.TabIndex = 111
    	Me.Label1.Text = "Search:"
    	'
    	'TextBox2
    	'
    	Me.TextBox2.AcceptsTab = true
    	Me.TextBox2.Location = New System.Drawing.Point(56, 48)
    	Me.TextBox2.Name = "TextBox2"
    	Me.TextBox2.Size = New System.Drawing.Size(168, 20)
    	Me.TextBox2.TabIndex = 110
    	Me.TextBox2.Tag = "0"
    	'
    	'TextBox3
    	'
    	Me.TextBox3.AcceptsTab = true
    	Me.TextBox3.Location = New System.Drawing.Point(56, 16)
    	Me.TextBox3.Name = "TextBox3"
    	Me.TextBox3.Size = New System.Drawing.Size(168, 20)
    	Me.TextBox3.TabIndex = 109
    	'
    	'Label2
    	'
    	Me.Label2.AutoSize = true
    	Me.Label2.BackColor = System.Drawing.SystemColors.Control
    	Me.Label2.Location = New System.Drawing.Point(8, 52)
    	Me.Label2.Name = "Label2"
    	Me.Label2.Size = New System.Drawing.Size(50, 13)
    	Me.Label2.TabIndex = 112
    	Me.Label2.Text = "Replace:"
    	'
    	'OK_Button
    	'
    	Me.OK_Button.BackColor = System.Drawing.SystemColors.Control
    	Me.OK_Button.Location = New System.Drawing.Point(88, 88)
    	Me.OK_Button.Name = "OK_Button"
    	Me.OK_Button.Size = New System.Drawing.Size(67, 24)
    	Me.OK_Button.TabIndex = 112
    	Me.OK_Button.Text = "Replace"
    	Me.OK_Button.UseVisualStyleBackColor = false
    	'
    	'Button7
    	'
    	Me.Button7.BackColor = System.Drawing.SystemColors.Control
    	Me.Button7.Location = New System.Drawing.Point(8, 88)
    	Me.Button7.Name = "Button7"
    	Me.Button7.Size = New System.Drawing.Size(67, 24)
    	Me.Button7.TabIndex = 111
    	Me.Button7.Text = "&Search"
    	Me.Button7.UseVisualStyleBackColor = false
    	'
    	'Cancel_Button
    	'
    	Me.Cancel_Button.BackColor = System.Drawing.SystemColors.Control
    	Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    	Me.Cancel_Button.Location = New System.Drawing.Point(168, 88)
    	Me.Cancel_Button.Name = "Cancel_Button"
    	Me.Cancel_Button.Size = New System.Drawing.Size(67, 24)
    	Me.Cancel_Button.TabIndex = 113
    	Me.Cancel_Button.Text = "&Cancel"
    	Me.Cancel_Button.UseVisualStyleBackColor = false
    	AddHandler Me.Cancel_Button.Click, AddressOf Me.Cancel_ButtonClick
    	'
    	'OFD1
    	'
    	Me.OFD1.Filter = "Word Documents (*.wrd)|*.rtf|C Files (*.c)|*.c|Rich Text File (*.rtf) |*.rtf|All "& _ 
    	"files (*.*)|*.*"
    	'
    	'SFD1
    	'
    	Me.SFD1.DefaultExt = "c"
    	Me.SFD1.Filter = "Word Documents (*.wrd)|*.rtf|C Files (*.c)|*.c|Rich Text File (*.rtf) |*.rtf|All "& _ 
    	"files (*.*)|*.*"
    	'
    	'TextBox1
    	'
    	Me.TextBox1.AcceptsTab = true
    	Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
    	    	    	Or System.Windows.Forms.AnchorStyles.Left)  _
    	    	    	Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.TextBox1.AutoWordSelection = true
    	Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
    	Me.TextBox1.ContextMenuStrip = Me.contextMenuStrip1
    	Me.TextBox1.DetectUrls = false
    	Me.TextBox1.Font = New System.Drawing.Font("Consolas", 11.25!)
    	Me.TextBox1.HideSelection = false
    	Me.TextBox1.Location = New System.Drawing.Point(6, 23)
    	Me.TextBox1.Name = "TextBox1"
    	Me.TextBox1.Size = New System.Drawing.Size(753, 491)
    	Me.TextBox1.TabIndex = 4
    	Me.TextBox1.Text = ""
    	AddHandler Me.TextBox1.KeyUp, AddressOf Me.TextBox1KeyUp
    	'
    	'contextMenuStrip1
    	'
    	Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cutToolStripMenuItem, Me.copyToolStripMenuItem, Me.pasteToolStripMenuItem, Me.toolStripMenuItem10, Me.toolStripMenuItem18, Me.deleteToolStripMenuItem, Me.toolStripSeparator5, Me.selectAllToolStripMenuItem1, Me.toolStripMenuItem11, Me.insertLineToolStripMenuItem, Me.toggleBulletToolStripMenuItem})
    	Me.contextMenuStrip1.Name = "contextMenuStrip1"
    	Me.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
    	Me.contextMenuStrip1.Size = New System.Drawing.Size(153, 236)
    	'
    	'cutToolStripMenuItem
    	'
    	Me.cutToolStripMenuItem.Name = "cutToolStripMenuItem"
    	Me.cutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    	Me.cutToolStripMenuItem.Text = "Cut"
    	AddHandler Me.cutToolStripMenuItem.Click, AddressOf Me.CutToolStripMenuItemClick
    	'
    	'copyToolStripMenuItem
    	'
    	Me.copyToolStripMenuItem.Name = "copyToolStripMenuItem"
    	Me.copyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    	Me.copyToolStripMenuItem.Text = "Copy"
    	AddHandler Me.copyToolStripMenuItem.Click, AddressOf Me.CopyToolStripMenuItemClick
    	'
    	'pasteToolStripMenuItem
    	'
    	Me.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem"
    	Me.pasteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    	Me.pasteToolStripMenuItem.Text = "Paste"
    	AddHandler Me.pasteToolStripMenuItem.Click, AddressOf Me.PasteToolStripMenuItemClick
    	'
    	'toolStripMenuItem10
    	'
    	Me.toolStripMenuItem10.Name = "toolStripMenuItem10"
    	Me.toolStripMenuItem10.Size = New System.Drawing.Size(152, 22)
    	Me.toolStripMenuItem10.Text = "Paste Image"
    	AddHandler Me.toolStripMenuItem10.Click, AddressOf Me.ToolStripMenuItem10Click
    	'
    	'toolStripMenuItem18
    	'
    	Me.toolStripMenuItem18.Name = "toolStripMenuItem18"
    	Me.toolStripMenuItem18.Size = New System.Drawing.Size(152, 22)
    	Me.toolStripMenuItem18.Text = "Paste Special"
    	AddHandler Me.toolStripMenuItem18.Click, AddressOf Me.ToolStripMenuItem18Click
    	'
    	'deleteToolStripMenuItem
    	'
    	Me.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem"
    	Me.deleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    	Me.deleteToolStripMenuItem.Text = "Delete"
    	AddHandler Me.deleteToolStripMenuItem.Click, AddressOf Me.DeleteToolStripMenuItemClick
    	'
    	'toolStripSeparator5
    	'
    	Me.toolStripSeparator5.Name = "toolStripSeparator5"
    	Me.toolStripSeparator5.Size = New System.Drawing.Size(149, 6)
    	'
    	'selectAllToolStripMenuItem1
    	'
    	Me.selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1"
    	Me.selectAllToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
    	Me.selectAllToolStripMenuItem1.Text = "Select All"
    	AddHandler Me.selectAllToolStripMenuItem1.Click, AddressOf Me.SelectAllToolStripMenuItem1Click
    	'
    	'toolStripMenuItem11
    	'
    	Me.toolStripMenuItem11.Name = "toolStripMenuItem11"
    	Me.toolStripMenuItem11.Size = New System.Drawing.Size(149, 6)
    	'
    	'insertLineToolStripMenuItem
    	'
    	Me.insertLineToolStripMenuItem.Name = "insertLineToolStripMenuItem"
    	Me.insertLineToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    	Me.insertLineToolStripMenuItem.Text = "Insert Line"
    	AddHandler Me.insertLineToolStripMenuItem.Click, AddressOf Me.InsertLineToolStripMenuItemClick
    	'
    	'toggleBulletToolStripMenuItem
    	'
    	Me.toggleBulletToolStripMenuItem.Name = "toggleBulletToolStripMenuItem"
    	Me.toggleBulletToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    	Me.toggleBulletToolStripMenuItem.Text = "Toggle Bullet"
    	AddHandler Me.toggleBulletToolStripMenuItem.Click, AddressOf Me.ToggleBulletToolStripMenuItemClick
    	'
    	'textBox4
    	'
    	Me.textBox4.BackColor = System.Drawing.SystemColors.Window
    	Me.textBox4.Cursor = System.Windows.Forms.Cursors.Default
    	Me.textBox4.Dock = System.Windows.Forms.DockStyle.Fill
    	Me.textBox4.ForeColor = System.Drawing.SystemColors.WindowText
    	Me.textBox4.Location = New System.Drawing.Point(0, 20)
    	Me.textBox4.Multiline = true
    	Me.textBox4.Name = "textBox4"
    	Me.textBox4.ReadOnly = true
    	Me.textBox4.Size = New System.Drawing.Size(760, 495)
    	Me.textBox4.TabIndex = 110
    	Me.textBox4.TabStop = false
    	AddHandler Me.textBox4.Click, AddressOf Me.TextBox4Click
    	'
    	'K
    	'
    	Me.K.Font = New System.Drawing.Font("Consolas", 11.25!)
    	'
    	'Form1
    	'
    	Me.AllowDrop = true
    	Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    	Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    	Me.ClientSize = New System.Drawing.Size(760, 515)
    	Me.Controls.Add(Me.Panel7)
    	Me.Controls.Add(Me.TextBox1)
    	Me.Controls.Add(Me.textBox4)
    	Me.Controls.Add(Me.MenuStrip1)
    	Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
    	Me.Name = "Form1"
    	Me.Text = "CPP - Notepad"
    	AddHandler DragDrop, AddressOf Me.Form1DragDrop
    	AddHandler DragEnter, AddressOf Me.Form1DragEnter
    	Me.MenuStrip1.ResumeLayout(false)
    	Me.MenuStrip1.PerformLayout
    	Me.Panel7.ResumeLayout(false)
    	Me.GroupBox3.ResumeLayout(false)
    	Me.GroupBox3.PerformLayout
    	Me.contextMenuStrip1.ResumeLayout(false)
    	Me.ResumeLayout(false)
    	Me.PerformLayout
    End Sub
    Private toolStripMenuItem18 As System.Windows.Forms.ToolStripMenuItem
    Private toolStripMenuItem17 As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Private toolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
    Private toolStripMenuItem15 As System.Windows.Forms.ToolStripMenuItem
    Private toolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
    Private toolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
    Private toolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem
    Private toolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Private toggleBulletToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private insertLineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolStripMenuItem11 As System.Windows.Forms.ToolStripSeparator
    Private selectAllToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Private deleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private pasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private cutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private copyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private contextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Private toolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private toolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Private toolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Private K As System.Windows.Forms.FontDialog
    Private toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private textBox4 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReplaceToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WordWrapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private TextBox1 As Notepad.MyRichTextBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OFD1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SFD1 As System.Windows.Forms.SaveFileDialog
End Class
