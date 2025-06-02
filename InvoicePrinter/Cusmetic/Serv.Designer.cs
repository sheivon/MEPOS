namespace InvoicePrinter.Cusmetic
{
    partial class Serv
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Serv));
            this.DGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURENCY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDTOCART = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSeach = new GUIHelper.GTxt();
            this.BTNADDNEW = new GUIHelper.GButton(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btncls = new GUIHelper.GButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AutoGenerateColumns = false;
            this.DGV.BackgroundColor = System.Drawing.Color.Gray;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV.ColumnHeadersHeight = 30;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.curDataGridViewTextBoxColumn,
            this.typeDataGridViewCheckBoxColumn,
            this.activeDataGridViewCheckBoxColumn});
            this.DGV.DataSource = this.productsBindingSource;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.GridColor = System.Drawing.Color.Silver;
            this.DGV.Location = new System.Drawing.Point(10, 72);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 42;
            this.DGV.RowTemplate.ReadOnly = true;
            this.DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.ShowCellErrors = false;
            this.DGV.ShowCellToolTips = false;
            this.DGV.ShowEditingIcon = false;
            this.DGV.ShowRowErrors = false;
            this.DGV.Size = new System.Drawing.Size(884, 351);
            this.DGV.TabIndex = 5;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            this.stockDataGridViewTextBoxColumn.Visible = false;
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
            // typeDataGridViewCheckBoxColumn
            // 
            this.typeDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewCheckBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewCheckBoxColumn.HeaderText = "IsProduct";
            this.typeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewCheckBoxColumn.Name = "typeDataGridViewCheckBoxColumn";
            this.typeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.typeDataGridViewCheckBoxColumn.Visible = false;
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
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(Entities.Products);
            // 
            // IDO
            // 
            this.IDO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IDO.HeaderText = "ID";
            this.IDO.MinimumWidth = 6;
            this.IDO.Name = "IDO";
            this.IDO.ReadOnly = true;
            this.IDO.Visible = false;
            this.IDO.Width = 125;
            // 
            // DESC
            // 
            this.DESC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESC.HeaderText = "SERVICES DESCRIPTION";
            this.DESC.MinimumWidth = 6;
            this.DESC.Name = "DESC";
            this.DESC.ReadOnly = true;
            // 
            // PRICES
            // 
            this.PRICES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRICES.HeaderText = "PRICES";
            this.PRICES.MinimumWidth = 6;
            this.PRICES.Name = "PRICES";
            this.PRICES.ReadOnly = true;
            this.PRICES.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CURENCY
            // 
            this.CURENCY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            this.CURENCY.DefaultCellStyle = dataGridViewCellStyle1;
            this.CURENCY.HeaderText = "MONEY";
            this.CURENCY.MaxInputLength = 5;
            this.CURENCY.MinimumWidth = 6;
            this.CURENCY.Name = "CURENCY";
            this.CURENCY.ReadOnly = true;
            // 
            // ADDTOCART
            // 
            this.ADDTOCART.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ADDTOCART.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADDTOCART.HeaderText = "ADD TO CART";
            this.ADDTOCART.MinimumWidth = 6;
            this.ADDTOCART.Name = "ADDTOCART";
            this.ADDTOCART.ReadOnly = true;
            this.ADDTOCART.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ADDTOCART.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtSeach
            // 
            this.txtSeach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSeach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeach.Location = new System.Drawing.Point(60, 30);
            this.txtSeach.Margin = new System.Windows.Forms.Padding(5);
            this.txtSeach.MaxLength = 50;
            this.txtSeach.Name = "txtSeach";
            this.txtSeach.Size = new System.Drawing.Size(824, 28);
            this.txtSeach.TabIndex = 1;
            this.txtSeach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSeach.WatermarkText = "Search Offering Services for Customer";
            this.txtSeach.TextChanged += new System.EventHandler(this.txtSeach_TextChanged);
            this.txtSeach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Serv_KeyDown);
            this.txtSeach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // BTNADDNEW
            // 
            this.BTNADDNEW.Dock = System.Windows.Forms.DockStyle.Left;
            this.BTNADDNEW.FlatAppearance.BorderSize = 0;
            this.BTNADDNEW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BTNADDNEW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.BTNADDNEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNADDNEW.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTNADDNEW.Location = new System.Drawing.Point(0, 0);
            this.BTNADDNEW.Margin = new System.Windows.Forms.Padding(0);
            this.BTNADDNEW.MaximumSize = new System.Drawing.Size(60, 58);
            this.BTNADDNEW.Name = "BTNADDNEW";
            this.BTNADDNEW.Size = new System.Drawing.Size(60, 58);
            this.BTNADDNEW.TabIndex = 2;
            this.BTNADDNEW.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BTNADDNEW.UIStyle = GUIHelper.GButton.Style.Flat;
            this.BTNADDNEW.UseVisualStyleBackColor = true;
            this.BTNADDNEW.Click += new System.EventHandler(this.BTNADDNEW_Click);
            this.BTNADDNEW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Serv_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSeach);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BTNADDNEW);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 59);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 0);
            this.label1.MinimumSize = new System.Drawing.Size(814, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(824, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Customer Service\'s to Cart ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.label1_PreviewKeyDown);
            // 
            // btncls
            // 
            this.btncls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncls.BackColor = System.Drawing.Color.Red;
            this.btncls.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btncls.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btncls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncls.Location = new System.Drawing.Point(865, -2);
            this.btncls.Margin = new System.Windows.Forms.Padding(0);
            this.btncls.MaximumSize = new System.Drawing.Size(38, 40);
            this.btncls.MinimumSize = new System.Drawing.Size(38, 40);
            this.btncls.Name = "btncls";
            this.btncls.Size = new System.Drawing.Size(38, 40);
            this.btncls.TabIndex = 4;
            this.btncls.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btncls.UIStyle = GUIHelper.GButton.Style.Cicle;
            this.btncls.UseVisualStyleBackColor = false;
            this.btncls.Click += new System.EventHandler(this.btncls_Click);
            // 
            // Serv
            // 
            this.ClientSize = new System.Drawing.Size(904, 433);
            this.Controls.Add(this.btncls);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(904, 433);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(904, 433);
            this.Name = "Serv";
            this.Opacity = 0.99D;
            this.Padding = new System.Windows.Forms.Padding(10, 13, 10, 10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Serv_Load);
            this.BackColorChanged += new System.EventHandler(this.Serv_BackColorChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Serv_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private GUIHelper.GTxt txtSeach;
        private GUIHelper.GButton BTNADDNEW;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private GUIHelper.GButton btncls;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICES;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURENCY;
        private System.Windows.Forms.DataGridViewButtonColumn ADDTOCART;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
    }
}
