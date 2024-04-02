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

namespace InvoicePrinter.Product
{
    public partial class Moneyfrm : Form
    {
        public Moneyfrm()
        {
            InitializeComponent();
        }

        private void Moneyfrm_Load(object sender, EventArgs e)
        {
            LoadMoney();
        }
        private void LoadMoney()
        {
            if(dgv.DataSource != null)
            {
                dgv.DataSource = null;
            }

            dgv.DataSource = DataModule.GetMoney();
        }

        private void dockPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var m = new Money() { Id = Convert.ToInt32(lbID.Tag), Name = txtmon.Text, Simbol = txtSim.Text, Active = cbxActive.IsOn };
            DataModule.SaveMoney(m);
            LoadMoney();
        }
    }
}
