using System.Windows.Forms;

namespace InvoicePrinter.Report.ReportFrm
{
    public partial class rptProductsfrm : Form
    {
        public rptProductsfrm()
        {
            InitializeComponent();
            printDocument1.PrinterSettings.PrintToFile = true;
            //printPreviewControl1.Document += new System.Drawing.Printing.PrintDocument("rptProducts.rdlc");
        }
    }
}
