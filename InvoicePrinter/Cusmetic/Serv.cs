using DataBase;
using GUIHelper; 
using InvoicePrinter.Product;
using System;
using System.Data;
using System.Windows.Forms;

namespace InvoicePrinter.Cusmetic
{
    public partial class Serv : Form
    {
        GMessage GMessage = new GMessage(); 
        public int ID;
         
        public int AM = 1;
        private Form Ow;
        public Serv(Form Owner)
        {
            InitializeComponent();
            Ow = Owner;
        }
        private void Serv_Load(object sender, EventArgs e)
        {
            LoadServices();
        }
        private void LoadServices(string Search = "")
        {
            try
            {
                dataGridView1.DataSource = DataModule.GetProductsServices(Search);
            }
            catch { } 
        }

        private void Serv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.OK;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2) // this is when description is clicked
            {
                try
                { 
                    int index = dataGridView1.CurrentRow.Index;
                    ID = (int)(dataGridView1[0, index].Value);
                    //
                    //QTY
                    AM = 1;
                    DialogResult = DialogResult.OK;  
                }
                catch (Exception ex)
                {
                    GMessage.Show(Ow, ID + Environment.NewLine + ex.Message, "Marshell's");
                }

            }
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            ID = (int)(dataGridView1[0, index].Value);

        }

        private void Serv_BackColorChanged(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = this.BackColor;
        }

        private void txtSeach_TextChanged(object sender, EventArgs e)
        {
            string srch = txtSeach.Text;
            if(srch.Length > 0) 
            {
                LoadServices(srch);
            }
            else 
            {
                LoadServices();
            }
                
        }

        private void BTNADDNEW_Click(object sender, EventArgs e)
        {
            using (ProductEdit se = new ProductEdit(this.ParentForm))
            {
                if (se.ShowDialog() == DialogResult.OK)
                {
                    LoadServices();
                }
            }
        }

        private void label1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btncls_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        } 
    }
}
