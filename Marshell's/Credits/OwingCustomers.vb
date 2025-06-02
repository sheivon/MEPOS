Imports System.ComponentModel
Imports System.Text
Imports System.Threading
Imports DataBase
Imports GUIHelper
Imports InvoicePrinter
Imports InvoicePrinter.Customer
Imports MarshellsSettings


<ToolboxItem(False)>
Public Class OwingCustomers
    Inherits UserControl
#Region "UIX"
    Private components As IContainer
    Private WithEvents lbInv As Label
    Friend WithEvents ToolsPanel As Panel
    Friend WithEvents txtSearch As GTxt
    Private WithEvents Invoicedgv As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents cusname As DataGridViewTextBoxColumn
    Friend WithEvents csn As DataGridViewTextBoxColumn
    Friend WithEvents indate As DataGridViewTextBoxColumn
    Friend WithEvents stt As DataGridViewTextBoxColumn
    Friend WithEvents vhd As DataGridViewTextBoxColumn
    Friend WithEvents clhTow As DataGridViewTextBoxColumn
    Friend WithEvents cr As DataGridViewTextBoxColumn
    Friend WithEvents invview As DataGridViewButtonColumn
    Friend WithEvents btnPay As DataGridViewButtonColumn
    Friend WithEvents pp As DataGridViewButtonColumn
    Friend WithEvents delinvoice As DataGridViewButtonColumn
    Friend WithEvents invIDI As DataGridViewTextBoxColumn
    Friend WithEvents clhiden As DataGridViewTextBoxColumn

    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbInv = New System.Windows.Forms.Label()
        Me.ToolsPanel = New System.Windows.Forms.Panel()
        Me.Invoicedgv = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.cusname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.csn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.indate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clhTow = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invview = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnPay = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pp = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.delinvoice = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.invIDI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clhiden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearch = New GUIHelper.GTxt()
        Me.ToolsPanel.SuspendLayout()
        CType(Me.Invoicedgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbInv
        '
        Me.lbInv.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInv.Location = New System.Drawing.Point(5, 10)
        Me.lbInv.Name = "lbInv"
        Me.lbInv.Size = New System.Drawing.Size(973, 41)
        Me.lbInv.TabIndex = 21
        Me.lbInv.Text = "Credit's Details"
        Me.lbInv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolsPanel
        '
        Me.ToolsPanel.Controls.Add(Me.Invoicedgv)
        Me.ToolsPanel.Controls.Add(Me.txtSearch)
        Me.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolsPanel.Location = New System.Drawing.Point(5, 51)
        Me.ToolsPanel.Name = "ToolsPanel"
        Me.ToolsPanel.Size = New System.Drawing.Size(973, 357)
        Me.ToolsPanel.TabIndex = 22
        '
        'Invoicedgv
        '
        Me.Invoicedgv.AllowUserToAddRows = False
        Me.Invoicedgv.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Invoicedgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.Invoicedgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Invoicedgv.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Invoicedgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Invoicedgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Invoicedgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Invoicedgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.Invoicedgv.ColumnHeadersHeight = 37
        Me.Invoicedgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewImageColumn1, Me.cusname, Me.csn, Me.indate, Me.stt, Me.vhd, Me.clhTow, Me.cr, Me.invview, Me.btnPay, Me.pp, Me.delinvoice, Me.invIDI, Me.clhiden})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Invoicedgv.DefaultCellStyle = DataGridViewCellStyle14
        Me.Invoicedgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Invoicedgv.EnableHeadersVisualStyles = False
        Me.Invoicedgv.Location = New System.Drawing.Point(0, 29)
        Me.Invoicedgv.MultiSelect = False
        Me.Invoicedgv.Name = "Invoicedgv"
        Me.Invoicedgv.ReadOnly = True
        Me.Invoicedgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Invoicedgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.Invoicedgv.RowHeadersVisible = False
        Me.Invoicedgv.RowHeadersWidth = 10
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Invoicedgv.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.Invoicedgv.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Invoicedgv.RowTemplate.Height = 40
        Me.Invoicedgv.RowTemplate.ReadOnly = True
        Me.Invoicedgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Invoicedgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Invoicedgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Invoicedgv.ShowEditingIcon = False
        Me.Invoicedgv.Size = New System.Drawing.Size(973, 328)
        Me.Invoicedgv.TabIndex = 24
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 50
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewImageColumn1.HeaderText = "Barcode"
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        '
        'cusname
        '
        Me.cusname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cusname.HeaderText = "Customer"
        Me.cusname.MaxInputLength = 50
        Me.cusname.MinimumWidth = 6
        Me.cusname.Name = "cusname"
        Me.cusname.ReadOnly = True
        '
        'csn
        '
        Me.csn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.csn.HeaderText = "Cashier"
        Me.csn.MinimumWidth = 6
        Me.csn.Name = "csn"
        Me.csn.ReadOnly = True
        '
        'indate
        '
        Me.indate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.indate.HeaderText = "Date"
        Me.indate.MinimumWidth = 6
        Me.indate.Name = "indate"
        Me.indate.ReadOnly = True
        '
        'stt
        '
        Me.stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.stt.HeaderText = "Status"
        Me.stt.MinimumWidth = 6
        Me.stt.Name = "stt"
        Me.stt.ReadOnly = True
        '
        'vhd
        '
        Me.vhd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.vhd.HeaderText = "Total"
        Me.vhd.MinimumWidth = 6
        Me.vhd.Name = "vhd"
        Me.vhd.ReadOnly = True
        '
        'clhTow
        '
        Me.clhTow.HeaderText = "Owing"
        Me.clhTow.MinimumWidth = 6
        Me.clhTow.Name = "clhTow"
        Me.clhTow.ReadOnly = True
        '
        'cr
        '
        Me.cr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cr.HeaderText = "cur"
        Me.cr.MinimumWidth = 6
        Me.cr.Name = "cr"
        Me.cr.ReadOnly = True
        Me.cr.Visible = False
        '
        'invview
        '
        Me.invview.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.invview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.invview.HeaderText = "VIEW"
        Me.invview.MinimumWidth = 6
        Me.invview.Name = "invview"
        Me.invview.ReadOnly = True
        Me.invview.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'btnPay
        '
        Me.btnPay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPay.HeaderText = "PAY"
        Me.btnPay.MinimumWidth = 6
        Me.btnPay.Name = "btnPay"
        Me.btnPay.ReadOnly = True
        Me.btnPay.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'pp
        '
        Me.pp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Padding = New System.Windows.Forms.Padding(2)
        Me.pp.DefaultCellStyle = DataGridViewCellStyle11
        Me.pp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pp.HeaderText = "PRINT"
        Me.pp.MinimumWidth = 6
        Me.pp.Name = "pp"
        Me.pp.ReadOnly = True
        Me.pp.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.pp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'delinvoice
        '
        Me.delinvoice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.delinvoice.DefaultCellStyle = DataGridViewCellStyle12
        Me.delinvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delinvoice.HeaderText = "Delete"
        Me.delinvoice.MinimumWidth = 6
        Me.delinvoice.Name = "delinvoice"
        Me.delinvoice.ReadOnly = True
        Me.delinvoice.Text = "DEL"
        Me.delinvoice.ToolTipText = "delete this invoice"
        Me.delinvoice.Width = 56
        '
        'invIDI
        '
        Me.invIDI.HeaderText = "Invoice ID"
        Me.invIDI.MinimumWidth = 6
        Me.invIDI.Name = "invIDI"
        Me.invIDI.ReadOnly = True
        Me.invIDI.Visible = False
        '
        'clhiden
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.Format = "CS 0"
        Me.clhiden.DefaultCellStyle = DataGridViewCellStyle13
        Me.clhiden.HeaderText = "CASHED"
        Me.clhiden.MinimumWidth = 6
        Me.clhiden.Name = "clhiden"
        Me.clhiden.ReadOnly = True
        Me.clhiden.Visible = False
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.DarkOrchid
        Me.txtSearch.Location = New System.Drawing.Point(0, 0)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSearch.MaxLength = 100
        Me.txtSearch.MinimumSize = New System.Drawing.Size(939, 20)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(973, 29)
        Me.txtSearch.TabIndex = 4
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSearch.WatermarkText = "Search Via | FAC No | ID | Date | Name | Barcode | "
        '
        'OwingCustomers
        '
        Me.Controls.Add(Me.ToolsPanel)
        Me.Controls.Add(Me.lbInv)
        Me.Margin = New System.Windows.Forms.Padding(5, 10, 5, 5)
        Me.Name = "OwingCustomers"
        Me.Padding = New System.Windows.Forms.Padding(5, 10, 5, 5)
        Me.Size = New System.Drawing.Size(983, 413)
        Me.ToolsPanel.ResumeLayout(False)
        Me.ToolsPanel.PerformLayout()
        CType(Me.Invoicedgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Sub New()
        DoubleBuffered = True
        InitializeComponent()
    End Sub
    Sub New(CashierName As String, CashierID As Integer)
        DoubleBuffered = True
        InitializeComponent()
        Cashier = CashierName
        casheirid = CashierID
    End Sub
    ''
    '' Props
    ''
    Private Cashier As String
    Private casheirid As Integer
    Private FilterOwing As Boolean = True
    Private bct As String = MSetting.GetBarcodeType()
    Private Scanner As New Scanners
    Private SQ As New MySqlControl()

    Private GMessage As New GMessage()


    Private USD As Double = MSetting.GetUSD()
    Private EUR As Double = MSetting.GetEUR()
    Private tel As String = MSetting.Gettell

    Private Function Printstring(ca As Decimal, otl As Decimal) As StringBuilder
        Dim pstring As New StringBuilder()
        Try
            pstring.Append(Environment.NewLine)
            pstring.Append(String.Format("Invoice No:{0}", bcode))
            pstring.Append(Environment.NewLine)
            pstring.Append(String.Format("ATT:{0} ", Cashier))
            pstring.Append(Environment.NewLine)
            pstring.Append(String.Format("Cus:{0} ", Invoicedgv.Item(2, index).Value))
            pstring.Append(Environment.NewLine)
            pstring.Append("============================")
            pstring.Append(Environment.NewLine)
            pstring.Append("Qnty".PadLeft(3) + " | ".PadLeft(2) + "Descriptions".PadLeft(2) + " | ".PadLeft(2) + "Price".PadLeft(2))
            pstring.Append(Environment.NewLine)
            pstring.Append("============================")
            pstring.Append(Environment.NewLine)
            'For Each item As DataGridViewRow In invoiceviewer.Rows
            '    Dim CCUr As String = item.Cells(9).Value
            '    pstring.Append(item.Cells(5).Value + " |".PadRight(2) + item.Cells(3).Value.PadRight(5) + " |".PadRight(2) + String.Format("{0}{1}", IIf(CCUr = "NIO", "C$", IIf(CCUr = "USD", "$", IIf(CCUr = "EUR", "€", "$$"))), item.Cells(6).Value).PadRight(5))
            '    pstring.Append(Environment.NewLine)
            'Next
            ' need to fix add the subtotal and total and owing if available
            pstring.Append("============================")
            pstring.Append(Environment.NewLine)
            pstring.Append(String.Format("TOTAL : C$ {0}", otl))

            If topay > 0 Then
                pstring.Append(Environment.NewLine)
                pstring.Append(String.Format("Owing : C$ {0}", topay))
                pstring.Append(Environment.NewLine)
                pstring.Append("============================")
            End If
            If ca > 0 Then

                pstring.Append(Environment.NewLine)
                pstring.Append(String.Format("PAYED : C$ {0}", ca))
                pstring.Append(Environment.NewLine)
                pstring.Append(String.Format("Change : C$ {0}", (ca - otl)))
                pstring.Append(Environment.NewLine)
                pstring.Append("============================")
            End If
            pstring.Append(Environment.NewLine)
            pstring.Append("THANKS FOR BUYING")
            pstring.AppendLine()
            pstring.AppendLine("PLEASE BE BACK SOON!")
            pstring.AppendLine()
            pstring.AppendLine(String.Format("Tel: {0}", tel))
            pstring.AppendLine()
            pstring.AppendLine("$$ Currency Conversion $$ ")
            pstring.AppendLine()
            pstring.AppendLine(String.Format("1 USD:C${0} | 1 EUR:C${1}", USD, EUR))
            pstring.AppendLine()
            'MsgBox(invoiceviewer.Item(13, 0).Value)
#If DEBUG Then
        Catch ex As Exception
            GMessage.Show(ex.Message)
#Else
        Catch ex As Exception
#End If
        End Try
        Return pstring
    End Function

    Private Sub OwingCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim th As Thread = New Thread(New ThreadStart(AddressOf LoadInvoices))
        th.Start()
        th.Join()
        'LoadInvowices()
    End Sub
    Private Sub ViewInvoice(invoice As String)
        Try
            'invoiceviewer.Rows.Clear()
            'Dim qr As String = "Select C.ID as CID,P.PRODUCTCODE AS BCODE,C.CDATE AS CDATE,C.ITEMID AS IID,COALESCE(C.CID,'0') AS CUSID,COALESCE(C.EMPID,'0') AS EMID,C.QNT AS QNT,C.OWIN AS OW,C.STAT AS STATU,CS.CNAME as CN,U.UNAME as UN,(SELECT (CONCAT_ws(' ',S.DESCRIPTIONS,P.PRODUCTCODE) )) AS ITEM,(SELECT (COALESCE(P.PRODUCTPRICE,'0')+COALESCE(S.PRICE,'0')) )AS UNITPRICE,((SELECT (COALESCE(P.PRODUCTPRICE,'0')+COALESCE(S.PRICE,'0')) )* C.QNT) AS TOTAL,(SELECT (CONCAT_ws(' ',S.CUR,P.CUR))) as CUR FROM CREDITS as C LEFT OUTER JOIN PRODUCT AS P ON C.ITEMID=P.PRODUCTCODE LEFT OUTER JOIN  SERVICE AS S ON C.ITEMID=S.ID INNER JOIN CUSTOMER CS ON CS.ID=C.CID INNER JOIN USERS U ON U.ID=C.EMPID WHERE C.EMPID=U.ID AND CS.ID = C.CID AND (P.PRODUCTCODE=C.ITEMID OR S.ID=C.ITEMID) AND C.BARCODE = '" + invoice + "';"
            Dim qr As String = "Select C.ID as CID, P.PRODUCTCODE AS BCODE, C.CDATE AS CDATE, C.ITEMID AS IID, C.QNT AS QNT,C.OWIN AS OW,C.STAT AS STATU, P.PRODUCTNAME AS ITEM, P.PRODUCTPRICE AS UNITPRICE,P.PRODUCTPRICE * C.QNT AS TOTAL, P.CUR as CUR FROM CREDITS as C LEFT OUTER JOIN PRODUCT AS P ON C.ITEMID=P.ID WHERE P.ID=C.ITEMID AND C.BARCODE = '" + invoice + "';"
            SQ.ExecQuery(qr)
            For Each Read As DataRow In SQ.DBDT.Rows
                'invoiceviewer.Rows.Add(New Object() {Read("CID").ToString(), Scanner.GetBarcode(Read("BCODE").ToString(), bct), Read("CDATE").ToString(), Read("ITEM").ToString(), Read("UNITPRICE").ToString(), Read("QNT").ToString(), Read("TOTAL").ToString(), Read("STATU").ToString(), Read("OW").ToString(), Read("CUR").ToString()})
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadInvoices(Optional text As String = "")
        Try
            'invoiceviewer.Rows.Clear()
            Invoicedgv.Rows.Clear()
            Dim Rows = DataModule.GetInvoices(text)
            For Each Read In Rows
                'GetBarcode(("INVOICE").ToString())
                Dim invID = Read.Invoice
                Dim cs = Read.cashed
                If FilterOwing = True Then
                    If Read.Stat = "OWING" Then
                        Invoicedgv.Rows.Add(New Object() {Read.ID, Scanner.GetBarcode(invID, bct), Read.Customer, Read.Seller, Read.Date, Read.Stat, Read.Total, (Read.TotalOw), Read.Cur, "VIEW", "PAY", "PRINT", "DEL", invID, cs})
                    End If
                Else
                    Invoicedgv.Rows.Add(New Object() {Read.ID, Scanner.GetBarcode(invID, bct), Read.Customer, Read.Seller, Read.Date, Read.Stat, Read.Total, (Read.TotalOw), Read.Cur, "VIEW", "PAY", "PRINT", "DEL", invID, cs})
                End If
            Next
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub OwingCustomers_BackColorChanged(sender As Object, e As EventArgs) Handles Me.BackColorChanged
        'invoiceviewer.BackgroundColor = Me.BackColor
        Invoicedgv.BackgroundColor = Me.BackColor
        txtSearch.BackColor = Me.BackColor
    End Sub
    ''Locak selected fact id number
    Dim seletedfact As Integer = 0
    Dim index As Integer
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If ((String.IsNullOrEmpty(txtSearch.Text) = False) AndAlso (txtSearch.Text.Length > 0)) Then
                LoadInvoices(txtSearch.Text)
            Else
                LoadInvoices()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private bcode As String = ""
    Private topay As Decimal = 0.0F
    Private cusID As Integer = 0
    Private cashed As Decimal = 0.0F
    Private ttal As Decimal = 0.0F
    Private rdate As New DateTime
    Private Sub Invoicedgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Invoicedgv.CellClick
        Try
            index = Invoicedgv.CurrentRow.Index
            'bcode = Scanner.DecodeToText(Invoicedgv(1, index).Value).ToString ' decode to text is bug need fix 4/26/2021
            'bcode = DecodeToString(Invoicedgv(1, index).Value).ToString
            'bcode = GetBarcode(Invoicedgv(0, index).Value.ToString)
            bcode = Invoicedgv(13, index).Value ' This get the Barcode from the hiden colum in invoicedgv column 12 
            rdate = Invoicedgv(4, index).Value
            ttal = Invoicedgv(6, index).Value
            topay = Invoicedgv(7, index).Value
            cashed = Invoicedgv(14, index).Value
            '' get the col clicked
            If (e.ColumnIndex = 9) Then ' btn View is clicked
                'Dim thv As Thread = New Thread(New ThreadStart(Sub() ViewInvoice(bcode)))
                'thv.Start()
                'thv.Join()

                ''review the invoice
                'MsgBox(bcode)
                ViewInvoice(bcode)

            ElseIf e.ColumnIndex = 10 Then
                If GMessage.Show("Would you like to cancel bill?") = DialogResult.OK Then
                    Dim CancelA As New CancelOutAmount(0, topay)
                    If CancelA.ShowDialog() = DialogResult.OK Then
                        Dim paying = CDec(CancelA.txtAmount.Text)
                        Dim Balance As Decimal = 0.0F
                        Balance = CDec(topay - paying)
                        'sales.PayingByCustomer(cusID, paying)
                        If paying >= topay Then
                            Cancelling("PAYED", 0)
                        Else
                            Cancelling("OWING", CDec(Balance))
                        End If
                        LoadInvoices()
                    End If
                End If
            ElseIf e.ColumnIndex = 11 Then 'btn Print clicked
                'Dim thp As Thread = New Thread(New ThreadStart(Sub() Vprint()))
                'thp.Start()
                ViewInvoice(bcode)
                'Dim pp As New PrintInvoice(Printstring(cashed, ttal), bcode)
                'pp.ShowDialog()
            ElseIf e.ColumnIndex = 12 Then ''When Press Delete Invoice
                If GMessage.Show(String.Format("Would like to delete invoice {0}? {1} !! Delete is permanent and can't be restore !!", bcode, Environment.NewLine)) = DialogResult.OK Then
                    SQ.ExecQuery("UPDATE invoices set active=0 where invoice = '" & bcode & "';")
                    LoadInvoices()
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub filerowing_CheckedChanged(sender As Object, e As EventArgs)

        'Dim t As Thread = New Thread(New ThreadStart(AddressOf LoadInvoices)) ' when threadin slow down
        't.Start()
        't.Join()
        LoadInvoices()
    End Sub

    Private Sub Cancelling(stat As String, owin As Decimal)
        Try
            SQ = New MySqlControl()
            SQ.ExecQuery("UPDATE CREDITS SET STAT='" & stat & "' WHERE BARCODE='" & bcode & "';")
            ''
            ''
            ''
            SQ.ExecQuery("UPDATE CREDITS SET OWIN='" & owin & "' WHERE BARCODE='" & bcode & "';")
            ''
            ''
            '' 
            SQ.ExecQuery("UPDATE invoices set stat='" & stat & "' WHERE INVOICE='" & bcode & "'")
            ''
            ''
            ''
            SQ.ExecQuery("UPDATE invoices set TOTAL='" & owin & "' WHERE INVOICE='" & bcode & "'")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbview_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Invoicedgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Invoicedgv.CellContentClick

    End Sub

    Private Sub cbxnactive_CheckedChanged(sender As Object, e As EventArgs)
        LoadInvoices()
    End Sub

    'Private Sub Invoicedgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Invoicedgv.CellContentClick
    '    Dim thIS As Thread = New Thread(New ThreadStart(AddressOf invoiceChanges))
    '    thIS.Start()
    '    thIS.Join()
    'End Sub
End Class
