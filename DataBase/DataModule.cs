using Entities;
using GUIHelper;
using MarshellsSettings;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;

namespace DataBase
{
    public static class DataModule
    {
        private static readonly string EncText = "1234567890";
        private static readonly GMessage GMessage = new GMessage();
        // --------------------------------------
        //              Server DB Stat
        // --------------------------------------
        #region SeverStats
        public enum ServerStatus { Online = 1, Offline = 2 }
        public static ServerStatus GetServerStatus()
        {
            ServerStatus ss = new ServerStatus();
            try
            {
                var o = GetEmployees().Count;

                if (o > 0)
                {
                    ss = ServerStatus.Online;
                }
                else
                {
                    ss = ServerStatus.Offline;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Fail to Connect with server");
            }
            return ss;
        }
        #endregion 
        // --------------------------------------
        //              Customer's 
        // --------------------------------------
        #region Customers
        public static List<Customers> GetCustomers(string keyword = "")
        {
            List<Customers> cs = new List<Customers>();
            try
            {
                string param = "";
                if (keyword == "") //if nothing then get all data
                {
                    param = ";";
                }
                else // else filter the data acording to keyword
                {
                    param = string.Format("WHERE CONCAT(first_name,last_name,CEDULA,phone) like '%{0}%';", keyword);
                }
                string qr = string.Format("SELECT customer_ID,first_name,last_name,ifnull(CEDULA,'626-NICA') CEDULA,email,phone,created_at,del FROM CUSTOMERs ORDER BY customer_id DESC", param);
                using (MySqlConnection cc = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    cc.Open();
                    using (MySqlCommand cm = new MySqlCommand(qr, cc))
                    {
                        MySqlDataReader dr = cm.ExecuteReader();
                        while (dr.Read())
                        {
                            Customers c = new Customers();
                            //read 
                            c.id = dr.GetInt32(0); // System.Convert.ToInt32(Dr["ID"].ToString());
                            c.name = dr.GetString(1); // Dr["CNAME"].ToString();
                            c.srname = dr.GetString(2);
                            c.idcard = dr.GetString(3);
                            c.email = dr.GetString(4);
                            c.mobile = dr.GetString(5);
                            c.active = (dr.GetInt32(7) == 0) ? false : true;
                            c.Created = dr.GetDateTime(6);

                            // save to list
                            cs.Add(c);
                        }
                    }
                    cc.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Fail to load Customers data");
            }
            return cs;
        }
        public static Customers GetCustomerbyID(int id)
        {
            Customers cs = new Customers();
            try
            {
                using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    cn.Open();
                    using (MySqlCommand cm = new MySqlCommand("SELECT customer_ID,first_name,last_name,ifnull(CEDULA,'626-NICA') CEDULA,email,phone,created_at,del FROM CUSTOMERs WHERE customer_ID=@id ORDER BY customer_id DESC ", cn))
                    {
                        cm.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                        var Rows = cm.ExecuteReader();
                        while (Rows.Read())
                        {

                            Customers c = new Customers();
                            //read 
                            c.id = Rows.GetInt32(0); // System.Convert.ToInt32(Dr["ID"].ToString());
                            c.name = Rows.GetString(1); // Dr["CNAME"].ToString();
                            c.srname = Rows.GetString(2);
                            c.idcard = Rows.GetString(3);
                            c.email = Rows.GetString(4);
                            c.mobile = Rows.GetString(5);
                            c.active = (Rows.GetInt32(7) == 0) ? false : true;
                            c.Created = Rows.GetDateTime(6);

                            // save to list
                            cs = c;
                        }
                    }
                }
            }
#if DEBUG
            catch (Exception ex)
            {
                GMessage.Show(ex.Message + Environment.NewLine + "Fail to load Customers data");
            }
#else
            catch
            {

            }
#endif
            return cs;

        }
        public static List<Customers> GetOwingCustomers(string keyword = "")
        {
            List<Customers> cs = new List<Customers>();
            //[Obsolute]
            //MySqlControl msql = new MySqlControl(MSetting.GetConnectionstring());
            try
            {
                string param = "";
                if (keyword == "") //if nothing then get all data
                {
                    param = "WHERE OW > 0;";
                }
                else // else filter the data acording to keyword
                {
                    param = string.Format("WHERE CONCAT(ID,CNAME,SRNAME,IDNUMBER,MOBILE,BLKCUS) like '%{0}%' AND (OW > 0);", keyword);
                }
                using (MySqlConnection con = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    con.Open();
                    using (MySqlCommand cm = new MySqlCommand(string.Format("SELECT ID,CNAME,SRNAME,ifnull(IDNUMBER,'N/A') IDNUMBER,ifnull(MOBILE,'N/A') MOBILE,ifnull(LOCATION,'N/A') LOCATION,ifnull(NATIONALITY,'N/A') NATIONALITY,GENDER,BLKCUS,OW,CUR,ACTIVE FROM CUSTOMER {0}", param), con))
                    {
                        cm.CommandType = CommandType.Text;
                        cm.Connection = con;
                        var r = cm.ExecuteReader();

                        while (r.Read())
                        {
                            cs.Add(new Customers() { id = r.GetInt32(0), name = r.GetString("CNAME"), srname = r.GetString("SRNAME"), idcard = r.GetString("IDNUMBER"), active = r.GetBoolean("Active") });
                        }
                    }
                }
            }
#if DEBUG
            catch (Exception ex)
            {
                GMessage.Show(ex.Message + Environment.NewLine + "Fail to load Customers data");
            }
#else
            catch
            {

            }
#endif
            return cs;

        }
        public static void UpdateCustomerOw(decimal OW, int id)
        {
            try
            {
                using (MySqlConnection c = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    c.Open();
                    using (MySqlCommand cm = new MySqlCommand(string.Format("UPDATE customer SET OW ={0} WHERE ID={1}", OW, id), c))
                    {
                        cm.ExecuteNonQuery();
                    }
                    c.Close();
                }
            }
            catch (Exception p) { Console.WriteLine(p.Message); }
        }
        public static List<PayingInvoice> GetPayed(int id = 0)
        {
            List<PayingInvoice> pl = new List<PayingInvoice>();
            try
            {
                using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    cn.Open();
                    string qry = "SELECT * FROM paying";
                    if (id != 0)
                    {
                        qry += " WHERE cusid='" + id + "';";
                    }
                    using (MySqlCommand cm = new MySqlCommand(qry, cn))
                    {

                        var Rows = cm.ExecuteReader();
                        while (Rows.Read())
                        {

                            PayingInvoice c = new PayingInvoice();
                            //read 
                            c.id = Rows.GetInt32(0);
                            c.paying = Rows.GetFloat(1);
                            c.owed = Rows.GetFloat(2);
                            c.reg = Rows.GetDateTime(3);
                            var cs = GetCustomerbyID(Rows.GetInt32(4)); //tmp cust info
                            c.Customer = cs.name.ToUpper() + " " + cs.srname.ToUpper();
                            var ca = GetUsersByID(Rows.GetInt32(5));
                            c.Cashier = ca.Name.ToUpper() + " " + ca.Srname.ToUpper();
                            pl.Add(c);
                        }
                    }
                    cn.Close();
                }
            }
#if DEBUG
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Fail to load Customers data");
            }
#else
            catch
            {

            }
#endif
            return pl;
        }
        public static void RegisterPaying(decimal am, decimal owd, int cid, int ca)
        {
            try
            {
                using (MySqlConnection c = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    c.Open();
                    using (MySqlCommand cm = new MySqlCommand("INSERT INTO PAYING(PAYING,OWED,REG,CUSID,CASHID) VALUES (@AM,@OW,NOW(),@CUI,@CAS);", c))
                    {
                        cm.Parameters.Add("@AM", MySqlDbType.Float).Value = am;
                        cm.Parameters.Add("@OW", MySqlDbType.Float).Value = owd;
                        cm.Parameters.Add("@CUI", MySqlDbType.Int24).Value = cid;
                        cm.Parameters.Add("@CAS", MySqlDbType.Int32).Value = ca;

                        cm.ExecuteNonQuery();
                    }
                    c.Close();
                }
            }
            catch (Exception p) { Console.WriteLine(p.Message); }
        }
        public static List<Payments> GetPayments(int id)
        {
            List<Payments> pl = new List<Payments>();
            try
            {
                using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    cn.Open();
                    string qry = "SELECT * FROM paying  WHERE cusid='" + id + "';";
                    using (MySqlCommand cm = new MySqlCommand(qry, cn))
                    {

                        var Rows = cm.ExecuteReader();
                        while (Rows.Read())
                        {

                            Payments p = new Payments();
                            //read  
                            p.payed = Rows.GetFloat(1);
                            p.owed = Rows.GetFloat(2);
                            p.Date = Rows.GetDateTime(3);
                            p.Customer = GetCustomerbyID(id).FullName;
                            var ca = GetUsersByID(Rows.GetInt32(5));
                            p.cashier = ca.Name.ToUpper() + " " + ca.Srname.ToUpper();
                            pl.Add(p);
                        }
                    }
                    cn.Close();
                }
            }
#if DEBUG
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Fail to load Customers data");
            }
#else
            catch
            {

            }
#endif
            return pl;
        }
        public static Payments GetLatestPayment(int id)
        {
            Payments p = new Payments();
            try
            {
                using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    cn.Open();
                    string qry = "SELECT * FROM paying  WHERE cusid='" + id + "' order by id desc limit 1;";
                    using (MySqlCommand cm = new MySqlCommand(qry, cn))
                    {

                        var Rows = cm.ExecuteReader();
                        while (Rows.Read())
                        {

                            //read  
                            p.payed = Rows.GetFloat(1);
                            p.owed = Rows.GetFloat(2);
                            p.Date = Rows.GetDateTime(3);
                            p.Customer = GetCustomerbyID(id).FullName;
                            var ca = GetUsersByID(Rows.GetInt32(5));
                            p.cashier = ca.Name.ToUpper() + " " + ca.Srname.ToUpper();
                        }
                    }
                    cn.Close();
                }
            }
#if DEBUG
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Fail to load Customers data");
            }
#else
            catch
            {

            }
#endif
            return p;
        }
        public static void SaveCustomer(Customers cus)
        {
            try
            {
                string qr = string.Empty;
                //SELECT ID,CNAME,SRNAME,IDNUMBER,MOBILE,LOCATION,NATIONALITY,GENDER,BLKCUS,OW,CUR,ACTIVE FROM CUSTOMER;
                if (cus.id == 0)
                {
                    qr = "INSERT INTO CUSTOMERs (first_name, last_name, email, CEDULA, phone) VALUES(@fn,@ln,@em,@ced,@te);";
                }
                else
                {
                    qr = "UPDATE CUSTOMERs SET first_name=@fn,last_name=@ln,email=@em, CEDULA=@ced, phone=@tel";
                }
                using (MySqlConnection cc = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    cc.Open();
                    using (MySqlCommand cm = new MySqlCommand(qr, cc))
                    {
                        cm.Parameters.AddWithValue("@fn", cus.name);
                        cm.Parameters.AddWithValue("@ln", cus.srname);
                        cm.Parameters.AddWithValue("@em", cus.email);
                        cm.Parameters.AddWithValue("@ced", cus.idcard);
                        cm.Parameters.AddWithValue("@te", cus.mobile);

                        cm.Connection = cc;
                        cm.CommandType = CommandType.Text;
                        cm.CommandText = qr;

                        cm.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Fail to load Customers data");
            }
        }
        #endregion
        // --------------------------------------
        //              Users Sections
        // --------------------------------------
        #region Users
        public static Users Login(string usr, string pass)
        {
            Users u = new Users();
            var password = EncryptPassword(pass);

            try
            {
                using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    cn.Open();
                    using (MySqlCommand cm = new MySqlCommand("SELECT * FROM users WHERE LOGIN=@us AND PASS=@pa LIMIT 1", cn))
                    {
                        cm.Parameters.Add("@us", MySqlDbType.String).Value = usr;
                        cm.Parameters.Add("@pa", MySqlDbType.String).Value = password;

                        var Rows = cm.ExecuteReader();
                        while (Rows.Read())
                        {
                            //read 
                            u.Id = Rows.GetInt32(0);
                            u.Name = Rows.GetString(1);
                            u.Srname = Rows.GetString(2);
                            u.IDNumber = Rows.GetString(3);
                            u.Mobile = Rows.GetString(4);
                            u.RegDate = Rows.GetDateTime(5).ToString();
                            u.Nationality = Rows.GetString(6);
                            u.Gender = Rows.GetString(7);
                            u.Location = Rows.GetString(8);
                            u.login = Rows.GetString(9);
                            u.pass = Rows.GetString(10);
                            u.Fired = Rows.GetBoolean(11);
                            u.Role = Rows.GetString(12);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Fail to load Customers data");
            }
            return u;
        }
        public static Users GetUsersByID(int id)
        {
            Users u = new Users();
            try
            {
                try
                {
                    using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                    {
                        cn.Open();
                        using (MySqlCommand cm = new MySqlCommand("SELECT * FROM users WHERE id=@id LIMIT 1", cn))
                        {
                            cm.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                            var Rows = cm.ExecuteReader();
                            while (Rows.Read())
                            {
                                //read 
                                u.Id = Rows.GetInt32(0);
                                u.Name = Rows.GetString(1);
                                u.Srname = Rows.GetString(2);
                                u.IDNumber = Rows.GetString(3);
                                u.Mobile = Rows.GetString(4);
                                u.RegDate = Rows.GetDateTime(5).ToString();
                                u.Nationality = Rows.GetString(6);
                                u.Gender = Rows.GetString(7);
                                u.Location = Rows.GetString(8);
                                u.login = Rows.GetString(9);
                                u.pass = Rows.GetString(10);
                                u.Fired = Rows.GetBoolean(11);
                                u.Role = Rows.GetString(12);

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + Environment.NewLine + "Fail to load Customers data");
                }
            }
            catch { }
            return u;
        }
        public static Users UdateUsersID(int id)
        {
            Users u = new Users();
            try
            {
                try
                {
                    using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                    {
                        cn.Open();
                        using (MySqlCommand cm = new MySqlCommand("SELECT * FROM users WHERE id=@id LIMIT 1", cn))
                        {
                            cm.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                            var Rows = cm.ExecuteReader();
                            while (Rows.Read())
                            {
                                //read 
                                u.Id = Rows.GetInt32(0);
                                u.Name = Rows.GetString(1);
                                u.Srname = Rows.GetString(2);
                                u.IDNumber = Rows.GetString(3);
                                u.Mobile = Rows.GetString(4);
                                u.RegDate = Rows.GetDateTime(5).ToString();
                                u.Nationality = Rows.GetString(6);
                                u.Gender = Rows.GetString(7);
                                u.Location = Rows.GetString(8);
                                u.login = Rows.GetString(9);
                                u.pass = Rows.GetString(10);
                                u.Fired = Rows.GetBoolean(11);
                                u.Role = Rows.GetString(12);

                            }
                        }
                    }
                }
#if DEBUG
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + Environment.NewLine + "Fail to load Customers data");
                }
#else
            catch
            {

            }
#endif
            }
            catch { }
            return u;
        }
        public static Users NewUser(Users u)
        {
            try
            {
                try
                {
                    using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                    {
                        cn.Open();
                        string qry = "INSERT IGNORE INTO USERS(UNAME,SRNAME,IDNUMBER,MOBILE,NATIONALITY,GENDER,LOCATION,LOGIN,PASS,FIRED,ROLE,ACTIVE) VALUES ('" + u.Name + "','" + u.Srname + "','" + u.IDNumber + "','" + u.Mobile + "','" + u.Nationality + "','" + u.Gender + "','" + u.Location + "','" + u.login + "','" + u.pass + "','0','" + u.Role + "','1');";
                        using (MySqlCommand cm = new MySqlCommand(qry, cn))
                        {
                            cm.ExecuteReader();
                        }
                    }
                }
#if DEBUG
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + Environment.NewLine + "Fail to load Customers data");
                }
#else
            catch
            {

            }
#endif
            }
            catch { }
            return u;
        }
        public static Users SaveUser(Users u)
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    cn.Open();
                    string qry = "INSERT IGNORE INTO USERS(UNAME,SRNAME,IDNUMBER,MOBILE,NATIONALITY,GENDER,LOCATION,LOGIN,PASS,FIRED,ROLE,ACTIVE) VALUES ('" + u.Name + "','" + u.Srname + "','" + u.IDNumber + "','" + u.Mobile + "','" + u.Nationality + "','" + u.Gender + "','" + u.Location + "','" + u.login + "','" + u.pass + "','0','" + u.Role + "','1');";


                    using (MySqlCommand cm = new MySqlCommand())
                    {
                        //
                        //Parameters
                        cm.Parameters.AddWithValue("@usr", u.Name);
                        cm.Parameters.AddWithValue("@srn", u.Srname);
                        cm.Parameters.AddWithValue("@iid", u.IDNumber);
                        cm.Parameters.AddWithValue("@cel", u.Mobile);
                        cm.Parameters.AddWithValue("@regd", u.RegDate);
                        cm.Parameters.AddWithValue("@nat", u.Nationality);
                        cm.Parameters.AddWithValue("@sex", u.Gender);
                        cm.Parameters.AddWithValue("@loc", u.Location);
                        cm.Parameters.AddWithValue("@login", u.login);
                        cm.Parameters.AddWithValue("@pass", u.pass);
                        cm.Parameters.AddWithValue("@fire", u.Fired);
                        cm.Parameters.AddWithValue("@rol", u.Role);
                        //
                        // Define connection string
                        cm.Connection = cn;
                        if (u.Id != 0)
                        {
                            //update
                            cm.Parameters.AddWithValue("@id", u.Id);        // only add id param when updating
                            cm.CommandText = "";
                        }
                        else
                        {
                            // New 
                            cm.CommandText = "";
                        }
                        cm.ExecuteReader();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + " * Fail to load Customers data *");
            }
            return u;
        }

        #endregion
        // --------------------------------------
        //              Employee's
        // --------------------------------------
        #region Employees
        public static List<Users> GetEmployees(string keyword = "")
        {
            List<Users> emplist = new List<Users>();
            MySqlControl db = new MySqlControl(MSetting.GetConnectionstring());
            try
            {
                string param = "";
                if (keyword == "")
                {
                    param = ";";
                }
                else
                {
                    param = string.Format(" WHERE CONCAT(ID,UNAME,SRNAME,IDNUMBER,MOBILE,REGDATE,NATIONALITY) LIKE '%{0}%';", keyword);
                }
                db.ExecQuery(string.Format("SELECT * FROM USERS {0}", param));
                foreach (DataRow d in db.DBDT.Rows)
                {
                    Users emp = new Users();
                    //load
                    emp.Id = System.Convert.ToInt32(d["ID"].ToString());
                    emp.Name = d["UNAME"].ToString();
                    emp.Srname = d["SRNAME"].ToString();
                    emp.IDNumber = d["IDNUMBER"].ToString();
                    emp.Mobile = d["MOBILE"].ToString();
                    emp.RegDate = d["REGDATE"].ToString();
                    emp.Location = d["LOCATION"].ToString();
                    emp.Gender = d["GENDER"].ToString();
                    int fire = System.Convert.ToInt32(d["FIRED"].ToString());
                    emp.Fired = (fire == 0) ? false : true;
                    emp.Role = d["ROLE"].ToString();
                    emp.Nationality = d["NATIONALITY"].ToString();
                    emp.pass = d["PASS"].ToString();
                    emp.login = d["LOGIN"].ToString();
                    //store
                    emplist.Add(emp);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Fail to load Employees!");
            }
            return emplist;
        }
        //
        // Save Users
        public static void SaveEmployee(Users emp)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    con.Open();
                    using (MySqlCommand cm = new MySqlCommand())
                    {
                        // Assuming cm is your MySqlCommand object
                        cm.CommandType = CommandType.StoredProcedure; // Set command type to stored procedure

                        string qry = string.Empty;

                        if (emp.Id > 0)
                        {
                            // Update existing record
                            qry = "sp_Save_usr";
                            cm.Parameters.AddWithValue("@ID", emp.Id);
                            cm.Parameters.AddWithValue("@UNAME", emp.Name);
                            cm.Parameters.AddWithValue("@SRNAME", emp.Srname);
                            cm.Parameters.AddWithValue("@IDNUMBER", emp.IDNumber);
                            cm.Parameters.AddWithValue("@MOBILE", emp.Mobile);
                            cm.Parameters.AddWithValue("@REGDATE", emp.RegDate);
                            cm.Parameters.AddWithValue("@NATIONALITY", emp.Nationality);
                            cm.Parameters.AddWithValue("@GENDER", emp.Gender);
                            cm.Parameters.AddWithValue("@LOCATION", emp.Location);
                            cm.Parameters.AddWithValue("@LOGIN", emp.login);
                            cm.Parameters.AddWithValue("@PASS", EncryptPassword(emp.pass));
                            cm.Parameters.AddWithValue("@FIRED", emp.Fired);
                            cm.Parameters.AddWithValue("@ROLE", emp.Role);
                        }
                        else
                        {
                            // Insert new record
                            qry = "sp_Save_usr";
                            // Add parameters without @p_ID since it's an auto-incremented primary key
                            cm.Parameters.AddWithValue("@ID", emp.Id);
                            cm.Parameters.AddWithValue("@UNAME", emp.Name);
                            cm.Parameters.AddWithValue("@SRNAME", emp.Srname);
                            cm.Parameters.AddWithValue("@IDNUMBER", emp.IDNumber);
                            cm.Parameters.AddWithValue("@MOBILE", emp.Mobile);
                            cm.Parameters.AddWithValue("@REGDATE", emp.RegDate);
                            cm.Parameters.AddWithValue("@NATIONALITY", emp.Nationality);
                            cm.Parameters.AddWithValue("@GENDER", emp.Gender);
                            cm.Parameters.AddWithValue("@LOCATION", emp.Location);
                            cm.Parameters.AddWithValue("@LOGIN", emp.login);
                            cm.Parameters.AddWithValue("@PASS", EncryptPassword(emp.pass));
                            cm.Parameters.AddWithValue("@FIRED", emp.Fired);
                            cm.Parameters.AddWithValue("@ROLE", emp.Role);
                        }

                        cm.CommandText = qry;

                        cm.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message + " Error During Save! "); }
        }
        #endregion
        // -------------------------------------- 
        //              Encryption
        // -------------------------------------- 
        #region Encryption
        public static string EncryptPassword(string password)
        {
            string SafePass = string.Empty;
            var Enc = new Encryption.Encrypt(EncText);
            SafePass = Enc.EncryptData(password);
            return SafePass;
        }
        public static string DecryptPassword(string Password)
        {
            string SafePass = string.Empty;
            var Dec = new Encryption.Decrypt(EncText);
            var ss = Dec.DecryptData(Password);
            try
            {
                SafePass = Dec.DecryptData(Password);
                if (ss == SafePass)
                {
                    return SafePass;
                }
            }
            catch (CryptographicException cp) { Console.WriteLine(cp.Message); return SafePass; }
            return SafePass;
        }

        #endregion
        // --------------------------------------
        //              Product's
        // --------------------------------------
        #region Products
        public static List<Products> GetProducts(string Keyword = "")
        {
            List<Products> lp = new List<Products>();
            try
            {
                string param = "";
                if (Keyword == "")
                {
                    param = ";";
                }
                else
                {
                    param = string.Format(" WHERE CONCAT(ID,PRODUCTCODE,PRODUCTNAME) LIKE '%{0}%';", Keyword);
                }

                using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    cn.Open();
                    using (MySqlCommand cm = new MySqlCommand(string.Format("SELECT ID,PRODUCTCODE,PRODUCTNAME,PRODUCTSTOCK QTY,PRODUCTPRICE PRICE,CUR,TYPE,ACTIVE FROM PRODUCT {0}", param), cn))
                    {
                        MySqlDataReader r = cm.ExecuteReader();
                        while (r.Read())
                        {
                            //l init
                            Products p = new Products();
                            //load
                            p.Id = r.IsDBNull(0) ? 0 : r.GetInt32(0);
                            p.Name = r.GetString(2);
                            p.Barcode = r.GetString(1);
                            p.Stock = r.IsDBNull(3) ? 0 : r.GetInt32(3);
                            p.Price = r.IsDBNull(4) ? 0 : r.GetDecimal(4);
                            p.Cur = r.GetString("CUR");
                            p.type = (r.IsDBNull(6) ? true : (r.GetInt32(6) == 0) ? true : false);
                            p.active = r.IsDBNull(7) ? true : (r.GetInt32(7) == 1 ? true : false);
                            //STORE
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
                using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    cn.Open();
                    using (MySqlCommand cm = new MySqlCommand(string.Format("SELECT ID,PRODUCTCODE,PRODUCTNAME,PRODUCTSTOCK QTY,PRODUCTPRICE PRICE,CUR,TYPE,ACTIVE FROM PRODUCT"), cn))
                    {
                        MySqlDataReader r = cm.ExecuteReader();
                        while (r.Read())
                        {
                            //l init
                            Products p = new Products();
                            //load
                            p.Id = r.IsDBNull(0) ? 0 : r.GetInt32(0);
                            p.Name = r.GetString(2);
                            p.Barcode = r.GetString(1);
                            p.Stock = r.IsDBNull(3) ? 0 : r.GetInt32(3);
                            p.Price = r.IsDBNull(4) ? 0 : r.GetDecimal(4);
                            p.Cur = r.GetString("CUR");
                            p.type = (r.IsDBNull(6) ? true : (r.GetInt32(6) == 0) ? true : false);
                            p.active = r.IsDBNull(7) ? true : (r.GetInt32(7) == 1 ? true : false);
                            //STORE

                            dt.Rows.Add(p);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                GMessage.Show(ex.Message + Environment.NewLine + "Fail to Load Products");
                return new DataTable();
            }
            return dt;
        }
        public static List<Products> GetProductsServices(string Keyword = "")
        {
            List<Products> lp = new List<Products>();
            try
            {
                string param = "";
                if (Keyword == "")
                {
                    param = "WHERE TYPE=1;";
                }
                else
                {
                    param = string.Format(" WHERE CONCAT(ID,PRODUCTCODE,PRODUCTNAME) LIKE '%{0}%' AND type=1;", Keyword);
                }

                using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    cn.Open();
                    using (MySqlCommand cm = new MySqlCommand(string.Format("SELECT ID,PRODUCTCODE,PRODUCTNAME,PRODUCTSTOCK QTY,PRODUCTPRICE PRICE,CUR,TYPE,ACTIVE FROM PRODUCT {0}", param), cn))
                    {
                        MySqlDataReader r = cm.ExecuteReader();
                        while (r.Read())
                        {
                            //l init
                            Products p = new Products();
                            //load
                            p.Id = r.IsDBNull(0) ? 0 : r.GetInt32(0);
                            p.Name = r.GetString(2);
                            p.Barcode = r.IsDBNull(1) ? "" : r.GetString(1);
                            p.Stock = r.IsDBNull(3) ? 0 : r.GetInt32(3);
                            //p.sold = r.IsDBNull(6) ? 0 : r.GetInt32("PRODUCTOUT");
                            p.Price = r.IsDBNull(4) ? 0 : r.GetDecimal(4);
                            p.Cur = r.GetString(5); //5
                            p.type = (r.IsDBNull(6) ? true : (r.GetInt32(6) == 0) ? true : false);
                            p.active = r.IsDBNull(7) ? true : (r.GetInt32(7) == 1 ? true : false);
                            //STORE
                            lp.Add(p);
                        }
                    }
                }

            }
#if DEBUG
            catch (Exception ex)
            {
                GMessage.Show(ex.Message + Environment.NewLine + "Fail to Load Products");
            }
#else
            catch (Exception)
            { }
#endif
            return lp;
        }
        public static List<Products> GetProductActiveOnly()
        {
            List<Products> lp = new List<Products>();
            try
            {
                lp = GetProducts().Where(p => p.active == true).ToList();
                //[Obsolute]
                //using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                //{
                //    cn.Open();
                //    using (MySqlCommand cm = new MySqlCommand("SELECT * FROM PRODUCT WHERE ACTIVE=1 AND TYPE=0", cn))
                //    {
                //        MySqlDataReader r = cm.ExecuteReader();
                //        while (r.Read())
                //        {
                //            //l init
                //            Products p = new Products();
                //            //load
                //            p.Id = r.IsDBNull(0) ? 0 : r.GetInt32("ID");
                //            p.Name = r.GetString("PRODUCTNAME");
                //            p.Barcode = r.GetString("PRODUCTCODE");
                //            p.Stock = r.IsDBNull(3) ? 0 : r.GetInt32("PRODUCTSTOCK");
                //            //p.sold = r.IsDBNull(6) ? 0 : r.GetInt32("PRODUCTOUT");
                //            p.Price = r.IsDBNull(4) ? 0  : r.GetDecimal("PRODUCTPRICE");
                //            p.Cur = r.GetString("CUR");
                //            p.type = (r.IsDBNull(8) ? true : (r.GetInt32(8) == 0) ? true : false);
                //            p.active = r.IsDBNull(7) ? true : (r.GetInt32(7) == 1 ? true : false);
                //            //STORE
                //            lp.Add(p);
                //        }
                //    }
                //}

            }
#if DEBUG
            catch (Exception ex)
            {
                GMessage.Show(ex.Message + Environment.NewLine + "Fail to Load Products");
            }
#else
            catch (Exception)
            { }
#endif
            return lp;
        }
        public static List<Products> GetProductsLow()
        {
            int low = 10;//init
            //replace default 10
            low = System.Convert.ToInt32(MSetting.GetStockLowWarn);
            List<Products> lp = new List<Products>();
            try
            {
                lp = GetProducts().Where(p => p.Stock <= low).ToList();
                return lp;
                //[Obsolute]
                //using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                //{
                //    cn.Open();
                //    using (MySqlCommand cm = new MySqlCommand("SELECT * FROM PRODUCT WHERE PRODUCTSTOCK <=@am and active=1 and type=0;", cn))
                //    {
                //        cm.Parameters.Add("@am", MySqlDbType.Int32).Value = low;
                //        MySqlDataReader r = cm.ExecuteReader();
                //        while (r.Read())
                //        {
                //            //l init
                //            Products p = new Products();
                //            //load
                //            p.Id = System.Convert.ToInt32(r["ID"].ToString());
                //            p.Name = (r["PRODUCTNAME"].ToString());
                //            p.Barcode = (r["PRODUCTCODE"].ToString());
                //            p.Stock = System.Convert.ToInt32(r["PRODUCTSTOCK"].ToString());
                //            p.Price = System.Convert.ToDecimal(r["PRODUCTPRICE"].ToString());
                //            p.Cur = r["CUR"].ToString();
                //            p.type = (r.IsDBNull(8) ? true : (r.GetInt32(8) == 0) ? true : false);
                //            p.active = r.IsDBNull(7) ? true : (r.GetInt32(7) == 1 ? true : false);
                //            //STORE
                //            lp.Add(p);
                //        }
                //    }
                //    cn.Close();
                //}
            }
#if DEBUG
            catch (Exception ex)
            {
                GMessage.Show(ex.Message + Environment.NewLine + " Fail to Load Understock Product Products");
            }
#else
            catch (Exception)
            { }
#endif
            return lp;
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
                using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
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
                        {
                            //rp = new Products()
                            //{
                            //    Id = r.GetInt32(0),
                            //    Barcode = r.GetString(1),
                            //    Name = r.GetString(2),
                            //    Stock = r.GetInt32(3)+0,
                            //    Price = r.GetFloat(4),
                            //    Cur = r.GetString(5),
                            //    sold = r.GetInt32(6)+0
                            //};
                            Products p = new Products();
                            //load
                            p.Id = r.IsDBNull(0) ? 0 : r.GetInt32(0);
                            p.Name = r.GetString(2);
                            p.Barcode = r.GetString(1);
                            p.Stock = r.IsDBNull(3) ? 0 : r.GetInt32(3);
                            p.Price = r.IsDBNull(4) ? 0 : r.GetDecimal(4);
                            p.Cur = r.GetString("CUR");
                            p.type = (r.IsDBNull(6) ? true : (r.GetInt32(6) == 0) ? true : false);
                            p.active = r.IsDBNull(7) ? true : (r.GetInt32(7) == 1 ? true : false);

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
                rp = GetProducts().Where(p => p.Id == ID).FirstOrDefault();

                //[Obsolute]
                //using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                //{
                //    cn.Open();
                //    using (MySqlCommand cm = new MySqlCommand())
                //    {
                //        cm.Connection = cn;
                //        cm.CommandText = "SELECT ID,PRODUCTCODE,PRODUCTNAME,PRODUCTSTOCK,PRODUCTPRICE,CUR,TYPE,ACTIVE FROM PRODUCT WHERE ID=@BC LIMIT 1;";

                //        cm.Parameters.AddWithValue("@BC", MySqlDbType.VarChar).Value = ID;
                //        cm.CommandType = CommandType.Text;

                //        MySqlDataReader r = cm.ExecuteReader();
                //        while (r.Read())
                //        {
                //            //rp = new Products()
                //            //{
                //            //    Id = r.GetInt32(0),
                //            //    Barcode = r.GetString(1),
                //            //    Name = r.GetString(2),
                //            //    Stock = r.GetInt32(3)+0,
                //            //    Price = r.GetFloat(4),
                //            //    Cur = r.GetString(5),
                //            //    sold = r.GetInt32(6)+0
                //            //};
                //            Products p = new Products();
                //            //load
                //            p.Id = r.GetInt32(0);
                //            p.Name = r.GetString(2);
                //            p.Barcode = r.GetString(1);
                //            p.Stock = r.IsDBNull(3) ? 0 : r.GetInt32(3);
                //            p.Price = r.IsDBNull(4) ? 0 : r.GetDecimal(4);
                //            p.Cur = r.GetString(5);
                //            p.type = (r.IsDBNull(6) ? true : (r.GetInt32(6) == 0) ? true : false);
                //            p.active = r.IsDBNull(7) ? true : (r.GetInt32(7) == 1) ? true : false;
                //            rp = p;
                //        }
                //    }
                //    cn.Close();
                //}
            }
            catch { }
            return rp;
        }
        /* Activate or Deactive a Product*/
        public static void ActivateProduct(int id, bool act = true)
        {
            try
            {
                using (MySqlConnection c = new MySqlConnection(MSetting.GetConnectionstring()))
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
                using (MySqlConnection c = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    c.Open();
                    using (MySqlCommand cm = new MySqlCommand())
                    {
                        cm.Connection = c;
                        cm.CommandType = CommandType.Text;

                        if (p.Id == 0)
                        {
                            cm.CommandText = "INSERT IGNORE INTO PRODUCT(PRODUCTCODE, PRODUCTNAME, PRODUCTSTOCK, PRODUCTPRICE, CUR, TYPE, ACTIVE) VALUES(@bc,@pn,@pi,@pp,@tp,@mn,@ac)";
                            //System.Windows.Forms.MessageBox.Show("NEW");
                        }
                        else
                        {
                            cm.CommandText = "UPDATE PRODUCT SET PRODUCTCODE=@bc, PRODUCTNAME=@pn, PRODUCTSTOCK=@pi, PRODUCTPRICE=@pp, type=@tp, CUR=@mn,ACTIVE=@ac WHERE ID=@id;";
                            // if updating then add extra params
                            cm.Parameters.Add("@id", MySqlDbType.Int32).Value = p.Id;
                        }

                        cm.Parameters.Add("@bc", MySqlDbType.VarChar, 50).Value = p.Barcode;
                        cm.Parameters.Add("@pn", MySqlDbType.VarChar, 50).Value = p.Name;
                        cm.Parameters.Add("@pi", MySqlDbType.Int32, 12).Value = p.Stock;
                        cm.Parameters.Add("@pp", MySqlDbType.Float, 12).Value = p.Price;
                        cm.Parameters.Add("@tp", MySqlDbType.Bit).Value = p.type == true ? 0 : 1;
                        cm.Parameters.Add("@mn", MySqlDbType.VarChar, 3).Value = p.Cur;
                        cm.Parameters.Add("@ac", MySqlDbType.Bit).Value = p.active == true ? 1 : 0;
                        //
                        //EXCEUTE OP
                        int u = cm.ExecuteNonQuery();

                        if (u == 1)
                        { GMessage.Show("!! SAVE SUCCESSFUL !!"); }

                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        #endregion
        // --------------------------------------
        //              Category's      
        // --------------------------------------
        #region Category
        public static List<Category> GetCategories()
        {
            var lcat = new List<Category>();
            try  //Table is Categories
            {
                using (MySqlConnection con = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = con;

                        cmd.CommandType = CommandType.Text;

                        string qry = "SELECT category_id, name,ACTIVE, created_at, updated_at FROM categories;";

                        cmd.CommandText = qry;

                        MySqlDataReader r = cmd.ExecuteReader();
                        while (r.Read())
                        {
                            lcat.Add(new Category() { Id = r.GetInt32(0), Name = r.GetString(1), Active = r.GetBoolean(2), CreatedAt = r.GetDateTime(3), UpdatedAt = r.GetDateTime(4) });
                        }
                    }
                }

            }
            catch { }

            return lcat;
        }
        public static void SaveCategory(Category cat)
        {
            try
            {
                var qr = string.Empty;
                if (cat.Id == 0)
                { qr = "INSERT INTO CATEGORIES(NAME,ACTIVE) VALUES(@N,@A);"; }
                else { qr = "UPDATE CATEGORIES SET NAME=@N,ACTIVE=@A WHERE CATEGORY_ID=@ID"; }
                using (MySqlConnection cc = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    cc.Open();
                    using (MySqlCommand cm = new MySqlCommand(qr, cc))
                    {
                        cm.Parameters.AddWithValue("@N", cat.Name);
                        cm.Parameters.AddWithValue("@A", cat.Active == true ? 1 : 0);

                        if (cat.Id > 0)
                        {
                            cm.Parameters.AddWithValue("@ID", cat.Id);
                        }
                        cm.ExecuteNonQuery();
                    }

                }
            }
            catch { }
        }
        #endregion
        // --------------------------------------    
        //              Money's  
        // --------------------------------------
        #region Money
        public static List<Entities.Money> GetMoney()
        {
            var l = new List<Entities.Money>();
            try
            {
                using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    cn.Open();
                    using (MySqlCommand cm = new MySqlCommand())
                    {
                        cm.Connection = cn;

                        cm.CommandText = "SELECT ID,NAME,SIMBOL,ACTIVE FROM MONEY";

                        var r = cm.ExecuteReader();
                        while (r.Read())
                        {
                            l.Add(new Entities.Money() { Id = r.GetInt32(0), Name = r.GetString(1), Simbol = r.GetString(2), Active = r.GetBoolean(3) });
                        }
                    }
                }
            }
            catch (Exception ss) { Console.WriteLine(ss.Message); return l; }
            return l;
        }
        public static int SaveMoney(Entities.Money money)
        {
            var retid = -1;
            try
            {
                using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    cn.Open();
                    using (MySqlCommand cm = new MySqlCommand())
                    {
                        cm.Connection = cn;

                        cm.CommandText = "INSERT INTO MONEY(NAME,SIMBOL,ACTIVE) VALUES(@NA,@SI,@AC);";
                        //
                        //PARAMS
                        cm.Parameters.AddWithValue("@NA", money.Name);
                        cm.Parameters.AddWithValue("@SI", money.Simbol);
                        cm.Parameters.AddWithValue("@AC", money.Active == true ? 1 : 0);

                        cm.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return retid; }
            return retid;
        }
        #endregion
        // --------------------------------------
        //              Invoice's
        // --------------------------------------
        #region Invoices

        public static int GenerateInvoice()
        {
            int id = -1;
            try
            {
                using (MySqlConnection c = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    c.Open();
                    using (MySqlCommand cm = new MySqlCommand())
                    {
                        cm.Connection = c;
                        cm.CommandText = "SELECT ifnull(MAX(InvoiceID),0) ID   FROM marshell.invoice;";
                        cm.CommandType = CommandType.Text;

                        var r = cm.ExecuteReader();
                        while (r.Read())
                        {
                            id = r.GetInt32(0);
                            id += 1;
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return id; }
            return id;
        }
        public static List<InvoiceDetails> GetInvoiceDetails()
        {
            List<InvoiceDetails> li = new List<InvoiceDetails>();
            try
            {
                //string qry = "Select C.ID as CID, P.PRODUCTCODE AS BCODE, C.CDATE AS CDATE, C.ITEMID AS IID, C.QNT AS QNT,C.OWIN AS OW,C.STAT AS STATU, P.PRODUCTNAME AS ITEM, P.PRODUCTPRICE AS UNITPRICE,P.PRODUCTPRICE* C.QNT AS TOTAL, P.CUR as CUR,(SELECT PRODUCTNAME FROM PRODUCT AS PP WHERE C.ITEMID = PP.ID) AS PN FROM CREDITS as C LEFT OUTER JOIN PRODUCT AS P ON C.ITEMID = P.ID WHERE P.ID = C.ITEMID AND C.BARCODE = '" + invoice + "';";
                //string qry = "SELECT ID,INVID,DATE,PID,QTY,(SELECT PRODUCTNAME FROM PRODUCT WHERE ID=PID) ITEM,PRICE,OFF,ACTIVE FROM INVOICEDETAILS;"; 
                string qry = "SELECT InvoiceDetailID,INVoiceID,CreatedAT,ProductID,total,(SELECT PRODUCTNAME FROM PRODUCT WHERE ID=ProductID) ITEM,unitPRICE,Discount  FROM INVOICEDETAILS;";
                using (MySqlConnection c = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    c.Open();
                    using (MySqlCommand cm = new MySqlCommand(qry, c))
                    {
                        var Rows = cm.ExecuteReader();
                        while (Rows.Read())
                        {
                            li.Add(new InvoiceDetails()
                            {
                                ID = Rows.GetInt32(0),
                                BCODE = Rows.GetString(1),
                                CDATE = Rows.GetDateTime(2),
                                IID = Rows.GetInt32(3),
                                QTY = Rows.GetInt32(4),
                                ITEM = Rows.GetString(5),
                                UNITPRICE = Rows.GetDecimal(6),
                                Off = Rows.GetDecimal(7),
                                Active = Rows.GetBoolean(8)
                            });
                        }
                    }
                    if (c.State == ConnectionState.Open)
                    {
                        c.Close();
                    }
                }
            }
            catch (Exception xs) { Console.WriteLine(xs.Message); return li; }
            return li;
        }
        public static List<Invoices> GetInvoices(string Keyword = "", bool active = true)
        {
            List<Invoices> li = new List<Invoices>();
            try
            {
                string param = "";
                if (Keyword == "")
                {
                    if (active == false)
                    {
                        param = ";";
                    }
                    else
                    {
                        param = "WHERE ACTIVE=1;";
                    }
                }
                else
                {
                    if (active == false)
                    {
                        param = string.Format("WHERE CONCAT(FACN,CUSTOMER,SELLER,DATE,TOTAL) LIKE '%{0}%'  ORDER BY ID DESC;", Keyword);
                    }
                    else
                    {
                        param = string.Format("WHERE CONCAT(FACN,CUSTOMER,SELLER,DATE,TOTAL) LIKE '%{0}%' AND ACTIVE='1' ORDER BY ID DESC;", Keyword);
                    }
                }
                using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    cn.Open();
                    using (MySqlCommand cm = new MySqlCommand($"SELECT  ID,FACN,ifnull((SELECT CONCAT(CNAME,' ',SRNAME) FROM CUSTOMER WHERE ID=CusId),'N/A') Customer,CusId,usrId,(SELECT CONCAT(UNAME,' ',SRNAME) FROM USERS WHERE ID=usrId) SELLER,DATE,STAT,TOTAL,OFF,EXRATE,NIO,ACTIVE,CASHED FROM INVOICE {param}", cn))
                    {
                        var Rows = cm.ExecuteReader();
                        while (Rows.Read())
                        {
                            li.Add(new Invoices()
                            {
                                ID = Rows.GetInt32(0),
                                Invoice = Rows.GetString(1),
                                Customer = Rows.GetString(2),
                                CusId = Rows.GetInt32(3),
                                usrId = Rows.GetInt32(4),
                                Seller = Rows.GetString(5),
                                Date = Rows.GetDateTime(6),
                                Stat = Rows.GetBoolean(7),
                                Total = Rows.GetDecimal(8),
                                off = Rows.GetDecimal(9),
                                Exchange = Rows.GetDecimal(10),
                                Cur = Rows.GetString(11),
                                //active = Rows.IsDBNull(12) ? false : (Rows.GetByte(12) == 0) ? false : true, 
                                active = Rows.IsDBNull(12) ? false : Rows.GetBoolean(12),
                                cashed = Rows.GetDecimal(13)
                            });
                        }
                    }
                    cn.Close();
                }

            }
            //#if DEBUG
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Fail to Load Invoices");
            }
            //#else
            //            catch (Exception)
            //            { }
            //#endif
            return li;
        }
        public static List<Invoices> GetInvoicesDateToDate(DateTime D1, DateTime D2)
        {
            List<Invoices> li = new List<Invoices>();
            MySqlControl DB = new MySqlControl(MSetting.GetConnectionstring());
            try
            {
                string param = string.Format(" WHERE IDATE BETWEEN '{0}' AND '{1}';", D1, D2);
                DB.ExecQuery(string.Format("SELECT * FROM INVOICE {0}", param));
                foreach (DataRow r in DB.DBDT.Rows)
                {
                    //STORE
                    li.Add(new Invoices
                    { //load
                        ID = System.Convert.ToInt32(r["ID"].ToString()),
                        Invoice = (r["INVOICE"].ToString()),
                        Customer = (r["CUSTOMER"].ToString()),
                        Seller = (r["SELLER"].ToString()),
                        Date = (DateTime)r["IDATE"],//, "yyyy-MM-dd H:m", provider);
                        Stat = System.Convert.ToBoolean(r["STAT"]),
                        Total = System.Convert.ToDecimal(r["TOTAL"].ToString()),
                        Cur = r["CUR"].ToString()
                    });
                }

            }
#if DEBUG
            catch (Exception ex)
            {
                GMessage.Show(ex.Message + Environment.NewLine + "Fail to Load INVOICES BY DATES");
            }
#else
            catch (Exception)
            { }
#endif
            return li;
        }
        public static List<Invoices> GetInvoicesThisweek()
        {
            List<Invoices> li = new List<Invoices>();
            MySqlControl DB = new MySqlControl(MSetting.GetConnectionstring());
            DateTime dt = DateTime.Now;
            try
            {
                string param = string.Format(" WHERE IDATE BETWEEN '{0}' AND '{1}';", (DateTime)dt.AddDays(-7), dt);
                DB.ExecQuery(string.Format("SELECT * FROM INVOICES {0}", param));
                foreach (DataRow r in DB.DBDT.Rows)
                {
                    //l init
                    Invoices p = new Invoices();
                    //load
                    p.ID = System.Convert.ToInt32(r["ID"].ToString());
                    p.Invoice = (r["INVOICE"].ToString());
                    p.Customer = (r["CUSTOMER"].ToString());
                    p.Seller = (r["SELLER"].ToString());
                    p.Date = (DateTime)r["IDATE"];//, "yyyy-MM-dd H:m", provider);
                    p.Stat = System.Convert.ToBoolean(r["STAT"]);
                    p.Total = System.Convert.ToDecimal(r["TOTAL"].ToString());
                    p.Cur = r["CUR"].ToString();
                    //STORE
                    li.Add(p);
                }

            }
#if DEBUG
            catch (Exception ex)
            {
                GMessage.Show(ex.Message + Environment.NewLine + "Fail to Load INVOICES FOR THIS WEEK");
            }
#else
            catch (Exception)
            { }
#endif
            return li;
        }
        /// <summary>
        /// Get This Month Invoices group by seller and total price
        /// </summary>
        /// <returns></returns>
        public static List<Invoices> GetInvoicesThisMonth()
        {
            List<Invoices> li = new List<Invoices>();
            MySqlControl DB = new MySqlControl(MSetting.GetConnectionstring());
            DateTime dt = DateTime.Now;
            try
            {
                string param = string.Format(" WHERE IDATE BETWEEN '{0}' AND '{1}';", (DateTime)dt.AddDays(-7), DateTime.Now);
                DB.ExecQuery(string.Format("SELECT ID,INVOICE,CUSTOMER,SELLER,IDATE,STAT,TOTAL,CUR FROM INVOICES {0}", param));
                foreach (DataRow r in DB.DBDT.Rows)
                {
                    //l init
                    Invoices p = new Invoices();
                    //load
                    p.ID = System.Convert.ToInt32(r["ID"].ToString());
                    p.Invoice = (r["INVOICE"].ToString());
                    p.Customer = (r["CUSTOMER"].ToString());
                    p.Seller = (r["SELLER"].ToString());
                    p.Date = (DateTime)r["IDATE"];//, "yyyy-MM-dd H:m", provider);
                    p.Stat = System.Convert.ToBoolean(r["STAT"]);
                    p.Total = System.Convert.ToDecimal(r["TOTAL"].ToString());
                    p.Cur = r["CUR"].ToString();
                    //STORE
                    li.Add(p);
                }

            }
#if DEBUG
            catch (Exception ex)
            {
                GMessage.Show(ex.Message + Environment.NewLine + "Fail to Load INVOICES FOR THIS MONTH");
            }
#else
            catch (Exception)
            { }
#endif
            return li;
        }
        public static List<Invoices> GetThisYear()
        {
            DateTime D1, D2;

            D2 = DateTime.Now;
            D1 = D2.AddYears(-1);
            Console.WriteLine($"Date to date{D1} - {D2}");
            return GetInvoicesDateToDate(D1, D2);
        }
        public static List<Invoices> GetPendientsInvoices()
        {
            List<Invoices> pen = GetInvoices().Where(i => i.Stat = false).ToList();
            return pen;
        }

        public static void InvoiceDetails(
            string BC /*invoice id*/,
            int ProdID /*item ID primarykey*/,
            string Idate, /* Sales date is to be same as invoice date*/
            int qty /*amount of product on the sale*/,
            float owin,
            string stat)
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    cn.Open();
                    using (MySqlCommand cm = new MySqlCommand("INSERT INTO CREDITS(BARCODE,ITEMID,CDATE,QNT,OWIN,STAT) VALUES(@bc,@pid,@cdat,@qn,@ow,@stat)", cn))
                    {
                        cm.Connection = cn;

                        cm.Parameters.Add("@bc", MySqlDbType.VarChar).Value = BC;
                        cm.Parameters.Add("@pid", MySqlDbType.VarChar).Value = ProdID;
                        cm.Parameters.Add("@cdat", MySqlDbType.DateTime).Value = Idate;
                        cm.Parameters.Add("@qn", MySqlDbType.Int32).Value = qty;
                        cm.Parameters.Add("@ow", MySqlDbType.Float).Value = owin;
                        cm.Parameters.Add("@stat", MySqlDbType.VarChar).Value = stat;

                        cm.CommandType = CommandType.Text;

                        int i = cm.ExecuteNonQuery();
                        if (i == 0)
                        {
                            GMessage.Show("Fail To add product Detials to Facturas");
                        }
                        else
                            Console.WriteLine("Add Successful!");
                    }
                    cn.Close();
                }
            }
            catch { }
        }


        /// <summary>
        /// Invoice is factura table
        /// </summary>
        /// <param name="invoice">invoice barcode</param>
        /// <param name="customer">customer name</param>
        /// <param name="seller">casheir</param>
        /// <param name="IDate">register date</param>
        /// <param name="status">status</param>
        /// <param name="total">Owing or ToPay</param>
        //
        public static void Invoice(string invoice, string customer, string seller, string IDate, string status, float total, float totalow, float cashed)
        {
            try
            {
                using (MySqlConnection Conn = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    Conn.Open();
                    using (MySqlCommand Com = new MySqlCommand("INSERT INTO INVOICES(INVOICE,CUSTOMER,SELLER,IDATE,STAT,TOTAL,OWTOTAL,Cashed) VALUES('" + invoice + "','" + customer + "','" + seller + "','" + IDate + "','" + status + "','" + total + "','" + totalow + "','" + cashed + "');", Conn))
                    {
                        Com.ExecuteNonQuery();
                    }
                    Conn.Close();
                }

            }
            catch (Exception ee)
            {
                Console.WriteLine("ERR adding invoice" + Environment.NewLine + ee.Message);
            }
        }
        /// <summary>
        /// Save Invoice and return ID 
        /// </summary>
        /// <param name="inv"></param>
        /// <returns></returns>
        public static int SaveInvoice(Invoices inv)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    con.Open();
                    using (MySqlCommand cm = new MySqlCommand())
                    {
                        cm.Connection = con;
                        string qry = string.Empty;
                        if (inv.ID != 0)
                        {
                            qry = "";
                        }
                        else
                        {
                            qry = "INSERT INTO Invoices(CUSTOMER,CusId,usrId,DATE,TOTAL,STAT,OFF,EXRATE,NIO,ACTIVE,Cashed,FACN) VALUES(@Cus,@cid,@uid,@dt,@ttl,@stt,@dc,@x,@mn,@act,@csh,@fn);";
                        }
                        cm.Parameters.AddWithValue("@Cus", inv.Customer);
                        cm.Parameters.AddWithValue("@cid", inv.CusId);
                        cm.Parameters.AddWithValue("@uid", inv.usrId);
                        cm.Parameters.AddWithValue("@dt", inv.Date);
                        cm.Parameters.AddWithValue("@ttl", inv.Total);
                        cm.Parameters.AddWithValue("@stt", inv.Stat == true ? 1 : 0);
                        cm.Parameters.AddWithValue("@dc", inv.off);
                        cm.Parameters.AddWithValue("@x", inv.Exchange);
                        cm.Parameters.AddWithValue("@mn", inv.Cur);
                        cm.Parameters.AddWithValue("@act", inv.active == true ? 1 : 0);
                        cm.Parameters.AddWithValue("@csh", inv.cashed);
                        cm.Parameters.AddWithValue("@fn", inv.Invoice);
                    }
                }
            }
            catch (Exception isv) { Console.WriteLine(isv.Message); return -1; }
            return -1;
        }
        public static void SaveInvoceDetails(List<InvoiceDetails> invlist)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    con.Open();
                    using (MySqlCommand cm = new MySqlCommand())
                    {
                        cm.Connection = con;
                        string qry = string.Empty;
                        if (invlist.Count != 0)
                        {
                            qry = "INSERT INTO Invoicesdetails(`INVID`,`PID`,`QTY`,`PRICE`,`OFF`,`DATE`,`Active`) VALUES(@inv,@pid,@qty,@prc,@off,@dt,@act);";

                            foreach (InvoiceDetails inv in invlist)
                            {
                                cm.Parameters.AddWithValue("@inv", inv.BCODE);
                                cm.Parameters.AddWithValue("@pid", inv.IID);
                                cm.Parameters.AddWithValue("@qty", inv.QTY);
                                cm.Parameters.AddWithValue("@prc", inv.UNITPRICE);
                                cm.Parameters.AddWithValue("@off", inv.Off);
                                cm.Parameters.AddWithValue("@dt", inv.CDATE);
                                cm.Parameters.AddWithValue("@act", inv.Active == true ? 1 : 0);
                            }
                        }
                    }
                }
            }
            catch (Exception isv) { Console.WriteLine(isv.Message); }
        }
        #endregion
        // --------------------------------------
        //              Stock's
        // --------------------------------------
        #region Stock
        //Update Product stock when selled
        public static void UpdateProductStock(string Barcode, int instock, int outsale, int offsale)
        {
            int newstock = (instock - offsale);
            int newout = (outsale + offsale);
            try
            {
                using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    cn.Open();
                    using (MySqlCommand cm = new MySqlCommand())
                    {
                        cm.Connection = cn;
                        cm.CommandText = "UPDATE PRODUCT SET PRODUCTSTOCK=@ps,PRODUCTOUT=@po WHERE PRODUCTCODE=@bc;";
                        cm.Parameters.AddWithValue("@ps", newstock);
                        cm.Parameters.AddWithValue("@po", newout);
                        cm.Parameters.AddWithValue("@bc", Barcode);
                        cm.CommandType = CommandType.Text;
                        cm.ExecuteNonQuery();
                    }
                    cn.Close();
                }
            }
#if DEBUG
            catch (Exception ex)
            {
                GMessage.Show(ex.Message);
            }
#else
            catch (Exception)
            { }
#endif
            finally
            {
            }
        }
        #endregion
        // --------------------------------------
        //              Supplier          
        // --------------------------------------
        #region Supplier
        public static List<Supplier> GetSupplier()
        {
            List<Supplier> suppliers = new List<Supplier>();
            try
            {
                using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    cn.Open();
                    using (MySqlCommand cm = new MySqlCommand())
                    {
                        cm.Connection = cn;
                        cm.CommandText = "SELECT supplier_id,name,contact_info,created_at FROM suppliers;";
                        var dr = cm.ExecuteReader();
                        while (dr.Read())
                        {
                            suppliers.Add(new Supplier() { Id = dr.GetInt32(0), Name = dr["name"].ToString(), ContactInfo = dr.GetString(2), Created = dr.GetDateTime(3) });
                        }
                    }
                    cn.Close();
                }
            }
            catch (Exception ps) { Console.WriteLine(ps.Message); return new List<Supplier>(); }
            return suppliers;
        }
        public static void SaveSupplier(Supplier sup)
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    cn.Open();
                    using (MySqlCommand cm = new MySqlCommand())
                    {
                        cm.Connection = cn;

                        string qry = string.Empty;
                        if (sup.Id == 0)
                        {
                            qry = "INSERT INTO SUPPLIERS(name,contact_info) VALUES (@na,@ci);";
                        }
                        else
                        {
                            qry = "UPDATE SUPPLIERS SET name=@na,contact_info=@ci WHERE supplier_id=@id";
                            cm.Parameters.AddWithValue("@id", sup.Id);
                        }
                        cm.Parameters.AddWithValue("@na", sup.Name);
                        cm.Parameters.AddWithValue("@ci", sup.ContactInfo);

                        cm.CommandText = qry;

                        cm.ExecuteNonQuery();
                    }
                    cn.Close();
                }
            }
            catch (Exception ps) { Console.WriteLine(ps.Message); }
        }

        #endregion
        // --------------------------------------
        //              Dashboard           
        // --------------------------------------
        #region Dashboard
        //props
        public static int numCustomers { get; set; }
        public static int numProducts { get; set; }
        public static int numProductsType { get; set; }
        public static int numInvoice { get; set; }
        //
        // more props analisis
        public static List<AnalyticItem> ProdAnalisis { get; set; }

        ///Get Numbers
        ///customers
        ///products
        ///invoices
        public static int GetCustomerCount()
        {
            try
            {
                using (MySqlConnection c = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    c.Open();
                    using (MySqlCommand cm = new MySqlCommand("SELECT COUNT(ID) FROM CUSTOMER;", c))
                    {
                        numCustomers = (int)cm.ExecuteScalar();
                    }
                }
            }
            catch (Exception p) { Console.WriteLine(p.Message); }
            return numCustomers;
        }
        public static int GetProductTypesCount()
        {
            try
            {
                using (MySqlConnection c = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    c.Open();
                    using (MySqlCommand cm = new MySqlCommand("SELECT COUNT(*) FROM PRODUCT;", c))
                    {
                        MySqlDataReader r = cm.ExecuteReader();
                        while (r.Read())
                        {
                            numProductsType = r.GetInt32(0);
                        }
                    }
                }
            }
            catch (Exception p) { Console.WriteLine(p.Message); }
            return numProductsType;
        }
        public static int GetProductCount()
        {
            try
            {
                using (MySqlConnection c = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    c.Open();
                    using (MySqlCommand cm = new MySqlCommand("SELECT SUM(PRODUCTSTOCK) AS TOTAL FROM PRODUCT;", c))
                    {
                        MySqlDataReader r = cm.ExecuteReader();
                        while (r.Read())
                        {
                            numProducts = r.GetInt32(0);
                        }
                    }
                    c.Close();
                }
            }
            catch (Exception p) { Console.WriteLine(p.Message); }
            return numProducts;
        }
        public static int GetInvoiceCount()
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    cn.Open();
                    using (MySqlCommand cm = new MySqlCommand("SELECT COUNT(ID) FROM INVOICES;", cn))
                    {
                        MySqlDataReader r = cm.ExecuteReader();
                        while (r.Read())
                        {
                            numInvoice = r.GetInt32(0);
                        }
                    }
                    cn.Close();
                }
            }
            catch (Exception i) { Console.WriteLine(i.Message); }
            return numInvoice;
        }
        public static int GetInvoiceCount(DateTime ds, DateTime df)
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    cn.Open();
                    using (MySqlCommand cm = new MySqlCommand("SELECT COUNT(ID) FROM INVOICE where IDATE BETWEEN @d1 AND @d2;", cn))
                    {
                        cm.Parameters.Add("@d1", MySqlDbType.DateTime).Value = ds;
                        cm.Parameters.Add("@d2", MySqlDbType.DateTime).Value = df;
                        MySqlDataReader r = cm.ExecuteReader();
                        while (r.Read())
                        {
                            numInvoice = r.GetInt32(0);
                        }
                    }
                    cn.Close();
                }
            }
            catch (Exception i) { Console.WriteLine(i.Message); }
            return numInvoice;
        }

        //public static List<KeyValuePair<string, int>> ProductAnalisys(DateTime sd, DateTime ed)

        //
        // Dec pl
        // 
        public static List<KeyValuePair<string, int>> UnderstockList { get; private set; }
        public static List<RevenueByDate> GrossRevenueList { get; private set; }
        public static int NumOrders { get; set; }
        public static decimal TotalRevenue { get; set; }
        public static decimal TotalProfit { get; set; }
        public static List<AnalyticItem> ProductAnalisys(DateTime sd, DateTime ed)
        {
            int numberDays = 0;
            ed = new DateTime(ed.Year, ed.Month, ed.Day,
                ed.Hour, ed.Minute, 59);
            numberDays = (ed - sd).Days;
            ProdAnalisis = new List<AnalyticItem>();
            using (MySqlConnection connection = new MySqlConnection(MSetting.GetConnectionstring()))
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    MySqlDataReader reader;
                    command.Connection = connection;
                    //Get Top 10 products
                    command.CommandText = @"select IDate, sum(TOTAL)
                                            from INVOICES
                                            where IDate between DATE_FORMAT(@fromDate,'%Y-%m-%d') and DATE_FORMAT(@toDate,'%Y-%m-%d %H:%i:%s:%x') 
                                            group by IDate ";
                    command.Parameters.Add("@fromDate", MySqlDbType.DateTime).Value = sd;
                    command.Parameters.Add("@toDate", MySqlDbType.DateTime).Value = ed;
                    reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        var topitem = new AnalyticItem { name = reader.GetString(0), value = reader.GetFloat(1) };
                        ProdAnalisis.Add(topitem);
                        Console.WriteLine(topitem);
                    }
                    //    TotalProfit = TotalRevenue * 0.2m;//20%
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
                }
                return ProdAnalisis;
            }
        }
        public static List<AnalyticItem> GetProductTop10(DateTime sd, DateTime ed)
        {
            var tmp = new List<AnalyticItem>();
            try
            {
                using (MySqlConnection c = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    c.Open();
                    using (MySqlCommand com = new MySqlCommand())
                    {
                        MySqlDataReader reader;
                        com.Connection = c;
                        //Get Top 10 products
                        com.CommandText = @"select P.ProductName, sum(credits.qnt) as Q
                                            from credits
                                            inner join Product P on P.Id = Credits.ITEMID
                                            inner join invoices O on O.invoice = credits.barcode
                                            where IDate between DATE_FORMAT(@fromDate,'%Y-%m-%d') and DATE_FORMAT(@toDate,'%Y-%m-%d %H:%i:%s:%x')
                                            group by P.ProductName
                                            order by Q desc LIMIT 10;";
                        com.Parameters.Add("@fromDate", MySqlDbType.DateTime).Value = sd;
                        com.Parameters.Add("@toDate", MySqlDbType.DateTime).Value = ed;
                        reader = com.ExecuteReader();
                        while (reader.Read())
                        {
                            tmp.Add(new AnalyticItem { name = reader.GetString(0), value = reader.GetInt32(1) });
                        }
                    }
                    c.Close();
                }
            }
            catch (Exception pp)
            {
                Console.WriteLine(pp.Message + " reading top 10");
                Console.WriteLine(sd + " - " + ed);
            }
            return tmp;
        }
        #endregion// --------------------------------------
        // --------------------------------------
        //              Sales           
        // --------------------------------------
        #region Sales
        public static List<sales> GetSales()
        {
           var lsales = new List<sales>();
            try
            {
                using (MySqlConnection cn = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    cn.Open();
                    using (MySqlCommand cm = new MySqlCommand())
                    {
                        cm.Connection = cn;
                        cm.CommandText = "SELECT SaleId,OrderNumber,SaleDate,TotalAmount,TaxAmount,ShippingCost,DiscountAmount,CustomerId,PaymentMethod,SaleStatus,CreatedAt,ShippingAddress,CustomerEmail,CustomerPhone FROM sales;";
                        var dr = cm.ExecuteReader();
                        while (dr.Read())
                        {
                            var cus = GetCustomerbyID(dr.GetInt32(7));
                            lsales.Add(new sales() { Saleid = dr.GetInt32(0),
                                OrderNumber= dr.GetString(1),
                                SaleDate =  dr.GetDateTime(2).ToString(),
                                TotalAmount = dr.GetDecimal(3),
                                TaxAmount = dr.GetDecimal(4),
                                ShippingCost = dr.GetDecimal(5),
                                Discount = dr.GetDecimal(6),
                                customers = cus,
                                PaymentMethod = dr.GetString(8),
                                SaleStatus = dr.GetString(9),
                                CreatedAt = dr.GetDateTime(10),
                                ShippingAddess = dr.GetString(11),
                                CustomerEmail = dr.GetString(12),
                                CustomerPhone = dr.GetString(13)
                                
                            });
                        }
                    }
                    cn.Close();
                }
            }
            catch (Exception ps) { Console.WriteLine(ps.Message); return new List<sales>(); }
            return lsales;
        }
        #endregion
    }
}