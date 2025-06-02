using Entities;
using System;
using System.Windows.Forms;

namespace InvoicePrinter.Cart
{
    public partial class cashing : GUIHelper.GForm
    {
        public decimal total = 0;
        public Money money = null;
        public Type type = null;
        public cashing()
        {
            InitializeComponent();
        }

        private void txtCash_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
            if (e.KeyCode == Keys.Enter)
            {
                total = Convert.ToDecimal(txtCash.Text);
                DialogResult = DialogResult.OK;
            }
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
