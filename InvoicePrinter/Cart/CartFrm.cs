using DataBase;
using Entities;
using GUIHelper;
using InvoicePrinter.Cusmetic;
using InvoicePrinter.Customer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InvoicePrinter.Cart
{
    public partial class CartFrm : UserControl
    {
        private string users = "";                              //Login Username
        private int usrID = 1;                                  // Login UserID
        private decimal discount = 0;                           // Actual Descount from fact
        private decimal total = 0;                              // sum of all item
        private decimal cash = 0;                               // Paying Amount in most case does be efective
        private long currentTime = 0;                           // Generated Factura Id from Timestamp

        private int selid = 0;                                  // Selected Customer ID
        private string custna = String.Empty;                   // Selected Customer Name

        private Customers cus = null;                           // new instance for customers 

        private int Invoice = -1;                                // INIT for new Invoice #


        public CartFrm()
        {
            InitializeComponent();
        }

        public CartFrm(string _users, int _usrID)
        {
            InitializeComponent();
            this.users = _users;
            this.usrID = _usrID;
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                //Console.WriteLine(txtBarcode.Text);
                var o = DataModule.GetProductBC(txtBarcode.Text);

                if (o != null && o.Id > 0)
                {   // Test Code
                    //GMessage gm = new GMessage();
                    //gm.Show("Product does exists " + o.Name);
                    AddDGV(o);
                }
                else
                {
                    GMessage gm = new GMessage();
                    gm.Show("Product does not exists !! VERIFY BARCODE !!");
                }

                //reset the textbox
                txtBarcode.ResetText();
                //active
                txtBarcode.Focus();
            }
        }

        //
        // check product and add to list and update the dgv
        private void AddDGV(Products p)
        {
            total = 0;
            var tmplist = new List<CartItem>();
            //
            // CHAT GPT 3.5  
            // Iterate through each row in the DataGridView
            foreach (DataGridViewRow row in dgv.Rows)
            {
                // Skip the last row, which is typically the new row for adding new data
                if (!row.IsNewRow)
                {
                    // Create a new instance of CartItem and populate its properties
                    CartItem prod = new CartItem()
                    {
                        id = System.Convert.ToInt32(row.Cells[0].Value),
                        Name = System.Convert.ToString(row.Cells[1].Value),
                        price = System.Convert.ToDecimal(row.Cells[2].Value),
                        amount = System.Convert.ToInt32(row.Cells[3].Value),
                        cur = System.Convert.ToString(row.Cells[5].Value) // Assuming column index 5 contains currenc

                    };
                    //add suttotal 
                    total += System.Convert.ToDecimal(prod.SubTotal);
                    // Add the data item to the list
                    tmplist.Add(prod);
                }
            }

            // Check if the product with the same ID already exists in tmplist
            bool found = false;
            foreach (CartItem cc in tmplist)
            {
                if (cc.id == p.Id)
                {
                    // Update the existing item
                    cc.Name = p.Name;
                    cc.price = p.Price;
                    cc.amount += 1;
                    //add suttotal 
                    total += System.Convert.ToDecimal(cc.price * cc.amount);
                    // Set found to true to indicate that the item was found and updated
                    found = true;
                    break; // Exit the loop since the item is found and updated
                }
            }

            // If the item was not found, add it to tmplist
            // how ever still add null item
            if (!found)
            {
                tmplist.Add(new CartItem()
                {
                    id = p.Id,
                    Name = p.Name,
                    price = p.Price,
                    amount = 1,
                    cur = p.Cur
                });
                total += System.Convert.ToDecimal(p.Price * 1); ;
            }

            //
            //clear dgv
            //if not null set null to reasign
            if (dgv.DataSource != null)
            {
                dgv.DataSource = null;
            }
            dgv.DataSource = tmplist;
            // Iterate through each row in the DataGridView
            //foreach (DataGridViewRow row in dgv.Rows)
            //{
            //    // Skip the last row, which is typically the new row for adding new data
            //    if (!row.IsNewRow)
            //    {
            //        // Create a new instance of DataItem and populate its properties
            //        CartItem prod = new CartItem()
            //        {
            //           id = System.Convert.ToInt32(row.Cells[0].Value),  
            //           Name = row.Cells[1].Value.ToString(),
            //           price = System.Convert.ToSingle(row.Cells[2].Value),
            //           amount = System.Convert.ToInt32(row.Cells[3].Value),
            //           cur = row.Cells[5].ToString()
            //        }; 
            //        // Add the data item to the list
            //        tmplist.Add(prod);
            //    }
            //}

            //// 
            //// Now Compare with income product then repopulate
            //foreach (CartItem cc in tmplist)
            //{
            //    if (cc.id == p.Id)
            //    {

            //    }
            //}

            //
            //after load
            UpdateLBS();
        }

        private void UpdateLBS()
        {
            decimal discountPercentage = (discount * total) / (total * 100);

            lbDisc.Text = string.Format("Discount: %{0} <= {1:c}", discount, discountPercentage);
            lbTotal.Text = string.Format("Total: C$ {0}", total);

            dgv.Rows.Clear();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.UtcNow;                      //Get Current Time
            //try
            {
                if (dgv.Rows.Count > 0)
                {
                    var ls = new List<InvoiceDetails>();        //New Invoice List
                    var inv = new Invoices();                   //New Invoice
                    {
                        inv.Invoice = currentTime.ToString();
                        inv.CusId = (cus.id <= 0 ? 0 : cus.id);
                        inv.usrId = usrID;
                        inv.Total = total;
                        inv.off = discount;
                        inv.Date = dt;
                    };

                    foreach (DataGridViewRow r in dgv.Rows)
                    {
                        // Skip the last row, which is typically the new row for adding new data
                        if (!r.IsNewRow)
                        {
                            // Create a new instance of CartItem and populate its properties
                            InvoiceDetails prod = new InvoiceDetails()
                            {
                                IID = System.Convert.ToInt32(r.Cells[0].Value),
                                ITEM = System.Convert.ToString(r.Cells[1].Value),
                                UNITPRICE = System.Convert.ToDecimal(r.Cells[2].Value),
                                QTY = System.Convert.ToInt32(r.Cells[3].Value),
                                BCODE = currentTime.ToString()
                                ,
                                CDATE = dt,
                                Active = true,
                                Off = 0
                            };

                            // Add the data item to the list
                            ls.Add(prod);
                        }
                    }
                    // Paying DX
                    using (cashing c = new cashing())
                    {
                        if (c.ShowDialog() == DialogResult.OK)
                        {
                            cash = c.total;
                            if (cash >= total)
                            {
                                // Transaction Successful
                                DataModule.SaveInvoice(inv);
                                // Invoices Detials
                                DataModule.SaveInvoceDetails(ls);
                            }
                        }
                    }
                }
            }
            //catch (Exception ps) { Console.WriteLine(ps.Message.ToString()); var g = new GMessage(); g.Show(ps.Message.ToString() /*+ Environment.NewLine + dt.ToString()*/); }

        }

        private void CartFrm_BackColorChanged(object sender, EventArgs e)
        {
            dgv.BackgroundColor = this.BackColor;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var owin = 0.0;
            using (AddCustomerToInvoice frm = new AddCustomerToInvoice())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    selid = frm.Sid;
                    custna = frm.cusname;
                    owin = frm.ow;
                    lbCustomer.Text = "Customer:" + custna;
                    lbCustomer.Tag = selid;
                    // tmp cusid
                    cus.id = selid;

                }
            }
        }

        private void CartFrm_Load(object sender, EventArgs e)
        {
            //
            // Generate Invoice N0.
            lbInvoice.Text = string.Format("Invoice:{0}-FAC ", GenerateUniqueNumber());
        }
        //
        //CHAT GPT 3.5
        public long GenerateUniqueNumber()
        {
            // Get the current time as a long value (ticks)
            currentTime = DateTime.UtcNow.Ticks;

            // You may also append milliseconds or other values for further uniqueness
            // long currentTimeWithMilliseconds = (DateTime.UtcNow.Ticks / TimeSpan.TicksPerMillisecond);

            // Return the current time as the unique number
            return currentTime;
        }

        private void BtnCancel_Clicked(object sender, EventArgs e)
        {
            UpdateLBS();
        }
        //
        // btn Addin discount
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            using (Discount ds = new Discount())
            {
                if (ds.ShowDialog() == DialogResult.OK)
                {
                    discount = System.Convert.ToDecimal(ds.dis);
                    UpdateLBS();
                }
            }
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            using (Serv sr = new Serv())
            {
                if (sr.ShowDialog() == DialogResult.OK)
                {
                    var tmpp = DataModule.GetProductID(sr.ID);
                    if (tmpp != null)
                    {
                        tmpp.Stock = sr.AM;
                        AddDGV(tmpp);
                    }
                }
            }
        }

        private void bottompanel_Paint(object sender, PaintEventArgs e)
        {

        }



        // -------------------------------------------------------------------
        // ----------------- GENERATE NEW INVOICE NUMBER ---------------------
        // -------------------------------------------------------------------
        private int GenerateInvoice()
        {
            Invoice = DataModule.GenerateInvoice();
            return Invoice;
        }

        private void btnGenerateInv_Click(object sender, EventArgs e)
        {
            GenerateInvoice();
            // Refres lbInvoice
            lbInvoice.Text = $"Invoice: {Invoice}";
        }

    }
}