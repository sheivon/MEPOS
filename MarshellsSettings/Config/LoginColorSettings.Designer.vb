<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginColorSettings
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.GButton4 = New GUIHelper.GButton(Me.components)
        Me.GButton3 = New GUIHelper.GButton(Me.components)
        Me.GButton2 = New GUIHelper.GButton(Me.components)
        Me.GGrandiantPanel1 = New GUIHelper.GGrandiantPanel()
        Me.GButton1 = New GUIHelper.GButton(Me.components)
        Me.SuspendLayout()
        '
        'GButton4
        '
        Me.GButton4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GButton4.Location = New System.Drawing.Point(185, 16)
        Me.GButton4.Name = "GButton4"
        Me.GButton4.Size = New System.Drawing.Size(221, 56)
        Me.GButton4.TabIndex = 10
        Me.GButton4.Text = "Gradiant"
        Me.GButton4.UIStyle = GUIHelper.GButton.Style.Flat
        Me.GButton4.UseVisualStyleBackColor = True
        '
        'GButton3
        '
        Me.GButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GButton3.Location = New System.Drawing.Point(476, 85)
        Me.GButton3.Name = "GButton3"
        Me.GButton3.Size = New System.Drawing.Size(91, 57)
        Me.GButton3.TabIndex = 9
        Me.GButton3.Text = "Right Color"
        Me.GButton3.UseVisualStyleBackColor = True
        '
        'GButton2
        '
        Me.GButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GButton2.Location = New System.Drawing.Point(62, 85)
        Me.GButton2.Name = "GButton2"
        Me.GButton2.Size = New System.Drawing.Size(78, 57)
        Me.GButton2.TabIndex = 8
        Me.GButton2.Text = "Left Color"
        Me.GButton2.UseVisualStyleBackColor = True
        '
        'GGrandiantPanel1
        '
        Me.GGrandiantPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GGrandiantPanel1.BorderColor = System.Drawing.Color.Gray
        Me.GGrandiantPanel1.GradientEndColor = System.Drawing.Color.Gray
        Me.GGrandiantPanel1.GradientStartColor = System.Drawing.Color.White
        Me.GGrandiantPanel1.Image = Nothing
        Me.GGrandiantPanel1.ImageLocation = New System.Drawing.Point(4, 4)
        Me.GGrandiantPanel1.Location = New System.Drawing.Point(62, 148)
        Me.GGrandiantPanel1.Name = "GGrandiantPanel1"
        Me.GGrandiantPanel1.PanelStyle = GUIHelper.GGrandiantPanel.GPanelStyle.Gradiant
        Me.GGrandiantPanel1.RoundCornerRadius = 5
        Me.GGrandiantPanel1.Size = New System.Drawing.Size(505, 104)
        Me.GGrandiantPanel1.TabIndex = 7
        '
        'GButton1
        '
        Me.GButton1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GButton1.Location = New System.Drawing.Point(185, 273)
        Me.GButton1.Name = "GButton1"
        Me.GButton1.Size = New System.Drawing.Size(239, 60)
        Me.GButton1.TabIndex = 6
        Me.GButton1.Text = "Apply"
        Me.GButton1.UIStyle = GUIHelper.GButton.Style.Flat
        Me.GButton1.UseVisualStyleBackColor = True
        '
        'LoginColorSettings
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.GButton4)
        Me.Controls.Add(Me.GButton3)
        Me.Controls.Add(Me.GButton2)
        Me.Controls.Add(Me.GGrandiantPanel1)
        Me.Controls.Add(Me.GButton1)
        Me.Name = "LoginColorSettings"
        Me.Size = New System.Drawing.Size(625, 378)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GButton4 As GUIHelper.GButton
    Friend WithEvents GButton3 As GUIHelper.GButton
    Friend WithEvents GButton2 As GUIHelper.GButton
    Friend WithEvents GGrandiantPanel1 As GUIHelper.GGrandiantPanel
    Friend WithEvents GButton1 As GUIHelper.GButton
End Class
