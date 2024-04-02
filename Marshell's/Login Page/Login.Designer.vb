Imports GUIHelper

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.MainUI = New GUIHelper.GGrandiantPanel()
        Me.BtnSubmit = New GUIHelper.GButton(Me.components)
        Me.Pass = New GUIHelper.GTxt()
        Me.Usrname = New GUIHelper.GTxt()
        Me.btnViewPass = New GUIHelper.GButton(Me.components)
        Me.MainUI.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainUI
        '
        Me.MainUI.BorderColor = System.Drawing.Color.DarkOliveGreen
        Me.MainUI.BorderWidth = 0
        Me.MainUI.Controls.Add(Me.btnViewPass)
        Me.MainUI.Controls.Add(Me.BtnSubmit)
        Me.MainUI.Controls.Add(Me.Pass)
        Me.MainUI.Controls.Add(Me.Usrname)
        Me.MainUI.GradientEndColor = System.Drawing.Color.Indigo
        Me.MainUI.GradientStartColor = System.Drawing.Color.Fuchsia
        Me.MainUI.Image = Global.Marshell.My.Resources.Resources.icons8_Privacy_100px
        Me.MainUI.ImageLocation = New System.Drawing.Point(50, 50)
        Me.MainUI.Location = New System.Drawing.Point(3, 3)
        Me.MainUI.Name = "MainUI"
        Me.MainUI.PanelStyle = GUIHelper.GGrandiantPanel.GPanelStyle.Gradiant
        Me.MainUI.RoundCornerRadius = 50
        Me.MainUI.Size = New System.Drawing.Size(642, 262)
        Me.MainUI.TabIndex = 5
        '
        'BtnSubmit
        '
        Me.BtnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnSubmit.Enabled = False
        Me.BtnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BtnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubmit.Image = Global.Marshell.My.Resources.Resources.icons8_Login_50px
        Me.BtnSubmit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSubmit.Location = New System.Drawing.Point(273, 172)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(60, 60)
        Me.BtnSubmit.TabIndex = 2
        Me.BtnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSubmit.UIStyle = GUIHelper.GButton.Style.Cicle
        Me.BtnSubmit.UseVisualStyleBackColor = True
        Me.BtnSubmit.Visible = False
        '
        'Pass
        '
        Me.Pass.BackColor = System.Drawing.SystemColors.Control
        Me.Pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pass.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Pass.Location = New System.Drawing.Point(155, 127)
        Me.Pass.MaximumSize = New System.Drawing.Size(342, 25)
        Me.Pass.MaxLength = 30
        Me.Pass.MinimumSize = New System.Drawing.Size(342, 26)
        Me.Pass.Name = "Pass"
        Me.Pass.Size = New System.Drawing.Size(342, 26)
        Me.Pass.TabIndex = 1
        Me.Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Pass.UseSystemPasswordChar = True
        Me.Pass.WatermarkText = "Password"
        Me.Pass.WordWrap = False
        '
        'Usrname
        '
        Me.Usrname.BackColor = System.Drawing.SystemColors.Control
        Me.Usrname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Usrname.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usrname.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Usrname.Location = New System.Drawing.Point(155, 80)
        Me.Usrname.MaximumSize = New System.Drawing.Size(342, 25)
        Me.Usrname.MaxLength = 30
        Me.Usrname.MinimumSize = New System.Drawing.Size(342, 26)
        Me.Usrname.Name = "Usrname"
        Me.Usrname.Size = New System.Drawing.Size(342, 26)
        Me.Usrname.TabIndex = 0
        Me.Usrname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Usrname.WatermarkText = "Username"
        Me.Usrname.WordWrap = False
        '
        'btnViewPass
        '
        Me.btnViewPass.BackColor = System.Drawing.Color.White
        Me.btnViewPass.FlatAppearance.BorderSize = 0
        Me.btnViewPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnViewPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnViewPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewPass.Location = New System.Drawing.Point(473, 121)
        Me.btnViewPass.Margin = New System.Windows.Forms.Padding(0)
        Me.btnViewPass.Name = "btnViewPass"
        Me.btnViewPass.Size = New System.Drawing.Size(35, 35)
        Me.btnViewPass.TabIndex = 3
        Me.btnViewPass.Text = "ōɹō"
        Me.btnViewPass.UIStyle = GUIHelper.GButton.Style.Cicle
        Me.btnViewPass.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.MainUI)
        Me.Name = "Login"
        Me.Size = New System.Drawing.Size(648, 268)
        Me.MainUI.ResumeLayout(False)
        Me.MainUI.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainUI As GUIHelper.GGrandiantPanel
    Friend WithEvents BtnSubmit As GUIHelper.GButton
    Private WithEvents Pass As GTxt
    Private WithEvents Usrname As GTxt
    Friend WithEvents btnViewPass As GButton
End Class
