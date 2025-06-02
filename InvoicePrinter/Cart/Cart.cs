using DataBase;
using Entities;
using InvoicePrinter.Cusmetic;
using InvoicePrinter.Customer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InvoicePrinter.Cart
{
    public partial class Cart : UserControl
    {
        Users _usr;

        [ToolboxItem(false)]
        public Cart()
        {
            InitializeComponent();
        }
        public Cart(Users usr)
        {
            InitializeComponent();
            _usr = usr;
        }

        private void Cart_BackColorChanged(object sender, EventArgs e)
        {
            this.dgv.BackgroundColor = this.BackColor;
            this.txtBarcode.BackColor = this.BackColor;
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            using (Serv Serv = new Serv())
            {
                if (Serv.ShowDialog() == DialogResult.OK)
                {
                    LoadCartItem(Serv.ID, Serv.AM);
                }
            }
        }

        private void LoadCartItem(int ID, int Amount)
        {
            Products products = DataModule.GetProductID(ID);
            //Console.WriteLine(products.ToString());

            //  products => Incoice details
            //
            //  Id { set; get; }        =>  IID { get; set; } /*Product ID*/
            //  Barcode { set; get; }   =>  BCODE { get; set; } /*FACN*/
            //  Name { set; get; }      =>  ITEM { get; set; } /*Does not save just read db*/
            //  Stock { set; get; }     =>  
            //  Price { set; get; }     =>  UNITPRICE { get; set; }
            //  Cur { set; get; }       =>  
            //  type { get; set; }      =>  
            //  active { get; set; }    =>  

            //  Amount (parameters IN)  =>  QTY { get; set; } 
            InvoiceDetails InD = new InvoiceDetails();
            InD.ITEM = products.Name;
            InD.IID = products.Id;
            InD.BCODE = products.Barcode;
            InD.UNITPRICE = products.Price;
            InD.QTY = Amount;

            dgv.DataSource = null;
            dgv.Rows.Add(InD);

        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            using (AddCustomerToInvoice cti = new AddCustomerToInvoice())
            {
                if (cti.ShowDialog() == DialogResult.OK)
                {
                    lbfirstname.Text = cti.cusname;
                    lblastname.Text = cti.Sid.ToString();
                }
            }
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //search itemp by code

            }

        }
    }
}
