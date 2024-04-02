Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConnectionDiag
    Inherits UserControl

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
        Me.label1 = New System.Windows.Forms.Label()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GButton1 = New GUIHelper.GButton(Me.components)
        Me.btnSaveConn = New GUIHelper.GButton(Me.components)
        Me.txtPort = New GUIHelper.GTxt()
        Me.txtPass = New GUIHelper.GTxt()
        Me.txtUsername = New GUIHelper.GTxt()
        Me.txtDatabase = New GUIHelper.GTxt()
        Me.txtServer = New GUIHelper.GTxt()
        Me.btnTest = New GUIHelper.GButton(Me.components)
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(153, 50)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(160, 22)
        Me.label1.TabIndex = 15
        Me.label1.Text = "Database Server"
        '
        'GButton1
        '
        Me.GButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GButton1.Location = New System.Drawing.Point(107, 268)
        Me.GButton1.Name = "GButton1"
        Me.GButton1.Size = New System.Drawing.Size(122, 45)
        Me.GButton1.TabIndex = 16
        Me.GButton1.Text = "Test Current Connection"
        Me.GButton1.UIStyle = GUIHelper.GButton.Style.Flat
        Me.GButton1.UseVisualStyleBackColor = True
        '
        'btnSaveConn
        '
        Me.btnSaveConn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnSaveConn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnSaveConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveConn.Location = New System.Drawing.Point(235, 217)
        Me.btnSaveConn.Name = "btnSaveConn"
        Me.btnSaveConn.Size = New System.Drawing.Size(118, 45)
        Me.btnSaveConn.TabIndex = 14
        Me.btnSaveConn.Text = "Save Connection"
        Me.btnSaveConn.UIStyle = GUIHelper.GButton.Style.Flat
        Me.btnSaveConn.UseVisualStyleBackColor = True
        '
        'txtPort
        '
        Me.txtPort.ForeColor = System.Drawing.Color.DarkOrchid
        Me.txtPort.Location = New System.Drawing.Point(107, 191)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(246, 20)
        Me.txtPort.TabIndex = 13
        Me.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPort.WatermarkText = "Port"
        '
        'txtPass
        '
        Me.err.SetError(Me.txtPass, "Blank For Seccurity Porpuse!")
        Me.txtPass.ForeColor = System.Drawing.Color.DarkOrchid
        Me.txtPass.Location = New System.Drawing.Point(107, 165)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(246, 20)
        Me.txtPass.TabIndex = 12
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPass.UseSystemPasswordChar = True
        Me.txtPass.WatermarkText = "Password"
        '
        'txtUsername
        '
        Me.err.SetError(Me.txtUsername, "Blank for Security Pupose!")
        Me.txtUsername.ForeColor = System.Drawing.Color.DarkOrchid
        Me.txtUsername.Location = New System.Drawing.Point(107, 139)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(246, 20)
        Me.txtUsername.TabIndex = 11
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtUsername.WatermarkText = "Username"
        '
        'txtDatabase
        '
        Me.txtDatabase.ForeColor = System.Drawing.Color.DarkOrchid
        Me.txtDatabase.Location = New System.Drawing.Point(107, 113)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(246, 20)
        Me.txtDatabase.TabIndex = 10
        Me.txtDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDatabase.WatermarkText = "Database"
        '
        'txtServer
        '
        Me.txtServer.ForeColor = System.Drawing.Color.DarkOrchid
        Me.txtServer.Location = New System.Drawing.Point(107, 87)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(246, 20)
        Me.txtServer.TabIndex = 9
        Me.txtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtServer.WatermarkText = "Server"
        '
        'btnTest
        '
        Me.btnTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTest.Location = New System.Drawing.Point(107, 217)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(122, 45)
        Me.btnTest.TabIndex = 8
        Me.btnTest.Text = "Test Connection"
        Me.btnTest.UIStyle = GUIHelper.GButton.Style.Flat
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'ConnectionDiag
        ' 
        Me.ClientSize = New System.Drawing.Size(461, 324)
        Me.Controls.Add(Me.GButton1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnSaveConn)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.btnTest)
        Me.Name = "ConnectionDiag"
        Me.Text = "ConnectionDiag"
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label1 As Windows.Forms.Label
    Private WithEvents btnSaveConn As GUIHelper.GButton
    Private WithEvents txtPort As GUIHelper.GTxt
    Private WithEvents txtPass As GUIHelper.GTxt
    Private WithEvents txtUsername As GUIHelper.GTxt
    Private WithEvents txtDatabase As GUIHelper.GTxt
    Private WithEvents txtServer As GUIHelper.GTxt
    Private WithEvents btnTest As GUIHelper.GButton
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Private WithEvents GButton1 As GUIHelper.GButton
End Class
