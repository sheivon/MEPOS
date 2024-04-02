namespace InvoicePrinter.Product
{
    partial class Printbarcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Printbarcode));
            this.GButton1 = new GUIHelper.GButton(this.components);
            this.GTxt1 = new GUIHelper.GTxt();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.gButton2 = new GUIHelper.GButton(this.components);
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.Wsize = new System.Windows.Forms.NumericUpDown();
            this.HSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // GButton1
            // 
            this.GButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.GButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.GButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.GButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GButton1.Location = new System.Drawing.Point(10, 259);
            this.GButton1.Name = "GButton1";
            this.GButton1.Size = new System.Drawing.Size(384, 59);
            this.GButton1.TabIndex = 1;
            this.GButton1.Text = "Print";
            this.GButton1.UIStyle = GUIHelper.GButton.Style.Flat;
            this.GButton1.UseVisualStyleBackColor = true;
            this.GButton1.Click += new System.EventHandler(this.GButton1_Click);
            // 
            // GTxt1
            // 
            this.GTxt1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GTxt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GTxt1.Location = new System.Drawing.Point(39, 219);
            this.GTxt1.Name = "GTxt1";
            this.GTxt1.Size = new System.Drawing.Size(318, 34);
            this.GTxt1.TabIndex = 0;
            this.GTxt1.WatermarkText = "Generate BarCode";
            this.GTxt1.TextChanged += new System.EventHandler(this.GTxt1_TextChanged);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(39, 39);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(318, 123);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 12;
            this.PictureBox1.TabStop = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // gButton2
            // 
            this.gButton2.BackColor = System.Drawing.Color.Red;
            this.gButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.gButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.gButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gButton2.Location = new System.Drawing.Point(378, 3);
            this.gButton2.Name = "gButton2";
            this.gButton2.Size = new System.Drawing.Size(24, 25);
            this.gButton2.TabIndex = 13;
            this.gButton2.UIStyle = GUIHelper.GButton.Style.Cicle;
            this.gButton2.UseVisualStyleBackColor = false;
            this.gButton2.Click += new System.EventHandler(this.gButton2_Click);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(39, 13);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(95, 20);
            this.cb1.TabIndex = 14;
            this.cb1.Text = "Print Label ";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Wsize
            // 
            this.Wsize.Location = new System.Drawing.Point(39, 192);
            this.Wsize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Wsize.Name = "Wsize";
            this.Wsize.Size = new System.Drawing.Size(120, 22);
            this.Wsize.TabIndex = 15;
            this.Wsize.ValueChanged += new System.EventHandler(this.Wsize_ValueChanged);
            // 
            // HSize
            // 
            this.HSize.Location = new System.Drawing.Point(165, 192);
            this.HSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.HSize.Name = "HSize";
            this.HSize.Size = new System.Drawing.Size(120, 22);
            this.HSize.TabIndex = 16;
            this.HSize.ValueChanged += new System.EventHandler(this.HSize_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "W";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "H";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Amount";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(291, 192);
            this.amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(66, 22);
            this.amount.TabIndex = 19;
            this.amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amount.ValueChanged += new System.EventHandler(this.amount_ValueChanged);
            // 
            // Printbarcode
            // 
            this.ClientSize = new System.Drawing.Size(404, 328);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HSize);
            this.Controls.Add(this.Wsize);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.gButton2);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.GButton1);
            this.Controls.Add(this.GTxt1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(404, 328);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(404, 328);
            this.Name = "Printbarcode";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Load += new System.EventHandler(this.Printbarcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal GUIHelper.GButton GButton1;
        internal GUIHelper.GTxt GTxt1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private GUIHelper.GButton gButton2;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.NumericUpDown Wsize;
        private System.Windows.Forms.NumericUpDown HSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown amount;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}
