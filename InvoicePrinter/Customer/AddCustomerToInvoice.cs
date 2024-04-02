using GUIHelper;
using System;
using System.Data;
using System.Windows.Forms;


using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Entities;
using DataBase;

namespace InvoicePrinter.Customer
{
    class AddCustomerToInvoice : GForm
    {
        //return the selected customer id and name
        public int Sid;
        public string cusname;
        //returning the owing amount
        public float ow = 0.0f;
        // Gen by UI
        private Label lbInv;
        private GButton btnAddNewCustomer;
        private System.ComponentModel.IContainer components;
        private GTxt txtSearch;
        private GButton btnClose;
        private BindingSource customersBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn srnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idcardDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn blockedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn owingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private DataGridViewButtonColumn clbtnedit;
        public Form pfrm ;
        public AddCustomerToInvoice()
        {
            DoubleBuffered = true;
            InitializeComponent();
            Thread lcus = new Thread(() => LoadCustomers());
            lcus.Start();
            lcus.Join();
        } 
        public AddCustomerToInvoice(Form owner, float owin)
        {
            DoubleBuffered = true;
            InitializeComponent();
            ow = owin;
            pfrm = owner;
            Thread lcus = new Thread(() => LoadCustomers());
            lcus.Start();
            lcus.Join();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomerToInvoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbInv = new System.Windows.Forms.Label();
            this.btnAddNewCustomer = new GUIHelper.GButton(this.components);
            this.txtSearch = new GUIHelper.GTxt();
            this.btnClose = new GUIHelper.GButton(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.owingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clbtnedit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbInv
            // 
            this.lbInv.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInv.Location = new System.Drawing.Point(5, 50);
            this.lbInv.Name = "lbInv";
            this.lbInv.Size = new System.Drawing.Size(1040, 47);
            this.lbInv.TabIndex = 21;
            this.lbInv.Text = "Add Customer to invoice";
            this.lbInv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewCustomer.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.btnAddNewCustomer.FlatAppearance.BorderSize = 2;
            this.btnAddNewCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnAddNewCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnAddNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewCustomer.Image")));
            this.btnAddNewCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(835, 10);
            this.btnAddNewCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddNewCustomer.MaximumSize = new System.Drawing.Size(140, 50);
            this.btnAddNewCustomer.MinimumSize = new System.Drawing.Size(140, 50);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Padding = new System.Windows.Forms.Padding(0, 3, 5, 5);
            this.btnAddNewCustomer.Size = new System.Drawing.Size(140, 50);
            this.btnAddNewCustomer.TabIndex = 22;
            this.btnAddNewCustomer.Text = "Add New";
            this.btnAddNewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewCustomer.UIStyle = GUIHelper.GButton.Style.Flat;
            this.btnAddNewCustomer.UseVisualStyleBackColor = true;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkOrchid;
            this.txtSearch.Location = new System.Drawing.Point(11, 10);
            this.txtSearch.MaximumSize = new System.Drawing.Size(380, 40);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.MinimumSize = new System.Drawing.Size(342, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(380, 30);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.WatermarkText = "Search Customer Names | Mobile ";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(995, 10);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.MaximumSize = new System.Drawing.Size(45, 45);
            this.btnClose.MinimumSize = new System.Drawing.Size(45, 45);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 24;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UIStyle = GUIHelper.GButton.Style.Cicle;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Fuchsia;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.srnameDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.idcardDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.nacionalityDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.blockedDataGridViewCheckBoxColumn,
            this.owingDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn,
            this.clbtnedit});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.customersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(5, 97);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 348);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataSource = typeof(Entities.Customers);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FULL NAME";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // srnameDataGridViewTextBoxColumn
            // 
            this.srnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.srnameDataGridViewTextBoxColumn.DataPropertyName = "srname";
            this.srnameDataGridViewTextBoxColumn.HeaderText = "srname";
            this.srnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.srnameDataGridViewTextBoxColumn.Name = "srnameDataGridViewTextBoxColumn";
            this.srnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.srnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "mobile";
            this.mobileDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcardDataGridViewTextBoxColumn
            // 
            this.idcardDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idcardDataGridViewTextBoxColumn.DataPropertyName = "idcard";
            this.idcardDataGridViewTextBoxColumn.HeaderText = "idcard";
            this.idcardDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcardDataGridViewTextBoxColumn.Name = "idcardDataGridViewTextBoxColumn";
            this.idcardDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Visible = false;
            // 
            // nacionalityDataGridViewTextBoxColumn
            // 
            this.nacionalityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nacionalityDataGridViewTextBoxColumn.DataPropertyName = "nacionality";
            this.nacionalityDataGridViewTextBoxColumn.HeaderText = "nacionality";
            this.nacionalityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nacionalityDataGridViewTextBoxColumn.Name = "nacionalityDataGridViewTextBoxColumn";
            this.nacionalityDataGridViewTextBoxColumn.ReadOnly = true;
            this.nacionalityDataGridViewTextBoxColumn.Visible = false;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // blockedDataGridViewCheckBoxColumn
            // 
            this.blockedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.blockedDataGridViewCheckBoxColumn.DataPropertyName = "blocked";
            this.blockedDataGridViewCheckBoxColumn.HeaderText = "blocked";
            this.blockedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.blockedDataGridViewCheckBoxColumn.Name = "blockedDataGridViewCheckBoxColumn";
            this.blockedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // owingDataGridViewTextBoxColumn
            // 
            this.owingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.owingDataGridViewTextBoxColumn.DataPropertyName = "owing";
            this.owingDataGridViewTextBoxColumn.HeaderText = "owing";
            this.owingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.owingDataGridViewTextBoxColumn.Name = "owingDataGridViewTextBoxColumn";
            this.owingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "money";
            this.moneyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            this.moneyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "active";
            this.activeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // clbtnedit
            // 
            this.clbtnedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Edit";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            this.clbtnedit.DefaultCellStyle = dataGridViewCellStyle3;
            this.clbtnedit.HeaderText = "Edit Info";
            this.clbtnedit.MinimumWidth = 6;
            this.clbtnedit.Name = "clbtnedit";
            this.clbtnedit.ReadOnly = true;
            this.clbtnedit.Text = "Edit";
            // 
            // AddCustomerToInvoice
            // 
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddNewCustomer);
            this.Controls.Add(this.lbInv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1050, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1050, 450);
            this.Name = "AddCustomerToInvoice";
            this.Padding = new System.Windows.Forms.Padding(5, 50, 5, 5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddCustomerToInvoice_KeyDown);
            this.SystemColorsChanged += new System.EventHandler(this.AddCustomerToInvoice_SystemColorsChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        /// <summary>
        /// here start the backend
        /// </summary>
        GMessage GMessage = new GMessage(); 
        private int ID;

        private void LoadCustomers()
        {
            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    dataGridView1.Rows.Clear();
                }

                List<Customers> cusls = DataModule.GetCustomers();
                dataGridView1.DataSource = cusls;

                //foreach (Customers Dr in cusls)
                //{
                //    //object[] values = new object[] { Dr.id.ToString(), Dr.FullName.ToString(), Dr.idcard.ToString(), Dr.mobile.ToString(), Dr.nacionality.ToString(), Dr.gender.ToString(), Dr.blocked.ToString(), Dr.owing.ToString(), Dr.money.ToString(), "ADD", "EDIT" };
                //    //this.dataGridView1.Rows.Add(values);

                //}
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
            finally { }

        }
        private void LoadCustomers(string qry)
        {
            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    dataGridView1.Rows.Clear();
                }

                List<Customers> cusls = DataModule.GetCustomers(qry);

                dataGridView1.DataSource = cusls;
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message); }
            finally { }

        }
        private void AddCustomerToInvoice_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.End)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();

            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 14) // inde start from 0
            {
                try
                {
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    GMessage.Show( ID + Environment.NewLine + ex.Message, "Marshell's");
                }

            }
            else if (e.ColumnIndex == 13) //if click edit
            {
                try
                {
                    AddCustomer ECustomer = new AddCustomer(ID);
                    if (ECustomer.ShowDialog() == DialogResult.OK)
                    {
                        LoadCustomers();
                    }
                }
#if DEBUG
                catch (Exception ex)
                {
                    GMessage.Show("EDIT FAILS!" +Environment.NewLine +ex.Message);
                }
#else
                catch (Exception)
                { }
#endif
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
             
                int index = dataGridView1.CurrentRow.Index;
                ID = System.Convert.ToInt32(dataGridView1[0, index].Value);
                cusname = (string)(dataGridView1[2, index].Value);
                Sid = (int)System.Convert.ToInt32(ID);
                ow += (float)System.Convert.ToDecimal(dataGridView1[8, index].Value);
            }
            catch { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if( e.RowIndex  > 0 || e.ColumnIndex >0)
            {

            }
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer DC = new AddCustomer();
            if (DC.ShowDialog() == DialogResult.OK)
            {
                LoadCustomers();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrEmpty(txtSearch.Text)) || (txtSearch.TextLength > 0))
                {
                    LoadCustomers(txtSearch.Text);
                }
                else
                {
                    LoadCustomers();
                }
            }
            catch (Exception)
            {

            }
        } 

        private void AddCustomerToInvoice_SystemColorsChanged(object sender, EventArgs e)
        {
            this.txtSearch.BackColor = this.BackColor;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentRow.Index;
                ID = System.Convert.ToInt32(dataGridView1[0, index].Value);
                cusname = (string)(dataGridView1[1, index].Value);
                Sid = (int)System.Convert.ToInt32(ID);
                ow += (float)System.Convert.ToDecimal(dataGridView1[8, index].Value);
            }
            catch { }
            this.DialogResult = DialogResult.OK;
        }
    }
}
