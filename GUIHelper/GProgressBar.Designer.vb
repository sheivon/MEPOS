<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GProgressBar
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Bk = New System.ComponentModel.BackgroundWorker()
        Me.Bk2 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel3.BackColor = System.Drawing.Color.SlateBlue
        Me.Panel3.Location = New System.Drawing.Point(3, 0)
        Me.Panel3.MaximumSize = New System.Drawing.Size(50, 10)
        Me.Panel3.MinimumSize = New System.Drawing.Size(50, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(50, 10)
        Me.Panel3.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Panel2.BackColor = System.Drawing.Color.SlateBlue
        Me.Panel2.Location = New System.Drawing.Point(508, 0)
        Me.Panel2.MaximumSize = New System.Drawing.Size(50, 10)
        Me.Panel2.MinimumSize = New System.Drawing.Size(50, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(50, 10)
        Me.Panel2.TabIndex = 2
        '
        'Bk
        '
        '
        'Bk2
        '
        '
        'GProgressBar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "GProgressBar"
        Me.Size = New System.Drawing.Size(565, 10)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Bk As ComponentModel.BackgroundWorker
    Friend WithEvents Bk2 As ComponentModel.BackgroundWorker
End Class
