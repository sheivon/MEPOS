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
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new GUIHelper.GButton(this.components);
            this.Cancel_Button = new GUIHelper.GButton(this.components);
            this.lbid = new System.Windows.Forms.Label();
            this.MOBILE = new GUIHelper.GTxt();
            this.IDNUMBER = new GUIHelper.GTxt();
            this.SRNAME = new GUIHelper.GTxt();
            this.USERNAME = new GUIHelper.GTxt();
            this.EMAIL = new GUIHelper.GTxt();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(10, 186);
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
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid.Location = new System.Drawing.Point(27, 29);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(83, 31);
            this.lbid.TabIndex = 22;
            this.lbid.Text = "ID:{0}";
            // 
            // MOBILE
            // 
            this.MOBILE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MOBILE.ForeColor = System.Drawing.Color.DarkOrchid;
            this.MOBILE.Location = new System.Drawing.Point(455, 61);
            this.MOBILE.Name = "MOBILE";
            this.MOBILE.Size = new System.Drawing.Size(305, 27);
            this.MOBILE.TabIndex = 26;
            this.MOBILE.WatermarkText = "Telephone";
            this.MOBILE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OW_KeyPress);
            // 
            // IDNUMBER
            // 
            this.IDNUMBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDNUMBER.ForeColor = System.Drawing.Color.DarkOrchid;
            this.IDNUMBER.Location = new System.Drawing.Point(455, 98);
            this.IDNUMBER.Name = "IDNUMBER";
            this.IDNUMBER.Size = new System.Drawing.Size(305, 27);
            this.IDNUMBER.TabIndex = 25;
            this.IDNUMBER.WatermarkText = "Cedula";
            this.IDNUMBER.TextChanged += new System.EventHandler(this.IDNUMBER_TextChanged);
            // 
            // SRNAME
            // 
            this.SRNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SRNAME.ForeColor = System.Drawing.Color.DarkOrchid;
            this.SRNAME.Location = new System.Drawing.Point(129, 98);
            this.SRNAME.Name = "SRNAME";
            this.SRNAME.Size = new System.Drawing.Size(305, 27);
            this.SRNAME.TabIndex = 24;
            this.SRNAME.WatermarkText = "Last Name";
            // 
            // USERNAME
            // 
            this.USERNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAME.ForeColor = System.Drawing.Color.DarkOrchid;
            this.USERNAME.Location = new System.Drawing.Point(129, 61);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(305, 27);
            this.USERNAME.TabIndex = 23;
            this.USERNAME.WatermarkText = "First Name";
            // 
            // EMAIL
            // 
            this.EMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMAIL.ForeColor = System.Drawing.Color.DarkOrchid;
            this.EMAIL.Location = new System.Drawing.Point(129, 131);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(631, 27);
            this.EMAIL.TabIndex = 25;
            this.EMAIL.WatermarkText = "Email";
            this.EMAIL.TextChanged += new System.EventHandler(this.EMAIL_TextChanged);
            // 
            // AddCustomer
            // 
            this.ClientSize = new System.Drawing.Size(874, 246);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.MOBILE);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.IDNUMBER);
            this.Controls.Add(this.SRNAME);
            this.Controls.Add(this.USERNAME);
            this.MaximumSize = new System.Drawing.Size(874, 274);
            this.MinimumSize = new System.Drawing.Size(874, 204);
            this.Name = "AddCustomer";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal GUIHelper.GButton OK_Button;
        internal GUIHelper.GButton Cancel_Button;
        internal System.Windows.Forms.Label lbid;
        internal GUIHelper.GTxt MOBILE;
        internal GUIHelper.GTxt IDNUMBER;
        internal GUIHelper.GTxt SRNAME;
        internal GUIHelper.GTxt USERNAME;
        internal GUIHelper.GTxt EMAIL;
    }
}
