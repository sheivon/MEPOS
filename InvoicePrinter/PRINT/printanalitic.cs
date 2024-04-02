using Entities;
using System;
using System.Collections.Generic; 
using System.Windows.Forms;

namespace InvoicePrinter.PRINT
{
    public partial class printanalitic : Form
    {
        private List<semiprod> tp;
        public printanalitic(List<semiprod> ls)
        {
            InitializeComponent();
            tp = ls;

            //documentViewer1.DocumentSource = new Analicitprint(tp);
        }

        private void printanalitic_Load(object sender, EventArgs e)
        {
            //documentViewer1.DocumentSource = new Analicitprint(tp);
        }
    }
}
