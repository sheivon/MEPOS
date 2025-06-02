using System.Configuration;

namespace Marshell_Web.Models
{
    public class Connectionstring
    {
        // Keep connectionString as an instance member
        private string connectionString = ConfigurationManager.ConnectionStrings["Mashelldbcon"].ConnectionString;

        // Instance property to access the connection string
        public string ConnectionString { get { return connectionString; } }

    }
}