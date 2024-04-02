using DataBase;
using DevExpress.CodeParser;
using DevExpress.Xpo.Exceptions; 
using InvoicePrinter.PRINT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoicePrinter.Customer
{
    public partial class CostomersFrm : UserControl
    {
        private int uid = 0;
        private int cid = 0;
        public CostomersFrm(int id)
        {
            InitializeComponent();
            uid = id;

        }
        public CostomersFrm()
        {
            InitializeComponent();
        }

        private void CostomersFrm_Load(object sender, EventArgs e)
        {
            loadCustomers();
        }

       private void loadCustomers(string txt = "")
        {
            try
            {
                custlist.DataSource = DataModule.GetCustomers(txt);
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
           var pfrm = new Payingfrm(cid, uid);
            //Dim pfrm As New Payingfrm(CID, idd)
            //Try
            try
            {
                //If pfrm.ShowDialog() = DialogResult.OK Then
                if (pfrm.ShowDialog() == DialogResult.OK)
                {
                    //Dim tmp As New PayingCustomer()
                    var tmp = new PayingCustomer();
                    //tmp.Parameters("CUSID").Value = cid;
                    //Dim f = New lowprt()
                    //f.Text = "Customer Payment"
                    //f.documentViewer1.DocumentSource = tmp
                    //f.ShowDialog();
                    //findCustomer()
                    loadCustomers();
                //End If
                }
            }
            catch(Exception ps) {  Console.WriteLine(ps.Message); }
            //Catch ex As Exception
            //Finally
            Console.WriteLine(cid);
   //End Try
        }

        private void btnEditCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(cid.ToString());
                if(cid > 0)
                {
                    using (var c = new AddCustomer(cid))
                    {   if (c.ShowDialog() == DialogResult.OK)
                        {
                            loadCustomers();
                        }
                    }
                }
       //         If String.IsNullOrEmpty(CID) = False Then
       //    Dim c As New CUSTOMEREDIT(CID)
       //    If c.ShowDialog() = DialogResult.OK Then
       //        Call findCustomer()
       //    End If
       //End If
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void btnNewCustomers_Click(object sender, EventArgs e)
        {
            var c = new AddCustomer()
                ;
            if(c.ShowDialog() == DialogResult.OK)
            {
                loadCustomers();
            }
        }

        private void custlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //if ((e.RowIndex != null && e.RowIndex >= 1) && e.ColumnIndex != null && e.ColumnIndex >= 1)
                //{
                //    var index = e.RowIndex;
                //    cid = System.Convert.ToInt32(e.ColumnIndex[0,index].value);
                //}
                //
                //CHAT GPT 3.5
                if (e.RowIndex > 0 && e.ColumnIndex > 0) // Check for valid row and column indices
                {
                    var index = e.RowIndex;
                    //var columnValue = custlist.Rows[index].Cells[e.ColumnIndex].Value;
                    var columnValue = custlist.Rows[index].Cells[0].Value;
                    if (columnValue != null)
                    {
                        cid = Convert.ToInt32(columnValue);
                    }
                }
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtSearchCustomer.Text))
            {
                loadCustomers(txtSearchCustomer.Text);
            }
            else
            { loadCustomers(); }
        }


        /*    Private Property SQlite As New MySqlControl
Private Property CID As UInteger ' curent selectid
Private idd As Integer 'employee id

Private GMessage As New GMessage

Sub New(d As Integer)

   ' This call is required by the designer.
   InitializeComponent()
   idd = d
   Call findCustomer()
   ' Add any initialization after the InitializeComponent() call.

End Sub
Private Sub AutorizedUsers_BackColorChanged(sender As Object, e As EventArgs) Handles MyBase.BackColorChanged
   Me.custlist.BackgroundColor = Me.BackColor
   Me.txtSearchCustomer.BackColor = Me.BackColor
End Sub
Private Sub GButton3_Click(sender As Object, e As EventArgs) Handles GButton3.Click
   Dim cusedit As New CUSTOMEREDIT
   If cusedit.ShowDialog() = DialogResult.OK Then
       Call findCustomer()
   End If
End Sub

Private Sub GButton1_Click(sender As Object, e As EventArgs) Handles GButton1.Click
   Try
       If String.IsNullOrEmpty(CID) = False Then
           Dim c As New CUSTOMEREDIT(CID)
           If c.ShowDialog() = DialogResult.OK Then
               Call findCustomer()
           End If
       End If
   Catch ex As Exception

   End Try
End Sub
''' <summary>
''' BLOCKLIST A CUSTOMER FROM TRUSTING
''' </summary>
''' <param name="sender"></param>
''' <param name="e"></param>
Private Sub GButton5_Click(sender As Object, e As EventArgs) Handles GButton5.Click
   SQlite.ExecQuery("UPDATE CUSTOMER SET BLKCUS='1' WHERE ID='" & CID & "';")
   Call findCustomer()
End Sub
''' <summary>
''' DELETE CUSTOMER WHEN THIS IS CLICKED
''' </summary>
''' <param name="sender"></param>
''' <param name="e"></param>
Private Sub btnDeleteRec_Click(sender As Object, e As EventArgs) Handles btnDeleteRec.Click
   If GMessage.Show(String.Format("Are you Sure to Delete Item ID {0}", CID)) = DialogResult.OK Then
       SQlite.ExecQuery("DELETE FROM CUSTOMER WHERE ID='" + CID + "';")
       Call findCustomer()
   End If
End Sub

Private Sub Costomers_Load(sender As Object, e As EventArgs) Handles Me.Load
   Me.Size = New Point(Parent.Width, Parent.Height)
End Sub

Private Sub btnUnblkCust_Click(sender As Object, e As EventArgs) Handles btnUnblkCust.Click
   SQlite.ExecQuery("UPDATE CUSTOMER SET BLKCUS='0' WHERE ID='" & CID & "';")
   Call findCustomer()
End Sub

Private Sub txtSearchCustomer_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCustomer.TextChanged
   findCustomer(txtSearchCustomer.Text)
   If String.IsNullOrEmpty(txtSearchCustomer.Text) Then
       findCustomer()
   End If
End Sub
Private Sub findCustomer(Optional txt As String = "")
   custlist.Rows.Clear()
   CID = 0
   Try
       Dim cs As List(Of Customers) = DataModule.GetCustomers(txt)
       For Each c As Customers In cs
           custlist.Rows.Add(New Object() {c.id, c.name, c.srname, c.idcard, c.mobile, c.location, c.nacionality, c.gender, c.blocked, c.owing, "View Payments"})
       Next
       lbcusam.Text = $"Customer amount: {cs.Count}"
       ''read payng info
       'Dim gp As List(Of PayingInvoice) = DataModule.GetPayed()
       'Payhist.Rows.Clear()
       'For Each g In gp
       '    'Payhist.Rows.Add(New PayingInvoice With {.id = g.id, .paying = g.paying, .owed = g.owed, .reg = g.reg, .Customer = g.Customer, .Cashier = g.Customer})
       '    'Payhist.Rows.Add(New Object() {g.id, g.paying, g.owed, g.reg, g.Customer, g.Customer
})
       'Next
       'Payhist.DataSource = DataModule.GetPayed()

   Catch ex As Exception
   Finally
   End Try
End Sub

Private Sub custlist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles custlist.CellClick
   Dim index As UInt32 = custlist.CurrentRow.Index
   Dim id As Integer = CInt(custlist.Item(0, CInt(index)).Value)
   CID = id

   If (custlist.CurrentCell.ColumnIndex = 10) Then
       '  MsgBox(id.ToString())      'print id
       Dim tmp As New PaymentHistory()
       tmp.Parameters("CUSID").Value = id
       Dim f = New lowprt()
       f.Text = "Customer Payment History"
       f.documentViewer1.DocumentSource = tmp

       f.ShowDialog()
   End If
End Sub

Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
   Dim pfrm As New Payingfrm(CID, idd)
   Try
       If pfrm.ShowDialog() = DialogResult.OK Then
           Dim tmp As New PayingCustomer()
           tmp.Parameters("CUSID").Value = CID
           Dim f = New lowprt()
           f.Text = "Customer Payment"
           f.documentViewer1.DocumentSource = tmp
           f.ShowDialog()
           findCustomer()
       End If
   Catch ex As Exception
   Finally
       Console.WriteLine(CID)
   End Try
End Sub
   */
    }
}
