using DataBase;
using Entities;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InvoicePrinter.Proveedor
{
    [ToolboxItem(false)]
    public partial class SupplierFrm : UserControl
    {
        private int tmpid = 0;
        public SupplierFrm()
        {
            InitializeComponent();
            LoadSuppliers();
        }
        private void LoadSuppliers()
        {
            dgv.DataSource = DataModule.GetSupplier();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var tmpsup = new Supplier() { Id = 0, Name = txtName.Text, ContactInfo = txtCinfo.Text };
            DataModule.SaveSupplier(tmpsup);
            LoadSuppliers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var tmpsup = new Supplier() { Id = tmpid, Name = txtName.Text, ContactInfo = txtCinfo.Text };
            DataModule.SaveSupplier(tmpsup);
            LoadSuppliers();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0 && e.RowIndex >= 0)
            {
                var index = (int)e.RowIndex;
                tmpid = System.Convert.ToInt32(dgv[0, index].Value);
                MessageBox.Show(tmpid.ToString());
            }
        }
    }
}
