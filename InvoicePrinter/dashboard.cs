using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MySql.Data;
using MarshellsSettings;
using MySql.Data.MySqlClient;
using Entities;

namespace InvoicePrinter
{ 
    public class dashboard
    {
        //Fields & Properties
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;
        //
        //
        // 
        public int NumCustomers { get; private set; } 
        public int NumProducts { get; private set; }
        public List<semiprod> TopProductsList { get; private set; }
        public List<KeyValuePair<string, int>> UnderstockList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumOrders { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set; }
        //
        public List<AnalyticItem> TopProd { get; set; }
        //Constructor
        public dashboard()
        {
           
        }

        //Private methods
        private void GetNumberItems()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    connection.Open();
                    using (var command = new MySqlCommand())
                    {
                        command.Connection = connection;
                        //Get Total Number of Customers
                        command.CommandText = "select count(id) from Customer";
                        NumCustomers = (int)command.ExecuteScalar();
                        Console.WriteLine(NumCustomers);
                        //Get Total Number of Products
                        command.CommandText = "select count(id) from Product";
                        NumProducts = (int)command.ExecuteScalar();
                        Console.WriteLine(NumProducts);
                        //Get Total Number of Orders
                        command.CommandText = @"select count(id) from invoices" +
                                                "where IDate between  @fromDate and @toDate";
                        command.Parameters.Add("@fromDate", MySqlDbType.DateTime).Value = startDate;
                        command.Parameters.Add("@toDate", MySqlDbType.DateTime).Value = endDate;
                        NumOrders = (int)command.ExecuteScalar();
                    }
                    connection.Close();
                }
            }
            catch (Exception p) { Console.WriteLine(p); }

        }
        private void GetProductAnalisys()
        {
            try
            {
                TopProductsList = new List<semiprod>();
                UnderstockList = new List<KeyValuePair<string, int>>();
                using (MySqlConnection connection = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    connection.Open();
                    using (var command = new MySqlCommand())
                    {
                        MySqlDataReader reader;
                        command.Connection = connection;
                        //Get Top 10 products
                        command.CommandText = @"select P.ProductName, sum(credits.qnt) as Q,SUM(credits.OWIN) as O
                                            from credits
                                            inner join Product P on P.Id = Credits.ITEMID
                                            inner
                                            join invoices O on O.invoice = credits.barcode
                                            where IDate between @fromDate and @toDate
                                            group by P.ProductName
                                            order by Q desc ";
                        command.Parameters.Add("@fromDate", MySqlDbType.DateTime).Value = startDate;
                        command.Parameters.Add("@toDate", MySqlDbType.DateTime).Value = endDate;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            string nam = reader.GetString(0);
                            int val = reader.GetInt32(1);
                            float ow = reader.GetFloat(2);
                            TopProductsList.Add(new semiprod { Name = nam, Total = val, UPrice = ow });
                            //AnalyticItem a = new AnalyticItem();
                            //a.name = nam;
                            //a.value = val;
                            //TopProd.Add(a   );
                        }
                        reader.Close();

                        //Get Understock
                        command.CommandText = @"select ProductName, productStock
                                            from Product
                                            where productStock <= 10 and active = 1 and type=0 order by Productstock desc;";
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            var unitem = new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]);
                            UnderstockList.Add(unitem);
                            Console.WriteLine(unitem);
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception d){ Console.WriteLine(d.Message); }
        }
        private void GetOrderAnalisys()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalProfit = 0;
            TotalRevenue = 0;

            using (MySqlConnection connection = new MySqlConnection(MSetting.GetConnectionstring()))
            {
                connection.Open();
                using (var command = new MySqlCommand(@"select IDate, sum(TOTAL)
                                            from INVOICES
                                            where IDate between @fromDate and @toDate
                                            group by IDate",connection))
                { 
                    command.Parameters.Add("@fromDate", MySqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", MySqlDbType.DateTime).Value = endDate;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        resultTable.Add(
                            new KeyValuePair<DateTime, decimal>((DateTime)reader.GetDateTime(0), (decimal)reader.GetDecimal(1))
                            );
                        TotalRevenue += (decimal)reader.GetDecimal(1);
                    }
                    TotalProfit = TotalRevenue * 0.2m;//20%
                    reader.Close();

                    //Group by Hours
                    if (numberDays <= 1)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("hh tt")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    //Group by Days
                    else if (numberDays <= 30)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("dd MMM")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Group by Weeks
                    else if (numberDays <= 92)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = "Week " + order.Key.ToString(),
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Group by Months
                    else if (numberDays <= (365 * 2))
                    {
                        bool isYear = numberDays <= 365 ? true : false;
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("MMM yyyy")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Group by Years
                    else
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("yyyy")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    Console.WriteLine(GrossRevenueList.ToString());
                }
            }
        }

        //Public methods
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);

            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;
                //get staticss
                Getstatistic();
                Console.WriteLine("Loaded view :)");
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString()); 
                return true;
            }
            else
            { 
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
        private void Getstatistic()
        {
            //get staticss
            Console.WriteLine("Numbers Static running");
            GetNumberItems();
            Console.WriteLine("Numbers Static runned success");

            Console.WriteLine("Product Analisys running");
            GetProductAnalisys();
            Console.WriteLine("Product Analisys");

            Console.WriteLine("Order Analisys running");
            GetOrderAnalisys();
            Console.WriteLine("Order Analisys");
        }
    }
}



