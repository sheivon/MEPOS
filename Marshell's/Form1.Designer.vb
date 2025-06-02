Imports GUIHelper

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Bk = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Settingst = New System.Windows.Forms.ToolStripMenuItem()
        Me.Users_Settings = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionPanel = New GUIHelper.GPanel()
        Me.sidemenu = New GUIHelper.GGrandiantPanel()
        Me.btnExpandContract = New DevExpress.XtraEditors.SimpleButton()
        Me.btnHome = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCart = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.btnProduct = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New GUIHelper.GGrandiantPanel()
        Me.lbstat = New System.Windows.Forms.Label()
        Me.LTIME = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblogout = New System.Windows.Forms.LinkLabel()
        Me.ToolsPanel = New GUIHelper.GPanel()
        Me.BTNMINI = New GUIHelper.GButton(Me.components)
        Me.BTNMAX = New GUIHelper.GButton(Me.components)
        Me.ThemONOFF = New GUIHelper.ToggleSwitch()
        Me.Xbtn = New GUIHelper.GButton(Me.components)
        Me.mnu = New GUIHelper.GButton(Me.components)
        Me.btnInvoices = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.sidemenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.ErrorImage = Global.Marshell.My.Resources.Resources.Marshell
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Global.Marshell.My.Resources.Resources.Marshell
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(116, 110)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ContextMenuStrip1.BackgroundImage = Global.Marshell.My.Resources.Resources.Marshell
        Me.ContextMenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(15, 15)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Settingst, Me.Users_Settings, Me.btnAbout})
        Me.ContextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.ContextMenuStrip1.Margin = New System.Windows.Forms.Padding(2)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.ShowItemToolTips = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(178, 118)
        '
        'Settingst
        '
        Me.Settingst.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Settingst.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Settingst.Name = "Settingst"
        Me.Settingst.Padding = New System.Windows.Forms.Padding(5)
        Me.Settingst.Size = New System.Drawing.Size(187, 38)
        Me.Settingst.Text = "Settings"
        '
        'Users_Settings
        '
        Me.Users_Settings.BackColor = System.Drawing.Color.Transparent
        Me.Users_Settings.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Users_Settings.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Users_Settings.Name = "Users_Settings"
        Me.Users_Settings.Padding = New System.Windows.Forms.Padding(5)
        Me.Users_Settings.Size = New System.Drawing.Size(187, 38)
        Me.Users_Settings.Text = "Users Settings"
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.Transparent
        Me.btnAbout.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnAbout.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Padding = New System.Windows.Forms.Padding(5)
        Me.btnAbout.Size = New System.Drawing.Size(187, 38)
        Me.btnAbout.Text = "About"
        '
        'OptionPanel
        '
        Me.OptionPanel.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.OptionPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OptionPanel.Location = New System.Drawing.Point(50, 40)
        Me.OptionPanel.Margin = New System.Windows.Forms.Padding(2, 1, 1, 1)
        Me.OptionPanel.Name = "OptionPanel"
        Me.OptionPanel.Padding = New System.Windows.Forms.Padding(5, 1, 1, 2)
        Me.OptionPanel.Size = New System.Drawing.Size(983, 493)
        Me.OptionPanel.TabIndex = 21
        '
        'sidemenu
        '
        Me.sidemenu.BackColor = System.Drawing.Color.Transparent
        Me.sidemenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.sidemenu.BorderColor = System.Drawing.Color.Transparent
        Me.sidemenu.BorderWidth = 0
        Me.sidemenu.Controls.Add(Me.btnExpandContract)
        Me.sidemenu.Controls.Add(Me.btnHome)
        Me.sidemenu.Controls.Add(Me.btnCart)
        Me.sidemenu.Controls.Add(Me.btnInvoices)
        Me.sidemenu.Controls.Add(Me.btnCustomer)
        Me.sidemenu.Controls.Add(Me.btnProduct)
        Me.sidemenu.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.sidemenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidemenu.ForeColor = System.Drawing.Color.Violet
        Me.sidemenu.GradientEndColor = System.Drawing.Color.Indigo
        Me.sidemenu.GradientStartColor = System.Drawing.Color.Fuchsia
        Me.sidemenu.Image = Nothing
        Me.sidemenu.ImageLocation = New System.Drawing.Point(0, 0)
        Me.sidemenu.Location = New System.Drawing.Point(0, 40)
        Me.sidemenu.Margin = New System.Windows.Forms.Padding(3, 40, 3, 3)
        Me.sidemenu.MaximumSize = New System.Drawing.Size(185, 0)
        Me.sidemenu.MinimumSize = New System.Drawing.Size(50, 0)
        Me.sidemenu.Name = "sidemenu"
        Me.sidemenu.Padding = New System.Windows.Forms.Padding(10, 60, 10, 10)
        Me.sidemenu.PanelStyle = GUIHelper.GGrandiantPanel.GPanelStyle.Gradiant
        Me.sidemenu.RoundCornerRadius = 10
        Me.sidemenu.ShadowOffSet = 0
        Me.sidemenu.Size = New System.Drawing.Size(50, 493)
        Me.sidemenu.TabIndex = 3
        Me.sidemenu.Visible = False
        '
        'btnExpandContract
        '
        Me.btnExpandContract.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[True]
        Me.btnExpandContract.Appearance.BackColor = System.Drawing.Color.Silver
        Me.btnExpandContract.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExpandContract.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpandContract.Appearance.Options.UseBackColor = True
        Me.btnExpandContract.Appearance.Options.UseBorderColor = True
        Me.btnExpandContract.Appearance.Options.UseFont = True
        Me.btnExpandContract.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExpandContract.AppearanceHovered.Options.UseBackColor = True
        Me.btnExpandContract.AppearancePressed.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnExpandContract.AppearancePressed.Options.UseBackColor = True
        Me.btnExpandContract.AutoWidthInLayoutControl = True
        Me.btnExpandContract.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExpandContract.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.btnExpandContract.ImageOptions.SvgImage = CType(resources.GetObject("btnExpandContract.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnExpandContract.Location = New System.Drawing.Point(-1, 98)
        Me.btnExpandContract.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExpandContract.MaximumSize = New System.Drawing.Size(180, 50)
        Me.btnExpandContract.MinimumSize = New System.Drawing.Size(48, 40)
        Me.btnExpandContract.Name = "btnExpandContract"
        Me.btnExpandContract.Padding = New System.Windows.Forms.Padding(4, 2, 2, 2)
        Me.btnExpandContract.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.btnExpandContract.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExpandContract.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnExpandContract.Size = New System.Drawing.Size(48, 40)
        Me.btnExpandContract.TabIndex = 33
        Me.btnExpandContract.Visible = False
        '
        'btnHome
        '
        Me.btnHome.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[True]
        Me.btnHome.Appearance.BackColor = System.Drawing.Color.Silver
        Me.btnHome.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHome.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Appearance.Options.UseBackColor = True
        Me.btnHome.Appearance.Options.UseBorderColor = True
        Me.btnHome.Appearance.Options.UseFont = True
        Me.btnHome.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnHome.AppearanceHovered.Options.UseBackColor = True
        Me.btnHome.AppearancePressed.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnHome.AppearancePressed.Options.UseBackColor = True
        Me.btnHome.AutoWidthInLayoutControl = True
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.btnHome.ImageOptions.Image = CType(resources.GetObject("btnHome.ImageOptions.Image"), System.Drawing.Image)
        Me.btnHome.Location = New System.Drawing.Point(-1, 165)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(0)
        Me.btnHome.MaximumSize = New System.Drawing.Size(180, 50)
        Me.btnHome.MinimumSize = New System.Drawing.Size(48, 40)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Padding = New System.Windows.Forms.Padding(4, 2, 2, 2)
        Me.btnHome.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.btnHome.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnHome.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnHome.Size = New System.Drawing.Size(175, 40)
        Me.btnHome.TabIndex = 33
        Me.btnHome.Text = "Home"
        Me.btnHome.Visible = False
        '
        'btnCart
        '
        Me.btnCart.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[True]
        Me.btnCart.Appearance.BackColor = System.Drawing.Color.Silver
        Me.btnCart.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCart.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCart.Appearance.Options.UseBackColor = True
        Me.btnCart.Appearance.Options.UseBorderColor = True
        Me.btnCart.Appearance.Options.UseFont = True
        Me.btnCart.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCart.AppearanceHovered.Options.UseBackColor = True
        Me.btnCart.AppearancePressed.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnCart.AppearancePressed.Options.UseBackColor = True
        Me.btnCart.AutoWidthInLayoutControl = True
        Me.btnCart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCart.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.btnCart.ImageOptions.Image = CType(resources.GetObject("btnCart.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCart.Location = New System.Drawing.Point(-1, 325)
        Me.btnCart.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCart.MaximumSize = New System.Drawing.Size(180, 50)
        Me.btnCart.MinimumSize = New System.Drawing.Size(48, 40)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Padding = New System.Windows.Forms.Padding(4, 2, 2, 2)
        Me.btnCart.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.btnCart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCart.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnCart.Size = New System.Drawing.Size(175, 40)
        Me.btnCart.TabIndex = 30
        Me.btnCart.Text = "Cart"
        Me.btnCart.Visible = False
        '
        'btnCustomer
        '
        Me.btnCustomer.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[True]
        Me.btnCustomer.Appearance.BackColor = System.Drawing.Color.Silver
        Me.btnCustomer.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCustomer.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer.Appearance.Options.UseBackColor = True
        Me.btnCustomer.Appearance.Options.UseBorderColor = True
        Me.btnCustomer.Appearance.Options.UseFont = True
        Me.btnCustomer.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCustomer.AppearanceHovered.Options.UseBackColor = True
        Me.btnCustomer.AppearancePressed.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnCustomer.AppearancePressed.Options.UseBackColor = True
        Me.btnCustomer.AutoWidthInLayoutControl = True
        Me.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomer.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.btnCustomer.ImageOptions.Image = CType(resources.GetObject("btnCustomer.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCustomer.Location = New System.Drawing.Point(-1, 217)
        Me.btnCustomer.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCustomer.MaximumSize = New System.Drawing.Size(180, 50)
        Me.btnCustomer.MinimumSize = New System.Drawing.Size(48, 40)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Padding = New System.Windows.Forms.Padding(4, 2, 2, 2)
        Me.btnCustomer.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.btnCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCustomer.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnCustomer.Size = New System.Drawing.Size(175, 40)
        Me.btnCustomer.TabIndex = 27
        Me.btnCustomer.Text = "Customer's"
        Me.btnCustomer.Visible = False
        '
        'btnProduct
        '
        Me.btnProduct.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[True]
        Me.btnProduct.Appearance.BackColor = System.Drawing.Color.Silver
        Me.btnProduct.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnProduct.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct.Appearance.Options.UseBackColor = True
        Me.btnProduct.Appearance.Options.UseBorderColor = True
        Me.btnProduct.Appearance.Options.UseFont = True
        Me.btnProduct.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnProduct.AppearanceHovered.Options.UseBackColor = True
        Me.btnProduct.AppearancePressed.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnProduct.AppearancePressed.Options.UseBackColor = True
        Me.btnProduct.AutoWidthInLayoutControl = True
        Me.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProduct.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.btnProduct.ImageOptions.SvgImage = CType(resources.GetObject("btnProduct.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnProduct.Location = New System.Drawing.Point(-1, 269)
        Me.btnProduct.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProduct.MaximumSize = New System.Drawing.Size(180, 50)
        Me.btnProduct.MinimumSize = New System.Drawing.Size(48, 40)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Padding = New System.Windows.Forms.Padding(4, 2, 2, 2)
        Me.btnProduct.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.btnProduct.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnProduct.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnProduct.Size = New System.Drawing.Size(175, 40)
        Me.btnProduct.TabIndex = 28
        Me.btnProduct.Text = "Poduct's"
        Me.btnProduct.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderColor = System.Drawing.Color.DarkOliveGreen
        Me.Panel1.BorderWidth = 0
        Me.Panel1.Controls.Add(Me.lbstat)
        Me.Panel1.Controls.Add(Me.LTIME)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblogout)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.GradientEndColor = System.Drawing.Color.BlueViolet
        Me.Panel1.GradientStartColor = System.Drawing.Color.HotPink
        Me.Panel1.Image = Nothing
        Me.Panel1.ImageLocation = New System.Drawing.Point(4, 4)
        Me.Panel1.Location = New System.Drawing.Point(0, 533)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.PanelStyle = GUIHelper.GGrandiantPanel.GPanelStyle.Gradiant
        Me.Panel1.RoundCornerRadius = 1
        Me.Panel1.ShadowOffSet = 0
        Me.Panel1.Size = New System.Drawing.Size(1033, 51)
        Me.Panel1.TabIndex = 19
        '
        'lbstat
        '
        Me.lbstat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbstat.AutoSize = True
        Me.lbstat.BackColor = System.Drawing.Color.Transparent
        Me.lbstat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbstat.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.lbstat.Location = New System.Drawing.Point(849, 5)
        Me.lbstat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbstat.Name = "lbstat"
        Me.lbstat.Size = New System.Drawing.Size(62, 20)
        Me.lbstat.TabIndex = 17
        Me.lbstat.Text = "Status:"
        '
        'LTIME
        '
        Me.LTIME.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LTIME.AutoSize = True
        Me.LTIME.BackColor = System.Drawing.Color.Transparent
        Me.LTIME.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTIME.ForeColor = System.Drawing.Color.BlueViolet
        Me.LTIME.Location = New System.Drawing.Point(849, 30)
        Me.LTIME.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTIME.Name = "LTIME"
        Me.LTIME.Size = New System.Drawing.Size(59, 20)
        Me.LTIME.TabIndex = 16
        Me.LTIME.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(18, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = " {0}"
        Me.Label1.Visible = False
        '
        'lblogout
        '
        Me.lblogout.AutoSize = True
        Me.lblogout.BackColor = System.Drawing.Color.Transparent
        Me.lblogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblogout.Image = CType(resources.GetObject("lblogout.Image"), System.Drawing.Image)
        Me.lblogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblogout.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblogout.Location = New System.Drawing.Point(13, 25)
        Me.lblogout.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblogout.Name = "lblogout"
        Me.lblogout.Padding = New System.Windows.Forms.Padding(5)
        Me.lblogout.Size = New System.Drawing.Size(83, 28)
        Me.lblogout.TabIndex = 15
        Me.lblogout.TabStop = True
        Me.lblogout.Text = "    LogOut"
        Me.lblogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblogout.Visible = False
        '
        'ToolsPanel
        '
        Me.ToolsPanel.BackColor = System.Drawing.Color.Transparent
        Me.ToolsPanel.Controls.Add(Me.BTNMINI)
        Me.ToolsPanel.Controls.Add(Me.BTNMAX)
        Me.ToolsPanel.Controls.Add(Me.ThemONOFF)
        Me.ToolsPanel.Controls.Add(Me.Xbtn)
        Me.ToolsPanel.Controls.Add(Me.mnu)
        Me.ToolsPanel.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ToolsPanel.Location = New System.Drawing.Point(0, 0)
        Me.ToolsPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolsPanel.MaximumSize = New System.Drawing.Size(0, 40)
        Me.ToolsPanel.Name = "ToolsPanel"
        Me.ToolsPanel.Size = New System.Drawing.Size(1033, 40)
        Me.ToolsPanel.TabIndex = 2
        '
        'BTNMINI
        '
        Me.BTNMINI.BackColor = System.Drawing.Color.Transparent
        Me.BTNMINI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNMINI.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTNMINI.FlatAppearance.BorderSize = 0
        Me.BTNMINI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BTNMINI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BTNMINI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNMINI.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMINI.Location = New System.Drawing.Point(925, 0)
        Me.BTNMINI.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNMINI.MaximumSize = New System.Drawing.Size(36, 36)
        Me.BTNMINI.MinimumSize = New System.Drawing.Size(36, 36)
        Me.BTNMINI.Name = "BTNMINI"
        Me.BTNMINI.Size = New System.Drawing.Size(36, 36)
        Me.BTNMINI.TabIndex = 10
        Me.BTNMINI.TabStop = False
        Me.BTNMINI.Text = "-"
        Me.BTNMINI.UIStyle = GUIHelper.GButton.Style.Cicle
        Me.BTNMINI.UseVisualStyleBackColor = False
        '
        'BTNMAX
        '
        Me.BTNMAX.BackColor = System.Drawing.Color.Transparent
        Me.BTNMAX.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNMAX.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTNMAX.FlatAppearance.BorderSize = 0
        Me.BTNMAX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BTNMAX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BTNMAX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNMAX.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMAX.Location = New System.Drawing.Point(961, 0)
        Me.BTNMAX.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNMAX.MaximumSize = New System.Drawing.Size(36, 36)
        Me.BTNMAX.MinimumSize = New System.Drawing.Size(36, 36)
        Me.BTNMAX.Name = "BTNMAX"
        Me.BTNMAX.Size = New System.Drawing.Size(36, 36)
        Me.BTNMAX.TabIndex = 25
        Me.BTNMAX.TabStop = False
        Me.BTNMAX.Text = "+"
        Me.BTNMAX.UIStyle = GUIHelper.GButton.Style.Cicle
        Me.BTNMAX.UseVisualStyleBackColor = False
        '
        'ThemONOFF
        '
        Me.ThemONOFF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ThemONOFF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ThemONOFF.Location = New System.Drawing.Point(732, 5)
        Me.ThemONOFF.Margin = New System.Windows.Forms.Padding(4)
        Me.ThemONOFF.Name = "ThemONOFF"
        Me.ThemONOFF.OffFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThemONOFF.OffText = "Dark"
        Me.ThemONOFF.OnFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThemONOFF.OnText = "Light"
        Me.ThemONOFF.Size = New System.Drawing.Size(99, 28)
        Me.ThemONOFF.Style = GUIHelper.ToggleSwitch.ToggleSwitchStyle.BrushedMetal
        Me.ThemONOFF.TabIndex = 16
        '
        'Xbtn
        '
        Me.Xbtn.BackColor = System.Drawing.Color.Transparent
        Me.Xbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Xbtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.Xbtn.FlatAppearance.BorderSize = 0
        Me.Xbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Xbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Xbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Xbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Xbtn.Location = New System.Drawing.Point(997, 0)
        Me.Xbtn.Margin = New System.Windows.Forms.Padding(2)
        Me.Xbtn.MaximumSize = New System.Drawing.Size(36, 36)
        Me.Xbtn.MinimumSize = New System.Drawing.Size(36, 36)
        Me.Xbtn.Name = "Xbtn"
        Me.Xbtn.Padding = New System.Windows.Forms.Padding(3, 2, 0, 0)
        Me.Xbtn.Size = New System.Drawing.Size(36, 36)
        Me.Xbtn.TabIndex = 5
        Me.Xbtn.TabStop = False
        Me.Xbtn.Text = "X"
        Me.Xbtn.UIStyle = GUIHelper.GButton.Style.Cicle
        Me.Xbtn.UseVisualStyleBackColor = False
        '
        'mnu
        '
        Me.mnu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mnu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnu.FlatAppearance.BorderSize = 0
        Me.mnu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.mnu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.mnu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mnu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte), True)
        Me.mnu.Location = New System.Drawing.Point(829, 3)
        Me.mnu.Margin = New System.Windows.Forms.Padding(2)
        Me.mnu.MinimumSize = New System.Drawing.Size(70, 30)
        Me.mnu.Name = "mnu"
        Me.mnu.Size = New System.Drawing.Size(70, 30)
        Me.mnu.TabIndex = 21
        Me.mnu.Text = "•••"
        Me.mnu.UIStyle = GUIHelper.GButton.Style.Flat
        Me.mnu.UseVisualStyleBackColor = True
        '
        'btnInvoices
        '
        Me.btnInvoices.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[True]
        Me.btnInvoices.Appearance.BackColor = System.Drawing.Color.Silver
        Me.btnInvoices.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnInvoices.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvoices.Appearance.Options.UseBackColor = True
        Me.btnInvoices.Appearance.Options.UseBorderColor = True
        Me.btnInvoices.Appearance.Options.UseFont = True
        Me.btnInvoices.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnInvoices.AppearanceHovered.Options.UseBackColor = True
        Me.btnInvoices.AppearancePressed.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnInvoices.AppearancePressed.Options.UseBackColor = True
        Me.btnInvoices.AutoWidthInLayoutControl = True
        Me.btnInvoices.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInvoices.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.btnInvoices.ImageOptions.SvgImage = CType(resources.GetObject("btnInvoices.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnInvoices.Location = New System.Drawing.Point(-1, 378)
        Me.btnInvoices.Margin = New System.Windows.Forms.Padding(0)
        Me.btnInvoices.MaximumSize = New System.Drawing.Size(225, 62)
        Me.btnInvoices.MinimumSize = New System.Drawing.Size(60, 50)
        Me.btnInvoices.Name = "btnInvoices"
        Me.btnInvoices.Padding = New System.Windows.Forms.Padding(5, 2, 2, 2)
        Me.btnInvoices.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.btnInvoices.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnInvoices.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnInvoices.Size = New System.Drawing.Size(219, 50)
        Me.btnInvoices.TabIndex = 31
        Me.btnInvoices.Text = "Invoices"
        Me.btnInvoices.Visible = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1033, 584)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.OptionPanel)
        Me.Controls.Add(Me.sidemenu)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolsPanel)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Fuchsia
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "Form1"
        Me.Opacity = 0.99R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marshell's"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.sidemenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblogout As LinkLabel
    Friend WithEvents ThemONOFF As GUIHelper.ToggleSwitch
    Friend WithEvents Panel1 As GUIHelper.GGrandiantPanel
    Friend WithEvents ToolsPanel As GPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LTIME As Label

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OptionPanel As GPanel
    Friend WithEvents mnu As GUIHelper.GButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Users_Settings As ToolStripMenuItem
    Friend WithEvents btnAbout As ToolStripMenuItem
    Friend WithEvents Settingst As ToolStripMenuItem
    Private WithEvents Xbtn As GUIHelper.GButton
    Private WithEvents BTNMINI As GUIHelper.GButton
    Friend WithEvents sidemenu As GUIHelper.GGrandiantPanel
    Friend WithEvents Bk As System.ComponentModel.BackgroundWorker
    Private WithEvents BTNMAX As GButton
    Friend WithEvents lbstat As Label
    Friend WithEvents btnHome As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCart As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnProduct As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExpandContract As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnInvoices As DevExpress.XtraEditors.SimpleButton
End Class
