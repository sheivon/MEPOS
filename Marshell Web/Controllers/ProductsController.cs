using Marshell_Web.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;


namespace Marshell_Web.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult payment() { return View(); }
        public ActionResult Pricing() { return View(); }
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Loadproducts()
        {
            var plist = GetProducts();
            return Json(new { data = plist }, JsonRequestBehavior.AllowGet);
        }
        // --------------------------------------
        //              Product's
        // --------------------------------------
        #region Products
        public static List<Products> GetProducts()
        {
            List<Products> lp = new List<Products>();
            try
            {
                var x = new Connectionstring();
                using (MySqlConnection cn = new MySqlConnection(x.ConnectionString))
                {
                    cn.Open();
                    using (MySqlCommand cm = new MySqlCommand())
                    {
                        cm.CommandText = "select p.product_id, p.name,p.description,p.price,p.cost,p.sku,p.category_id,c.name,p.barcode,p.created_at,p.updated_at from products p   join categories c on c.category_id = p.category_id";
                        cm.Connection = cn;
                        cm.CommandType = CommandType.Text;

                        MySqlDataReader r = cm.ExecuteReader();
                        while (r.Read())
                        {
                            // Initialize a new product object
                            Products p = new Products();
                            // Safely read values from the SqlDataReader
                            p.ProductId = r.IsDBNull(0) ? 0 : r.GetInt32(0); // product_id
                            p.Name = r.IsDBNull(1) ? string.Empty : r.GetString(1); // name
                            p.Description = r.IsDBNull(2) ? string.Empty : r.GetString(2); // description
                            p.Price = r.IsDBNull(3) ? 0 : r.GetDecimal(3); // price
                            p.Cost = r.IsDBNull(4) ? 0 : r.GetDecimal(4); // cost
                            p.Sku = r.IsDBNull(5) ? string.Empty : r.GetString(5); // sku
                            p.CategoryId = r.IsDBNull(6) ? 1 : r.GetInt32(6); // category_id (nullable)
                            p.CategoryName = r.GetString(7);
                            p.Barcode = r.IsDBNull(8) ? string.Empty : r.GetString(8); // barcode
                            //p.CreatedAt = r.IsDBNull(8) ? DateTime.MinValue : r.GetDateTime(8); // created_at
                            p.CreatedAt = r.GetDateTime(9); // created_at
                            p.UpdatedAt = r.IsDBNull(10) ? DateTime.MinValue : r.GetDateTime(10); // updated_at 

                            // Add the product to the list
                            lp.Add(p);
                        }
                    }
                }

            }
#if DEBUG
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Fail to Load Products");
            }
#else
            catch (Exception)
            { }
#endif
            return lp;
        }
        public static DataTable GetrptProducts(string Keyword = "")
        {
            var dt = new DataTable();
            try
            {
                var x = new Connectionstring();
                using (MySqlConnection cn = new MySqlConnection(x.ConnectionString))
                {
                    cn.Open();
                    using (MySqlCommand cm = new MySqlCommand(string.Format("SELECT ID,PRODUCTCODE,PRODUCTNAME,PRODUCTSTOCK QTY,PRODUCTPRICE PRICE,CUR,TYPE,ACTIVE FROM PRODUCT"), cn))
                    {
                        MySqlDataReader r = cm.ExecuteReader();
                        while (r.Read())
                        {
                            // Initialize a new product object
                            Products p = new Products();

                            // Safely read values from the SqlDataReader
                            p.ProductId = r.IsDBNull(0) ? 0 : r.GetInt32(0); // product_id
                            p.Name = r.IsDBNull(1) ? string.Empty : r.GetString(1); // name
                            p.Description = r.IsDBNull(2) ? string.Empty : r.GetString(2); // description
                            p.Price = r.IsDBNull(3) ? 0 : r.GetDecimal(3); // price
                            p.Cost = r.IsDBNull(4) ? 0 : r.GetDecimal(4); // cost
                            p.Sku = r.IsDBNull(5) ? string.Empty : r.GetString(5); // sku
                            p.CategoryId = r.IsDBNull(6) ? (int?)null : r.GetInt32(6); // category_id (nullable)
                            p.Barcode = r.IsDBNull(7) ? string.Empty : r.GetString(7); // barcode
                            p.CreatedAt = r.IsDBNull(8) ? DateTime.MinValue : r.GetDateTime(8); // created_at
                            p.UpdatedAt = r.IsDBNull(9) ? DateTime.MinValue : r.GetDateTime(9); // updated_at 
                            dt.Rows.Add(p);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Fail to Load Products");
                return new DataTable();
            }
            return dt;
        }

        /// <summary>
        /// Get Product by Barcode and retun product
        /// </summary>
        /// <param name="BC"></param>
        /// <returns></returns>
        public static Products GetProductBC(string BC /*Barcode only*/)
        {
            Products rp = new Products();
            try
            {
                var x = new Connectionstring();
                using (MySqlConnection cn = new MySqlConnection(x.ConnectionString))
                {
                    cn.Open();
                    using (MySqlCommand cm = new MySqlCommand())
                    {
                        cm.Connection = cn;

                        cm.CommandText = "SELECT ID,PRODUCTCODE,PRODUCTNAME,PRODUCTSTOCK QTY,PRODUCTPRICE PRICE,CUR,TYPE,ACTIVE FROM PRODUCT WHERE PRODUCTCODE=@BC and active=1 and type=0 LIMIT 1;";

                        cm.Parameters.Add("@BC", MySqlDbType.VarChar).Value = BC;

                        cm.CommandType = CommandType.Text;

                        MySqlDataReader r = cm.ExecuteReader();
                        while (r.Read())
                        { // Initialize a new product object
                            Products p = new Products();

                            // Safely read values from the SqlDataReader
                            p.ProductId = r.IsDBNull(0) ? 0 : r.GetInt32(0); // product_id
                            p.Name = r.IsDBNull(1) ? string.Empty : r.GetString(1); // name
                            p.Description = r.IsDBNull(2) ? string.Empty : r.GetString(2); // description
                            p.Price = r.IsDBNull(3) ? 0 : r.GetDecimal(3); // price
                            p.Cost = r.IsDBNull(4) ? 0 : r.GetDecimal(4); // cost
                            p.Sku = r.IsDBNull(5) ? string.Empty : r.GetString(5); // sku
                            p.CategoryId = r.IsDBNull(6) ? (int?)null : r.GetInt32(6); // category_id (nullable)
                            p.Barcode = r.IsDBNull(7) ? string.Empty : r.GetString(7); // barcode
                            p.CreatedAt = r.IsDBNull(8) ? DateTime.MinValue : r.GetDateTime(8); // created_at
                            p.UpdatedAt = r.IsDBNull(9) ? DateTime.MinValue : r.GetDateTime(9); // updated_at 
                            rp = p;
                        }
                    }
                    cn.Close();
                }
            }
            catch (Exception bcp) { Console.WriteLine($"Barcode Search Err:{bcp.Message}"); }
            return rp;
        }
        public static Products GetProductID(int ID /*ID only*/)
        {
            Products rp = null;
            try
            {
                rp = GetProducts().Where(p => p.ProductId == ID).FirstOrDefault();

            }
            catch { }
            return rp;
        }
        /* Activate or Deactive a Product*/
        public static void ActivateProduct(int id, bool act = true)
        {
            try
            {
                var x = new Connectionstring();
                using (MySqlConnection c = new MySqlConnection(x.ConnectionString))
                {
                    c.Open();
                    string qry = "";
                    if (id > 0)
                    {
                        if (act == false)
                        {
                            qry = "UPDATE PRODUCT SET active='0' WHERE ID=@id";
                        }
                        if (act == true)
                        {
                            qry = "UPDATE PRODUCT SET active='1' WHERE ID=@id";
                        }
                        using (MySqlCommand cm = new MySqlCommand(qry, c))
                        {
                            cm.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                            int EX = cm.ExecuteNonQuery();
                            if (EX == 1)
                                Console.WriteLine("PRODUCT / SOFTWARE STATUS UPDATE SUCCESSFUL");
                            else
                                Console.WriteLine("ERR CHANGIN STAT");
                        }
                    }
                }
            }
            catch { }
        }

        public static void SaveProduct(Products p)
        {
            try
            {
                var x = new Connectionstring();
                using (MySqlConnection c = new MySqlConnection(x.ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cm = new MySqlCommand())
                    {
                        cm.Connection = c;
                        cm.CommandType = CommandType.Text;

                        if (p.ProductId == 0)
                        {
                            cm.CommandText = "INSERT IGNORE INTO PRODUCT(PRODUCTCODE, PRODUCTNAME, PRODUCTSTOCK, PRODUCTPRICE, CUR, TYPE, ACTIVE) VALUES(@bc,@pn,@pi,@pp,@tp,@mn,@ac)";
                            //System.Windows.Forms.MessageBox.Show("NEW");
                        }
                        else
                        {
                            cm.CommandText = "UPDATE PRODUCT SET PRODUCTCODE=@bc, PRODUCTNAME=@pn, PRODUCTSTOCK=@pi, PRODUCTPRICE=@pp, type=@tp, CUR=@mn,ACTIVE=@ac WHERE ID=@id;";
                            // if updating then add extra params
                            cm.Parameters.Add("@id", MySqlDbType.Int32).Value = p.ProductId;
                        }

                        cm.Parameters.Add("@bc", MySqlDbType.VarChar, 50).Value = p.Barcode;
                        cm.Parameters.Add("@pn", MySqlDbType.VarChar, 50).Value = p.Name;
                        cm.Parameters.Add("@pp", MySqlDbType.Float, 12).Value = p.Price;
                        //
                        //EXCEUTE OP
                        int u = cm.ExecuteNonQuery();

                        if (u == 1)
                        { Console.WriteLine("!! SAVE SUCCESSFUL !!"); }

                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public JsonResult GetProductDetails(int id)
        {
            return Json(new { data = GetProductID(id) }, JsonRequestBehavior.AllowGet);
        }
        #endregion
        // --------------------------------------
        //              Supplier's
        // --------------------------------------

        #region Suppliers
        public ActionResult Supplier()
        {
            return View();
        }

        public JsonResult GetSuppliers()
        {
            var ls = AllSuppliers();
            return Json(new { data = ls }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetSuppliersId(int id)
        {
            var ls = AllSuppliers().Where(s => s.supplier_id == id).ToList();
            return Json(new { data = ls }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult SaveSupplier(Suppliers sup)
        {
            int Saved = SaveSupplierDB(sup);
            return Json(new { data = Saved }, JsonRequestBehavior.AllowGet);
        }
        private int SaveSupplierDB(Suppliers supp)
        {
            string qry = string.Empty;
            try
            {
                var x = new Connectionstring();
                using (MySqlConnection con = new MySqlConnection(x.ConnectionString))
                {
                    con.Open();
                    using (MySqlCommand cm = new MySqlCommand())
                    {
                        cm.Connection = con;
                        cm.CommandType = CommandType.Text;


                        if (supp.supplier_id == 0) // New
                        {
                            qry = "INSERT INTO suppliers(name,contact_info) VALUES(@na,@ci);SELECT LAST_INSERT_ID() AS id;";
                        }
                        else //update
                        { 
                            qry = "UPDATE suppliers SET name=@na,contact_info=@ci where supplier_id=@id;SELECT @id AS id;";
                            cm.Parameters.AddWithValue("@id", supp.supplier_id);
                        }
                        cm.Parameters.AddWithValue("@na", supp.name);
                        cm.Parameters.AddWithValue("@ci", supp.contactinfo);

                        cm.CommandText = qry;

                        //execute
                        var result = cm.ExecuteScalar(); // Execute and get the result

                        // Return the supplier ID (either newly inserted or the updated one)
                        return result != null ? Convert.ToInt32(result) : supp.supplier_id;

                    }
                }
            }
            catch (Exception ex) { Console.WriteLine($"{ex.Message}"); return -1; }
        }
        private List<Suppliers> AllSuppliers()
        {
            var ls = new List<Suppliers>();
            try
            {
                var x = new Connectionstring();
                using (MySqlConnection cn = new MySqlConnection(x.ConnectionString))
                {
                    cn.Open();
                    using (MySqlCommand cm = new MySqlCommand("SELECT supplier_id,name,contact_info,created_at FROM suppliers ", cn))
                    {
                        MySqlDataReader r = cm.ExecuteReader();
                        while (r.Read())
                        {
                            // Initialize a new product object
                            Suppliers s = new Suppliers();

                            // Safely read values from the SqlDataReader
                            s.supplier_id = r.IsDBNull(0) ? 0 : r.GetInt32(0);
                            s.name = r.IsDBNull(1) ? string.Empty : r.GetString(1);
                            s.contactinfo = r.IsDBNull(2) ? string.Empty : r.GetString(2);
                            s.created_at = r.IsDBNull(3) ? DateTime.MinValue : r.GetDateTime(3); // created_at 

                            // Add the product to the list
                            ls.Add(s);
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return ls;
        }
        #endregion
        // --------------------------------------
        //              Sales's
        // --------------------------------------

        #region Sales
        public class CartItemsParams
        {
            public string ord { get; set; }
            public int sid { get; set; }
        }
        public ActionResult Sales() { return View(); }

        public JsonResult GetSales()
        {
            var saleslist = new List<sales>();
            var x = new Connectionstring();
            using (MySqlConnection connection = new MySqlConnection(x.ConnectionString))
            {
                // SQL query to select a sale by SaleId
                string query = @"SELECT s.saleid, s.saledate, s.totalamount, s.customerid, s.paymentmethod, s.createdat,s.OrderNumber, c.first_name, s.customeremail, s.customerphone,c.last_name FROM sales s join customers as c on s.customerid = c.customer_id;";

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
            return Json(new { data = saleslist }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetCartItems(CartItemsParams ci)
        {
            var lcartiem = new List<CartItem>();
            var x = new Connectionstring();
            using (MySqlConnection connection = new MySqlConnection(x.ConnectionString))
            {
                // SQL query to select a sale by SaleId
                string query = @"SELECT Cartitemid,ProductId,productname,Price,Quantity,Discount,TaxAmount,SaleId,Ordernumber,ProductDescription  FROM cartitems where Ordernumber = @ordn and SaleId=@sid ORDER BY Ordernumber ASC";

                MySqlCommand command = new MySqlCommand(query, connection);

                connection.Open();
                command.Parameters.Add("@ordn",MySqlDbType.String).Value = ci.ord;
                command.Parameters.Add("@sid", MySqlDbType.Int32).Value= ci.sid;

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
                           ProductDescription = reader.IsDBNull(9)?"N/A": reader.GetString(9)
                        };

                        lcartiem.Add(caritem);
                    }

                }
            }
            return Json(new { data = lcartiem}, JsonRequestBehavior.AllowGet);
        }
        // Method to update a sale
        public void UpdateSale(sales sale)
        {
            var x = new Connectionstring();
            using (MySqlConnection connection = new MySqlConnection(x.ConnectionString))
            {
                // SQL query to update a sale
                string query = @"
                    UPDATE sales
                    SET sale_date = @SaleDate, total_amount = @TotalAmount, customer_id = @CustomerId, 
                        payment_method = @PaymentMethod, created_at = @CreatedAt
                    WHERE sale_id = @SaleId;";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@SaleId", sale.SaleId);
                command.Parameters.AddWithValue("@SaleDate", sale.SaleDate);
                command.Parameters.AddWithValue("@TotalAmount", sale.TotalAmount);
                command.Parameters.AddWithValue("@CustomerId", sale.Customers.customer_id ); // Handle nullable customer_id
                command.Parameters.AddWithValue("@PaymentMethod", sale.PaymentMethod ?? (object)DBNull.Value); // Handle nullable payment_method
                command.Parameters.AddWithValue("@CreatedAt", sale.CreatedAt);

                connection.Open();
                command.ExecuteNonQuery(); // Execute the update query
                connection.Close();
            }
        }
        // Method to delete a sale by SaleId
        public void DeleteSale(int saleId)
        {
            var x = new Connectionstring();
            using (MySqlConnection connection = new MySqlConnection(x.ConnectionString))
            {
                // SQL query to delete a sale by SaleId
                string query = "DELETE FROM sales WHERE sale_id = @SaleId";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@SaleId", saleId);

                connection.Open();
                command.ExecuteNonQuery(); // Execute the delete query
                connection.Close();
            }
        }


        #endregion
        // --------------------------------------
        //              Return's
        // --------------------------------------

        #region Returns
        public ActionResult Returns() { return View(); }
        public JsonResult GetReturns()
        {
            return Json(new { data = GetReturnsList() }, JsonRequestBehavior.AllowGet);
        }
        public List<Returns> GetReturnsList()
        {
            var list = new List<Returns>();
            try
            {
                var x = new Connectionstring();
                using (MySqlConnection connection = new MySqlConnection(x.ConnectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        command.CommandType = CommandType.Text;
                        command.CommandText = "select return_id,sale_id,r.product_id,quantity_returned,return_date,p.name from returns r join products p on r.product_id = p.product_id";

                        var r = command.ExecuteReader();
                        while (r.Read())
                        {
                            list.Add(new Returns() { return_id = r.GetInt32(0), sale_id = r.GetInt32(1), product_id = r.GetInt32(2), quantity_returned = r.GetDecimal(3), return_date = r.GetDateTime(4), product_name = r.GetString(5) });
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return list;
        }
        #endregion
        // --------------------------------------
        //              Category's
        // --------------------------------------

        #region Category   
        public ActionResult Category() { return View(); }
        public JsonResult Categories()
        {
            var clist = GetCategory();
            return Json(new { data = clist }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetCategory(int id)
        {
            var clist = GetCategory().Where(c => c.CategoryId == id).ToList();
            return Json(new { data = clist }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult SaveCategory(Category cat)
        {
            var c = new Category();
            var x = new Connectionstring();
            using (MySqlConnection con = new MySqlConnection(x.ConnectionString))
            {
                // Open the connection to the database
                con.Open();
                using (MySqlCommand cm = new MySqlCommand())
                {
                    cm.Connection = con;
                    cm.CommandType = System.Data.CommandType.Text;
                    string qry = string.Empty;

                    if (cat.CategoryId == 0)
                    {
                        // Create the MySQL query to fetch categories
                        qry = "INSERT INTO CATEGORIES(name,Description, ACTIVE, created_at, updated_at) VALUES(@na,@ds,@ac,@cd,@md);";

                        cm.Parameters.AddWithValue("@na", cat.Name);
                        cm.Parameters.AddWithValue("@ds", cat.Description);
                        cm.Parameters.AddWithValue("@ac",(cat.Active) ? 1 : 0);
                        cm.Parameters.AddWithValue("@cd", DateTime.Now);
                        cm.Parameters.AddWithValue("@md", DateTime.Now);
                        // Execute the query 
                    }
                    else
                    {
                        // Create the MySQL query to fetch categories
                        qry = "UPDATE CATEGORIES set name=@na,Description=@ds, ACTIVE=@ac, updated_at=@md where category_id=@cid;";

                        cm.Parameters.AddWithValue("@na", cat.Name);
                        cm.Parameters.AddWithValue("@ds", cat.Description);
                        cm.Parameters.AddWithValue("@ac", cat.Active? 1:0);
                        cm.Parameters.AddWithValue("@cid", cat.CategoryId);
                        cm.Parameters.AddWithValue("@md", DateTime.Now);
                    }

                    cm.CommandText = qry;
                    // Execute the query
                    var e = cm.ExecuteNonQuery();
                    if (e == 1)
                    {
                        return Json(new { data = cat }, JsonRequestBehavior.AllowGet);
                    }
                }

            }
            return Json(new { data = c }, JsonRequestBehavior.AllowGet);
        }

        private List<Category> GetCategory()
        {
            var categories = new List<Category>();
            try
            {
                // Get the connection string
                var x = new Connectionstring();
                using (MySqlConnection con = new MySqlConnection(x.ConnectionString))
                {
                    // Open the connection to the database
                    con.Open();

                    // Create the MySQL query to fetch categories
                    string query = "SELECT category_id, name, ACTIVE, created_at, updated_at,Description FROM categories";

                    using (MySqlCommand cm = new MySqlCommand(query, con))
                    {
                        // Execute the query
                        using (MySqlDataReader reader = cm.ExecuteReader())
                        {
                            // Read data row by row
                            while (reader.Read())
                            {
                                var category = new Category
                                {
                                    CategoryId = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                                    Name = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                                    Active = reader.IsDBNull(2) ? true : reader.GetBoolean(2),
                                    CreatedAt = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3),
                                    UpdatedAt = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4),
                                    Description = reader.IsDBNull(5) ? "...": reader.GetString(5)
                                };

                                // Add the category to the list
                                categories.Add(category);
                            }
                        }
                    }
                }

                return categories;
            }
            catch (Exception ex)
            {
                // Handle the exception (log it if necessary)
                Console.WriteLine(ex.Message);

                // Return null if there's an error
                return null;
            }
        }

        public JsonResult Delete(int id)
        {
            var vid = deletecat(id);
            return Json(new { data = vid }, JsonRequestBehavior.AllowGet);
        }
        public int deletecat(int id)
        {
            var categories = new List<Category>();
            try
            {
                // Get the connection string
                var x = new Connectionstring();
                using (MySqlConnection con = new MySqlConnection(x.ConnectionString))
                {
                    con.Open();
                    string query = "delete FROM categories where category_id=@id";

                    using (MySqlCommand cm = new MySqlCommand(query, con))
                    {
                        cm.Parameters.AddWithValue("@id", id);

                        var r = cm.ExecuteNonQuery();
                        if (r == 1)
                        {
                            return id;
                        }
                        else { return -1; }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (log it if necessary)
                Console.WriteLine(ex.Message);

                // Return null if there's an error
                return -1;
            }
        }
        #endregion
    }

}