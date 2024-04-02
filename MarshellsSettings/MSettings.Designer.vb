Imports GUIHelper

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MSettings
    Inherits GUIHelper.GForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MSettings))
        Me.GButton2 = New GUIHelper.GButton(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New GUIHelper.GPanel()
        Me.GButton8 = New GUIHelper.GButton(Me.components)
        Me.GButton7 = New GUIHelper.GButton(Me.components)
        Me.GButton6 = New GUIHelper.GButton(Me.components)
        Me.GButton1 = New GUIHelper.GButton(Me.components)
        Me.GButton5 = New GUIHelper.GButton(Me.components)
        Me.GButton3 = New GUIHelper.GButton(Me.components)
        Me.GButton4 = New GUIHelper.GButton(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New GUIHelper.GPanel()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GButton2
        '
        Me.GButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GButton2.BackColor = System.Drawing.Color.Red
        Me.GButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GButton2.Location = New System.Drawing.Point(752, 13)
        Me.GButton2.Name = "GButton2"
        Me.GButton2.Size = New System.Drawing.Size(26, 27)
        Me.GButton2.TabIndex = 2
        Me.GButton2.UIStyle = GUIHelper.GButton.Style.Cicle
        Me.GButton2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(780, 43)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Marshell's Settings"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GButton8)
        Me.Panel2.Controls.Add(Me.GButton7)
        Me.Panel2.Controls.Add(Me.GButton6)
        Me.Panel2.Controls.Add(Me.GButton1)
        Me.Panel2.Controls.Add(Me.GButton5)
        Me.Panel2.Controls.Add(Me.GButton3)
        Me.Panel2.Controls.Add(Me.GButton4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(10, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(207, 437)
        Me.Panel2.TabIndex = 8
        '
        'GButton8
        '
        Me.GButton8.BackColor = System.Drawing.Color.Transparent
        Me.GButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GButton8.FlatAppearance.BorderSize = 0
        Me.GButton8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GButton8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GButton8.Image = CType(resources.GetObject("GButton8.Image"), System.Drawing.Image)
        Me.GButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GButton8.Location = New System.Drawing.Point(6, 323)
        Me.GButton8.Name = "GButton8"
        Me.GButton8.Size = New System.Drawing.Size(191, 39)
        Me.GButton8.TabIndex = 10
        Me.GButton8.Text = "Server db Settings"
        Me.GButton8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GButton8.UIStyle = GUIHelper.GButton.Style.Flat
        Me.GButton8.UseVisualStyleBackColor = False
        '
        'GButton7
        '
        Me.GButton7.BackColor = System.Drawing.Color.Transparent
        Me.GButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GButton7.FlatAppearance.BorderSize = 0
        Me.GButton7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GButton7.Image = CType(resources.GetObject("GButton7.Image"), System.Drawing.Image)
        Me.GButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GButton7.Location = New System.Drawing.Point(6, 278)
        Me.GButton7.Name = "GButton7"
        Me.GButton7.Size = New System.Drawing.Size(191, 39)
        Me.GButton7.TabIndex = 9
        Me.GButton7.Text = "Curency Exchange"
        Me.GButton7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GButton7.UIStyle = GUIHelper.GButton.Style.Flat
        Me.GButton7.UseVisualStyleBackColor = False
        '
        'GButton6
        '
        Me.GButton6.BackColor = System.Drawing.Color.Transparent
        Me.GButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GButton6.FlatAppearance.BorderSize = 0
        Me.GButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GButton6.Image = CType(resources.GetObject("GButton6.Image"), System.Drawing.Image)
        Me.GButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GButton6.Location = New System.Drawing.Point(6, 233)
        Me.GButton6.Name = "GButton6"
        Me.GButton6.Size = New System.Drawing.Size(191, 39)
        Me.GButton6.TabIndex = 8
        Me.GButton6.Text = "Print Sheet Settings"
        Me.GButton6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GButton6.UIStyle = GUIHelper.GButton.Style.Flat
        Me.GButton6.UseVisualStyleBackColor = False
        '
        'GButton1
        '
        Me.GButton1.BackColor = System.Drawing.Color.Transparent
        Me.GButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GButton1.FlatAppearance.BorderSize = 0
        Me.GButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GButton1.Image = CType(resources.GetObject("GButton1.Image"), System.Drawing.Image)
        Me.GButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GButton1.Location = New System.Drawing.Point(6, 98)
        Me.GButton1.Name = "GButton1"
        Me.GButton1.Size = New System.Drawing.Size(191, 39)
        Me.GButton1.TabIndex = 0
        Me.GButton1.Text = "Codebar Settings"
        Me.GButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GButton1.UIStyle = GUIHelper.GButton.Style.Flat
        Me.GButton1.UseVisualStyleBackColor = False
        '
        'GButton5
        '
        Me.GButton5.BackColor = System.Drawing.Color.Transparent
        Me.GButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GButton5.FlatAppearance.BorderSize = 0
        Me.GButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GButton5.Image = CType(resources.GetObject("GButton5.Image"), System.Drawing.Image)
        Me.GButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GButton5.Location = New System.Drawing.Point(3, 368)
        Me.GButton5.Name = "GButton5"
        Me.GButton5.Size = New System.Drawing.Size(194, 39)
        Me.GButton5.TabIndex = 7
        Me.GButton5.Text = "RESET DEFAULT"
        Me.GButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GButton5.UIStyle = GUIHelper.GButton.Style.Flat
        Me.GButton5.UseVisualStyleBackColor = False
        '
        'GButton3
        '
        Me.GButton3.BackColor = System.Drawing.Color.Transparent
        Me.GButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GButton3.FlatAppearance.BorderSize = 0
        Me.GButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GButton3.Image = CType(resources.GetObject("GButton3.Image"), System.Drawing.Image)
        Me.GButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GButton3.Location = New System.Drawing.Point(6, 143)
        Me.GButton3.Name = "GButton3"
        Me.GButton3.Size = New System.Drawing.Size(191, 39)
        Me.GButton3.TabIndex = 5
        Me.GButton3.Text = "Bottom Settings"
        Me.GButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GButton3.UIStyle = GUIHelper.GButton.Style.Flat
        Me.GButton3.UseVisualStyleBackColor = False
        '
        'GButton4
        '
        Me.GButton4.BackColor = System.Drawing.Color.Transparent
        Me.GButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GButton4.FlatAppearance.BorderSize = 0
        Me.GButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GButton4.Image = CType(resources.GetObject("GButton4.Image"), System.Drawing.Image)
        Me.GButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GButton4.Location = New System.Drawing.Point(6, 188)
        Me.GButton4.Name = "GButton4"
        Me.GButton4.Size = New System.Drawing.Size(191, 39)
        Me.GButton4.TabIndex = 6
        Me.GButton4.Text = "Login UI Settings"
        Me.GButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GButton4.UIStyle = GUIHelper.GButton.Style.Flat
        Me.GButton4.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(217, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 40, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(573, 437)
        Me.Panel1.TabIndex = 1
        '
        'MSettings
        '
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GButton2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(800, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "MSettings"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.TopMost = True
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GButton1 As GUIHelper.GButton
    Friend WithEvents Panel1 As GPanel
    Friend WithEvents GButton2 As GUIHelper.GButton
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents GButton3 As GUIHelper.GButton
    Friend WithEvents GButton4 As GUIHelper.GButton
    Friend WithEvents GButton5 As GUIHelper.GButton
    Friend WithEvents Panel2 As GPanel
    Friend WithEvents GButton6 As GUIHelper.GButton
    Friend WithEvents GButton7 As GButton
    Friend WithEvents GButton8 As GButton
End Class
