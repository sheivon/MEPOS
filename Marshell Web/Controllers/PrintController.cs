using Marshell_Web.Models;
using Microsoft.Reporting.WebForms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Web.Mvc;
using static Marshell_Web.Controllers.ProductsController;
using Warning = Microsoft.Reporting.WebForms.Warning;

namespace Marshell_Web.Controllers
{
    public class PrintController : Controller
    {
        // GET: Print
        public ActionResult Index()
        {
            return View();
        }

        #region Category
        public ActionResult PrintCategory()
        { // Create an instance of the LocalReport class and specify the report path
            LocalReport lr = new LocalReport();
            string path = Path.Combine(Server.MapPath("~/Report/rdlc"), "rptCategory.rdlc");
            if (System.IO.File.Exists(path))
            {
                lr.ReportPath = path;
            }
            else
            {
                return View("Error");
            }
            // Set the parameter for the report
            ReportParameter rp = new ReportParameter("rptTitle", "Marshell");
            lr.SetParameters(new ReportParameter[] { rp });

            // Supply data for the report
            DataTable dt = GetCategory(); // return a DataTable with the required data
            ReportDataSource rd = new ReportDataSource("DSCategory", dt); // DataSet1 is the name of the DataSet in your RDLC report
            lr.DataSources.Add(rd);

            // Render the report to a byte array
            string reportType = "PDF";
            string mimeType;
            string encoding;
            string fileNameExtension;

            string deviceInfo =
            "<DeviceInfo>" +
            "  <OutputFormat>PDF</OutputFormat>" +
            "  <PageWidth>8.5in</PageWidth>" +
            "  <PageHeight>11in</PageHeight>" +
            "  <MarginTop>0.08in</MarginTop>" +
            "  <MarginLeft>0.08in</MarginLeft>" +
            "  <MarginRight>0.08in</MarginRight>" +
            "  <MarginBottom>0.08in</MarginBottom>" +
            "</DeviceInfo>";

            Warning[] warnings;
            string[] streams;
            byte[] renderedBytes;

            renderedBytes = lr.Render(
                reportType,
                deviceInfo,
                out mimeType,
                out encoding,
                out fileNameExtension,
                out streams,
                out warnings);

            // Return the rendered report as a FileResult
            return File(renderedBytes, mimeType);
        }
        private DataTable GetCategory()
        {
            var categoriesTable = new DataTable();
            try
            {
                // Get the connection string
                var x = new Connectionstring();
                using (MySqlConnection con = new MySqlConnection(x.ConnectionString))
                {
                    // Open the connection to the database
                    con.Open();

                    // Create the MySQL query to fetch categories
                    string query = "SELECT category_id as CategoryId, name as Name,Description as Description , ACTIVE Active, created_at CreatedAt, updated_at UpdatedAt FROM categories";

                    using (MySqlCommand cm = new MySqlCommand(query, con))
                    {
                        // Execute the query
                        using (MySqlDataReader reader = cm.ExecuteReader())
                        {
                            // Load data into the DataTable
                            categoriesTable.Load(reader);
                        }
                    }
                }

                return categoriesTable;
            }
            catch (Exception ex)
            {
                // Handle the exception (log it if necessary)
                Console.WriteLine(ex.Message);

                // Return null if there's an error
                return null;
            }
        }


        #endregion

        #region Customers

        #endregion

        #region Products

        public ActionResult PrintProducts()
        { // Create an instance of the LocalReport class and specify the report path
            LocalReport lr = new LocalReport();
            string path = Path.Combine(Server.MapPath("~/Report/rdlc"), "rptProducts.rdlc");
            if (System.IO.File.Exists(path))
            {
                lr.ReportPath = path;
            }
            else
            {
                return View("Error");
            }
            // Set the parameter for the report
            ReportParameter rp = new ReportParameter("rptTitle", "Marshell");
            lr.SetParameters(new ReportParameter[] { rp });

            // Supply data for the report
            DataTable dt = GetProducts(); // return a DataTable with the required data
            ReportDataSource rd = new ReportDataSource("DSProducts", dt); // DataSet1 is the name of the DataSet in your RDLC report
            lr.DataSources.Add(rd);

            // Render the report to a byte array
            string reportType = "PDF";
            string mimeType;
            string encoding;
            string fileNameExtension;

            string deviceInfo =
            "<DeviceInfo>" +
            "  <OutputFormat>PDF</OutputFormat>" +
            "  <PageWidth>8.5in</PageWidth>" +
            "  <PageHeight>11in</PageHeight>" +
            "  <MarginTop>0.08in</MarginTop>" +
            "  <MarginLeft>0.08in</MarginLeft>" +
            "  <MarginRight>0.08in</MarginRight>" +
            "  <MarginBottom>0.08in</MarginBottom>" +
            "</DeviceInfo>";

            Warning[] warnings;
            string[] streams;
            byte[] renderedBytes;

            renderedBytes = lr.Render(
                reportType,
                deviceInfo,
                out mimeType,
                out encoding,
                out fileNameExtension,
                out streams,
                out warnings);

            // Return the rendered report as a FileResult
            return File(renderedBytes, mimeType);
        }
        private DataTable GetProducts()
        {
            var Table = new DataTable();
            try
            {
                // Get the connection string
                var x = new Connectionstring();
                using (MySqlConnection con = new MySqlConnection(x.ConnectionString))
                {
                    // Open the connection to the database
                    con.Open();

                    // Create the MySQL query to fetch categories
                    string query = "SELECT p.name product,c.name Category,description,price,cost,sku,barcode,p.created_at,p.updated_at Updatedat FROM `products` p join categories c on p.category_id = c.category_id";

                    using (MySqlCommand cm = new MySqlCommand(query, con))
                    {
                        // Execute the query
                        using (MySqlDataReader reader = cm.ExecuteReader())
                        {
                            // Load data into the DataTable
                            Table.Load(reader);
                        }
                    }
                }

                return Table;
            }
            catch (Exception ex)
            {
                // Handle the exception (log it if necessary)
                Console.WriteLine(ex.Message);

                // Return null if there's an error
                return null;
            }
        }
        #endregion
        #region Sales
        public ActionResult PrintInvoice(string ord, int sid)
        { // Create an instance of the LocalReport class and specify the report path
            LocalReport lr = new LocalReport();
            string path = Path.Combine(Server.MapPath("~/Report/rdlc"), "Recibo.rdlc");
            if (System.IO.File.Exists(path))
            {
                lr.ReportPath = path;
            }
            else
            {
                return View("Error");
            }
            ProductsController.CartItemsParams ca = new ProductsController.CartItemsParams();
            ca.ord = ord;
            ca.sid = sid;
            // Set the parameter for the report
            ReportParameter rp = new ReportParameter("rptTitle", "Marshell");
            lr.SetParameters(new ReportParameter[] { rp });

            // Supply data for the report
            DataTable dt = GetrtpCartItems(ca); // return a DataTable with the required data
            ReportDataSource rd = new ReportDataSource("DSInvoice", dt); // DataSet1 is the name of the DataSet in your RDLC report
            lr.DataSources.Add(rd);

            // Render the report to a byte array
            string reportType = "PDF";
            string mimeType;
            string encoding;
            string fileNameExtension;

            string deviceInfo =
            "<DeviceInfo>" +
            "  <OutputFormat>PDF</OutputFormat>" +
            "  <PageWidth>8.5in</PageWidth>" +
            "  <PageHeight>11in</PageHeight>" +
            "  <MarginTop>0.08in</MarginTop>" +
            "  <MarginLeft>0.08in</MarginLeft>" +
            "  <MarginRight>0.08in</MarginRight>" +
            "  <MarginBottom>0.08in</MarginBottom>" +
            "</DeviceInfo>";

            Warning[] warnings;
            string[] streams;
            byte[] renderedBytes;

            renderedBytes = lr.Render(
                reportType,
                deviceInfo,
                out mimeType,
                out encoding,
                out fileNameExtension,
                out streams,
                out warnings);

            // Return the rendered report as a FileResult
            return File(renderedBytes, mimeType);
        }

        public DataTable GetrtpCartItems(CartItemsParams ci)
        {
            var lcartiem = new DataTable();
            var x = new Connectionstring();
            using (MySqlConnection connection = new MySqlConnection(x.ConnectionString))
            {
                // SQL query to select a sale by SaleId
                string query = @"SELECT Cartitemid,ProductId,productname,Price,Quantity,Discount,TaxAmount,SaleId,Ordernumber,ProductDescription  FROM cartitems where Ordernumber = @ordn and SaleId=@sid ORDER BY Ordernumber ASC";

                MySqlCommand command = new MySqlCommand(query, connection);

                connection.Open();
                command.Parameters.Add("@ordn", MySqlDbType.String).Value = ci.ord;
                command.Parameters.Add("@sid", MySqlDbType.Int32).Value = ci.sid;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CartItem caritem = new CartItem
                        {
                            CartItemId = reader.GetInt32(0),
                            ProductId = reader.GetInt32(1),
                            ProductName = reader.GetString(2),
                            Price = reader.GetDecimal(3),
                            Quantity = reader.GetInt32(4),
                            Discount = reader.GetDecimal(5),
                            TaxAmount = reader.GetDecimal(6),
                            SaleId = reader.GetInt32(7),
                            OrderNumber = reader.GetString(8),
                            ProductDescription = reader.IsDBNull(9) ? "N/A" : reader.GetString(9)
                        };

                        lcartiem.Rows.Add(caritem);
                    }

                }
            }
            return lcartiem;
        }
        public ActionResult PrintSales()
        {
            // Create an instance of the LocalReport class and specify the report path
            LocalReport lr = new LocalReport();
            string path = Path.Combine(Server.MapPath("~/Report/rdlc"), "rptSales.rdlc");
            if (System.IO.File.Exists(path))
            {
                lr.ReportPath = path;
            }
            else
            {
                return View("Error");
            } 
            // Set the parameter for the report
            ReportParameter rp = new ReportParameter("rptTitle", "Marshell");
            lr.SetParameters(new ReportParameter[] { rp });

            // Supply data for the report
            DataTable dt = PrintrtpSales(); // return a DataTable with the required data
            ReportDataSource rd = new ReportDataSource("DSSales", dt); // DataSet1 is the name of the DataSet in your RDLC report
            lr.DataSources.Add(rd);

            // Render the report to a byte array
            string reportType = "PDF";
            string mimeType;
            string encoding;
            string fileNameExtension;

            string deviceInfo =
            "<DeviceInfo>" +
            "  <OutputFormat>PDF</OutputFormat>" +
            "  <PageWidth>8.5in</PageWidth>" +
            "  <PageHeight>11in</PageHeight>" +
            "  <MarginTop>0.08in</MarginTop>" +
            "  <MarginLeft>0.08in</MarginLeft>" +
            "  <MarginRight>0.08in</MarginRight>" +
            "  <MarginBottom>0.08in</MarginBottom>" +
            "</DeviceInfo>";

            Warning[] warnings;
            string[] streams;
            byte[] renderedBytes;

            renderedBytes = lr.Render(
                reportType,
                deviceInfo,
                out mimeType,
                out encoding,
                out fileNameExtension,
                out streams,
                out warnings);

            // Return the rendered report as a FileResult
            return File(renderedBytes, mimeType);
        }
        private DataTable PrintrtpSales()
        {
            var Table = new DataTable();
            try
            {
                // Get the connection string
                var x = new Connectionstring();
                using (MySqlConnection con = new MySqlConnection(x.ConnectionString))
                {
                    // Open the connection to the database
                    con.Open();

                    // Create the MySQL query to fetch categories
                    string query = "SELECT s.saleid saleid, s.saledate saledate, s.totalamount total, s.customerid customerid, s.paymentmethod paymentmethod, s.createdat createdat,s.OrderNumber ordernumber, c.first_name firstname, s.customeremail email, s.customerphone phone,c.last_name lastname FROM sales s join customers as c on s.customerid = c.customer_id;";

                    using (MySqlCommand cm = new MySqlCommand(query, con))
                    {
                        // Execute the query
                        using (MySqlDataReader reader = cm.ExecuteReader())
                        {
                            // Load data into the DataTable
                            Table.Load(reader);
                        }
                    }
                }

                return Table;
            }
            catch (Exception ex)
            {
                // Handle the exception (log it if necessary)
                Console.WriteLine(ex.Message);

                // Return null if there's an error
                return null;
            }
        }
        #endregion
    }
}