using DataBase;
using Entities;
using GUIHelper;
using MarshellsSettings;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace InvoicePrinter.Product
{
    public partial class ProductEdit : GForm
    {
        GMessage GMessage = new GMessage();

        /// <summary>
        /// Update or new product
        /// </summary>
        private Products prod = null;

        internal string BCType = MSetting.GetBarcodeType();
        internal Form FW;

        public ProductEdit()
        {
            this.InitializeComponent();
        }
        public ProductEdit(Form ow)
        {
            InitializeComponent();
            FW = ow;
        }
        public ProductEdit(Form ow, Products p)
        {
            InitializeComponent();
            FW = ow;
            prod = p;
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {  //MessageBox.Show(cbxtype.SelectedItem.ToString());
            if (cbxtype.SelectedItem != null)
            {
                prod.type = System.Convert.ToBoolean(cbxtype.SelectedItem.ToString() == "PRODUCT");
                //MessageBox.Show(prod.type.ToString());
            }
            prod.active = cbActive.CheckState == CheckState.Checked ? true : false;
            //
            //CHAT GPT3.5
            if (prod.Id > 0 && !string.IsNullOrWhiteSpace(Pname.Text) && !string.IsNullOrWhiteSpace(PPrice.Text))
            {
                // If Id is greater than 0 and name and price are not empty or whitespace
                DataModule.SaveProduct(prod);
                DialogResult = DialogResult.OK;
            }
            else if (!string.IsNullOrWhiteSpace(Pname.Text) && !string.IsNullOrWhiteSpace(PPrice.Text))
            {
                // If Id is not greater than 0 and name and price are not empty or whitespace
                DataModule.SaveProduct(prod);
                DialogResult = DialogResult.OK;
            }
            else
            { GMessage.Show("ALL Requiered field must be filled!"); DialogResult = DialogResult.Cancel; }
            // If Id is not greater than 0 and name or price is empty or whitespace, do nothing 
        }
        private void ProductEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (prod != null)
                {
                    Products Dr = DataModule.GetProductID(prod.Id);
                    if (Dr != null)
                    {
                        lbid.Text = $"ID: {Dr.Id} ";
                        lbid.Visible = true; lbid.Enabled = true;
                        Pcode.Text = Dr.Barcode;
                        Pname.Text = Dr.Name;
                        PInstock.Text = Dr.Stock.ToString();
                        PPrice.Text = Dr.Price.ToString();
                        string tmp = Dr.Cur.ToString();
                        curselector.Text = (tmp == "NIO") ? "C$" : tmp.Equals("USD") ? "$" : "€";
                        byte typ = System.Convert.ToByte(Dr.type);
                        cbxtype.Text = (typ == 1) ? "PRODUCT" : "SERVICE";
                        //asign locasl as default  
                        cbActive.CheckState = Dr.active ? CheckState.Checked : CheckState.Unchecked;
                    }
                }
                else
                {
                    prod = new Products();
                }
            }
            catch (Exception ps) { Console.WriteLine(ps.Message + " - Loading Products into DX Edit Prod"); }
        }
        private void ScanBarcode(string barcode)
        {
            try
            {
                var p = DataModule.GetProductBC(barcode);
                if (p.Barcode == barcode)
                {
                    GMessage.Show($"Product '{p.Name}' with that Barcode Already");
                }
            }
            catch (Exception)
            {
            }
        }
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void curselector_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (curselector.SelectedItem.Equals("C$"))
                {
                    prod.Cur = "NIO";
                }
                else if (curselector.SelectedItem.Equals("$"))
                {
                    prod.Cur = "USD";
                }
                else if (curselector.SelectedItem.Equals("€"))
                {
                    prod.Cur = "EUR";
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message + " - Selecting Currency"); }
        }

        private void PPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void PInstock_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Pcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(Pcode.Text) && Pcode.Enabled == true)
                {
                    string barcode = Pcode.Text;
                    Scanners sc = new Scanners();
                    Image img;
                    img = sc.GetBarcode(barcode, BCType);
                    PictureBox1.Image = img;
                    //check to see if barcode not exist
                    if (prod.Id != 0)
                    {
                        ScanBarcode(barcode);
                    }

                }
            }
        }


        private void cbxtype_SelectedIndexChanged(object sender, EventArgs e)
        {

            //#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
            //if (cbxtype.SelectedItem == "PRODUCT" )
            //{
            //    type = 0;
            //    Pcode.Enabled = true;
            //}

            //if(cbxtype.SelectedItem == "SERVICE")
            //{
            //    type = 1;
            //    Pcode.Enabled = false;
            //}
            //
            //CHAT GPT3.5
            if (cbxtype.SelectedItem.Equals("PRODUCT"))
            {
                prod.type = true;
                Pcode.Enabled = true;
            }
            else if (cbxtype.SelectedItem.Equals("SERVICE"))
            {
                prod.type = false;
                Pcode.Enabled = false;
            }
        }

        private void Pcode_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Pcode.Text))
            {
                string barcode = Pcode.Text;
                Scanners sc = new Scanners();
                Image img = sc.GetBarcode(barcode, BCType);
                PictureBox1.Image = img;
                prod.Barcode = barcode;
            }
            else
            {
                Image img = null;
                PictureBox1.Image = img;
                Pcode.Text = "";
            }
        }

        [Obsolete]
        private void cbActive_CheckedChanged(object sender, EventArgs e)
        {
            ////Looooop
            //if(cbActive.CheckState == CheckState.Unchecked)
            //{ cbActive.Checked = true; } else  {  cbActive.Checked = false;  } 
        }

        private void cbActive_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbActive.CheckState == CheckState.Checked) { cbActive.Checked = true; } else { cbActive.Checked = false; }
        }

        private void PInstock_TextChanged(object sender, EventArgs e)
        {
            if (PInstock.TextLength > 1)
            { prod.Stock = int.Parse(PInstock.Text); }
        }

        private void PPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PPrice.Text)) { prod.Price = decimal.Parse(PPrice.Text); }
        }

        private void Pname_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Pname.Text)) { prod.Name = Pname.Text; }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            var frmcat = new frmCategory();

            frmcat.ShowDialog();
        }
    }
}
