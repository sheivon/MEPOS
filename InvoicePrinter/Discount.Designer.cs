namespace InvoicePrinter
{
    partial class Discount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Discount));
            this.txtD = new GUIHelper.GTxt();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtD
            // 
            this.txtD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.txtD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtD.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD.ForeColor = System.Drawing.Color.DarkOrchid;
            this.txtD.Location = new System.Drawing.Point(-2, 83);
            this.txtD.MaxLength = 2;
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(284, 73);
            this.txtD.TabIndex = 0;
            this.txtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtD.WatermarkText = "Discount";
            this.txtD.TextChanged += new System.EventHandler(this.txtD_TextChanged);
            this.txtD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtD_KeyDown);
            this.txtD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtD_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "[ESC] to Close";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "[Enter] to Accept ";
            // 
            // Discount
            // 
            this.ClientSize = new System.Drawing.Size(283, 242);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(283, 242);
            this.MinimumSize = new System.Drawing.Size(283, 242);
            this.Name = "Discount";
            this.Load += new System.EventHandler(this.Discount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GUIHelper.GTxt txtD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
