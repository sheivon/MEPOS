namespace InvoicePrinter.Product
{
    partial class frmCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategory));
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.DGV_Cat = new System.Windows.Forms.DataGridView();
            this.toppanel = new System.Windows.Forms.Panel();
            this.cbxActive = new System.Windows.Forms.CheckBox();
            this.btnSaveCat = new GUIHelper.GButton(this.components);
            this.txtCategory = new GUIHelper.GTextbox();
            this.btnClear = new GUIHelper.GButton(this.components);
            this.grp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cat)).BeginInit();
            this.toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.DGV_Cat);
            this.grp1.Controls.Add(this.toppanel);
            this.grp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp1.Location = new System.Drawing.Point(10, 10);
            this.grp1.Name = "grp1";
            this.grp1.Padding = new System.Windows.Forms.Padding(10);
            this.grp1.Size = new System.Drawing.Size(980, 445);
            this.grp1.TabIndex = 0;
            this.grp1.TabStop = false;
            this.grp1.Text = "Category";
            // 
            // DGV_Cat
            // 
            this.DGV_Cat.AllowUserToAddRows = false;
            this.DGV_Cat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Cat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Cat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Cat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_Cat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Cat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_Cat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Cat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Cat.ColumnHeadersHeight = 40;
            this.DGV_Cat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Cat.EnableHeadersVisualStyles = false;
            this.DGV_Cat.Location = new System.Drawing.Point(10, 116);
            this.DGV_Cat.MultiSelect = false;
            this.DGV_Cat.Name = "DGV_Cat";
            this.DGV_Cat.ReadOnly = true;
            this.DGV_Cat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Cat.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Cat.RowHeadersVisible = false;
            this.DGV_Cat.RowHeadersWidth = 10;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Cat.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Cat.RowTemplate.Height = 40;
            this.DGV_Cat.RowTemplate.ReadOnly = true;
            this.DGV_Cat.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Cat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Cat.ShowEditingIcon = false;
            this.DGV_Cat.Size = new System.Drawing.Size(960, 319);
            this.DGV_Cat.TabIndex = 26;
            this.DGV_Cat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Cat_CellClick);
            // 
            // toppanel
            // 
            this.toppanel.Controls.Add(this.cbxActive);
            this.toppanel.Controls.Add(this.btnClear);
            this.toppanel.Controls.Add(this.btnSaveCat);
            this.toppanel.Controls.Add(this.txtCategory);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(10, 25);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(960, 91);
            this.toppanel.TabIndex = 0;
            // 
            // cbxActive
            // 
            this.cbxActive.AutoSize = true;
            this.cbxActive.Location = new System.Drawing.Point(488, 37);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(66, 20);
            this.cbxActive.TabIndex = 2;
            this.cbxActive.Text = "Active";
            this.cbxActive.UseVisualStyleBackColor = true;
            // 
            // btnSaveCat
            // 
            this.btnSaveCat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnSaveCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnSaveCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCat.Location = new System.Drawing.Point(594, 31);
            this.btnSaveCat.Name = "btnSaveCat";
            this.btnSaveCat.Size = new System.Drawing.Size(94, 30);
            this.btnSaveCat.TabIndex = 1;
            this.btnSaveCat.Text = "Save";
            this.btnSaveCat.UIStyle = GUIHelper.GButton.Style.Flat;
            this.btnSaveCat.UseVisualStyleBackColor = true;
            this.btnSaveCat.Click += new System.EventHandler(this.btnSaveCat_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Cue = "Category";
            this.txtCategory.Location = new System.Drawing.Point(138, 35);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(329, 22);
            this.txtCategory.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(705, 31);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 30);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UIStyle = GUIHelper.GButton.Style.Flat;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 465);
            this.Controls.Add(this.grp1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCategory";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Category";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.grp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cat)).EndInit();
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.Panel toppanel;
        private GUIHelper.GButton btnSaveCat;
        private GUIHelper.GTextbox txtCategory;
        private System.Windows.Forms.DataGridView DGV_Cat;
        private System.Windows.Forms.CheckBox cbxActive;
        private GUIHelper.GButton btnClear;
    }
}