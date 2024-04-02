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
        Me.OptionPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCart = New GUIHelper.GButton(Me.components)
        Me.btnInventory = New GUIHelper.GButton(Me.components)
        Me.btnCredits = New GUIHelper.GButton(Me.components)
        Me.BtnAdmin = New GUIHelper.GButton(Me.components)
        Me.GButton2 = New GUIHelper.GButton(Me.components)
        Me.GButton4 = New GUIHelper.GButton(Me.components)
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
        Me.Panel1.Controls.Add(Me.btnInventory)
        Me.Panel1.Controls.Add(Me.btnCredits)
        Me.Panel1.Controls.Add(Me.BtnAdmin)
        Me.Panel1.Controls.Add(Me.GButton2)
        Me.Panel1.Controls.Add(Me.GButton4)
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
        Me.btnCart.Image = Global.Marshell.My.Resources.Resources.icons8_Checkout_50px
        Me.btnCart.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCart.Location = New System.Drawing.Point(151, 324)
        Me.btnCart.MaximumSize = New System.Drawing.Size(300, 150)
        Me.btnCart.MinimumSize = New System.Drawing.Size(250, 140)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(250, 140)
        Me.btnCart.TabIndex = 8
        Me.btnCart.Text = "Cart"
        Me.btnCart.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCart.UIStyle = GUIHelper.GButton.Style.Flat
        Me.btnCart.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.Color.Fuchsia
        Me.btnInventory.Image = Global.Marshell.My.Resources.Resources.icons8_Investment_Portfolio_96px_2
        Me.btnInventory.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnInventory.Location = New System.Drawing.Point(463, 22)
        Me.btnInventory.Margin = New System.Windows.Forms.Padding(5)
        Me.btnInventory.MaximumSize = New System.Drawing.Size(300, 150)
        Me.btnInventory.MinimumSize = New System.Drawing.Size(250, 140)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Padding = New System.Windows.Forms.Padding(5)
        Me.btnInventory.Size = New System.Drawing.Size(250, 140)
        Me.btnInventory.TabIndex = 6
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInventory.UIStyle = GUIHelper.GButton.Style.Flat
        Me.btnInventory.UseVisualStyleBackColor = True
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
        Me.btnCredits.Image = Global.Marshell.My.Resources.Resources.icons8_Cash_in_Hand_96px_5
        Me.btnCredits.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCredits.Location = New System.Drawing.Point(463, 174)
        Me.btnCredits.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCredits.MaximumSize = New System.Drawing.Size(300, 150)
        Me.btnCredits.MinimumSize = New System.Drawing.Size(250, 140)
        Me.btnCredits.Name = "btnCredits"
        Me.btnCredits.Padding = New System.Windows.Forms.Padding(5)
        Me.btnCredits.Size = New System.Drawing.Size(250, 140)
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
        Me.BtnAdmin.Image = Global.Marshell.My.Resources.Resources.icons8_Admin_100px
        Me.BtnAdmin.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAdmin.Location = New System.Drawing.Point(151, 22)
        Me.BtnAdmin.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnAdmin.MaximumSize = New System.Drawing.Size(300, 150)
        Me.BtnAdmin.MinimumSize = New System.Drawing.Size(250, 140)
        Me.BtnAdmin.Name = "BtnAdmin"
        Me.BtnAdmin.Padding = New System.Windows.Forms.Padding(5)
        Me.BtnAdmin.Size = New System.Drawing.Size(250, 140)
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
        Me.GButton2.Image = Global.Marshell.My.Resources.Resources.icons8_Edit_Property_100px
        Me.GButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GButton2.Location = New System.Drawing.Point(151, 174)
        Me.GButton2.Margin = New System.Windows.Forms.Padding(5)
        Me.GButton2.MaximumSize = New System.Drawing.Size(300, 150)
        Me.GButton2.MinimumSize = New System.Drawing.Size(250, 140)
        Me.GButton2.Name = "GButton2"
        Me.GButton2.Padding = New System.Windows.Forms.Padding(5)
        Me.GButton2.Size = New System.Drawing.Size(250, 140)
        Me.GButton2.TabIndex = 2
        Me.GButton2.Text = "Customer's Details"
        Me.GButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.GButton2.UIStyle = GUIHelper.GButton.Style.Flat
        Me.GButton2.UseVisualStyleBackColor = True
        '
        'GButton4
        '
        Me.GButton4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GButton4.ForeColor = System.Drawing.Color.Fuchsia
        Me.GButton4.Image = Global.Marshell.My.Resources.Resources.icons8_New_Product_100px
        Me.GButton4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GButton4.Location = New System.Drawing.Point(463, 326)
        Me.GButton4.Margin = New System.Windows.Forms.Padding(5)
        Me.GButton4.MaximumSize = New System.Drawing.Size(300, 150)
        Me.GButton4.MinimumSize = New System.Drawing.Size(250, 140)
        Me.GButton4.Name = "GButton4"
        Me.GButton4.Padding = New System.Windows.Forms.Padding(5)
        Me.GButton4.Size = New System.Drawing.Size(250, 140)
        Me.GButton4.TabIndex = 4
        Me.GButton4.Text = "Product's"
        Me.GButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.GButton4.UIStyle = GUIHelper.GButton.Style.Flat
        Me.GButton4.UseVisualStyleBackColor = True
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
    Friend WithEvents GButton4 As GUIHelper.GButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnInventory As GUIHelper.GButton
    Friend WithEvents btnCredits As GUIHelper.GButton
    Friend WithEvents btnCart As GUIHelper.GButton
End Class
