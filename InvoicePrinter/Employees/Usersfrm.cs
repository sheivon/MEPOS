using DataBase;
using InvoicePrinter.Report.ReportFrm;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InvoicePrinter.Employees
{
    [ToolboxItem(false)]
    public partial class Usersfrm : UserControl
    {
        private int row = 0;
        private int id = 0;
        public Usersfrm()
        {
            InitializeComponent();
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            using (UsersDX usersDX = new UsersDX())
            {
                usersDX.ShowDialog(this);
            }
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            using (UsersDX usr = new UsersDX(id))
            {
                usr.ShowDialog(this);
            }
        }

        private void Usersfrm_Load(object sender, EventArgs e)
        {
            loadusers();
        }
        private void loadusers(string qry = "")
        {
            empviewer.DataSource = DataModule.GetEmployees(qry);
        }

        private void Usersfrm_BackColorChanged(object sender, EventArgs e)
        {
            this.empviewer.BackgroundColor = this.BackColor;
        }
        //
        // When select row
        private void empviewer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row != 0)
            {
                id = System.Convert.ToInt32(empviewer[0, row].Value);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.TextLength > 1)
            {
                loadusers(txtSearch.Text);
            }
            else
            { loadusers(); }
        }

        private void gButton3_Click(object sender, EventArgs e)
        {
            var prt = new rptProductsfrm();
            prt.ShowDialog(this);
        }
    }
}
