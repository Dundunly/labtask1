<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TyreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TyreToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TyreX2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TyreX3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TyreX4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 496)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(499, 433)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 37)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TyreToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(194, 124)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(146, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TyreToolStripMenuItem
        '
        Me.TyreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TyreToolStripMenuItem1, Me.TyreX2ToolStripMenuItem, Me.TyreX3ToolStripMenuItem, Me.TyreX4ToolStripMenuItem})
        Me.TyreToolStripMenuItem.Name = "TyreToolStripMenuItem"
        Me.TyreToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.TyreToolStripMenuItem.Text = "Tyre complete set"
        '
        'TyreToolStripMenuItem1
        '
        Me.TyreToolStripMenuItem1.Name = "TyreToolStripMenuItem1"
        Me.TyreToolStripMenuItem1.Size = New System.Drawing.Size(181, 26)
        Me.TyreToolStripMenuItem1.Text = "Tyre X1"
        '
        'TyreX2ToolStripMenuItem
        '
        Me.TyreX2ToolStripMenuItem.Name = "TyreX2ToolStripMenuItem"
        Me.TyreX2ToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.TyreX2ToolStripMenuItem.Text = "Tyre X2"
        '
        'TyreX3ToolStripMenuItem
        '
        Me.TyreX3ToolStripMenuItem.Name = "TyreX3ToolStripMenuItem"
        Me.TyreX3ToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.TyreX3ToolStripMenuItem.Text = "Tyre X3"
        '
        'TyreX4ToolStripMenuItem
        '
        Me.TyreX4ToolStripMenuItem.Name = "TyreX4ToolStripMenuItem"
        Me.TyreX4ToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.TyreX4ToolStripMenuItem.Text = "Tyre X4"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(194, 173)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(458, 236)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(654, 495)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TyreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TyreToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TyreX2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TyreX3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TyreX4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
End Class
