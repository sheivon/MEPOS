using GUIHelper;
using System;
using System.Data;
using System.Windows.Forms;

using MarshellsSettings;
using System.Net.Configuration;
using Entities;
using DataBase;

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
                string gender = "FEMALE"; // by default gender is female
                if (GENDERCBX.Text != "SELECT GENDER")
                {
                    gender = GENDERCBX.SelectedItem.ToString();
                } 
                cust =  new Customers() {
                    id = (idcusto == 0? 0: System.Convert.ToInt32(lbid.Tag)), 
                    name = USERNAME.Text, 
                    srname = SRNAME.Text, 
                    idcard = IDNUMBER.Text,
                    mobile = MOBILE.Text,
                    location = LLOCATION.Text,
                    nacionality = NATIONALITY.Text,
                    gender = gender,
                    blocked = cbBlockedusers.CheckState == CheckState.Checked,
                    owing = System.Convert.ToDecimal(OW.Text)
                }; 
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
                        LLOCATION.Text = cust.location;
                        NATIONALITY.Text = cust.nacionality;
                        OW.Text = cust.owing.ToString();
                        GENDERCBX.ResetText();// reset gender text to load
                        string Gender = cust.gender;
                        GENDERCBX.SelectedText = Gender;
                        GENDERCBX.Text = Gender;
                    }                             
                }

            }
#if DEBUG 
            catch (Exception ex)
            {
                GMessage.Show("Loading Data to UI Fails !" + Environment.NewLine + ex.Message, Title);
               
            }
#else
            catch (Exception ex)
            { Console.WriteLine(ex.Message.ToString()); }
#endif 
        }
    }
}
