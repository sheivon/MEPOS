using Marshell_Web.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;

namespace Marshell_Web.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session["user"] = null;
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var penc = string.Empty;
            penc =EncriptionHelper.EncryptPassword(password);

            Users usr = GetAllUsers().Where( u=>u.LOGIN == username && u.PASS==penc).FirstOrDefault();
            if (usr != null && usr.LOGIN == username)
            {
                Session["user"] = usr;
               return RedirectToAction("Index", "Home"); 
            }
            else
            {
                ViewBag.Error = "Invalid credentials.";
                return View();
            }
        }

        #region Users
        public ActionResult Users()
        {
            return View();
        }
        // This will return the users as JSON
        public JsonResult GetUsers()
        {
            List<Users> users = new List<Users>();
            var x = new Connectionstring();
            using (var connection = new MySqlConnection(x.ConnectionString)) // Use MySQLConnection for MySQL
            {
                string query = "SELECT ID,UNAME,SRNAME,IDNUMBER,MOBILE,LOCATION,ROLE,FIRED,LOGIN,PASS,ifnull(GENDER,'N/A') Gender FROM users WHERE IsDeleted = 0";
                var command = new MySqlCommand(query, connection); // Use MySqlCommand for MySQL

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader(); // Use MySqlDataReader for MySQL

                    while (reader.Read())
                    {
                        users.Add(new Users
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            UNAME = reader["UNAME"].ToString(),
                            SRNAME = reader["SRNAME"].ToString(),
                            IDNUMBER = reader["IDNUMBER"].ToString(),
                            MOBILE = reader["MOBILE"].ToString(),
                            LOCATION = reader["LOCATION"].ToString(),
                            ROLE = reader["ROLE"].ToString(),
                            FIRED = Convert.ToInt32(reader["FIRED"])
                        });
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return Json(new { data = users }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetUserById(int id)
        {
            var l = GetAllUsers().Where(u => u.ID == id).ToList();
            return Json(new { data = l }, JsonRequestBehavior.AllowGet);
        }
        private List<Users> GetAllUsers()
        {
            List<Users> users = new List<Users>();
            var x = new Connectionstring();
            using (var connection = new MySqlConnection(x.ConnectionString)) // Use MySQLConnection for MySQL
            {
                string query = "SELECT ID,UNAME,SRNAME,IDNUMBER,MOBILE,LOCATION,ROLE,FIRED,LOGIN,PASS,ifnull(GENDER,'N/A') GENDER FROM users WHERE IsDeleted = 0";
                var command = new MySqlCommand(query, connection); // Use MySqlCommand for MySQL

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader(); // Use MySqlDataReader for MySQL

                    while (reader.Read())
                    {
                        users.Add(new Users
                        {
                            ID = reader.GetInt32(0),
                            UNAME = reader.GetString(1),
                            SRNAME = reader.GetString(2),
                            IDNUMBER = reader.GetString(3),
                            MOBILE = reader.GetString(4),
                            LOCATION = reader.GetString(5),
                            ROLE = reader.GetString(6),
                            FIRED = reader.GetInt32(7),
                            LOGIN = reader.GetString(8),
                            PASS = reader.GetString(9),
                            GENDER = reader.GetString(10)
                        });
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return users;
        }

        [HttpPost]
        public JsonResult AddUser(Users user)
        {
            var x = new Connectionstring();
            using (var connection = new MySqlConnection(x.ConnectionString)) // Use MySqlConnection for MySQL
            {
                string query = "INSERT INTO users (UNAME, SRNAME, IDNUMBER, MOBILE, LOCATION, ROLE, FIRED,LOGIN,PASS) VALUES (@UNAME, @SRNAME, @IDNUMBER, @MOBILE, @LOCATION, @ROLE, @FIRED,@LG,@PAS)";
                var command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@UNAME", user.UNAME);
                command.Parameters.AddWithValue("@SRNAME", user.SRNAME);
                command.Parameters.AddWithValue("@IDNUMBER", user.IDNUMBER);
                command.Parameters.AddWithValue("@MOBILE", user.MOBILE ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@LOCATION", user.LOCATION ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ROLE", user.ROLE);
                command.Parameters.AddWithValue("@FIRED", user.FIRED);
                command.Parameters.AddWithValue("@LG", user.LOGIN);
                command.Parameters.AddWithValue("@PAS", EncriptionHelper.EncryptPassword(user.PASS));

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    return Json(new { success = true });
                }
                catch (Exception ex)
                {
                    return Json(new { success = false, message = ex.Message });
                }
            }
        }

        [HttpPost]
        public JsonResult UpdateUser(Users user)
        {
            var x = new Connectionstring();
            using (var con = new MySqlConnection(x.ConnectionString)) 
            { 
                con.Open();

                string query = "UPDATE users SET UNAME = @UNAME, SRNAME = @SRNAME, IDNUMBER = @IDNUMBER, MOBILE = @MOBILE, LOCATION = @LOCATION, ROLE = @ROLE, FIRED = @FIRED WHERE ID = @ID";
                var command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("@ID", user.ID);
                command.Parameters.AddWithValue("@UNAME", user.UNAME);
                command.Parameters.AddWithValue("@SRNAME", user.SRNAME);
                command.Parameters.AddWithValue("@IDNUMBER", user.IDNUMBER);
                command.Parameters.AddWithValue("@MOBILE", user.MOBILE ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@LOCATION", user.LOCATION ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ROLE", user.ROLE);
                command.Parameters.AddWithValue("@FIRED", user.FIRED);

                try
                { 
                    command.ExecuteNonQuery();
                    return Json(new { success = true });
                }
                catch (Exception ex)
                {
                    return Json(new { success = false, message = ex.Message });
                }
            }
        }

        public JsonResult ResetPassword(int id, string rpass, string rpass1)
        {
            return Json(new { data = id }, JsonRequestBehavior.AllowGet);
        }
        #endregion


        #region Customers
        public JsonResult GetCustomerDetails(int id)
        {
            var customer = GetCustomers().FirstOrDefault(c => c.customer_id == id);
            return Json(new { data = customer }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Customers() { return View(); }
        public JsonResult GetCustomer()
        {
            var l = GetCustomers();
            return Json(new { data = l }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetCustomerId(int id)
        {
            var l = GetCustomers().Where(c => c.customer_id == id).FirstOrDefault();
            return Json(new { data = l }, JsonRequestBehavior.AllowGet);
        }
        public static List<Customers> GetCustomers()
        {
            var list = new List<Customers>();
            try
            {
                var x = new Connectionstring();
                using (MySqlConnection con = new MySqlConnection(x.ConnectionString))
                {
                    con.Open();
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        string qry = "SELECT customer_id, first_name, COALESCE(last_name,'') as last_name, COALESCE(email, 'Noreply@gmail.com') AS email,  COALESCE(CEDULA, 'No CEDULA') AS CEDULA, COALESCE(phone, 'No phone') AS phone, Del,  created_at FROM Customers;"
                            //"select customer_id,first_name,last_name,email,CEDULA,phone,Del,created_at from Customers;"
                            ;
                        command.Connection = con;
                        command.CommandText = qry;

                        var r = command.ExecuteReader();
                        while (r.Read())
                        {
                            list.Add(new Customers { customer_id = r.GetInt32(0), first_name = r.GetString(1), last_name = r.GetString(2), email = r.GetString(3), cedula = r.GetString(4), phone = r.GetString(5), isdelete = r.GetBoolean(6), created_at = r.GetDateTime(7) });
                        }
                    }

                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); new List<Customers>(); }
            return list;
        }
        [HttpPost]
        public JsonResult SaveCustomer(Customers customer)
        {
            try
            {
                var x = new Connectionstring();
                using (MySqlConnection conn = new MySqlConnection(x.ConnectionString))
                {
                    conn.Open();
                    // Check if it's an existing customer or a new one
                    if (customer.customer_id == 0)
                    {
                        // Add new customer (INSERT query)
                        string insertQuery = "INSERT INTO Customers (first_name, last_name, email, cedula, phone, del, created_at) " + "VALUES (@FirstName, @LastName, @Email, @Cedula, @Phone, @IsDelete,NOW())";/* @CreatedAt*/

                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@FirstName", customer.first_name);
                            cmd.Parameters.AddWithValue("@LastName", customer.last_name);
                            cmd.Parameters.AddWithValue("@Email", customer.email);
                            cmd.Parameters.AddWithValue("@Cedula", customer.cedula);
                            cmd.Parameters.AddWithValue("@Phone", customer.phone);
                          /*  cmd.Parameters.AddWithValue("@IsDelete", customer.isdelete?1:0); */ // Can use current date if not set

                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // Update existing customer (UPDATE query)
                        string updateQuery = "UPDATE Customers SET first_name = @FirstName, last_name = @LastName, " +
                                             "email = @Email, cedula = @Cedula, phone = @Phone, del = @IsDelete " +
                                             "WHERE customer_id = @CustomerId";

                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@FirstName", customer.first_name);
                            cmd.Parameters.AddWithValue("@LastName", customer.last_name);
                            cmd.Parameters.AddWithValue("@Email", customer.email);
                            cmd.Parameters.AddWithValue("@Cedula", customer.cedula);
                            cmd.Parameters.AddWithValue("@Phone", customer.phone);
                            cmd.Parameters.AddWithValue("@IsDelete", customer.isdelete ?1:0);
                            cmd.Parameters.AddWithValue("@CustomerId", customer.customer_id);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                // Handle exceptions (log, etc.)
                return Json(new { success = false, message = ex.Message });
            }
        }

        public JsonResult DelCustomer(int id)
        {
            var del = DeleteCustomer(id);
            return Json(new {data = del }, JsonRequestBehavior.AllowGet);
        }
        private bool DeleteCustomer(int id)
        {
            try
            {
                var x = new Connectionstring();
                using (MySqlConnection conn = new MySqlConnection(x.ConnectionString))
                {
                    conn.Open();
                    // Check if it's an existing customer or a new one
                    if (id != 0)
                    {
                        // Add new customer (INSERT query)
                        string insertQuery = "Update Customers set del=@Del where customer_id=@cid";/* @CreatedAt*/

                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                        { 
                            cmd.Parameters.AddWithValue("@Del", 1);
                            cmd.Parameters.AddWithValue("@cid",id);
                            /*  cmd.Parameters.AddWithValue("@IsDelete", customer.isdelete?1:0); */ // Can use current date if not set

                           int ret = cmd.ExecuteNonQuery();
                            if (ret == 1)
                                return true;
                            else
                                return false;
                        }
                    }
                    else
                        return false;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Delete ERROR MSM: " + ex.Message);
                return false;
            } 
        }
        #endregion
    }
}