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

namespace InvoicePrinter.Cart
{
    public partial class CheckoutDX : GUIHelper.GForm
    {
        public CheckoutDX()
        {
            InitializeComponent(); 

        }
        
        async private void loadcbxCustomers()
        {
            DataModule.GetCustomers().ToList().ForEach(x => { cbxCustomers.Items.Add(x.FullName); });
        }
    }
}
