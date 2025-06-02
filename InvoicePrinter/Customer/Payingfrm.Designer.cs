namespace InvoicePrinter.Customer
{
    partial class Payingfrm
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
            this.lbPendingOw = new System.Windows.Forms.Label();
            this.LbLOw = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtAmout = new GUIHelper.GTxt();
            this.lbcusname = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new GUIHelper.GButton(this.components);
            this.SuspendLayout();
            // 
            // lbPendingOw
            // 
            this.lbPendingOw.AutoSize = true;
            this.lbPendingOw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPendingOw.Location = new System.Drawing.Point(24, 266);
            this.lbPendingOw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPendingOw.Name = "lbPendingOw";
            this.lbPendingOw.Size = new System.Drawing.Size(168, 25);
            this.lbPendingOw.TabIndex = 9;
            this.lbPendingOw.Text = "Total Ow Pending";
            this.lbPendingOw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbLOw
            // 
            this.LbLOw.AutoSize = true;
            this.LbLOw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLOw.Location = new System.Drawing.Point(16, 105);
            this.LbLOw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbLOw.Name = "LbLOw";
            this.LbLOw.Size = new System.Drawing.Size(80, 25);
            this.LbLOw.TabIndex = 8;
            this.LbLOw.Text = "Log Ow";
            this.LbLOw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(307, 342);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(117, 16);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "[ENTER to Accept";
            // 
            // txtAmout
            // 
            this.txtAmout.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAmout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmout.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmout.Location = new System.Drawing.Point(-3, 145);
            this.txtAmout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmout.MaxLength = 6;
            this.txtAmout.Name = "txtAmout";
            this.txtAmout.Size = new System.Drawing.Size(447, 76);
            this.txtAmout.TabIndex = 5;
            this.txtAmout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmout.WatermarkText = "OW";
            this.txtAmout.TextChanged += new System.EventHandler(this.txtAmout_TextChanged);
            this.txtAmout.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmout_KeyDown);
            this.txtAmout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmout_KeyPress);
            // 
            // lbcusname
            // 
            this.lbcusname.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbcusname.Location = new System.Drawing.Point(12, 49);
            this.lbcusname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbcusname.Name = "lbcusname";
            this.lbcusname.Size = new System.Drawing.Size(423, 52);
            this.lbcusname.TabIndex = 10;
            this.lbcusname.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(404, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(29, 28);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.UIStyle = GUIHelper.GButton.Style.Cicle;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Payingfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(439, 364);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbcusname);
            this.Controls.Add(this.lbPendingOw);
            this.Controls.Add(this.LbLOw);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtAmout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Payingfrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payingfrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbPendingOw;
        internal System.Windows.Forms.Label LbLOw;
        internal System.Windows.Forms.Label Label2;
        internal GUIHelper.GTxt txtAmout;
        private DevExpress.XtraEditors.LabelControl lbcusname;
        private GUIHelper.GButton btnCancel;
    }
}