namespace InvoicePrinter.Invoice
{
    partial class Invoicefrm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.filerowing = new GUIHelper.ToggleSwitch();
            this.ToolsPanel = new System.Windows.Forms.Panel();
            this.Invoicedgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new GUIHelper.GTxt();
            this.lbInv = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalOwDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exchangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cashedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNITPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ToolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Invoicedgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // filerowing
            // 
            this.filerowing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filerowing.Location = new System.Drawing.Point(866, 10);
            this.filerowing.Name = "filerowing";
            this.filerowing.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filerowing.OffText = "Get All invoice";
            this.filerowing.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filerowing.OnText = "Get Owing Only";
            this.filerowing.Size = new System.Drawing.Size(140, 30);
            this.filerowing.Style = GUIHelper.ToggleSwitch.ToggleSwitchStyle.BrushedMetal;
            this.filerowing.TabIndex = 27;
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.Controls.Add(this.Invoicedgv);
            this.ToolsPanel.Controls.Add(this.panel1);
            this.ToolsPanel.Controls.Add(this.txtSearch);
            this.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolsPanel.Location = new System.Drawing.Point(5, 46);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Size = new System.Drawing.Size(1004, 517);
            this.ToolsPanel.TabIndex = 26;
            // 
            // Invoicedgv
            // 
            this.Invoicedgv.AllowUserToAddRows = false;
            this.Invoicedgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Invoicedgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Invoicedgv.AutoGenerateColumns = false;
            this.Invoicedgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Invoicedgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Invoicedgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Invoicedgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Invoicedgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Invoicedgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Invoicedgv.ColumnHeadersHeight = 40;
            this.Invoicedgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.invoiceDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.cusIdDataGridViewTextBoxColumn,
            this.sellerDataGridViewTextBoxColumn,
            this.usrIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.statDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.offDataGridViewTextBoxColumn,
            this.totalOwDataGridViewTextBoxColumn,
            this.exchangeDataGridViewTextBoxColumn,
            this.curDataGridViewTextBoxColumn1,
            this.activeDataGridViewCheckBoxColumn,
            this.cashedDataGridViewTextBoxColumn});
            this.Invoicedgv.DataSource = this.invoicesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Invoicedgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.Invoicedgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Invoicedgv.EnableHeadersVisualStyles = false;
            this.Invoicedgv.Location = new System.Drawing.Point(400, 29);
            this.Invoicedgv.MultiSelect = false;
            this.Invoicedgv.Name = "Invoicedgv";
            this.Invoicedgv.ReadOnly = true;
            this.Invoicedgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Invoicedgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Invoicedgv.RowHeadersVisible = false;
            this.Invoicedgv.RowHeadersWidth = 10;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Invoicedgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Invoicedgv.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Invoicedgv.RowTemplate.Height = 40;
            this.Invoicedgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Invoicedgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Invoicedgv.ShowEditingIcon = false;
            this.Invoicedgv.Size = new System.Drawing.Size(604, 488);
            this.Invoicedgv.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.MaximumSize = new System.Drawing.Size(400, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(400, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(400, 488);
            this.panel1.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.bCODEDataGridViewTextBoxColumn,
            this.iIDDataGridViewTextBoxColumn,
            this.iTEMDataGridViewTextBoxColumn,
            this.qTYDataGridViewTextBoxColumn,
            this.uNITPRICEDataGridViewTextBoxColumn,
            this.tOTALDataGridViewTextBoxColumn1,
            this.cDATEDataGridViewTextBoxColumn,
            this.cURDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn1});
            this.dataGridView1.DataSource = this.invoiceDetailsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.RowTemplate.DefaultCellStyle.NullValue = "0";
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.dataGridView1.RowTemplate.DividerHeight = 2;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(390, 478);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkOrchid;
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.MaxLength = 100;
            this.txtSearch.MinimumSize = new System.Drawing.Size(700, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1004, 29);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.WatermarkText = "Search Via | FAC No | ID | Date | Name | Barcode | ";
            // 
            // lbInv
            // 
            this.lbInv.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInv.Location = new System.Drawing.Point(5, 5);
            this.lbInv.Name = "lbInv";
            this.lbInv.Size = new System.Drawing.Size(1004, 41);
            this.lbInv.TabIndex = 25;
            this.lbInv.Text = "Invoice Details";
            this.lbInv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // invoiceDataGridViewTextBoxColumn
            // 
            this.invoiceDataGridViewTextBoxColumn.DataPropertyName = "Invoice";
            this.invoiceDataGridViewTextBoxColumn.HeaderText = "Invoice";
            this.invoiceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.invoiceDataGridViewTextBoxColumn.Name = "invoiceDataGridViewTextBoxColumn";
            this.invoiceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cusIdDataGridViewTextBoxColumn
            // 
            this.cusIdDataGridViewTextBoxColumn.DataPropertyName = "CusId";
            this.cusIdDataGridViewTextBoxColumn.HeaderText = "CusId";
            this.cusIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusIdDataGridViewTextBoxColumn.Name = "cusIdDataGridViewTextBoxColumn";
            this.cusIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // sellerDataGridViewTextBoxColumn
            // 
            this.sellerDataGridViewTextBoxColumn.DataPropertyName = "Seller";
            this.sellerDataGridViewTextBoxColumn.HeaderText = "Seller";
            this.sellerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sellerDataGridViewTextBoxColumn.Name = "sellerDataGridViewTextBoxColumn";
            this.sellerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usrIdDataGridViewTextBoxColumn
            // 
            this.usrIdDataGridViewTextBoxColumn.DataPropertyName = "usrId";
            this.usrIdDataGridViewTextBoxColumn.HeaderText = "usrId";
            this.usrIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usrIdDataGridViewTextBoxColumn.Name = "usrIdDataGridViewTextBoxColumn";
            this.usrIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.usrIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statDataGridViewTextBoxColumn
            // 
            this.statDataGridViewTextBoxColumn.DataPropertyName = "Stat";
            this.statDataGridViewTextBoxColumn.HeaderText = "Stat";
            this.statDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statDataGridViewTextBoxColumn.Name = "statDataGridViewTextBoxColumn";
            this.statDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // offDataGridViewTextBoxColumn
            // 
            this.offDataGridViewTextBoxColumn.DataPropertyName = "off";
            this.offDataGridViewTextBoxColumn.HeaderText = "off";
            this.offDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.offDataGridViewTextBoxColumn.Name = "offDataGridViewTextBoxColumn";
            this.offDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalOwDataGridViewTextBoxColumn
            // 
            this.totalOwDataGridViewTextBoxColumn.DataPropertyName = "TotalOw";
            this.totalOwDataGridViewTextBoxColumn.HeaderText = "TotalOw";
            this.totalOwDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalOwDataGridViewTextBoxColumn.Name = "totalOwDataGridViewTextBoxColumn";
            this.totalOwDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exchangeDataGridViewTextBoxColumn
            // 
            this.exchangeDataGridViewTextBoxColumn.DataPropertyName = "Exchange";
            this.exchangeDataGridViewTextBoxColumn.HeaderText = "Exchange";
            this.exchangeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.exchangeDataGridViewTextBoxColumn.Name = "exchangeDataGridViewTextBoxColumn";
            this.exchangeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // curDataGridViewTextBoxColumn1
            // 
            this.curDataGridViewTextBoxColumn1.DataPropertyName = "Cur";
            this.curDataGridViewTextBoxColumn1.HeaderText = "Cur";
            this.curDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.curDataGridViewTextBoxColumn1.Name = "curDataGridViewTextBoxColumn1";
            this.curDataGridViewTextBoxColumn1.ReadOnly = true;
            this.curDataGridViewTextBoxColumn1.Visible = false;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "active";
            this.activeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activeDataGridViewCheckBoxColumn.Visible = false;
            // 
            // cashedDataGridViewTextBoxColumn
            // 
            this.cashedDataGridViewTextBoxColumn.DataPropertyName = "cashed";
            this.cashedDataGridViewTextBoxColumn.HeaderText = "cashed";
            this.cashedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cashedDataGridViewTextBoxColumn.Name = "cashedDataGridViewTextBoxColumn";
            this.cashedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataSource = typeof(Entities.Invoices);
            // 
            // invoiceDetailsBindingSource
            // 
            this.invoiceDetailsBindingSource.DataSource = typeof(Entities.InvoiceDetails);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bCODEDataGridViewTextBoxColumn
            // 
            this.bCODEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bCODEDataGridViewTextBoxColumn.DataPropertyName = "BCODE";
            this.bCODEDataGridViewTextBoxColumn.HeaderText = "BCODE";
            this.bCODEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bCODEDataGridViewTextBoxColumn.Name = "bCODEDataGridViewTextBoxColumn";
            this.bCODEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iIDDataGridViewTextBoxColumn
            // 
            this.iIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iIDDataGridViewTextBoxColumn.DataPropertyName = "IID";
            this.iIDDataGridViewTextBoxColumn.HeaderText = "IID";
            this.iIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iIDDataGridViewTextBoxColumn.Name = "iIDDataGridViewTextBoxColumn";
            this.iIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // iTEMDataGridViewTextBoxColumn
            // 
            this.iTEMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iTEMDataGridViewTextBoxColumn.DataPropertyName = "ITEM";
            this.iTEMDataGridViewTextBoxColumn.HeaderText = "ITEM";
            this.iTEMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iTEMDataGridViewTextBoxColumn.Name = "iTEMDataGridViewTextBoxColumn";
            this.iTEMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qTYDataGridViewTextBoxColumn
            // 
            this.qTYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qTYDataGridViewTextBoxColumn.DataPropertyName = "QTY";
            this.qTYDataGridViewTextBoxColumn.HeaderText = "QTY";
            this.qTYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qTYDataGridViewTextBoxColumn.Name = "qTYDataGridViewTextBoxColumn";
            this.qTYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uNITPRICEDataGridViewTextBoxColumn
            // 
            this.uNITPRICEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uNITPRICEDataGridViewTextBoxColumn.DataPropertyName = "UNITPRICE";
            this.uNITPRICEDataGridViewTextBoxColumn.HeaderText = "UNITPRICE";
            this.uNITPRICEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uNITPRICEDataGridViewTextBoxColumn.Name = "uNITPRICEDataGridViewTextBoxColumn";
            this.uNITPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tOTALDataGridViewTextBoxColumn1
            // 
            this.tOTALDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tOTALDataGridViewTextBoxColumn1.DataPropertyName = "TOTAL";
            this.tOTALDataGridViewTextBoxColumn1.HeaderText = "TOTAL";
            this.tOTALDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tOTALDataGridViewTextBoxColumn1.Name = "tOTALDataGridViewTextBoxColumn1";
            this.tOTALDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cDATEDataGridViewTextBoxColumn
            // 
            this.cDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cDATEDataGridViewTextBoxColumn.DataPropertyName = "CDATE";
            this.cDATEDataGridViewTextBoxColumn.HeaderText = "CDATE";
            this.cDATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cDATEDataGridViewTextBoxColumn.Name = "cDATEDataGridViewTextBoxColumn";
            this.cDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDATEDataGridViewTextBoxColumn.Visible = false;
            // 
            // cURDataGridViewTextBoxColumn
            // 
            this.cURDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cURDataGridViewTextBoxColumn.DataPropertyName = "CUR";
            this.cURDataGridViewTextBoxColumn.HeaderText = "CUR";
            this.cURDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cURDataGridViewTextBoxColumn.Name = "cURDataGridViewTextBoxColumn";
            this.cURDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeDataGridViewCheckBoxColumn1
            // 
            this.activeDataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.activeDataGridViewCheckBoxColumn1.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn1.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.activeDataGridViewCheckBoxColumn1.Name = "activeDataGridViewCheckBoxColumn1";
            this.activeDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.activeDataGridViewCheckBoxColumn1.Visible = false;
            // 
            // Invoicefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ToolsPanel);
            this.Controls.Add(this.filerowing);
            this.Controls.Add(this.lbInv);
            this.Name = "Invoicefrm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1014, 568);
            this.Load += new System.EventHandler(this.Invoicefrm_Load);
            this.ToolsPanel.ResumeLayout(false);
            this.ToolsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Invoicedgv)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal GUIHelper.ToggleSwitch filerowing;
        internal System.Windows.Forms.Panel ToolsPanel;
        private System.Windows.Forms.DataGridView Invoicedgv;
        internal GUIHelper.GTxt txtSearch;
        private System.Windows.Forms.Label lbInv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usrIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalOwDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exchangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNITPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource invoiceDetailsBindingSource;
    }
}
