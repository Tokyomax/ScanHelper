<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class myMainForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.myMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.menu_File = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItem_SelectDirectory = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FunctionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullyParseCurrentDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OCRParseCurrentDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.myMainImage = New System.Windows.Forms.PictureBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.myMenuStrip.SuspendLayout()
        CType(Me.myMainImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 601)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1094, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 26)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1094, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'myMenuStrip
        '
        Me.myMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_File, Me.FunctionToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.myMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.myMenuStrip.Name = "myMenuStrip"
        Me.myMenuStrip.Size = New System.Drawing.Size(1094, 26)
        Me.myMenuStrip.TabIndex = 2
        Me.myMenuStrip.Text = "MenuStrip2"
        '
        'menu_File
        '
        Me.menu_File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItem_SelectDirectory, Me.CloseToolStripMenuItem})
        Me.menu_File.Name = "menu_File"
        Me.menu_File.Size = New System.Drawing.Size(51, 22)
        Me.menu_File.Text = "Menu"
        '
        'menuItem_SelectDirectory
        '
        Me.menuItem_SelectDirectory.Name = "menuItem_SelectDirectory"
        Me.menuItem_SelectDirectory.Size = New System.Drawing.Size(181, 22)
        Me.menuItem_SelectDirectory.Text = "Select a Directory"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'FunctionToolStripMenuItem
        '
        Me.FunctionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FullyParseCurrentDirectoryToolStripMenuItem, Me.OCRParseCurrentDirectoryToolStripMenuItem})
        Me.FunctionToolStripMenuItem.Name = "FunctionToolStripMenuItem"
        Me.FunctionToolStripMenuItem.Size = New System.Drawing.Size(69, 22)
        Me.FunctionToolStripMenuItem.Text = "Function"
        '
        'FullyParseCurrentDirectoryToolStripMenuItem
        '
        Me.FullyParseCurrentDirectoryToolStripMenuItem.Name = "FullyParseCurrentDirectoryToolStripMenuItem"
        Me.FullyParseCurrentDirectoryToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.FullyParseCurrentDirectoryToolStripMenuItem.Text = "Fully Parse Current Directory"
        '
        'OCRParseCurrentDirectoryToolStripMenuItem
        '
        Me.OCRParseCurrentDirectoryToolStripMenuItem.Name = "OCRParseCurrentDirectoryToolStripMenuItem"
        Me.OCRParseCurrentDirectoryToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.OCRParseCurrentDirectoryToolStripMenuItem.Text = "OCR Parse Current Directory"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(48, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.ToolsToolStripMenuItem.Text = "Tool"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(58, 22)
        Me.OptionsToolStripMenuItem.Text = "Option"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(46, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'myMainImage
        '
        Me.myMainImage.Location = New System.Drawing.Point(0, 53)
        Me.myMainImage.Name = "myMainImage"
        Me.myMainImage.Size = New System.Drawing.Size(768, 545)
        Me.myMainImage.TabIndex = 3
        Me.myMainImage.TabStop = False
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(774, 53)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(320, 545)
        Me.TreeView1.TabIndex = 4
        '
        'myMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 623)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.myMainImage)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.myMenuStrip)
        Me.MainMenuStrip = Me.myMenuStrip
        Me.Name = "myMainForm"
        Me.Text = "ScanHelper 0.1"
        Me.myMenuStrip.ResumeLayout(False)
        Me.myMenuStrip.PerformLayout()
        CType(Me.myMainImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents myMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents menu_File As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItem_SelectDirectory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FunctionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FullyParseCurrentDirectoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OCRParseCurrentDirectoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents myMainImage As System.Windows.Forms.PictureBox
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView

End Class
