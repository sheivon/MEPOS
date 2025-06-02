<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeCotrols
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeCotrols))
        Me.OptionPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCart = New GUIHelper.GButton(Me.components)
        Me.btnCredits = New GUIHelper.GButton(Me.components)
        Me.BtnAdmin = New GUIHelper.GButton(Me.components)
        Me.GButton2 = New GUIHelper.GButton(Me.components)
        Me.OptionPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OptionPanel
        '
        Me.OptionPanel.Controls.Add(Me.Panel1)
        Me.OptionPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OptionPanel.Location = New System.Drawing.Point(0, 0)
        Me.OptionPanel.Name = "OptionPanel"
        Me.OptionPanel.Size = New System.Drawing.Size(948, 503)
        Me.OptionPanel.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnCart)
        Me.Panel1.Controls.Add(Me.btnCredits)
        Me.Panel1.Controls.Add(Me.BtnAdmin)
        Me.Panel1.Controls.Add(Me.GButton2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(948, 503)
        Me.Panel1.TabIndex = 5
        '
        'btnCart
        '
        Me.btnCart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCart.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia
        Me.btnCart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCart.ForeColor = System.Drawing.Color.Fuchsia
        Me.btnCart.Image = CType(resources.GetObject("btnCart.Image"), System.Drawing.Image)
        Me.btnCart.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCart.Location = New System.Drawing.Point(223, 242)
        Me.btnCart.MaximumSize = New System.Drawing.Size(300, 150)
        Me.btnCart.MinimumSize = New System.Drawing.Size(200, 100)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(200, 100)
        Me.btnCart.TabIndex = 8
        Me.btnCart.Text = "Cart"
        Me.btnCart.UIStyle = GUIHelper.GButton.Style.Flat
        Me.btnCart.UseVisualStyleBackColor = True
        '
        'btnCredits
        '
        Me.btnCredits.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCredits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCredits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnCredits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCredits.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredits.ForeColor = System.Drawing.Color.Fuchsia
        Me.btnCredits.Image = CType(resources.GetObject("btnCredits.Image"), System.Drawing.Image)
        Me.btnCredits.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCredits.Location = New System.Drawing.Point(535, 242)
        Me.btnCredits.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCredits.MaximumSize = New System.Drawing.Size(300, 150)
        Me.btnCredits.MinimumSize = New System.Drawing.Size(200, 100)
        Me.btnCredits.Name = "btnCredits"
        Me.btnCredits.Padding = New System.Windows.Forms.Padding(5)
        Me.btnCredits.Size = New System.Drawing.Size(200, 100)
        Me.btnCredits.TabIndex = 7
        Me.btnCredits.Text = "Credit's Details"
        Me.btnCredits.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCredits.UIStyle = GUIHelper.GButton.Style.Flat
        Me.btnCredits.UseVisualStyleBackColor = True
        '
        'BtnAdmin
        '
        Me.BtnAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BtnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BtnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdmin.ForeColor = System.Drawing.Color.Fuchsia
        Me.BtnAdmin.Image = CType(resources.GetObject("BtnAdmin.Image"), System.Drawing.Image)
        Me.BtnAdmin.Location = New System.Drawing.Point(223, 104)
        Me.BtnAdmin.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnAdmin.MaximumSize = New System.Drawing.Size(300, 150)
        Me.BtnAdmin.MinimumSize = New System.Drawing.Size(200, 100)
        Me.BtnAdmin.Name = "BtnAdmin"
        Me.BtnAdmin.Padding = New System.Windows.Forms.Padding(5)
        Me.BtnAdmin.Size = New System.Drawing.Size(200, 100)
        Me.BtnAdmin.TabIndex = 1
        Me.BtnAdmin.Text = "Employee's"
        Me.BtnAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAdmin.UIStyle = GUIHelper.GButton.Style.Flat
        Me.BtnAdmin.UseVisualStyleBackColor = True
        '
        'GButton2
        '
        Me.GButton2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GButton2.ForeColor = System.Drawing.Color.Fuchsia
        Me.GButton2.Image = CType(resources.GetObject("GButton2.Image"), System.Drawing.Image)
        Me.GButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GButton2.Location = New System.Drawing.Point(535, 104)
        Me.GButton2.Margin = New System.Windows.Forms.Padding(5)
        Me.GButton2.MaximumSize = New System.Drawing.Size(300, 150)
        Me.GButton2.MinimumSize = New System.Drawing.Size(200, 100)
        Me.GButton2.Name = "GButton2"
        Me.GButton2.Padding = New System.Windows.Forms.Padding(5)
        Me.GButton2.Size = New System.Drawing.Size(200, 100)
        Me.GButton2.TabIndex = 2
        Me.GButton2.Text = "Customer's"
        Me.GButton2.UIStyle = GUIHelper.GButton.Style.Flat
        Me.GButton2.UseVisualStyleBackColor = True
        '
        'HomeCotrols
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.OptionPanel)
        Me.Name = "HomeCotrols"
        Me.Size = New System.Drawing.Size(948, 503)
        Me.OptionPanel.ResumeLayout(False)
        Me.OptionPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OptionPanel As Panel
    Friend WithEvents BtnAdmin As GUIHelper.GButton
    Friend WithEvents GButton2 As GUIHelper.GButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCredits As GUIHelper.GButton
    Friend WithEvents btnCart As GUIHelper.GButton
End Class
