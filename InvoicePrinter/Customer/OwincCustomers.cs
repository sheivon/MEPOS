using DataBase;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InvoicePrinter.Customer
{
    [ToolboxItem(false)]
    public partial class OwincCustomers : UserControl
    {
        public OwincCustomers()
        {
            InitializeComponent();
        }

        private void OwincCustomers_Load(object sender, EventArgs e)
        {
            loadOwinCustomers();
        }
        private void loadOwinCustomers(string qry = "")
        {
            Invoicedgv.DataSource = null;

            Invoicedgv.DataSource = DataModule.GetOwingCustomers(qry);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadOwinCustomers(txtSearch.Text);
        }
    }
}
