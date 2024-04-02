using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace InvoicePrinter.PRINT
{
    public partial class facview : DevExpress.XtraReports.UI.XtraReport
    {
        public Image IMG  { get; set; }
        public facview()
        {
            InitializeComponent();
        }

    }
}
