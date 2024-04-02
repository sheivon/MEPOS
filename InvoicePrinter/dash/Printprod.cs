using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoicePrinter.dash
{
    public partial class Printprod : UserControl
    {
        public Printprod()
        {
            InitializeComponent();
            var rep = new XtraReport1();
            documentViewer1.DocumentSource = rep;
            documentViewer1.InitiateDocumentCreation();
        }

    }
}
