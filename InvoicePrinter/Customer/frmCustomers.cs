using DataBase;
using Entities;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InvoicePrinter.Customer
{
    [ToolboxItem(false)]
    public partial class frmCustomers : UserControl
    {
        private Users tmpusr;
        private int tmpid = 0; // for editing
        public frmCustomers()
        {
            InitializeComponent();
        }
        public frmCustomers(Users usr)
        {
            InitializeComponent();
            LoadCustomers();
            tmpusr = usr;
        }

        private void LoadCustomers()
        {
            var db = DataModule.GetCustomers((txtSearchbox.Text == null ? "" : txtSearchbox.Text));
            try
            {
                custlist.DataSource = db;
            }
            catch { }
        }


        //Add New CUSTOMER
        private void GButton1_Click(object sender, EventArgs e)
        {
            using (var nc = new AddCustomer())
            {
                if (nc.ShowDialog() == DialogResult.OK)
                {
                    DataModule.SaveCustomer(nc.NCustomers);
                    LoadCustomers();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (var nc = new AddCustomer(tmpid))
            {
                if (tmpid != 1)
                {
                    if (nc.ShowDialog() == DialogResult.OK)
                    {
                        DataModule.SaveCustomer(nc.NCustomers);
                        LoadCustomers();
                    }
                }
            }
        }

        private void custlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (custlist.Rows.Count > 0 && custlist.CurrentRow != null && custlist.CurrentCell != null)
            {
                if (custlist.CurrentCell.RowIndex >= 0)
                {
                    var tmpselrow = custlist.CurrentCell.RowIndex;
                    var id = System.Convert.ToInt32(custlist[0, tmpselrow].Value);
                    tmpid = id;
                }
            }

        }
    }
}
