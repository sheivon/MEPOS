namespace InvoicePrinter.Customer
{
    partial class CostomersFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostomersFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPay = new DevExpress.XtraEditors.SimpleButton();
            this.btnUnblkCust = new DevExpress.XtraEditors.SimpleButton();
            this.btnBanCust = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteRec = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewCustomers = new DevExpress.XtraEditors.SimpleButton();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.txtSearchCustomer = new GUIHelper.GTxt();
            this.btnEditCustomers = new DevExpress.XtraEditors.SimpleButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.custlist = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.owingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clViewPaymentHistory = new System.Windows.Forms.DataGridViewButtonColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPay.ImageOptions.SvgImage")));
            this.btnPay.Location = new System.Drawing.Point(767, 69);
            this.btnPay.MaximumSize = new System.Drawing.Size(171, 49);
            this.btnPay.MinimumSize = new System.Drawing.Size(100, 36);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(117, 36);
            this.btnPay.TabIndex = 22;
            this.btnPay.Text = "Pay";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnUnblkCust
            // 
            this.btnUnblkCust.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUnblkCust.ImageOptions.SvgImage")));
            this.btnUnblkCust.Location = new System.Drawing.Point(380, 69);
            this.btnUnblkCust.MaximumSize = new System.Drawing.Size(171, 49);
            this.btnUnblkCust.MinimumSize = new System.Drawing.Size(100, 36);
            this.btnUnblkCust.Name = "btnUnblkCust";
            this.btnUnblkCust.Size = new System.Drawing.Size(117, 36);
            this.btnUnblkCust.TabIndex = 21;
            this.btnUnblkCust.Text = "UnBlock";
            // 
            // btnBanCust
            // 
            this.btnBanCust.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBanCust.ImageOptions.SvgImage")));
            this.btnBanCust.Location = new System.Drawing.Point(509, 69);
            this.btnBanCust.MaximumSize = new System.Drawing.Size(171, 49);
            this.btnBanCust.MinimumSize = new System.Drawing.Size(100, 36);
            this.btnBanCust.Name = "btnBanCust";
            this.btnBanCust.Size = new System.Drawing.Size(117, 36);
            this.btnBanCust.TabIndex = 3;
            this.btnBanCust.Text = "Block";
            // 
            // btnDeleteRec
            // 
            this.btnDeleteRec.ImageOptions.Image = global::InvoicePrinter.Properties.Resources.Delete__2_;
            this.btnDeleteRec.Location = new System.Drawing.Point(638, 69);
            this.btnDeleteRec.MaximumSize = new System.Drawing.Size(171, 49);
            this.btnDeleteRec.MinimumSize = new System.Drawing.Size(100, 36);
            this.btnDeleteRec.Name = "btnDeleteRec";
            this.btnDeleteRec.Size = new System.Drawing.Size(117, 36);
            this.btnDeleteRec.TabIndex = 20;
            this.btnDeleteRec.Text = "Delete";
            // 
            // btnNewCustomers
            // 
            this.btnNewCustomers.ImageOptions.Image = global::InvoicePrinter.Properties.Resources.Plus__2_;
            this.btnNewCustomers.Location = new System.Drawing.Point(122, 69);
            this.btnNewCustomers.MaximumSize = new System.Drawing.Size(171, 49);
            this.btnNewCustomers.MinimumSize = new System.Drawing.Size(100, 36);
            this.btnNewCustomers.Name = "btnNewCustomers";
            this.btnNewCustomers.Size = new System.Drawing.Size(117, 36);
            this.btnNewCustomers.TabIndex = 1;
            this.btnNewCustomers.Text = "New";
            this.btnNewCustomers.Click += new System.EventHandler(this.btnNewCustomers_Click);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.btnPay);
            this.Panel2.Controls.Add(this.txtSearchCustomer);
            this.Panel2.Controls.Add(this.btnUnblkCust);
            this.Panel2.Controls.Add(this.btnBanCust);
            this.Panel2.Controls.Add(this.btnDeleteRec);
            this.Panel2.Controls.Add(this.btnNewCustomers);
            this.Panel2.Controls.Add(this.btnEditCustomers);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Padding = new System.Windows.Forms.Padding(50, 2, 50, 0);
            this.Panel2.Size = new System.Drawing.Size(985, 116);
            this.Panel2.TabIndex = 21;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.ForeColor = System.Drawing.Color.DarkOrchid;
            this.txtSearchCustomer.Location = new System.Drawing.Point(50, 35);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(885, 30);
            this.txtSearchCustomer.TabIndex = 22;
            this.txtSearchCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchCustomer.WatermarkText = "Search Customer via Names | Sr Name | Mobile ";
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // btnEditCustomers
            // 
            this.btnEditCustomers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCustomers.ImageOptions.Image")));
            this.btnEditCustomers.Location = new System.Drawing.Point(251, 69);
            this.btnEditCustomers.MaximumSize = new System.Drawing.Size(171, 49);
            this.btnEditCustomers.MinimumSize = new System.Drawing.Size(100, 36);
            this.btnEditCustomers.Name = "btnEditCustomers";
            this.btnEditCustomers.Size = new System.Drawing.Size(117, 36);
            this.btnEditCustomers.TabIndex = 2;
            this.btnEditCustomers.Text = "Edit";
            this.btnEditCustomers.Click += new System.EventHandler(this.btnEditCustomers_Click);
            // 
            // Label2
            // 
            this.Label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(50, 2);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(885, 33);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "Customer Details";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // custlist
            // 
            this.custlist.AllowUserToAddRows = false;
            this.custlist.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.custlist.AutoGenerateColumns = false;
            this.custlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.custlist.BackgroundColor = System.Drawing.SystemColors.Control;
            this.custlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.custlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.custlist.ColumnHeadersHeight = 35;
            this.custlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.srnameDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.idcardDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.nacionalityDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.blockedDataGridViewCheckBoxColumn,
            this.owingDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.clViewPaymentHistory});
            this.custlist.DataSource = this.customersBindingSource;
            this.custlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.custlist.EnableHeadersVisualStyles = false;
            this.custlist.Location = new System.Drawing.Point(0, 116);
            this.custlist.MultiSelect = false;
            this.custlist.Name = "custlist";
            this.custlist.ReadOnly = true;
            this.custlist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custlist.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.custlist.RowHeadersWidth = 10;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custlist.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.custlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.custlist.ShowEditingIcon = false;
            this.custlist.Size = new System.Drawing.Size(985, 366);
            this.custlist.TabIndex = 24;
            this.custlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.custlist_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // srnameDataGridViewTextBoxColumn
            // 
            this.srnameDataGridViewTextBoxColumn.DataPropertyName = "srname";
            this.srnameDataGridViewTextBoxColumn.HeaderText = "srname";
            this.srnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.srnameDataGridViewTextBoxColumn.Name = "srnameDataGridViewTextBoxColumn";
            this.srnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "mobile";
            this.mobileDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcardDataGridViewTextBoxColumn
            // 
            this.idcardDataGridViewTextBoxColumn.DataPropertyName = "idcard";
            this.idcardDataGridViewTextBoxColumn.HeaderText = "idcard";
            this.idcardDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcardDataGridViewTextBoxColumn.Name = "idcardDataGridViewTextBoxColumn";
            this.idcardDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Visible = false;
            // 
            // nacionalityDataGridViewTextBoxColumn
            // 
            this.nacionalityDataGridViewTextBoxColumn.DataPropertyName = "nacionality";
            this.nacionalityDataGridViewTextBoxColumn.HeaderText = "nacionality";
            this.nacionalityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nacionalityDataGridViewTextBoxColumn.Name = "nacionalityDataGridViewTextBoxColumn";
            this.nacionalityDataGridViewTextBoxColumn.ReadOnly = true;
            this.nacionalityDataGridViewTextBoxColumn.Visible = false;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Visible = false;
            // 
            // blockedDataGridViewCheckBoxColumn
            // 
            this.blockedDataGridViewCheckBoxColumn.DataPropertyName = "blocked";
            this.blockedDataGridViewCheckBoxColumn.HeaderText = "blocked";
            this.blockedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.blockedDataGridViewCheckBoxColumn.Name = "blockedDataGridViewCheckBoxColumn";
            this.blockedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // owingDataGridViewTextBoxColumn
            // 
            this.owingDataGridViewTextBoxColumn.DataPropertyName = "owing";
            this.owingDataGridViewTextBoxColumn.HeaderText = "owing";
            this.owingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.owingDataGridViewTextBoxColumn.Name = "owingDataGridViewTextBoxColumn";
            this.owingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "money";
            this.moneyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            this.moneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.moneyDataGridViewTextBoxColumn.Visible = false;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "active";
            this.activeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FULL NAME";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // clViewPaymentHistory
            // 
            this.clViewPaymentHistory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Indigo;
            this.clViewPaymentHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.clViewPaymentHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clViewPaymentHistory.HeaderText = "VIew Payments";
            this.clViewPaymentHistory.MinimumWidth = 6;
            this.clViewPaymentHistory.Name = "clViewPaymentHistory";
            this.clViewPaymentHistory.ReadOnly = true;
            this.clViewPaymentHistory.Text = "View";
            this.clViewPaymentHistory.ToolTipText = "View Customer Payment history";
            this.clViewPaymentHistory.UseColumnTextForButtonValue = true;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataSource = typeof(Entities.Customers);
            // 
            // Panel1
            // 
            this.Panel1.AutoSize = true;
            this.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel1.Controls.Add(this.custlist);
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(10, 10);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(985, 482);
            this.Panel1.TabIndex = 1;
            // 
            // CostomersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel1);
            this.Name = "CostomersFrm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1005, 502);
            this.Load += new System.EventHandler(this.CostomersFrm_Load);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal DevExpress.XtraEditors.SimpleButton btnPay;
        internal DevExpress.XtraEditors.SimpleButton btnUnblkCust;
        internal DevExpress.XtraEditors.SimpleButton btnBanCust;
        internal DevExpress.XtraEditors.SimpleButton btnDeleteRec;
        internal DevExpress.XtraEditors.SimpleButton btnNewCustomers;
        internal System.Windows.Forms.Panel Panel2;
        internal DevExpress.XtraEditors.SimpleButton btnEditCustomers;
        internal GUIHelper.GTxt txtSearchCustomer;
        private System.Windows.Forms.DataGridView custlist;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacionalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn blockedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn owingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn clViewPaymentHistory;
    }
}
