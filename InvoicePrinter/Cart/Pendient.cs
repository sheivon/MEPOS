using System;

namespace InvoicePrinter.Cart
{
    public partial class Pendient : GUIHelper.GForm
    {
        public Pendient()
        {
            InitializeComponent();
        }
        private void PendientLoads()
        {
            dgv.DataSource = null;
            dgv.DataSource = DataBase.DataModule.GetPendientsInvoices();
        }

        private void Pendient_Load(object sender, EventArgs e)
        {
            PendientLoads();
        }
    }
}
