Imports System
Imports GUIHelper
Imports System.Windows
Imports System.ComponentModel
Imports InvoicePrinter
Imports DataBase.MySqlControl

Imports System.Threading
Imports System.Threading.Thread
Imports System.Threading.Tasks
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports MarshellsSettings
Imports DGVPrinterHelper
Imports InvoicePrinter.PRINT
Imports Entities
Imports DataBase

<ToolboxItem(False)>
Public Class InventryPanel
    Inherits UserControl
#Region "UIX"
    Friend WithEvents GGrandiantPanel4 As GGrandiantPanel
    Friend WithEvents ptypes As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GGrandiantPanel2 As GGrandiantPanel
    Friend WithEvents lbSalesAmount As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents InstockGGP As GGrandiantPanel
    Friend WithEvents lbProductInStockAmount As Label
    Friend WithEvents Label1 As Label
    Private components As IContainer
    Friend WithEvents tbprodsaled As TabControl
    Private WithEvents lbInv As Label


    Private Scanner As New Scanners
    Friend WithEvents SSalesTab As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents tbsaledprods As TabPage
    Friend WithEvents OwingCustomerChart As Chart
    Private WithEvents chartGrossRevenue As Chart
    Private WithEvents chartTopProducts As Chart
    Friend WithEvents TabPage1 As TabPage
    Private WithEvents panel5 As Panel
    Private WithEvents dgvUnderstock As DataGridView
    Private WithEvents label13 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Panel3 As Panel
    Private WithEvents dtpEndDate As DateTimePicker
    Private WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents btnThisWeek As GButton
    Friend WithEvents btnThisMont As GButton
    Friend WithEvents btnThisYear As GButton
    Friend WithEvents tgscustomedates As ToggleSwitch
    Friend WithEvents btnFilterSALES As GButton
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents AnalyticItemBindingSource As BindingSource
    Friend WithEvents Dgv As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnPrintSalesres As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPrintLowstock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BarcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoldDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TopProductsListBindingSource As BindingSource
    Friend WithEvents DashboardBindingSource As BindingSource
    Friend WithEvents KeyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Private bct As String = MarshellsSettings.MSetting.GetBarcodeType


    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbprodsaled = New System.Windows.Forms.TabControl()
        Me.SSalesTab = New System.Windows.Forms.TabPage()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopProductsListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DashboardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnPrintSalesres = New DevExpress.XtraEditors.SimpleButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.OwingCustomerChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tbsaledprods = New System.Windows.Forms.TabPage()
        Me.chartGrossRevenue = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartTopProducts = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.AnalyticItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.panel5 = New System.Windows.Forms.Panel()
        Me.btnPrintLowstock = New DevExpress.XtraEditors.SimpleButton()
        Me.dgvUnderstock = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.label13 = New System.Windows.Forms.Label()
        Me.lbInv = New System.Windows.Forms.Label()
        Me.GGrandiantPanel4 = New GUIHelper.GGrandiantPanel()
        Me.ptypes = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GGrandiantPanel2 = New GUIHelper.GGrandiantPanel()
        Me.lbSalesAmount = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.InstockGGP = New GUIHelper.GGrandiantPanel()
        Me.lbProductInStockAmount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.btnThisWeek = New GUIHelper.GButton(Me.components)
        Me.btnThisMont = New GUIHelper.GButton(Me.components)
        Me.btnThisYear = New GUIHelper.GButton(Me.components)
        Me.tgscustomedates = New GUIHelper.ToggleSwitch()
        Me.btnFilterSALES = New GUIHelper.GButton(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.tbprodsaled.SuspendLayout()
        Me.SSalesTab.SuspendLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopProductsListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DashboardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.OwingCustomerChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbsaledprods.SuspendLayout()
        CType(Me.chartGrossRevenue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartTopProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnalyticItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.panel5.SuspendLayout()
        CType(Me.dgvUnderstock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GGrandiantPanel4.SuspendLayout()
        Me.GGrandiantPanel2.SuspendLayout()
        Me.InstockGGP.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbprodsaled
        '
        Me.tbprodsaled.Controls.Add(Me.SSalesTab)
        Me.tbprodsaled.Controls.Add(Me.TabPage2)
        Me.tbprodsaled.Controls.Add(Me.tbsaledprods)
        Me.tbprodsaled.Controls.Add(Me.TabPage1)
        Me.tbprodsaled.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbprodsaled.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbprodsaled.ItemSize = New System.Drawing.Size(150, 25)
        Me.tbprodsaled.Location = New System.Drawing.Point(1, 151)
        Me.tbprodsaled.Name = "tbprodsaled"
        Me.tbprodsaled.Padding = New System.Drawing.Point(8, 5)
        Me.tbprodsaled.SelectedIndex = 0
        Me.tbprodsaled.Size = New System.Drawing.Size(932, 292)
        Me.tbprodsaled.TabIndex = 50
        '
        'SSalesTab
        '
        Me.SSalesTab.Controls.Add(Me.Dgv)
        Me.SSalesTab.Controls.Add(Me.Panel2)
        Me.SSalesTab.Location = New System.Drawing.Point(4, 29)
        Me.SSalesTab.Name = "SSalesTab"
        Me.SSalesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.SSalesTab.Size = New System.Drawing.Size(924, 259)
        Me.SSalesTab.TabIndex = 3
        Me.SSalesTab.Text = "Sales Resume "
        Me.SSalesTab.UseVisualStyleBackColor = True
        '
        'Dgv
        '
        Me.Dgv.AllowUserToAddRows = False
        Me.Dgv.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv.AutoGenerateColumns = False
        Me.Dgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.Dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv.ColumnHeadersHeight = 34
        Me.Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn1, Me.TotalDataGridViewTextBoxColumn, Me.UPriceDataGridViewTextBoxColumn})
        Me.Dgv.DataSource = Me.TopProductsListBindingSource
        Me.Dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv.Location = New System.Drawing.Point(3, 39)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.ReadOnly = True
        Me.Dgv.RowHeadersVisible = False
        Me.Dgv.RowHeadersWidth = 4
        Me.Dgv.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Dgv.RowTemplate.Height = 30
        Me.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv.ShowCellErrors = False
        Me.Dgv.ShowCellToolTips = False
        Me.Dgv.ShowEditingIcon = False
        Me.Dgv.ShowRowErrors = False
        Me.Dgv.Size = New System.Drawing.Size(918, 217)
        Me.Dgv.TabIndex = 0
        '
        'NameDataGridViewTextBoxColumn1
        '
        Me.NameDataGridViewTextBoxColumn1.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn1.HeaderText = "PRODUCT NAME"
        Me.NameDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn1.Name = "NameDataGridViewTextBoxColumn1"
        Me.NameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn1.Width = 350
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "TOTAL"
        Me.TotalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalDataGridViewTextBoxColumn.Width = 125
        '
        'UPriceDataGridViewTextBoxColumn
        '
        Me.UPriceDataGridViewTextBoxColumn.DataPropertyName = "UPrice"
        Me.UPriceDataGridViewTextBoxColumn.HeaderText = "SUB TOTAL"
        Me.UPriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UPriceDataGridViewTextBoxColumn.Name = "UPriceDataGridViewTextBoxColumn"
        Me.UPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.UPriceDataGridViewTextBoxColumn.Width = 125
        '
        'TopProductsListBindingSource
        '
        Me.TopProductsListBindingSource.DataMember = "TopProductsList"
        Me.TopProductsListBindingSource.DataSource = Me.DashboardBindingSource
        '
        'DashboardBindingSource
        '
        Me.DashboardBindingSource.DataSource = GetType(InvoicePrinter.dashboard)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LabelControl1)
        Me.Panel2.Controls.Add(Me.btnPrintSalesres)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(918, 36)
        Me.Panel2.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(13, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(104, 21)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Sales Resume"
        Me.LabelControl1.UseMnemonic = False
        '
        'btnPrintSalesres
        '
        Me.btnPrintSalesres.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPrintSalesres.Location = New System.Drawing.Point(814, 0)
        Me.btnPrintSalesres.Name = "btnPrintSalesres"
        Me.btnPrintSalesres.Size = New System.Drawing.Size(104, 36)
        Me.btnPrintSalesres.TabIndex = 0
        Me.btnPrintSalesres.Text = "Print"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.OwingCustomerChart)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(906, 257)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "Owing Customer Chart"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'OwingCustomerChart
        '
        Me.OwingCustomerChart.BackColor = System.Drawing.Color.Fuchsia
        Me.OwingCustomerChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter
        Me.OwingCustomerChart.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DashedHorizontal
        Me.OwingCustomerChart.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.OwingCustomerChart.BorderlineColor = System.Drawing.Color.Transparent
        Me.OwingCustomerChart.BorderSkin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OwingCustomerChart.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
        Me.OwingCustomerChart.BorderSkin.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkVertical
        Me.OwingCustomerChart.BorderSkin.BorderWidth = 2
        Me.OwingCustomerChart.BorderSkin.PageColor = System.Drawing.Color.DarkViolet
        Me.OwingCustomerChart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameTitle5
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Angle = 90
        ChartArea1.AxisY.IsLabelAutoFit = False
        ChartArea1.AxisY.LabelStyle.Format = "C${0}"
        ChartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot
        ChartArea1.Name = "ChartArea1"
        Me.OwingCustomerChart.ChartAreas.Add(ChartArea1)
        Me.OwingCustomerChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
        Legend1.Name = "Legend1"
        Me.OwingCustomerChart.Legends.Add(Legend1)
        Me.OwingCustomerChart.Location = New System.Drawing.Point(3, 3)
        Me.OwingCustomerChart.Name = "OwingCustomerChart"
        Me.OwingCustomerChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
        Series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DashedHorizontal
        Series1.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot
        Series1.BorderWidth = 7
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.LabelAngle = -45
        Series1.LabelBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Series1.LabelBorderColor = System.Drawing.Color.Gray
        Series1.LabelBorderWidth = 2
        Series1.LabelFormat = "C${0}"
        Series1.Legend = "Legend1"
        Series1.MarkerBorderColor = System.Drawing.Color.Indigo
        Series1.MarkerBorderWidth = 2
        Series1.MarkerColor = System.Drawing.Color.Fuchsia
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star10
        Series1.Name = "OwingCustomers"
        Series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series1.ShadowOffset = 3
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[String]
        Series1.YValuesPerPoint = 6
        Me.OwingCustomerChart.Series.Add(Series1)
        Me.OwingCustomerChart.Size = New System.Drawing.Size(900, 251)
        Me.OwingCustomerChart.TabIndex = 1
        Me.OwingCustomerChart.Text = "Owing Customers"
        Title1.Name = "Title1"
        Title1.Text = "Customers that ow the shop"
        Me.OwingCustomerChart.Titles.Add(Title1)
        '
        'tbsaledprods
        '
        Me.tbsaledprods.Controls.Add(Me.chartGrossRevenue)
        Me.tbsaledprods.Controls.Add(Me.chartTopProducts)
        Me.tbsaledprods.Location = New System.Drawing.Point(4, 29)
        Me.tbsaledprods.Name = "tbsaledprods"
        Me.tbsaledprods.Padding = New System.Windows.Forms.Padding(3)
        Me.tbsaledprods.Size = New System.Drawing.Size(906, 257)
        Me.tbsaledprods.TabIndex = 6
        Me.tbsaledprods.Text = "Products Sales"
        Me.tbsaledprods.UseVisualStyleBackColor = True
        '
        'chartGrossRevenue
        '
        ChartArea2.AlignmentOrientation = CType((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical Or System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal), System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)
        ChartArea2.AxisX.Interval = 1.0R
        ChartArea2.AxisX.IsLabelAutoFit = False
        ChartArea2.AxisX.LabelStyle.Angle = -45
        ChartArea2.AxisX.LabelStyle.Interval = 1.0R
        ChartArea2.AxisX2.Interval = 1.0R
        ChartArea2.AxisX2.IsLabelAutoFit = False
        ChartArea2.AxisX2.LabelStyle.Angle = 45
        ChartArea2.AxisY.LabelStyle.Format = "C${0}"
        ChartArea2.Name = "ChartArea1"
        Me.chartGrossRevenue.ChartAreas.Add(ChartArea2)
        Me.chartGrossRevenue.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Me.chartGrossRevenue.Legends.Add(Legend2)
        Me.chartGrossRevenue.Location = New System.Drawing.Point(3, 3)
        Me.chartGrossRevenue.Margin = New System.Windows.Forms.Padding(5)
        Me.chartGrossRevenue.Name = "chartGrossRevenue"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Color = System.Drawing.Color.Magenta
        Series2.IsValueShownAsLabel = True
        Series2.LabelAngle = -45
        Series2.Legend = "Legend1"
        Series2.LegendText = "Gross Rvenue"
        Series2.MarkerSize = 2
        Series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross
        Series2.Name = "grossrev"
        Series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series2.ShadowOffset = 1
        Series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime
        Me.chartGrossRevenue.Series.Add(Series2)
        Me.chartGrossRevenue.Size = New System.Drawing.Size(570, 251)
        Me.chartGrossRevenue.TabIndex = 61
        Me.chartGrossRevenue.Text = "chartGrossRevenue"
        Title2.Alignment = System.Drawing.ContentAlignment.TopLeft
        Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Title2.Name = "Title1"
        Title2.Text = "Gross revenue"
        Me.chartGrossRevenue.Titles.Add(Title2)
        '
        'chartTopProducts
        '
        ChartArea3.Name = "ChartArea1"
        Me.chartTopProducts.ChartAreas.Add(ChartArea3)
        Me.chartTopProducts.DataSource = Me.AnalyticItemBindingSource
        Me.chartTopProducts.Dock = System.Windows.Forms.DockStyle.Right
        Legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Legend3.IsTextAutoFit = False
        Legend3.Name = "Legend1"
        Me.chartTopProducts.Legends.Add(Legend3)
        Me.chartTopProducts.Location = New System.Drawing.Point(573, 3)
        Me.chartTopProducts.Margin = New System.Windows.Forms.Padding(5)
        Me.chartTopProducts.Name = "chartTopProducts"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Series3.IsValueShownAsLabel = True
        Series3.LabelAngle = -45
        Series3.LabelForeColor = System.Drawing.Color.White
        Series3.Legend = "Legend1"
        Series3.Name = "TopProducts"
        Series3.XValueMember = "name"
        Series3.YValueMembers = "value"
        Me.chartTopProducts.Series.Add(Series3)
        Me.chartTopProducts.Size = New System.Drawing.Size(330, 251)
        Me.chartTopProducts.TabIndex = 62
        Me.chartTopProducts.Text = "TopProducts"
        Title3.Alignment = System.Drawing.ContentAlignment.TopLeft
        Title3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Title3.Name = "Title1"
        Title3.Text = "Top 10 Best selling products"
        Me.chartTopProducts.Titles.Add(Title3)
        '
        'AnalyticItemBindingSource
        '
        Me.AnalyticItemBindingSource.DataSource = GetType(Entities.AnalyticItem)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.panel5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(906, 257)
        Me.TabPage1.TabIndex = 7
        Me.TabPage1.Text = "Low Instock"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'panel5
        '
        Me.panel5.BackColor = System.Drawing.Color.White
        Me.panel5.Controls.Add(Me.btnPrintLowstock)
        Me.panel5.Controls.Add(Me.dgvUnderstock)
        Me.panel5.Controls.Add(Me.label13)
        Me.panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel5.Location = New System.Drawing.Point(3, 3)
        Me.panel5.Margin = New System.Windows.Forms.Padding(5)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New System.Drawing.Size(900, 251)
        Me.panel5.TabIndex = 61
        '
        'btnPrintLowstock
        '
        Me.btnPrintLowstock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintLowstock.Location = New System.Drawing.Point(819, 4)
        Me.btnPrintLowstock.Name = "btnPrintLowstock"
        Me.btnPrintLowstock.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintLowstock.TabIndex = 4
        Me.btnPrintLowstock.Text = "Print"
        '
        'dgvUnderstock
        '
        Me.dgvUnderstock.AllowUserToAddRows = False
        Me.dgvUnderstock.AllowUserToDeleteRows = False
        Me.dgvUnderstock.AllowUserToResizeColumns = False
        Me.dgvUnderstock.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(1)
        Me.dgvUnderstock.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvUnderstock.AutoGenerateColumns = False
        Me.dgvUnderstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUnderstock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUnderstock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvUnderstock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUnderstock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvUnderstock.ColumnHeadersHeight = 35
        Me.dgvUnderstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvUnderstock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.BarcodeDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.CurDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.ActiveDataGridViewCheckBoxColumn})
        Me.dgvUnderstock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvUnderstock.DataSource = Me.ProductsBindingSource
        Me.dgvUnderstock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUnderstock.EnableHeadersVisualStyles = False
        Me.dgvUnderstock.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvUnderstock.Location = New System.Drawing.Point(0, 32)
        Me.dgvUnderstock.MultiSelect = False
        Me.dgvUnderstock.Name = "dgvUnderstock"
        Me.dgvUnderstock.ReadOnly = True
        Me.dgvUnderstock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUnderstock.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvUnderstock.RowHeadersVisible = False
        Me.dgvUnderstock.RowHeadersWidth = 4
        Me.dgvUnderstock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUnderstock.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvUnderstock.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvUnderstock.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(1)
        Me.dgvUnderstock.RowTemplate.Height = 30
        Me.dgvUnderstock.RowTemplate.ReadOnly = True
        Me.dgvUnderstock.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUnderstock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUnderstock.ShowCellErrors = False
        Me.dgvUnderstock.ShowCellToolTips = False
        Me.dgvUnderstock.ShowEditingIcon = False
        Me.dgvUnderstock.ShowRowErrors = False
        Me.dgvUnderstock.Size = New System.Drawing.Size(900, 219)
        Me.dgvUnderstock.TabIndex = 3
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'BarcodeDataGridViewTextBoxColumn
        '
        Me.BarcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode"
        Me.BarcodeDataGridViewTextBoxColumn.HeaderText = "BARCODE"
        Me.BarcodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BarcodeDataGridViewTextBoxColumn.Name = "BarcodeDataGridViewTextBoxColumn"
        Me.BarcodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.BarcodeDataGridViewTextBoxColumn.Visible = False
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "AVAILABLE"
        Me.StockDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "UNIT PRICE"
        Me.PriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.PriceDataGridViewTextBoxColumn.Visible = False
        '
        'CurDataGridViewTextBoxColumn
        '
        Me.CurDataGridViewTextBoxColumn.DataPropertyName = "Cur"
        Me.CurDataGridViewTextBoxColumn.HeaderText = "MONEY"
        Me.CurDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CurDataGridViewTextBoxColumn.Name = "CurDataGridViewTextBoxColumn"
        Me.CurDataGridViewTextBoxColumn.ReadOnly = True
        Me.CurDataGridViewTextBoxColumn.Visible = False
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "TYPES"
        Me.TypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TypeDataGridViewTextBoxColumn.Visible = False
        '
        'ActiveDataGridViewCheckBoxColumn
        '
        Me.ActiveDataGridViewCheckBoxColumn.DataPropertyName = "active"
        Me.ActiveDataGridViewCheckBoxColumn.HeaderText = "ACTIVE"
        Me.ActiveDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.ActiveDataGridViewCheckBoxColumn.Name = "ActiveDataGridViewCheckBoxColumn"
        Me.ActiveDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ActiveDataGridViewCheckBoxColumn.Visible = False
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataSource = GetType(Entities.Products)
        '
        'label13
        '
        Me.label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.Location = New System.Drawing.Point(0, 0)
        Me.label13.Margin = New System.Windows.Forms.Padding(3)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(900, 32)
        Me.label13.TabIndex = 2
        Me.label13.Text = "Low stock products"
        '
        'lbInv
        '
        Me.lbInv.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInv.Location = New System.Drawing.Point(1, 1)
        Me.lbInv.Name = "lbInv"
        Me.lbInv.Size = New System.Drawing.Size(932, 40)
        Me.lbInv.TabIndex = 49
        Me.lbInv.Text = "Inventory Details"
        Me.lbInv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GGrandiantPanel4
        '
        Me.GGrandiantPanel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GGrandiantPanel4.BackColor = System.Drawing.Color.Transparent
        Me.GGrandiantPanel4.BorderColor = System.Drawing.Color.Transparent
        Me.GGrandiantPanel4.BorderWidth = 0
        Me.GGrandiantPanel4.Controls.Add(Me.ptypes)
        Me.GGrandiantPanel4.Controls.Add(Me.Label7)
        Me.GGrandiantPanel4.GradientEndColor = System.Drawing.Color.Silver
        Me.GGrandiantPanel4.GradientStartColor = System.Drawing.Color.Fuchsia
        Me.GGrandiantPanel4.Image = Nothing
        Me.GGrandiantPanel4.ImageLocation = New System.Drawing.Point(4, 4)
        Me.GGrandiantPanel4.Location = New System.Drawing.Point(20, 36)
        Me.GGrandiantPanel4.Name = "GGrandiantPanel4"
        Me.GGrandiantPanel4.Padding = New System.Windows.Forms.Padding(5, 2, 12, 8)
        Me.GGrandiantPanel4.PanelStyle = GUIHelper.GGrandiantPanel.GPanelStyle.Gradiant
        Me.GGrandiantPanel4.RoundCornerRadius = 15
        Me.GGrandiantPanel4.ShadowOffSet = 3
        Me.GGrandiantPanel4.Size = New System.Drawing.Size(295, 75)
        Me.GGrandiantPanel4.TabIndex = 57
        '
        'ptypes
        '
        Me.ptypes.BackColor = System.Drawing.Color.Transparent
        Me.ptypes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ptypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ptypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ptypes.Location = New System.Drawing.Point(5, 24)
        Me.ptypes.Margin = New System.Windows.Forms.Padding(1)
        Me.ptypes.Name = "ptypes"
        Me.ptypes.Padding = New System.Windows.Forms.Padding(2)
        Me.ptypes.Size = New System.Drawing.Size(278, 43)
        Me.ptypes.TabIndex = 1
        Me.ptypes.Text = "00"
        Me.ptypes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(278, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Products Types"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GGrandiantPanel2
        '
        Me.GGrandiantPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GGrandiantPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GGrandiantPanel2.BorderColor = System.Drawing.Color.Transparent
        Me.GGrandiantPanel2.BorderWidth = 0
        Me.GGrandiantPanel2.Controls.Add(Me.lbSalesAmount)
        Me.GGrandiantPanel2.Controls.Add(Me.Label6)
        Me.GGrandiantPanel2.GradientEndColor = System.Drawing.Color.Silver
        Me.GGrandiantPanel2.GradientStartColor = System.Drawing.Color.Fuchsia
        Me.GGrandiantPanel2.Image = Nothing
        Me.GGrandiantPanel2.ImageLocation = New System.Drawing.Point(4, 4)
        Me.GGrandiantPanel2.Location = New System.Drawing.Point(315, 36)
        Me.GGrandiantPanel2.Name = "GGrandiantPanel2"
        Me.GGrandiantPanel2.Padding = New System.Windows.Forms.Padding(5, 2, 12, 8)
        Me.GGrandiantPanel2.PanelStyle = GUIHelper.GGrandiantPanel.GPanelStyle.Gradiant
        Me.GGrandiantPanel2.RoundCornerRadius = 15
        Me.GGrandiantPanel2.ShadowOffSet = 3
        Me.GGrandiantPanel2.Size = New System.Drawing.Size(295, 75)
        Me.GGrandiantPanel2.TabIndex = 59
        '
        'lbSalesAmount
        '
        Me.lbSalesAmount.BackColor = System.Drawing.Color.Transparent
        Me.lbSalesAmount.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbSalesAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbSalesAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSalesAmount.Location = New System.Drawing.Point(5, 24)
        Me.lbSalesAmount.Margin = New System.Windows.Forms.Padding(1)
        Me.lbSalesAmount.Name = "lbSalesAmount"
        Me.lbSalesAmount.Padding = New System.Windows.Forms.Padding(2)
        Me.lbSalesAmount.Size = New System.Drawing.Size(278, 43)
        Me.lbSalesAmount.TabIndex = 1
        Me.lbSalesAmount.Text = "00"
        Me.lbSalesAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(278, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Total Sales"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InstockGGP
        '
        Me.InstockGGP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.InstockGGP.BackColor = System.Drawing.Color.Transparent
        Me.InstockGGP.BorderColor = System.Drawing.Color.Transparent
        Me.InstockGGP.BorderWidth = 0
        Me.InstockGGP.Controls.Add(Me.lbProductInStockAmount)
        Me.InstockGGP.Controls.Add(Me.Label1)
        Me.InstockGGP.GradientEndColor = System.Drawing.Color.Silver
        Me.InstockGGP.GradientStartColor = System.Drawing.Color.Fuchsia
        Me.InstockGGP.Image = Nothing
        Me.InstockGGP.ImageLocation = New System.Drawing.Point(4, 4)
        Me.InstockGGP.Location = New System.Drawing.Point(610, 36)
        Me.InstockGGP.Name = "InstockGGP"
        Me.InstockGGP.Padding = New System.Windows.Forms.Padding(5, 2, 12, 8)
        Me.InstockGGP.PanelStyle = GUIHelper.GGrandiantPanel.GPanelStyle.Gradiant
        Me.InstockGGP.RoundCornerRadius = 15
        Me.InstockGGP.ShadowOffSet = 3
        Me.InstockGGP.Size = New System.Drawing.Size(295, 75)
        Me.InstockGGP.TabIndex = 56
        '
        'lbProductInStockAmount
        '
        Me.lbProductInStockAmount.BackColor = System.Drawing.Color.Transparent
        Me.lbProductInStockAmount.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbProductInStockAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbProductInStockAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProductInStockAmount.Location = New System.Drawing.Point(5, 24)
        Me.lbProductInStockAmount.Margin = New System.Windows.Forms.Padding(1)
        Me.lbProductInStockAmount.Name = "lbProductInStockAmount"
        Me.lbProductInStockAmount.Padding = New System.Windows.Forms.Padding(2)
        Me.lbProductInStockAmount.Size = New System.Drawing.Size(278, 43)
        Me.lbProductInStockAmount.TabIndex = 1
        Me.lbProductInStockAmount.Text = "00"
        Me.lbProductInStockAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Products Instock"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.GGrandiantPanel4)
        Me.Panel1.Controls.Add(Me.GGrandiantPanel2)
        Me.Panel1.Controls.Add(Me.InstockGGP)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(1, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(932, 110)
        Me.Panel1.TabIndex = 61
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dtpEndDate)
        Me.Panel3.Controls.Add(Me.dtpStartDate)
        Me.Panel3.Controls.Add(Me.btnThisWeek)
        Me.Panel3.Controls.Add(Me.btnThisMont)
        Me.Panel3.Controls.Add(Me.btnThisYear)
        Me.Panel3.Controls.Add(Me.tgscustomedates)
        Me.Panel3.Controls.Add(Me.btnFilterSALES)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(932, 35)
        Me.Panel3.TabIndex = 61
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpEndDate.CustomFormat = "MMM dd, yyyy"
        Me.dtpEndDate.Enabled = False
        Me.dtpEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(723, 7)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(122, 23)
        Me.dtpEndDate.TabIndex = 61
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpStartDate.CustomFormat = "MMM dd, yyyy"
        Me.dtpStartDate.Enabled = False
        Me.dtpStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(595, 7)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(122, 23)
        Me.dtpStartDate.TabIndex = 60
        '
        'btnThisWeek
        '
        Me.btnThisWeek.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThisWeek.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnThisWeek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnThisWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThisWeek.Location = New System.Drawing.Point(255, 3)
        Me.btnThisWeek.Name = "btnThisWeek"
        Me.btnThisWeek.Size = New System.Drawing.Size(74, 29)
        Me.btnThisWeek.TabIndex = 58
        Me.btnThisWeek.Text = "7 Days"
        Me.btnThisWeek.UIStyle = GUIHelper.GButton.Style.Flat
        Me.btnThisWeek.UseVisualStyleBackColor = True
        '
        'btnThisMont
        '
        Me.btnThisMont.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThisMont.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnThisMont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnThisMont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThisMont.Location = New System.Drawing.Point(329, 3)
        Me.btnThisMont.Name = "btnThisMont"
        Me.btnThisMont.Size = New System.Drawing.Size(74, 29)
        Me.btnThisMont.TabIndex = 57
        Me.btnThisMont.Text = "30 Days"
        Me.btnThisMont.UIStyle = GUIHelper.GButton.Style.Flat
        Me.btnThisMont.UseVisualStyleBackColor = True
        '
        'btnThisYear
        '
        Me.btnThisYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThisYear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnThisYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnThisYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThisYear.Location = New System.Drawing.Point(403, 3)
        Me.btnThisYear.Name = "btnThisYear"
        Me.btnThisYear.Size = New System.Drawing.Size(74, 29)
        Me.btnThisYear.TabIndex = 56
        Me.btnThisYear.Text = "365 Days"
        Me.btnThisYear.UIStyle = GUIHelper.GButton.Style.Flat
        Me.btnThisYear.UseVisualStyleBackColor = True
        '
        'tgscustomedates
        '
        Me.tgscustomedates.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tgscustomedates.Location = New System.Drawing.Point(520, 8)
        Me.tgscustomedates.Name = "tgscustomedates"
        Me.tgscustomedates.OffFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgscustomedates.OnFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgscustomedates.Size = New System.Drawing.Size(59, 19)
        Me.tgscustomedates.Style = GUIHelper.ToggleSwitch.ToggleSwitchStyle.BrushedMetal
        Me.tgscustomedates.TabIndex = 55
        '
        'btnFilterSALES
        '
        Me.btnFilterSALES.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFilterSALES.FlatAppearance.BorderSize = 0
        Me.btnFilterSALES.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnFilterSALES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnFilterSALES.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilterSALES.Location = New System.Drawing.Point(851, 3)
        Me.btnFilterSALES.Name = "btnFilterSALES"
        Me.btnFilterSALES.Size = New System.Drawing.Size(63, 26)
        Me.btnFilterSALES.TabIndex = 1
        Me.btnFilterSALES.Text = "Submit"
        Me.btnFilterSALES.UIStyle = GUIHelper.GButton.Style.Flat
        Me.btnFilterSALES.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        Me.PrintDocument1.OriginAtMargins = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.AllowCurrentPage = True
        Me.PrintDialog1.UseEXDialog = True
        '
        'InventryPanel
        '
        Me.Controls.Add(Me.tbprodsaled)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbInv)
        Me.Name = "InventryPanel"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(934, 444)
        Me.tbprodsaled.ResumeLayout(False)
        Me.SSalesTab.ResumeLayout(False)
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopProductsListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DashboardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.OwingCustomerChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbsaledprods.ResumeLayout(False)
        CType(Me.chartGrossRevenue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartTopProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnalyticItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.panel5.ResumeLayout(False)
        CType(Me.dgvUnderstock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GGrandiantPanel4.ResumeLayout(False)
        Me.GGrandiantPanel2.ResumeLayout(False)
        Me.InstockGGP.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region
    ''
    '' Init
    '' 
    Private GMessage As New GMessage()
    Private startdate As Date = DateTime.Now.AddDays(-7).Date
    Private enddate As Date = DateTime.Now.Date
    Private anstatic As List(Of semiprod) ' List(Of KeyValuePair(Of String, Integer))
    Sub New()
        DoubleBuffered = True
        InitializeComponent()
        startdate = DateTime.Now.AddDays(-7)
        enddate = DateTime.Now '.AddDays(1)
        Dim th As Thread = New Thread(New ThreadStart(Sub() LoadInventry()))
        th.Start()
        th.Join()
        ' This line of code is generated by Data Source Configuration Wizard
        ' Uncomment next line to set the total number of data records stored within your source
        ' UnboundSource1.SetRowCount(42); 
    End Sub
    Sub New(id As Integer)
        DoubleBuffered = True
        InitializeComponent()
        startdate = DateTime.Now.AddDays(-7)
        enddate = DateTime.Now '.AddDays(1)
        Dim th As Thread = New Thread(New ThreadStart(Sub() LoadInventry()))
        th.Start()
        th.Join()
    End Sub
    Private Sub Inventry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoadInventry()
        Try
            Dim A As Action = AddressOf LoadTop10 ' INIT TOP Prod by date
            Dim B As Action = AddressOf LoadChart ' Load the details info
            Dim C As Action = AddressOf LoadGraf ' LOad the Charts
            ''
            ''Load
            ''
            Dim t As Task() = New Task() {
                Task.Factory.StartNew(A),
                Task.Factory.StartNew(B),
                Task.Factory.StartNew(C)
                }
            Task.WaitAll(t)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadGraf()
        Try
            Dim li As New List(Of Invoices)
            Dim lc As New List(Of Customers)
            'li = DataModule.GetInvoices()
            lc = DataModule.GetOwingCustomers()
            'For Each row In li
            '    SalesChart.Series("SalesS").Points.AddXY(row.Customer, row.TotalOw)
            '    SalesChart.Series("SalesS").AxisLabel = row.Seller
            '    'SalesChart.AlignDataPointsByAxisLabel("SalesS")
            'Next
            For Each c In lc
                OwingCustomerChart.Series("OwingCustomers").Points.AddXY(c.name.ToString(), c.owing)
                OwingCustomerChart.Series("OwingCustomers").AxisLabel = c.name
            Next

        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadTop10()
        Try
            Dim ltop = DataModule.GetProductTop10(startdate, enddate).ToList()
            For Each t In ltop
                chartTopProducts.Series("TopProducts").Points.AddXY(t.name, t.value)
                chartTopProducts.Series(0).AxisLabel = t.name
                Console.WriteLine(t.name & " " & t.value)
            Next
            chartTopProducts.DataSource = ltop

            'Loadinfos()
            Dim dash = New dashboard()
            'Dim pal = DataModule.ProductAnalisys(startdate, enddate)
            'chartGrossRevenue.Series(0).Points.Clear()
            'For Each l In pal
            '    chartGrossRevenue.Series("grossrev").Points.AddXY(l.name, l.value)
            '    chartGrossRevenue.Series("grossrev").AxisLabel = l.name
            'Next

            Dim freshdata = dash.LoadData(startdate, enddate)
            If freshdata = True Then
                chartGrossRevenue.DataSource = dash.GrossRevenueList
                chartGrossRevenue.Series(0).XValueMember = "Date"
                chartGrossRevenue.Series(0).YValueMembers = "TotalAmount"
                chartGrossRevenue.DataBind()

                'ChartControl1.DataSource = dash.TopProductsList
                Dgv.DataSource = dash.TopProductsList
                anstatic = dash.TopProductsList
                ' S.Series(0).XValueMember = "Key"
                'SalesChart.Series(0).YValueMembers = "Value"
                'Dgv.DataBind()
            End If

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Public Sub LoadChart()
        Try
            '' get the amount of product from datamodule
            lbProductInStockAmount.Text = String.Format("{0}", DataModule.GetProductCount)
            ptypes.Text = String.Format("{0}", DataModule.GetProductTypesCount)
            lbSalesAmount.Text = String.Format("{0}", DataModule.GetInvoiceCount)

            dgvUnderstock.DataSource = DataModule.GetProductsLow()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Inventry_BackColorChanged(sender As Object, e As EventArgs) Handles MyBase.BackColorChanged
        Me.InstockGGP.BackColor = Me.BackColor
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GetSaledProductByDale(dat As String)
        Try

        Catch ex As Exception

        End Try
    End Sub

    ' This event is generated by Data Source Configuration Wizard
    Sub UnboundSource1_ValueNeeded(sender As Object, e As DevExpress.Data.UnboundSourceValueNeededEventArgs)
        ' Handle this event to obtain data from your data source
        ' e.Value = something /* TODO: Assign the real data here.*/
    End Sub

    ' This event is generated by Data Source Configuration Wizard
    Sub UnboundSource1_ValuePushed(sender As Object, e As DevExpress.Data.UnboundSourceValuePushedEventArgs)
        ' Handle this event to save modified data back to your data source
        ' something = e.Value; /* TODO: Propagate the value into the storage.*/
    End Sub
#Region "Inventry"

    Private Sub btnThisMont_Click(sender As Object, e As EventArgs) Handles btnThisMont.Click
        startdate = DateTime.Now.AddDays(-30)
        enddate = DateTime.Now
        LoadTop10()
    End Sub

    Private Sub Chart2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub label13_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub btnThisWeek_Click(sender As Object, e As EventArgs) Handles btnThisWeek.Click
        startdate = DateTime.Now.AddDays(-7)
        enddate = DateTime.Now
        LoadTop10()
    End Sub

    Private Sub btnThisYear_Click(sender As Object, e As EventArgs) Handles btnThisYear.Click
        startdate = DateTime.Now.AddYears(-1)
        enddate = DateTime.Now
        LoadTop10()
    End Sub

    Private Sub tgscustomedates_CheckedChanged(sender As Object, e As EventArgs) Handles tgscustomedates.CheckedChanged
        If tgscustomedates.Checked = True Then
            btnThisWeek.Enabled = False
            btnThisMont.Enabled = False
            btnThisYear.Enabled = False

            dtpEndDate.Enabled = True
            dtpStartDate.Enabled = True
        Else
            btnThisWeek.Enabled = True
            btnThisMont.Enabled = True
            btnThisYear.Enabled = True

            dtpEndDate.Enabled = False
            dtpStartDate.Enabled = False
        End If
    End Sub

    Private Sub btnFilterSALES_Click(sender As Object, e As EventArgs) Handles btnFilterSALES.Click
        startdate = dtpStartDate.Value
        enddate = dtpEndDate.Value
        LoadTop10()
    End Sub

    Private Sub btnPrintSalesres_Click(sender As Object, e As EventArgs) Handles btnPrintSalesres.Click
        Try
            Dim p As New printanalitic(anstatic)
            p.ShowDialog()
        Catch
        End Try

        printdgv(Dgv)
    End Sub

    Private Sub btnPrintLowstock_Click(sender As Object, e As EventArgs) Handles btnPrintLowstock.Click
        'Dim p As New PRINT.lowprt
        'p.ShowDialog()
    End Sub
    Private Sub printdgv(dv As DataGridView)
        Try
            Dim printer As DGVPrinter = New DGVPrinter()
            printer.Title = "Marshell" '; //give your report name 
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit Or StringFormatFlags.NoClip
            printer.PageNumbers = True '; // If you need page numbers you can keep this As True other wise False 
            printer.PageNumberInHeader = True
            printer.PorportionalColumns = False
            printer.ColumnWidth = DGVPrinter.ColumnWidthSetting.Porportional
            printer.HeaderCellAlignment = StringAlignment.Near
            printer.Footer = "Marshell :)  " + DateTime.Now().ToString() ' //this Is the footer 
            printer.FooterSpacing = 15 '
            printer.printDocument.DefaultPageSettings.Landscape = True
            printer.PrintDataGridView(dv)
        Catch d As Exception
            Console.WriteLine(d.Message)
        End Try
    End Sub
#End Region
End Class
