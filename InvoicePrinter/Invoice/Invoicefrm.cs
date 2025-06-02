using DataBase;
using System;
using System.Windows.Forms;

namespace InvoicePrinter.Invoice
{
    public partial class Invoicefrm : UserControl
    {
        public Invoicefrm()
        {
            InitializeComponent();
        }

        private void Invoicefrm_Load(object sender, EventArgs e)
        {
            LoadInvoices();
        }

        private void LoadInvoices()
        {
            Invoicedgv.DataSource = null;
            Invoicedgv.DataSource = DataModule.GetInvoices();
        }
    }
}
