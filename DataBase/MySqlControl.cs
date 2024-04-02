using GUIHelper;
using MarshellsSettings;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class MySqlControl : IDisposable
    {
        //
        // GMessage
        //
        private GMessage GMessage = new GMessage();
        //
        // Database connection string
        //
        private MySqlConnection connection = new MySqlConnection(MSetting.GetConnectionstring());
        private MySqlCommand DBCmd;
        public MySqlControl()
        {

        }
        //
        // DB Data
        //
        public MySqlDataAdapter DBDA = new MySqlDataAdapter();
        public DataTable DBDT = new DataTable();
        //
        // Query Parameters
        //
        public List<MySqlParameter> param = new List<MySqlParameter>();
        //
        // Query Statistics
        //
        public int recordCount;
        public string Exception;
        //
        // DataReader
        //
        public MySqlDataReader DataReader;
        //
        // Allow Connection Override
        //
        public MySqlControl(string Connectionstring)
        {
            connection = new MySqlConnection(Connectionstring);
        }
        //
        // EXECUTE QUERY sub
        //
        public void ExecQuery(string Query)
        {
            //
            // reset query stats
            //
            recordCount = 0;
            try
            {
                //
                // open connection to db
                //
                connection.Open();
                //
                // create db command
                //
                DBCmd = new MySqlCommand(Query, connection);
                //
                // Load parameter
                //
                param.ForEach(p => DBCmd.Parameters.Add(p));
                //foreach (var p in param)
                //{
                //    DBCmd.Parameters.Add(p);
                //}
                //
                // Clear param list when added
                //
                param.Clear();
                //
                // Execute command and load dataset
                DBDT = new DataTable();
                DBDA = new MySqlDataAdapter(DBCmd);
                recordCount = DBDA.Fill(DBDT);
                //
                // Load reader
                //
                DataReader = DBCmd.ExecuteReader();
                connection.Close();
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }
#if DEBUG
            catch (Exception ex)
            {
                if (connection != null) { connection.Close(); }
                GMessage.Show("Database ExecQuery Error: " + Environment.NewLine + ex.Message);
            }
#else
            catch(Exception)
            {  if (connection != null) { connection.Close(); }}
#endif
            finally
            {
                if (connection.State == ConnectionState.Open) { connection.Close(); }
                Dispose();
            }
        }
        //
        // Adding parameters
        //
        public void AddParameter(string Name, object value)
        {
            MySqlParameter newparam = new MySqlParameter(Name, value);
            param.Add(newparam);
        }
        //
        // Reade the stored Data
        //
        public MySqlDataReader GetDataReader()
        {
            return DataReader;
        }
        public static string GetConnectionString()
        {
            return MSetting.GetConnectionstring();
        }
        public void Dispose()
        {
            if (connection.State == ConnectionState.Open) { connection.Close(); }
        }

        ~MySqlControl()
        {
            if (connection.State == ConnectionState.Open) { connection.Close(); }
        }

        //#pragma warning disable CS0465 // Introducing a 'Finalize' method can interfere with destructor invocation
        //        protected override void Finalize()

        //        {
        //            try
        //            {
        //                if (connection.State == ConnectionState.Open)
        //                {
        //                    connection.Close();
        //                }
        //            }
        //            finally
        //            {
        //                base.Finalize();
        //            }
        //        }
        //#pragma warning restore CS0465 // Introducing a 'Finalize' method can interfere with destructor invocation
    }
}
