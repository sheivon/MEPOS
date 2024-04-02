namespace InvoicePrinter.Product
{
    partial class ProductEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductEdit));
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new GUIHelper.GButton(this.components);
            this.Cancel_Button = new GUIHelper.GButton(this.components);
            this.lbid = new System.Windows.Forms.Label();
            this.PPrice = new GUIHelper.GTxt();
            this.PInstock = new GUIHelper.GTxt();
            this.Pname = new GUIHelper.GTxt();
            this.Pcode = new GUIHelper.GTxt();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.curselector = new System.Windows.Forms.ComboBox();
            this.cbxtype = new System.Windows.Forms.ComboBox();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(67, 211);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(649, 50);
            this.TableLayoutPanel1.TabIndex = 7;
            // 
            // OK_Button
            // 
            this.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_Button.Location = new System.Drawing.Point(3, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(318, 44);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.UIStyle = GUIHelper.GButton.Style.Flat;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Button.Location = new System.Drawing.Point(327, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(319, 44);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UIStyle = GUIHelper.GButton.Style.Flat;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid.Location = new System.Drawing.Point(62, 32);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(83, 31);
            this.lbid.TabIndex = 12;
            this.lbid.Text = "ID:{0}";
            this.lbid.Visible = false;
            // 
            // PPrice
            // 
            this.PPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.PPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPrice.ForeColor = System.Drawing.Color.DarkOrchid;
            this.PPrice.Location = new System.Drawing.Point(296, 165);
            this.PPrice.MaxLength = 50;
            this.PPrice.Name = "PPrice";
            this.PPrice.Size = new System.Drawing.Size(183, 30);
            this.PPrice.TabIndex = 11;
            this.PPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PPrice.WatermarkText = "Product Price";
            this.PPrice.TextChanged += new System.EventHandler(this.PPrice_TextChanged);
            this.PPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PPrice_KeyPress);
            // 
            // PInstock
            // 
            this.PInstock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.PInstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PInstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PInstock.ForeColor = System.Drawing.Color.DarkOrchid;
            this.PInstock.Location = new System.Drawing.Point(296, 122);
            this.PInstock.MaxLength = 50;
            this.PInstock.Name = "PInstock";
            this.PInstock.Size = new System.Drawing.Size(183, 30);
            this.PInstock.TabIndex = 10;
            this.PInstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PInstock.WatermarkText = "Product Instock";
            this.PInstock.TextChanged += new System.EventHandler(this.PInstock_TextChanged);
            this.PInstock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PInstock_KeyPress);
            // 
            // Pname
            // 
            this.Pname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Pname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pname.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Pname.Location = new System.Drawing.Point(103, 165);
            this.Pname.MaxLength = 50;
            this.Pname.Name = "Pname";
            this.Pname.Size = new System.Drawing.Size(183, 30);
            this.Pname.TabIndex = 9;
            this.Pname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pname.WatermarkText = "Product Name";
            this.Pname.TextChanged += new System.EventHandler(this.Pname_TextChanged);
            // 
            // Pcode
            // 
            this.Pcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Pcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pcode.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Pcode.Location = new System.Drawing.Point(103, 122);
            this.Pcode.MaxLength = 100;
            this.Pcode.Name = "Pcode";
            this.Pcode.Size = new System.Drawing.Size(183, 30);
            this.Pcode.TabIndex = 8;
            this.Pcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pcode.WatermarkText = "Product Code";
            this.Pcode.TextChanged += new System.EventHandler(this.Pcode_TextChanged);
            this.Pcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pcode_KeyDown);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(242, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(341, 83);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 13;
            this.PictureBox1.TabStop = false;
            // 
            // curselector
            // 
            this.curselector.BackColor = System.Drawing.Color.Gray;
            this.curselector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.curselector.FormattingEnabled = true;
            this.curselector.ItemHeight = 16;
            this.curselector.Items.AddRange(new object[] {
            "C$",
            "$",
            "€"});
            this.curselector.Location = new System.Drawing.Point(485, 122);
            this.curselector.MaxDropDownItems = 5;
            this.curselector.Name = "curselector";
            this.curselector.Size = new System.Drawing.Size(183, 24);
            this.curselector.TabIndex = 14;
            this.curselector.Text = "MONEY";
            this.curselector.SelectedIndexChanged += new System.EventHandler(this.curselector_SelectedIndexChanged);
            // 
            // cbxtype
            // 
            this.cbxtype.BackColor = System.Drawing.Color.Gray;
            this.cbxtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxtype.FormattingEnabled = true;
            this.cbxtype.ItemHeight = 16;
            this.cbxtype.Items.AddRange(new object[] {
            "PRODUCT",
            "SERVICE"});
            this.cbxtype.Location = new System.Drawing.Point(485, 165);
            this.cbxtype.MaxDropDownItems = 5;
            this.cbxtype.Name = "cbxtype";
            this.cbxtype.Size = new System.Drawing.Size(183, 24);
            this.cbxtype.TabIndex = 16;
            this.cbxtype.Text = "TYPE";
            this.cbxtype.SelectedIndexChanged += new System.EventHandler(this.cbxtype_SelectedIndexChanged);
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Checked = true;
            this.cbActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActive.ForeColor = System.Drawing.Color.White;
            this.cbActive.Location = new System.Drawing.Point(663, 66);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(88, 29);
            this.cbActive.TabIndex = 17;
            this.cbActive.Text = "Active";
            this.cbActive.UseVisualStyleBackColor = true;
            this.cbActive.CheckStateChanged += new System.EventHandler(this.cbActive_CheckStateChanged);
            // 
            // ProductEdit
            // 
            this.AcceptButton = this.OK_Button;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(780, 273);
            this.Controls.Add(this.cbActive);
            this.Controls.Add(this.cbxtype);
            this.Controls.Add(this.curselector);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.PPrice);
            this.Controls.Add(this.PInstock);
            this.Controls.Add(this.Pname);
            this.Controls.Add(this.Pcode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(780, 273);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(780, 273);
            this.Name = "ProductEdit";
            this.Load += new System.EventHandler(this.ProductEdit_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal GUIHelper.GButton OK_Button;
        internal GUIHelper.GButton Cancel_Button;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label lbid;
        internal GUIHelper.GTxt PPrice;
        internal GUIHelper.GTxt PInstock;
        internal GUIHelper.GTxt Pname;
        internal GUIHelper.GTxt Pcode;
        private System.Windows.Forms.ComboBox curselector;
        private System.Windows.Forms.ComboBox cbxtype;
        private System.Windows.Forms.CheckBox cbActive;
    }
}
