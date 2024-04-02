using GUIHelper;

namespace InvoicePrinter.Product
{
    partial class Productsfrm
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
            this.Panel2 = new System.Windows.Forms.Panel();
            this.btnMoney = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintProd = new DevExpress.XtraEditors.SimpleButton();
            this.btnViewBarcode = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewProd = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearchCustomer = new GUIHelper.GTxt();
            this.Label2 = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Edt = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.btnMoney);
            this.Panel2.Controls.Add(this.btnPrintProd);
            this.Panel2.Controls.Add(this.btnViewBarcode);
            this.Panel2.Controls.Add(this.btnNewProd);
            this.Panel2.Controls.Add(this.txtSearchCustomer);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(5, 5);
            this.Panel2.Name = "Panel2";
            this.Panel2.Padding = new System.Windows.Forms.Padding(40, 2, 40, 0);
            this.Panel2.Size = new System.Drawing.Size(966, 114);
            this.Panel2.TabIndex = 22;
            // 
            // btnMoney
            // 
            this.btnMoney.Location = new System.Drawing.Point(305, 68);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(123, 40);
            this.btnMoney.TabIndex = 26;
            this.btnMoney.Text = "Money";
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // btnPrintProd
            // 
            this.btnPrintProd.ImageOptions.Image = global::InvoicePrinter.Properties.Resources.icons8_Print_30px;
            this.btnPrintProd.Location = new System.Drawing.Point(177, 68);
            this.btnPrintProd.Name = "btnPrintProd";
            this.btnPrintProd.Size = new System.Drawing.Size(120, 40);
            this.btnPrintProd.TabIndex = 25;
            this.btnPrintProd.Text = "Print";
            this.btnPrintProd.Click += new System.EventHandler(this.btnPrintProd_Click);
            // 
            // btnViewBarcode
            // 
            this.btnViewBarcode.ImageOptions.Image = global::InvoicePrinter.Properties.Resources.icons8_Barcode_30px;
            this.btnViewBarcode.Location = new System.Drawing.Point(533, 68);
            this.btnViewBarcode.Name = "btnViewBarcode";
            this.btnViewBarcode.Size = new System.Drawing.Size(159, 40);
            this.btnViewBarcode.TabIndex = 24;
            this.btnViewBarcode.Text = "View Barcode";
            this.btnViewBarcode.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnNewProd
            // 
            this.btnNewProd.ImageOptions.Image = global::InvoicePrinter.Properties.Resources.Plus__2_;
            this.btnNewProd.Location = new System.Drawing.Point(51, 68);
            this.btnNewProd.Name = "btnNewProd";
            this.btnNewProd.Size = new System.Drawing.Size(120, 40);
            this.btnNewProd.TabIndex = 23;
            this.btnNewProd.Text = "New";
            this.btnNewProd.Click += new System.EventHandler(this.btnNewProd_Click);
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.ForeColor = System.Drawing.Color.DarkOrchid;
            this.txtSearchCustomer.Location = new System.Drawing.Point(40, 35);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(886, 30);
            this.txtSearchCustomer.TabIndex = 22;
            this.txtSearchCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchCustomer.WatermarkText = "Search Products via Names | Sr Name | Mobile ";
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // Label2
            // 
            this.Label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(40, 2);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(886, 33);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "Products Details";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AutoGenerateColumns = false;
            this.DGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.curDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn,
            this.Edt});
            this.DGV.DataSource = this.productsBindingSource;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.GridColor = System.Drawing.SystemColors.Control;
            this.DGV.Location = new System.Drawing.Point(5, 119);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.DividerHeight = 2;
            this.DGV.RowTemplate.Height = 40;
            this.DGV.RowTemplate.ReadOnly = true;
            this.DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(966, 475);
            this.DGV.TabIndex = 23;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "BARCODE";
            this.barcodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.barcodeDataGridViewTextBoxColumn.Visible = false;
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
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "AVAILABLE";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "UNIT PRICE";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // curDataGridViewTextBoxColumn
            // 
            this.curDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.curDataGridViewTextBoxColumn.DataPropertyName = "Cur";
            this.curDataGridViewTextBoxColumn.HeaderText = "MONEY";
            this.curDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.curDataGridViewTextBoxColumn.Name = "curDataGridViewTextBoxColumn";
            this.curDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "TYPES";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "ACTIVE";
            this.activeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Edt
            // 
            this.Edt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Edt.HeaderText = "Edit";
            this.Edt.MinimumWidth = 6;
            this.Edt.Name = "Edt";
            this.Edt.ReadOnly = true;
            this.Edt.Text = "Edit";
            this.Edt.UseColumnTextForButtonValue = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(Entities.Products);
            // 
            // Productsfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.Panel2);
            this.Name = "Productsfrm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(976, 599);
            this.Load += new System.EventHandler(this.Productsfrm_Load);
            this.BackColorChanged += new System.EventHandler(this.Productsfrm_BackColorChanged);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel2;
        private GUIHelper.GTxt txtSearchCustomer;
        private System.Windows.Forms.Label Label2;
        private DevExpress.XtraEditors.SimpleButton btnNewProd;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnViewBarcode;
        private DevExpress.XtraEditors.SimpleButton btnPrintProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edt;
        private DevExpress.XtraEditors.SimpleButton btnMoney;
    }
}
