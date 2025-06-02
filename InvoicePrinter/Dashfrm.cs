using System;
using System.Windows.Forms;

namespace InvoicePrinter
{
    public partial class Dashfrm : UserControl
    {
        //Fields
        private dashboard model;

        //Constructor
        public Dashfrm()
        {
            try
            {
                InitializeComponent();
                //Default - Last 7 days
                dtpStartDate.Value = DateTime.Today.AddDays(-7);
                dtpEndDate.Value = DateTime.Now;
                btnLast7Days.Select();

                model = new dashboard();
                LoadData();
            }
            catch (Exception d) { Console.WriteLine(d.Message); }
        }

        //Private methods
        private void LoadData()
        {
            try
            {
                var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
                if (refreshData == true)
                {

                    chartGrossRevenue.DataSource = model.GrossRevenueList;
                    chartGrossRevenue.Series[0].XValueMember = "Date";
                    chartGrossRevenue.Series[0].YValueMembers = "TotalAmount";
                    chartGrossRevenue.DataBind();

                    chartTopProducts.DataSource = model.TopProductsList;
                    chartTopProducts.Series[0].XValueMember = "Key";
                    chartTopProducts.Series[0].YValueMembers = "Value";
                    chartTopProducts.DataBind();

                    //dgvUnderstock.DataSource = model.UnderstockList;
                    //dgvUnderstock.Columns[0].HeaderText = "Item";
                    //dgvUnderstock.Columns[1].HeaderText = "Units";
                    Console.WriteLine("Loaded view :)");
                }
                else Console.WriteLine("View not loaded, same query");
            }
            catch { }
        }
        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOkCustomDate.Visible = false;
        }

        //Event methods
        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            try
            {
                dtpStartDate.Value = DateTime.Today.AddDays(-7);
                dtpEndDate.Value = DateTime.Now;
                LoadData();
                DisableCustomDates();
            }
            catch { }
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnOkCustomDate.Visible = true;
        }

        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void chartTopProducts_Click(object sender, EventArgs e)
        {

        }
    }
}
