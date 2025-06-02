using Marshell_Web.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Marshell_Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() 
        {
            if (Session["user"] == null)
            {
                // Redirect to login page if the user is not authenticated
                return RedirectToAction("Login", "Account");
            } 
            // Session["user"] exists, proceed with the action
            var user = Session["user"];

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        #region Dashboard
        public JsonResult Totalusers() {
            int count = 0;
            var x = new Connectionstring();
            using (var connection = new MySqlConnection(x.ConnectionString))
            { 
                connection.Open();
                using (MySqlCommand cm = connection.CreateCommand())
                {
                    cm.CommandText = "select count(*) QTY from users";
                    cm.Connection = connection;
                    cm.CommandType = System.Data.CommandType.Text;
                    cm.CommandTimeout = 500;
                   count = Convert.ToInt32( cm.ExecuteScalar());
                }
            }

         return Json(new {data= count}, JsonRequestBehavior.AllowGet); } 
        public JsonResult Totalcustomers() {
            int count = 0;
            var x = new Connectionstring();
            using (var connection = new MySqlConnection(x.ConnectionString))
            { 
                connection.Open();
                using (MySqlCommand cm = connection.CreateCommand())
                {
                    cm.CommandText = "select count(*) QTY from customers";
                    cm.Connection = connection;
                    cm.CommandType = System.Data.CommandType.Text;
                    cm.CommandTimeout = 500;
                   count = Convert.ToInt32( cm.ExecuteScalar());
                }
            }

         return Json(new {data= count}, JsonRequestBehavior.AllowGet); } 
        public JsonResult Totalsales() {
            int count = 0;
            var x = new Connectionstring();
            using (var connection = new MySqlConnection(x.ConnectionString))
            { 
                connection.Open();
                using (MySqlCommand cm = connection.CreateCommand())
                {
                    cm.CommandText = "select count(*) QTY from sales";
                    cm.Connection = connection;
                    cm.CommandType = System.Data.CommandType.Text;
                    cm.CommandTimeout = 500;
                   count = Convert.ToInt32( cm.ExecuteScalar());
                }
            }

         return Json(new {data= count}, JsonRequestBehavior.AllowGet); }
        public JsonResult Totalsuppliers() {
            int count = 0;
            var x = new Connectionstring();
            using (var connection = new MySqlConnection(x.ConnectionString))
            { 
                connection.Open();
                using (MySqlCommand cm = connection.CreateCommand())
                {
                    cm.CommandText = "select count(*) QTY from suppliers";
                    cm.Connection = connection;
                    cm.CommandType = System.Data.CommandType.Text;
                    cm.CommandTimeout = 500;
                   count = Convert.ToInt32( cm.ExecuteScalar());
                }
            }

         return Json(new {data= count}, JsonRequestBehavior.AllowGet); }
        public JsonResult Top5Sales()
        {
            var top = GetTop5Sales();
            return Json(new { data =top}, JsonRequestBehavior.AllowGet);
        }


        private List<sales> GetTop5Sales()
        {
            var saleslist = new List<sales>();
            var x = new Connectionstring();
            using (MySqlConnection connection = new MySqlConnection(x.ConnectionString))
            {
                // SQL query to select top 5 sale by total amount
                string query = @"SELECT s.saleid, s.saledate, s.totalamount, s.customerid, s.paymentmethod, s.createdat,s.OrderNumber, c.first_name, s.customeremail, s.customerphone,c.last_name
FROM sales s 
join customers as c on s.customerid = c.customer_id order by totalamount DESC limit 0,5;";

                MySqlCommand command = new MySqlCommand(query, connection);

                connection.Open();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cus = new Customers()
                        {
                            customer_id = reader.IsDBNull(3) ? 0 : reader.GetInt32(3),
                            first_name = reader.IsDBNull(7) ? "N/A" : reader.GetString(7),
                            last_name = reader.IsDBNull(10) ? "N/A" : reader.GetString(10),
                            email = reader.IsDBNull(8) ? "N/A" : reader.GetString(8),
                            phone = reader.IsDBNull(9) ? "N/A" : reader.GetString(9)
                        };

                        // Create and populate a Sale object
                        sales sale = new sales
                        {
                            SaleId = reader.GetInt32(0),
                            SaleDate = reader.GetDateTime(1),
                            TotalAmount = reader.GetDecimal(2),
                            PaymentMethod = reader.IsDBNull(4) ? "N/A" : reader.GetString(4),
                            CreatedAt = reader.GetDateTime(5),
                            OrderNumber = reader.GetString(6),
                            Customers = cus
                        };

                        saleslist.Add(sale);
                    }

                }
            }
            return saleslist;
        }
        #endregion
    }
}