namespace InvoicePrinter.Cart
{
    partial class cashing
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
            this.txtCash = new GUIHelper.GTxt();
            this.toggleSwitch1 = new GUIHelper.ToggleSwitch();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCash
            // 
            this.txtCash.BackColor = System.Drawing.Color.DarkGray;
            this.txtCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCash.Location = new System.Drawing.Point(81, 97);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(331, 50);
            this.txtCash.TabIndex = 0;
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCash.WatermarkText = "Paying Amount";
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txtCash.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtCash_PreviewKeyDown);
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(165, 239);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch1.OffText = "Card";
            this.toggleSwitch1.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch1.OnText = "Cash";
            this.toggleSwitch1.Size = new System.Drawing.Size(156, 37);
            this.toggleSwitch1.Style = GUIHelper.ToggleSwitch.ToggleSwitchStyle.BrushedMetal;
            this.toggleSwitch1.TabIndex = 1;
            this.toggleSwitch1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtCash_PreviewKeyDown);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(139, 182);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "USD $";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtCash_PreviewKeyDown);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox2.Location = new System.Drawing.Point(247, 182);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(113, 24);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Cordoba C$";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtCash_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "[ESC]";
            this.label1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtCash_PreviewKeyDown);
            // 
            // cashing
            // 
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.txtCash);
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "cashing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GUIHelper.GTxt txtCash;
        private GUIHelper.ToggleSwitch toggleSwitch1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
    }
}
