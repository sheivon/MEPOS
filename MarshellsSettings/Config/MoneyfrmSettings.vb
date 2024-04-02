Imports GUIHelper

Public Class MoneyfrmSettings
    Inherits GControl

    Friend WithEvents btnSave As GButton
    Friend WithEvents txtEUR As GTxt
    Private components As ComponentModel.IContainer
    Friend WithEvents txttel As GTxt
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtUSD As GTxt

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtUSD = New GUIHelper.GTxt()
        Me.btnSave = New GUIHelper.GButton(Me.components)
        Me.txtEUR = New GUIHelper.GTxt()
        Me.txttel = New GUIHelper.GTxt()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUSD
        '
        Me.txtUSD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUSD.ForeColor = System.Drawing.Color.DarkOrchid
        Me.txtUSD.Location = New System.Drawing.Point(220, 110)
        Me.txtUSD.MaxLength = 9
        Me.txtUSD.Name = "txtUSD"
        Me.txtUSD.Size = New System.Drawing.Size(202, 26)
        Me.txtUSD.TabIndex = 0
        Me.txtUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtUSD.WatermarkText = "C$1 NIO to USD"
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(250, 243)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(134, 38)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UIStyle = GUIHelper.GButton.Style.Flat
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtEUR
        '
        Me.txtEUR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEUR.ForeColor = System.Drawing.Color.DarkOrchid
        Me.txtEUR.Location = New System.Drawing.Point(220, 151)
        Me.txtEUR.MaxLength = 9
        Me.txtEUR.Name = "txtEUR"
        Me.txtEUR.Size = New System.Drawing.Size(202, 26)
        Me.txtEUR.TabIndex = 2
        Me.txtEUR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtEUR.WatermarkText = "C$1 NIO to EUR"
        '
        'txttel
        '
        Me.txttel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttel.ForeColor = System.Drawing.Color.DarkOrchid
        Me.txttel.Location = New System.Drawing.Point(220, 194)
        Me.txttel.MaxLength = 15
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(202, 26)
        Me.txttel.TabIndex = 3
        Me.txttel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txttel.WatermarkText = "Phone number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Label1.Location = New System.Drawing.Point(145, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "USD : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Label2.Location = New System.Drawing.Point(145, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "EUR : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Label3.Location = New System.Drawing.Point(145, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Phone : "
        '
        'Money
        '
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttel)
        Me.Controls.Add(Me.txtEUR)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtUSD)
        Me.Name = "Money"
        Me.Size = New System.Drawing.Size(504, 378)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Sub New()
        InitializeComponent()
    End Sub

    Private USD As Double
    Private EUR As Double
    Private tel As String
    Private Sub txtChange_TextChanged(sender As Object, e As EventArgs) Handles txtUSD.TextChanged
        USD = System.Convert.ToDouble(txtUSD.Text)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.Curency = USD
        My.Settings.EUR = EUR
        My.Settings.tel = tel
        My.Settings.Save()
        txtUSD.Text = My.Settings.Curency
        txtEUR.Text = My.Settings.EUR
        txttel.Text = My.Settings.tel
    End Sub

    Private Sub Money_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUSD.Text = My.Settings.Curency
        txtEUR.Text = My.Settings.EUR
        txttel.Text = My.Settings.tel
    End Sub

    Private Sub txtEUR_TextChanged(sender As Object, e As EventArgs) Handles txtEUR.TextChanged
        EUR = System.Convert.ToDouble(txtEUR.Text)
    End Sub

    Private Sub txttel_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txttel.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or e.KeyChar = " " Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cur_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtUSD.KeyPress, txtEUR.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txttel_TextChanged(sender As Object, e As EventArgs) Handles txttel.TextChanged
        tel = txttel.Text
    End Sub
End Class
