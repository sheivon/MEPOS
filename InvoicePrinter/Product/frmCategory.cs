using DataBase;
using Entities;
using System;
using System.Windows.Forms;

namespace InvoicePrinter.Product
{
    public partial class frmCategory : Form
    {
        private Category tmp = null;
        private int tmpid = 0;
        public frmCategory()
        {
            InitializeComponent();
        }

        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            DataModule.SaveCategory(new Category() { Id = tmpid, Name = txtCategory.Text, Active = cbxActive.Checked });
            txtCategory.ResetText();
            txtCategory.Focus();
            loadCategories();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            loadCategories();
        }

        private void loadCategories()
        {
            var db = DataModule.GetCategories();
            try
            {
                DGV_Cat.DataSource = db;
            }
            catch { }
        }

        private void DGV_Cat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_Cat.CurrentCell != null && DGV_Cat.CurrentRow != null)
            {
                int rownum = DGV_Cat.CurrentCell.RowIndex;
                if (rownum > 0 && DGV_Cat.CurrentRow.Index > 0)
                {
                    int id = System.Convert.ToInt32(DGV_Cat[0, rownum].Value); //       Fisrt Column id
                    string cat = DGV_Cat[1, rownum].Value.ToString();          //       Name Column
                    bool act = System.Convert.ToBoolean(DGV_Cat[2, rownum].Value); //   Active Column

                    // // for debug info
                    //MessageBox.Show(id.ToString() + " => " + cat.ToString() + (act? "Active":"Not Active"));
                    txtCategory.Tag = id;
                    tmpid = id;
                    txtCategory.Text = cat;
                    cbxActive.Checked = act;

                }
                tmp = new Category();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tmpid = 0;
            txtCategory.ResetText();
            txtCategory.Focus();
            loadCategories();
        }
    }
}
