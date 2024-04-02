using DataBase;
using Entities;
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
    public partial class Payingfrm : Form
    {
        private Customers _Cus;
        private decimal paying;
        private int uid; //emp id

        public Payingfrm(int id,int ud)
        {
            InitializeComponent();
            uid = ud;
            getcustomer(id);
        }

        private void getcustomer(int id)
        {
            try
            {
               _Cus =  DataModule.GetCustomerbyID(id);
                lbcusname.Text = _Cus.FullName;
                LbLOw.Text = _Cus.owing.ToString();
            }
            catch(Exception s)
            { Console.WriteLine(s.Message); }
        }

        private void txtAmout_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                //procede with payout
                try
                {
                    if (uid > 0)
                    {
                        decimal sum = (_Cus.owing - paying >= 0) ? _Cus.owing - paying : 0;
                        lbPendingOw.Text = $"Pendient : {sum.ToString()}";
                        DataModule.RegisterPaying(paying, sum, _Cus.id, uid);
                        DataModule.UpdateCustomerOw(sum, _Cus.id);
                    }
                }
                catch { }

                this.DialogResult = DialogResult.OK;
            } 
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void txtAmout_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((txtAmout.TextLength > 0) && (uid > 0))
                {
                    paying = System.Convert.ToDecimal(txtAmout.Text);
                   
                }
            }
            catch (Exception E) { Console.WriteLine(E.Message); }
        }

        private void txtAmout_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;

           
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //close
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
