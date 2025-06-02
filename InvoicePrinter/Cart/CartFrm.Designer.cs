namespace InvoicePrinter.Cart
{
    partial class CartFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartFrm));
            this.toppanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.btnAddCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.leftpanel = new System.Windows.Forms.Panel();
            this.btnGenerateInv = new GUIHelper.GButton(this.components);
            this.btnPay = new DevExpress.XtraEditors.SimpleButton();
            this.txtBarcode = new GUIHelper.GTxt();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btnDescount = new DevExpress.XtraEditors.SimpleButton();
            this.btnService = new DevExpress.XtraEditors.SimpleButton();
            this.viewpanel = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cartItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bottompanel = new System.Windows.Forms.Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbDisc = new System.Windows.Forms.Label();
            this.lbInvoice = new System.Windows.Forms.Label();
            this.toppanel.SuspendLayout();
            this.leftpanel.SuspendLayout();
            this.viewpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartItemBindingSource)).BeginInit();
            this.bottompanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.Controls.Add(this.label1);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(10, 10);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(975, 41);
            this.toppanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(975, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cart";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomer.Location = new System.Drawing.Point(12, 9);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(117, 29);
            this.lbCustomer.TabIndex = 1;
            this.lbCustomer.Text = "Customer";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCustomer.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddCustomer.ImageOptions.SvgImage")));
            this.btnAddCustomer.Location = new System.Drawing.Point(605, 19);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(124, 40);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Customer";
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.btnGenerateInv);
            this.leftpanel.Controls.Add(this.btnPay);
            this.leftpanel.Controls.Add(this.txtBarcode);
            this.leftpanel.Controls.Add(this.btnCancel);
            this.leftpanel.Controls.Add(this.simpleButton3);
            this.leftpanel.Controls.Add(this.btnDescount);
            this.leftpanel.Controls.Add(this.btnService);
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftpanel.Location = new System.Drawing.Point(10, 51);
            this.leftpanel.MinimumSize = new System.Drawing.Size(220, 0);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(220, 404);
            this.leftpanel.TabIndex = 1;
            // 
            // btnGenerateInv
            // 
            this.btnGenerateInv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerateInv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnGenerateInv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnGenerateInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateInv.Location = new System.Drawing.Point(12, 359);
            this.btnGenerateInv.Name = "btnGenerateInv";
            this.btnGenerateInv.Size = new System.Drawing.Size(199, 32);
            this.btnGenerateInv.TabIndex = 4;
            this.btnGenerateInv.Text = "Generate Invoice";
            this.btnGenerateInv.UIStyle = GUIHelper.GButton.Style.Flat;
            this.btnGenerateInv.UseVisualStyleBackColor = true;
            this.btnGenerateInv.Click += new System.EventHandler(this.btnGenerateInv_Click);
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPay.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPay.ImageOptions.SvgImage")));
            this.btnPay.Location = new System.Drawing.Point(12, 235);
            this.btnPay.Name = "btnPay";
            this.btnPay.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnPay.Size = new System.Drawing.Size(202, 45);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Pay";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(9, 8);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(202, 28);
            this.txtBarcode.TabIndex = 2;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.WatermarkText = "Barcode";
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(12, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCancel.Size = new System.Drawing.Size(202, 45);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Clicked);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(9, 148);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(202, 43);
            this.simpleButton3.TabIndex = 0;
            this.simpleButton3.Text = "Remove Item";
            // 
            // btnDescount
            // 
            this.btnDescount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDescount.ImageOptions.SvgImage")));
            this.btnDescount.Location = new System.Drawing.Point(9, 97);
            this.btnDescount.Name = "btnDescount";
            this.btnDescount.Size = new System.Drawing.Size(202, 43);
            this.btnDescount.TabIndex = 1;
            this.btnDescount.Text = "Discount";
            this.btnDescount.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnService
            // 
            this.btnService.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnService.ImageOptions.Image")));
            this.btnService.Location = new System.Drawing.Point(9, 46);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(202, 43);
            this.btnService.TabIndex = 0;
            this.btnService.Text = "Service\'s";
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // viewpanel
            // 
            this.viewpanel.Controls.Add(this.dgv);
            this.viewpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewpanel.Location = new System.Drawing.Point(230, 51);
            this.viewpanel.Name = "viewpanel";
            this.viewpanel.Size = new System.Drawing.Size(755, 404);
            this.viewpanel.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersHeight = 29;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.subTotalDataGridViewTextBoxColumn,
            this.curDataGridViewTextBoxColumn,
            this.typeDataGridViewCheckBoxColumn});
            this.dgv.DataSource = this.cartItemBindingSource;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.RowTemplate.DividerHeight = 1;
            this.dgv.RowTemplate.Height = 42;
            this.dgv.RowTemplate.ReadOnly = true;
            this.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.ShowCellErrors = false;
            this.dgv.ShowEditingIcon = false;
            this.dgv.ShowRowErrors = false;
            this.dgv.Size = new System.Drawing.Size(755, 404);
            this.dgv.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "#";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "UNIT PRICE";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "AMOUNT";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "SUBTOTAL";
            this.subTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            this.subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // curDataGridViewTextBoxColumn
            // 
            this.curDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.curDataGridViewTextBoxColumn.DataPropertyName = "cur";
            this.curDataGridViewTextBoxColumn.HeaderText = "MONEY";
            this.curDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.curDataGridViewTextBoxColumn.Name = "curDataGridViewTextBoxColumn";
            this.curDataGridViewTextBoxColumn.ReadOnly = true;
            this.curDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeDataGridViewCheckBoxColumn
            // 
            this.typeDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewCheckBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewCheckBoxColumn.HeaderText = "TYPE";
            this.typeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewCheckBoxColumn.Name = "typeDataGridViewCheckBoxColumn";
            this.typeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.typeDataGridViewCheckBoxColumn.Visible = false;
            // 
            // cartItemBindingSource
            // 
            this.cartItemBindingSource.DataSource = typeof(Entities.CartItem);
            // 
            // bottompanel
            // 
            this.bottompanel.Controls.Add(this.lbTotal);
            this.bottompanel.Controls.Add(this.lbDisc);
            this.bottompanel.Controls.Add(this.btnAddCustomer);
            this.bottompanel.Controls.Add(this.lbInvoice);
            this.bottompanel.Controls.Add(this.lbCustomer);
            this.bottompanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottompanel.Location = new System.Drawing.Point(230, 373);
            this.bottompanel.Name = "bottompanel";
            this.bottompanel.Size = new System.Drawing.Size(755, 82);
            this.bottompanel.TabIndex = 1;
            this.bottompanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bottompanel_Paint);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(386, 49);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(87, 20);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "Total: 0.00";
            // 
            // lbDisc
            // 
            this.lbDisc.AutoSize = true;
            this.lbDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisc.Location = new System.Drawing.Point(386, 19);
            this.lbDisc.Name = "lbDisc";
            this.lbDisc.Size = new System.Drawing.Size(95, 20);
            this.lbDisc.TabIndex = 2;
            this.lbDisc.Text = "Discount: 0";
            // 
            // lbInvoice
            // 
            this.lbInvoice.AutoSize = true;
            this.lbInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvoice.Location = new System.Drawing.Point(6, 49);
            this.lbInvoice.Name = "lbInvoice";
            this.lbInvoice.Size = new System.Drawing.Size(203, 20);
            this.lbInvoice.TabIndex = 1;
            this.lbInvoice.Text = "Invoice: 00000000-FAC";
            // 
            // CartFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bottompanel);
            this.Controls.Add(this.viewpanel);
            this.Controls.Add(this.leftpanel);
            this.Controls.Add(this.toppanel);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "CartFrm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(995, 465);
            this.Load += new System.EventHandler(this.CartFrm_Load);
            this.BackColorChanged += new System.EventHandler(this.CartFrm_BackColorChanged);
            this.toppanel.ResumeLayout(false);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.viewpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartItemBindingSource)).EndInit();
            this.bottompanel.ResumeLayout(false);
            this.bottompanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Panel leftpanel;
        private System.Windows.Forms.Panel viewpanel;
        private System.Windows.Forms.Panel bottompanel;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btnDescount;
        private DevExpress.XtraEditors.SimpleButton btnService;
        private GUIHelper.GTxt txtBarcode;
        private DevExpress.XtraEditors.SimpleButton btnAddCustomer;
        private DevExpress.XtraEditors.SimpleButton btnPay;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource cartItemBindingSource;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbInvoice;
        private System.Windows.Forms.Label lbDisc;
        private System.Windows.Forms.Label lbTotal;
        private GUIHelper.GButton btnGenerateInv;
    }
}
