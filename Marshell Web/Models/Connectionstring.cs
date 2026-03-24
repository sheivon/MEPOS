using System.Configuration;

namespace Marshell_Web.Models
{
    public class Connectionstring
    {
        // Read directly from web.config each time (reflects latest saved config without keeping stale cache)
        public string ConnectionString
        {
            get
            {
                var settings = ConfigurationManager.ConnectionStrings["Mashelldbcon"];
                return settings?.ConnectionString ?? string.Empty;
            }
        }

        public string ProviderName
        {
            get
            {
                var settings = ConfigurationManager.ConnectionStrings["Mashelldbcon"];
                return settings?.ProviderName ?? "MySql.Data.MySqlClient";
            }
        }
    }
}