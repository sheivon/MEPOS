using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Office.Crypto;
using GUIHelper;


using Encryption;
using DevExpress.Xpo.Exceptions;
using System.Security.Cryptography;
using DevExpress.Office.Utils;
using DevExpress.CodeParser;
using Entities;
using DevExpress.DataAccess.Native.EntityFramework;
using DevExpress.XtraCharts;
using DataBase;
namespace InvoicePrinter.Employees
{
    public partial class UsersDX : GForm
    {
         
        private int _id = 0;
        public UsersDX(int id = 0)
        {
            InitializeComponent();
            _id = id;
            if(id != 0)
            {
                LoadUsers();
            }
        }
        public UsersDX()
        {
            InitializeComponent();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
           var encpass = DataModule.EncryptPassword(txtpass.Text);
            var usr = new Users();
            try
            {
                //post data to user save modules
                usr.Id = _id;
                usr.Name = txtusrname.Text;
                usr.Srname = txtsrname.Text;
                usr.IDNumber = txtIDnumber.Text;
                usr.Mobile = txtcel.Text;
                usr.RegDate =  txthireddate.Text;

                //login
                usr.login = txtusrlogin.Text;
                usr.pass = encpass;

                DialogResult = DialogResult.OK;
            }
            catch (Exception sd) { Console.WriteLine(sd.Message); }

        }
        
        private void UsersDX_Load(object sender, EventArgs e)
        {

        }
        /*
Private Function EncryptPassword(pass As String) As String
   Dim SafePassword As String = ""
   Dim Enc As New Encryption.Encrypt(EncText)
   SafePassword = Enc.EncryptData(pass)
   Return SafePassword
End Function

Private Function DecryptPassword(Pass As String) As String
   Dim SafePassword As String = ""
   Dim Dec As New Encryption.Decrypt(EncText)
   Dim ss = Dec.DecryptData(Pass)
   Try
       SafePassword = Dec.DecryptData(Pass)
       If ss = SafePassword Then
           Return SafePassword
       End If
   Catch ex As System.Security.Cryptography.CryptographicException
       MsgBox(ex.Message)
       Return SafePassword
   End Try
   Return SafePassword
End Function
*/

        //
        //load controls

        private void LoadUsers()
        {
            var E = DataModule.GetUsersByID(_id);

            try
            {
                lbid.Text = string.Format("ID: {0}",E.Id);
                lbid.Tag = E.Id;                //Save for editing
                txtusrname.Text = E.Name;
                txtsrname.Text = E.Srname;
                txtIDnumber.Text = E.IDNumber;
                txtcel.Text = E.Mobile;
                txthireddate.Text = E.RegDate;//.ToString("yyyy-MM-dd H:mm:ss");
                txtnat.Text = E.Nationality;
                cbxgender.Text = E.Gender;
                txtdir.Text = E.Location;
                txtusrlogin.Text = E.login;

                var tmppas = E.pass;
                txtpass.Text = DataModule.DecryptPassword(tmppas);


                cbxactive.SelectedItem = E.Fired.ToString();
                cbxactive.Text = E.Fired.ToString();
                cbxrole.Text = E.Role;

                if (E.Role == "SYSTEMADMINISTRATOR")
                {
                    this.cbxactive.Enabled = true;
                    //Me.FIREDCBX.Enabled = False
                    this.cbxrole.Enabled = true;
                    //Me.ROLE.Enabled = False
                    this.cbxgender.Enabled = true;
                    //Me.GENDERCBX.Enabled = False
                }
                else {  
                    this.cbxactive.Enabled = false;
                    //Me.FIREDCBX.Enabled = True
                    this.cbxrole.Enabled = false;
                    //Me.ROLE.Enabled = True
                    this.cbxgender.Enabled = false;
                    //Me.GENDERCBX.Enabled = True
                }
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
           
        }

        private void btnShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (btnShowPass.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else { txtpass.UseSystemPasswordChar= true; }

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
