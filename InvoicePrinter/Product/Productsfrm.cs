using DataBase;
using Entities;
using System;
using System.Windows.Forms;

namespace InvoicePrinter.Product
{
    public partial class Productsfrm : UserControl
    {
        private Products tmpprod = null;
        public Productsfrm()
        {
            InitializeComponent();
        }

        private void btnNewProd_Click(object sender, EventArgs e)
        {
            using (ProductEdit np = new ProductEdit())
            {
                if (np.ShowDialog() == DialogResult.OK)
                {
                    LoadProducts();
                }
            }
        }
        private void LoadProducts()
        {
            try
            {
                DGV.DataSource = DataModule.GetProducts();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void Productsfrm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void Productsfrm_BackColorChanged(object sender, EventArgs e)
        {
            this.DGV.BackgroundColor = this.BackColor;
        }

        private void btnPrintProd_Click(object sender, EventArgs e)
        {
            //Print Items in list

        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV.Rows.Count > 0 && e.RowIndex > 0 && e.ColumnIndex == 8 || e.ColumnIndex == 9)
            {
                DataGridViewRow row = DGV.Rows[e.RowIndex];
                tmpprod = new Products() { Id = Convert.ToInt32(row.Cells[0].Value), Barcode = row.Cells[1].Value.ToString(), Name = row.Cells[2].Value.ToString(), Stock = Convert.ToInt32(row.Cells[3].Value) };
                // Edit Products
                if (e.ColumnIndex == 8)
                {
                    using (ProductEdit pe = new ProductEdit(this.ParentForm, tmpprod))
                    {
                        if (pe.ShowDialog() == DialogResult.OK)
                        {
                            LoadProducts();
                        }
                    }
                }
                // View Barcode
                if (e.ColumnIndex == 9)
                {
                    if (tmpprod != null)
                    {
                        using (Printbarcode pbc = new Printbarcode(tmpprod.Barcode))
                        {
                            pbc.ShowDialog();
                        }
                    }
                }
            }
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (tmpprod != null)
            {
                using (Printbarcode pbc = new Printbarcode(tmpprod.Barcode))
                {
                    pbc.ShowDialog();
                }
            }
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchCustomer.Text.Length > 0)
                {
                    DGV.DataSource = null;
                    DGV.DataSource = DataModule.GetProducts(txtSearchCustomer.Text);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
