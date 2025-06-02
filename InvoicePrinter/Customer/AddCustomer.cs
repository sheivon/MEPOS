using DataBase;
using Entities;
using GUIHelper;
using System;
using System.Windows.Forms;

namespace InvoicePrinter.Customer
{
    public partial class AddCustomer : GUIHelper.GForm
    {
        GMessage GMessage = new GMessage();
        string Title = "Marshell's";

        /// <summary>
        /// int id  to edit when ready
        /// </summary>
        private int idcusto = 0;
        private Customers cust = new Customers();

        //
        public Customers NCustomers = new Customers();
        public AddCustomer()
        {
            InitializeComponent();
        }
        public AddCustomer(int id)
        {
            InitializeComponent();
            idcusto = id;
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            try
            {
                cust = new Customers()
                {
                    id = (idcusto == 0 ? 0 : System.Convert.ToInt32(lbid.Tag)),
                    name = USERNAME.Text,
                    srname = SRNAME.Text,
                    idcard = IDNUMBER.Text,
                    mobile = MOBILE.Text,
                    email = EMAIL.Text,
                };
                NCustomers = cust;
            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message + Environment.NewLine + @"Unable to Add Customer", Title);
            }
            DialogResult = DialogResult.OK;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
     (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void IDNUMBER_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                if (idcusto > 0)
                {
                    var cust = DataModule.GetCustomerbyID(idcusto);

                    if (cust != null)
                    {
                        lbid.Text = cust.id.ToString();
                        lbid.Tag = cust.id;
                        USERNAME.Text = cust.name;
                        SRNAME.Text = cust.srname;
                        IDNUMBER.Text = cust.idcard;
                        MOBILE.Text = cust.mobile;
                        EMAIL.Text = cust.email;
                    }
                }

            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message.ToString()); }
        }
        private void EMAIL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
