namespace InvoicePrinter.Cart
{
    partial class CheckoutDX
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxPaymenttype = new System.Windows.Forms.ComboBox();
            this.cbxCustomers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbxPaymenttype
            // 
            this.cbxPaymenttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaymenttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPaymenttype.FormattingEnabled = true;
            this.cbxPaymenttype.Items.AddRange(new object[] {
            "Credit Card",
            "Cash"});
            this.cbxPaymenttype.Location = new System.Drawing.Point(141, 64);
            this.cbxPaymenttype.Name = "cbxPaymenttype";
            this.cbxPaymenttype.Size = new System.Drawing.Size(435, 30);
            this.cbxPaymenttype.TabIndex = 0; 
            // 
            // cbxCustomers
            // 
            this.cbxCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCustomers.FormattingEnabled = true;
            this.cbxCustomers.Items.AddRange(new object[] {
            "Credit Card",
            "Cash"});
            this.cbxCustomers.Location = new System.Drawing.Point(141, 131);
            this.cbxCustomers.Name = "cbxCustomers";
            this.cbxCustomers.Size = new System.Drawing.Size(435, 30);
            this.cbxCustomers.TabIndex = 0; 
            // 
            // CheckoutDX
            // 
            this.ClientSize = new System.Drawing.Size(700, 349);
            this.Controls.Add(this.cbxCustomers);
            this.Controls.Add(this.cbxPaymenttype);
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimumSize = new System.Drawing.Size(400, 150);
            this.Name = "CheckoutDX";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPaymenttype;
        private System.Windows.Forms.ComboBox cbxCustomers;
    }
}
