using DataBase;
using GUIHelper;
using MarshellsSettings;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace InvoicePrinter
{
    static public class sales
    {
        private static GMessage GMessage = new GMessage();
        private static string Title = "Marshell's";
        //sales is logs table
        public static void Insert(string FacturaNo, string customer, string cashier, float TotalPayed, float Owing, String status, string DATE)
        {
            try
            {
                using (MySqlConnection SQL = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    string qry = ("INSERT INTO SALES(FACTURANO,CUSTOMERNAME,CASHIER,TOTALPAY,OWING,STATUS,SALES_DATE) VALUES ('" + FacturaNo + "','" + customer + "','" + cashier + "','" + TotalPayed + "','" + Owing + "','" + status + "','" + DATE + "');");
                    SQL.Open();
                    MySqlCommand cmd = new MySqlCommand(qry, SQL);
                    cmd.ExecuteNonQuery();
                    SQL.Close();
                }
            }
            catch (Exception es)
            {
                GMessage.Show(es.Message + Environment.NewLine + "Insert saleslogs error!", Title);
                createDailyTable();
            }
            finally
            {
            }
        }
       
           
        public static void
            UpdateOwingCustomer(int custID, float Ow)
        {
            try
            {
                //float Topay = 0.0f;
                //MySqlControl SQ = new MySqlControl();
                //SQ.ExecQuery("Select OW,CNAME from customer where ID = '" + custID + "';");
                //foreach (DataRow D in SQ.DBDT.Rows)
                //{
                //    Topay =(float) D["OW"];
                //}
                //float newOw = 0.0f;
                //newOw = (Topay - Ow);

                using (MySqlConnection Conn = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    Conn.Open();
                    MySqlCommand Com = new MySqlCommand(string.Format("update customer set OW = {0} where ID = {1};", Ow, custID), Conn);
                    Com.ExecuteNonQuery();
                    Conn.Close();
                }
            }
            catch (Exception)
            {
            }
        }
        public static int UnkownCustomer(string factura)
        {
            int retid = 0;
            try
            {
                using (MySqlConnection s = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    s.Open();
                    using (MySqlCommand k = new MySqlCommand("INSERT INTO CUSTOMER(CNAME,SRNAME,IDNUMBER,MOBILE,GENDER,OW) VALUES ('" + factura + "','" + factura + "','" + factura + "','" + factura + "','FEMALE','0.0');", s))
                    {
                        k.ExecuteNonQuery();
                    }
                    s.Close();
                }

                using (MySqlControl mcon = new MySqlControl())
                {
                    mcon.ExecQuery("SELECT * FROM CUSTOMER WHERE CNAME = '" + factura + "' LIMIT 1; ");
                    foreach (DataRow dd in mcon.DBDT.Rows)
                    {
                        retid = (int)System.Convert.ToInt32(dd["ID"]);
                        //System.Windows.Forms.MessageBox.Show(retid.ToString());
                        return retid;
                    }
                }
            }
#if DEBUG
            catch (Exception ex)
            {
                GMessage.Show(ex.Message);
            }
#else
            catch
            { }
#endif
            finally
            { }
            return retid;
        }
        public static void createDailyTable()
        {
            MySqlControl SQL = new MySqlControl();
            try
            {
                SQL.ExecQuery("CREATE TABLE IF NOT EXISTS 'SALES'( `ID` TEXT NOT NULL PRIMARY KEY UNIQUE,`FACTURANO` TEXT NOT NULL,`CUSTOMERNAME` TEXT NOT NULL,`CASHIER` TEXT NOT NULL,`TOTALPAY` TEXT NOT NULL,`OWING` TEXT NOT NULL,`STATUS` TEXT NOT NULL);");
            }
            catch (Exception es)
            {
                GMessage.Show(es.Message, Title);
            }
            finally
            {
            }
        }
        //retunr the customer owing total from db
        public static float GetCustomerOwing(int id)
        {
            float ow = 0.0f;
            try
            {
                MySqlControl sqlcontrol = new MySqlControl();
                sqlcontrol.ExecQuery("SELECT OW FROM CUSTOMER WHERE ID ='" + id + "';");
                if (sqlcontrol.recordCount > 0)
                {
                    foreach (DataRow item in sqlcontrol.DBDT.Rows)
                    {
                        ow = (float)item["OW"];
                        return ow;
                    }
                }
                return ow;
            }
            catch
            {
                return ow;
            }
        }
        /// <summary>
        /// This funcion take a customerid and a amount 
        /// so that if customer owing then give away the paying
        /// </summary>
        /// <param name="CustomerID"></param>
        /// <param name="paying"></param>
        /// <returns></returns>
        public static void PayingByCustomer(int CustomerID, float paying)
        {
            float Balance = 0.0f;
            Balance = GetCustomerOwing(CustomerID);
            //New var to save updated value
            float NewOW = 0.0f;
            //if paying surpase the ow amout then eq 0
            if (paying >= Balance)
                NewOW = 0.0f;
            else
                NewOW = (Balance - paying);

            try
            {
                using (MySqlConnection mc = new MySqlConnection(MSetting.GetConnectionstring()))
                {
                    mc.Open();
                    using (MySqlCommand cmd = new MySqlCommand(string.Format("UPDATE customer SET OW={0} WHERE ID={1}",NewOW,CustomerID),mc))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    mc.Close();
                }
            }
            #if DEBUG
            catch (Exception ex )
            {
                GMessage.Show(ex.Message);
            }
#else
            catch (Exception)
            { }
#endif 
        }

        
    } 
}
