namespace InvoicePrinter.Employees
{
    partial class UsersDX
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
            this.cbxactive = new System.Windows.Forms.ComboBox();
            this.cbxrole = new System.Windows.Forms.ComboBox();
            this.cbxgender = new System.Windows.Forms.ComboBox();
            this.txtusrlogin = new GUIHelper.GTxt();
            this.txtdir = new GUIHelper.GTxt();
            this.txtpass = new GUIHelper.GTxt();
            this.txtnat = new GUIHelper.GTxt();
            this.txthireddate = new GUIHelper.GTxt();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new GUIHelper.GButton(this.components);
            this.Cancel_Button = new GUIHelper.GButton(this.components);
            this.lbid = new System.Windows.Forms.Label();
            this.txtcel = new GUIHelper.GTxt();
            this.txtIDnumber = new GUIHelper.GTxt();
            this.txtsrname = new GUIHelper.GTxt();
            this.txtusrname = new GUIHelper.GTxt();
            this.btnShowPass = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxactive
            // 
            this.cbxactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxactive.FormattingEnabled = true;
            this.cbxactive.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbxactive.Location = new System.Drawing.Point(703, 217);
            this.cbxactive.Name = "cbxactive";
            this.cbxactive.Size = new System.Drawing.Size(203, 28);
            this.cbxactive.TabIndex = 26;
            this.cbxactive.Text = "FIRED";
            // 
            // cbxrole
            // 
            this.cbxrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxrole.FormattingEnabled = true;
            this.cbxrole.Items.AddRange(new object[] {
            "SYSTEMADMINISTRATOR",
            "CASHIER"});
            this.cbxrole.Location = new System.Drawing.Point(703, 177);
            this.cbxrole.Name = "cbxrole";
            this.cbxrole.Size = new System.Drawing.Size(203, 28);
            this.cbxrole.TabIndex = 25;
            this.cbxrole.Text = "USER ROLE";
            // 
            // cbxgender
            // 
            this.cbxgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxgender.FormattingEnabled = true;
            this.cbxgender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cbxgender.Location = new System.Drawing.Point(703, 135);
            this.cbxgender.Name = "cbxgender";
            this.cbxgender.Size = new System.Drawing.Size(203, 28);
            this.cbxgender.TabIndex = 24;
            this.cbxgender.Text = "SELECT GENDER";
            // 
            // txtusrlogin
            // 
            this.txtusrlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusrlogin.Location = new System.Drawing.Point(28, 27);
            this.txtusrlogin.MaxLength = 30;
            this.txtusrlogin.Name = "txtusrlogin";
            this.txtusrlogin.Size = new System.Drawing.Size(243, 26);
            this.txtusrlogin.TabIndex = 21;
            this.txtusrlogin.WatermarkText = "LOGIN";
            // 
            // txtdir
            // 
            this.txtdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdir.Location = new System.Drawing.Point(19, 135);
            this.txtdir.Name = "txtdir";
            this.txtdir.Size = new System.Drawing.Size(203, 26);
            this.txtdir.TabIndex = 20;
            this.txtdir.WatermarkText = "LOCATION";
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(288, 26);
            this.txtpass.MaxLength = 30;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(243, 26);
            this.txtpass.TabIndex = 22;
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.WatermarkText = "PASSWORD";
            // 
            // txtnat
            // 
            this.txtnat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnat.Location = new System.Drawing.Point(463, 81);
            this.txtnat.Name = "txtnat";
            this.txtnat.Size = new System.Drawing.Size(219, 26);
            this.txtnat.TabIndex = 19;
            this.txtnat.WatermarkText = "NATIONALITY";
            // 
            // txthireddate
            // 
            this.txthireddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthireddate.Location = new System.Drawing.Point(703, 81);
            this.txthireddate.Name = "txthireddate";
            this.txthireddate.Size = new System.Drawing.Size(203, 26);
            this.txthireddate.TabIndex = 23;
            this.txthireddate.WatermarkText = "HIRED DATE";
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 6;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 4, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(10, 264);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(950, 55);
            this.TableLayoutPanel1.TabIndex = 27;
            this.TableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // OK_Button
            // 
            this.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_Button.Image = global::InvoicePrinter.Properties.Resources.Ok__2_;
            this.OK_Button.Location = new System.Drawing.Point(33, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(282, 49);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OK_Button.UIStyle = GUIHelper.GButton.Style.Flat;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Button.Location = new System.Drawing.Point(635, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(282, 49);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UIStyle = GUIHelper.GButton.Style.Flat;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid.Location = new System.Drawing.Point(13, 19);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(83, 31);
            this.lbid.TabIndex = 14;
            this.lbid.Tag = "0";
            this.lbid.Text = "ID:{0}";
            // 
            // txtcel
            // 
            this.txtcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcel.Location = new System.Drawing.Point(463, 137);
            this.txtcel.MaxLength = 20;
            this.txtcel.Name = "txtcel";
            this.txtcel.Size = new System.Drawing.Size(219, 26);
            this.txtcel.TabIndex = 18;
            this.txtcel.WatermarkText = "MOBILE";
            // 
            // txtIDnumber
            // 
            this.txtIDnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDnumber.Location = new System.Drawing.Point(241, 135);
            this.txtIDnumber.MaxLength = 30;
            this.txtIDnumber.Name = "txtIDnumber";
            this.txtIDnumber.Size = new System.Drawing.Size(205, 26);
            this.txtIDnumber.TabIndex = 17;
            this.txtIDnumber.WatermarkText = "ID NUMBER";
            // 
            // txtsrname
            // 
            this.txtsrname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsrname.Location = new System.Drawing.Point(243, 81);
            this.txtsrname.MaxLength = 50;
            this.txtsrname.Name = "txtsrname";
            this.txtsrname.Size = new System.Drawing.Size(203, 26);
            this.txtsrname.TabIndex = 16;
            this.txtsrname.WatermarkText = "SR.NAME";
            // 
            // txtusrname
            // 
            this.txtusrname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusrname.Location = new System.Drawing.Point(19, 81);
            this.txtusrname.MaxLength = 50;
            this.txtusrname.Name = "txtusrname";
            this.txtusrname.Size = new System.Drawing.Size(203, 26);
            this.txtusrname.TabIndex = 15;
            this.txtusrname.WatermarkText = "NAME";
            // 
            // btnShowPass
            // 
            this.btnShowPass.AutoSize = true;
            this.btnShowPass.Location = new System.Drawing.Point(288, 58);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(125, 20);
            this.btnShowPass.TabIndex = 28;
            this.btnShowPass.Text = "Show Password";
            this.btnShowPass.UseVisualStyleBackColor = true;
            this.btnShowPass.CheckedChanged += new System.EventHandler(this.btnShowPass_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtusrlogin);
            this.groupBox1.Controls.Add(this.btnShowPass);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Location = new System.Drawing.Point(54, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 87);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // UsersDX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 329);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxactive);
            this.Controls.Add(this.cbxrole);
            this.Controls.Add(this.cbxgender);
            this.Controls.Add(this.txtdir);
            this.Controls.Add(this.txtnat);
            this.Controls.Add(this.txthireddate);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.txtcel);
            this.Controls.Add(this.txtIDnumber);
            this.Controls.Add(this.txtsrname);
            this.Controls.Add(this.txtusrname);
            this.MaximumSize = new System.Drawing.Size(970, 370);
            this.MinimumSize = new System.Drawing.Size(770, 270);
            this.Name = "UsersDX";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "UsersDX";
            this.Load += new System.EventHandler(this.UsersDX_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cbxactive;
        internal System.Windows.Forms.ComboBox cbxrole;
        internal System.Windows.Forms.ComboBox cbxgender;
        internal GUIHelper.GTxt txtusrlogin;
        internal GUIHelper.GTxt txtdir;
        internal GUIHelper.GTxt txtpass;
        internal GUIHelper.GTxt txtnat;
        internal GUIHelper.GTxt txthireddate;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal GUIHelper.GButton OK_Button;
        internal GUIHelper.GButton Cancel_Button;
        internal System.Windows.Forms.Label lbid;
        internal GUIHelper.GTxt txtcel;
        internal GUIHelper.GTxt txtIDnumber;
        internal GUIHelper.GTxt txtsrname;
        internal GUIHelper.GTxt txtusrname;
        private System.Windows.Forms.CheckBox btnShowPass;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}