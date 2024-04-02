namespace InvoicePrinter.PRINT
{
    partial class InvoiceReport
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
            this.gTxt1 = new GUIHelper.GTxt();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // gTxt1
            // 
            this.gTxt1.Location = new System.Drawing.Point(32, 33);
            this.gTxt1.Name = "gTxt1";
            this.gTxt1.Size = new System.Drawing.Size(178, 22);
            this.gTxt1.TabIndex = 0;
            this.gTxt1.WatermarkText = "GTXT";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(266, 33);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 29);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(21, 112);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(360, 440);
            this.reportViewer1.TabIndex = 2;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(397, 112);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(319, 440);
            this.reportViewer2.TabIndex = 3;
            // 
            // InvoiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gTxt1);
            this.Name = "InvoiceReport";
            this.Text = "InvoiceReport";
            this.Load += new System.EventHandler(this.InvoiceReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GUIHelper.GTxt gTxt1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}