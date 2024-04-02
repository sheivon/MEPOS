using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoicePrinter.Customer
{
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
        private void loadOwinCustomers(string qry="")
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
