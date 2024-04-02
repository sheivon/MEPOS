using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoicePrinter.PRINT
{
    public partial class PrintInvoicefrm : DevExpress.XtraEditors.XtraForm
    {
        //SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
        public PrintInvoicefrm()
        {
            InitializeComponent();
        }

        private void PrintInvoicefrm_Load(object sender, EventArgs e)
        { 
        }

    }
}