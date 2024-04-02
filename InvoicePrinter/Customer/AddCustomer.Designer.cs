namespace InvoicePrinter.Customer
{
    partial class AddCustomer
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
            this.GENDERCBX = new System.Windows.Forms.ComboBox();
            this.LLOCATION = new GUIHelper.GTxt();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new GUIHelper.GButton(this.components);
            this.Cancel_Button = new GUIHelper.GButton(this.components);
            this.OW = new GUIHelper.GTxt();
            this.NATIONALITY = new GUIHelper.GTxt();
            this.lbid = new System.Windows.Forms.Label();
            this.MOBILE = new GUIHelper.GTxt();
            this.IDNUMBER = new GUIHelper.GTxt();
            this.SRNAME = new GUIHelper.GTxt();
            this.USERNAME = new GUIHelper.GTxt();
            this.cbBlockedusers = new System.Windows.Forms.CheckBox();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GENDERCBX
            // 
            this.GENDERCBX.FormattingEnabled = true;
            this.GENDERCBX.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.GENDERCBX.Location = new System.Drawing.Point(516, 90);
            this.GENDERCBX.Name = "GENDERCBX";
            this.GENDERCBX.Size = new System.Drawing.Size(229, 24);
            this.GENDERCBX.TabIndex = 29;
            this.GENDERCBX.Text = "SELECT GENDER";
            // 
            // LLOCATION
            // 
            this.LLOCATION.ForeColor = System.Drawing.Color.DarkOrchid;
            this.LLOCATION.Location = new System.Drawing.Point(281, 146);
            this.LLOCATION.Name = "LLOCATION";
            this.LLOCATION.Size = new System.Drawing.Size(229, 22);
            this.LLOCATION.TabIndex = 27;
            this.LLOCATION.WatermarkText = "LOCATION";
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(10, 214);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(854, 50);
            this.TableLayoutPanel1.TabIndex = 31;
            // 
            // OK_Button
            // 
            this.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_Button.Location = new System.Drawing.Point(3, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(421, 44);
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
            this.Cancel_Button.Location = new System.Drawing.Point(430, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(421, 44);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UIStyle = GUIHelper.GButton.Style.Flat;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // OW
            // 
            this.OW.ForeColor = System.Drawing.Color.DarkOrchid;
            this.OW.Location = new System.Drawing.Point(516, 120);
            this.OW.Name = "OW";
            this.OW.Size = new System.Drawing.Size(229, 22);
            this.OW.TabIndex = 32;
            this.OW.WatermarkText = "OWING";
            this.OW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OW_KeyPress);
            // 
            // NATIONALITY
            // 
            this.NATIONALITY.ForeColor = System.Drawing.Color.DarkOrchid;
            this.NATIONALITY.Location = new System.Drawing.Point(281, 118);
            this.NATIONALITY.Name = "NATIONALITY";
            this.NATIONALITY.Size = new System.Drawing.Size(229, 22);
            this.NATIONALITY.TabIndex = 28;
            this.NATIONALITY.WatermarkText = "NATIONALITY";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid.Location = new System.Drawing.Point(27, 41);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(83, 31);
            this.lbid.TabIndex = 22;
            this.lbid.Text = "ID:{0}";
            // 
            // MOBILE
            // 
            this.MOBILE.ForeColor = System.Drawing.Color.DarkOrchid;
            this.MOBILE.Location = new System.Drawing.Point(281, 90);
            this.MOBILE.Name = "MOBILE";
            this.MOBILE.Size = new System.Drawing.Size(229, 22);
            this.MOBILE.TabIndex = 26;
            this.MOBILE.WatermarkText = "MOBILE";
            this.MOBILE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OW_KeyPress);
            // 
            // IDNUMBER
            // 
            this.IDNUMBER.ForeColor = System.Drawing.Color.DarkOrchid;
            this.IDNUMBER.Location = new System.Drawing.Point(46, 142);
            this.IDNUMBER.Name = "IDNUMBER";
            this.IDNUMBER.Size = new System.Drawing.Size(229, 22);
            this.IDNUMBER.TabIndex = 25;
            this.IDNUMBER.WatermarkText = "ID NUMBER";
            this.IDNUMBER.TextChanged += new System.EventHandler(this.IDNUMBER_TextChanged);
            // 
            // SRNAME
            // 
            this.SRNAME.ForeColor = System.Drawing.Color.DarkOrchid;
            this.SRNAME.Location = new System.Drawing.Point(46, 118);
            this.SRNAME.Name = "SRNAME";
            this.SRNAME.Size = new System.Drawing.Size(229, 22);
            this.SRNAME.TabIndex = 24;
            this.SRNAME.WatermarkText = "SR.NAME";
            // 
            // USERNAME
            // 
            this.USERNAME.ForeColor = System.Drawing.Color.DarkOrchid;
            this.USERNAME.Location = new System.Drawing.Point(46, 90);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(229, 22);
            this.USERNAME.TabIndex = 23;
            this.USERNAME.WatermarkText = "NAME";
            // 
            // cbBlockedusers
            // 
            this.cbBlockedusers.AutoSize = true;
            this.cbBlockedusers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBlockedusers.Location = new System.Drawing.Point(516, 148);
            this.cbBlockedusers.Name = "cbBlockedusers";
            this.cbBlockedusers.Size = new System.Drawing.Size(194, 29);
            this.cbBlockedusers.TabIndex = 33;
            this.cbBlockedusers.Text = "Blocked Customer";
            this.cbBlockedusers.UseVisualStyleBackColor = true;
            // 
            // AddCustomer
            // 
            this.ClientSize = new System.Drawing.Size(874, 274);
            this.Controls.Add(this.cbBlockedusers);
            this.Controls.Add(this.GENDERCBX);
            this.Controls.Add(this.LLOCATION);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.OW);
            this.Controls.Add(this.NATIONALITY);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.MOBILE);
            this.Controls.Add(this.IDNUMBER);
            this.Controls.Add(this.SRNAME);
            this.Controls.Add(this.USERNAME);
            this.MaximumSize = new System.Drawing.Size(874, 274);
            this.MinimumSize = new System.Drawing.Size(874, 274);
            this.Name = "AddCustomer";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox GENDERCBX;
        internal GUIHelper.GTxt LLOCATION;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal GUIHelper.GButton OK_Button;
        internal GUIHelper.GButton Cancel_Button;
        internal GUIHelper.GTxt OW;
        internal GUIHelper.GTxt NATIONALITY;
        internal System.Windows.Forms.Label lbid;
        internal GUIHelper.GTxt MOBILE;
        internal GUIHelper.GTxt IDNUMBER;
        internal GUIHelper.GTxt SRNAME;
        internal GUIHelper.GTxt USERNAME;
        internal System.Windows.Forms.CheckBox cbBlockedusers;
    }
}
