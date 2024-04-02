using System;
using System.Windows.Forms;

namespace InvoicePrinter
{
    public partial class Discount : GUIHelper.GForm
    {
        /// <summary>
        /// return discount
        /// </summary>
        public float dis = 00.0f;
        public Discount()
        {
            InitializeComponent();
        }

        private void txtD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtD_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.D0 || e.KeyData == Keys.D1 || e.KeyData == Keys.D2 || e.KeyData == Keys.D3 || e.KeyData == Keys.D4 || e.KeyData == Keys.D5 || e.KeyData == Keys.D6 || e.KeyData == Keys.D7 || e.KeyData == Keys.D8 || e.KeyData == Keys.D9)
                {
                    e.Handled = false;
                }
                else if (e.KeyData == Keys.Enter)
                {
                    try
                    {
                        if (txtD.TextLength > 0)
                        {
                            dis = (float)System.Convert.ToDouble(txtD.Text);
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                            this.DialogResult = DialogResult.Cancel;
                        this.Close();
                    }
                    catch { }
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch { }
        }

        private void txtD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Discount_Load(object sender, EventArgs e)
        {

        }
    }
}
