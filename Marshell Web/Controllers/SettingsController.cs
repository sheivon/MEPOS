using Marshell_Web.Models;
using System;
using System.Configuration;
using System.Data.Common;
using System.Web.Configuration;
using System.Web.Mvc;

namespace Marshell_Web.Controllers
{
    public class SettingsController : Controller
    {
        private const string DefaultConnectionName = "Mashelldbcon";

        [HttpGet]
        public ActionResult Index()
        {
            var connection = ConfigurationManager.ConnectionStrings[DefaultConnectionName];
            var model = new ConnectionConfigViewModel();

            if (connection != null)
            {
                model.Name = connection.Name;
                model.ConnectionString = connection.ConnectionString;
                model.ProviderName = connection.ProviderName;

                try
                {
                    var builder = new DbConnectionStringBuilder { ConnectionString = connection.ConnectionString };
                    model.Server = builder.ContainsKey("server") ? builder["server"]?.ToString() : builder.ContainsKey("data source") ? builder["data source"]?.ToString() : string.Empty;
                    model.Database = builder.ContainsKey("database") ? builder["database"]?.ToString() : builder.ContainsKey("initial catalog") ? builder["initial catalog"]?.ToString() : string.Empty;
                    model.Port = builder.ContainsKey("port") ? builder["port"]?.ToString() : "";
                    model.UserId = builder.ContainsKey("uid") ? builder["uid"]?.ToString() : builder.ContainsKey("user id") ? builder["user id"]?.ToString() : string.Empty;
                    model.Password = builder.ContainsKey("pwd") ? builder["pwd"]?.ToString() : builder.ContainsKey("password") ? builder["password"]?.ToString() : string.Empty;
                }
                catch
                {
                    // keep fallback values if parse fails.
                }
            }
            else
            {
                model.Name = DefaultConnectionName;
                model.ProviderName = "MySql.Data.MySqlClient";
                model.Server = "localhost";
                model.Database = "marshelldb";
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ConnectionConfigViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var normalizedPort = 3306;
            if (!string.IsNullOrWhiteSpace(model.Port) && int.TryParse(model.Port, out var p) && p > 0)
            {
                normalizedPort = p;
            }

            model.ConnectionString = $"server={model.Server};port={normalizedPort};database={model.Database};uid={model.UserId};pwd={model.Password};";

            try
            {
                var config = WebConfigurationManager.OpenWebConfiguration("~");
                var section = (ConnectionStringsSection)config.GetSection("connectionStrings");

                if (section == null)
                {
                    throw new InvalidOperationException("connectionStrings section is missing in web.config");
                }

                if (section.ConnectionStrings[DefaultConnectionName] != null)
                {
                    section.ConnectionStrings[DefaultConnectionName].ConnectionString = model.ConnectionString;
                    section.ConnectionStrings[DefaultConnectionName].ProviderName = model.ProviderName;
                }
                else
                {
                    section.ConnectionStrings.Add(new ConnectionStringSettings
                    {
                        Name = DefaultConnectionName,
                        ConnectionString = model.ConnectionString,
                        ProviderName = model.ProviderName
                    });
                }

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");

                TempData["Message"] = "Connection string updated successfully. App may restart to apply new config.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Unable to save configuration: " + ex.Message);
                return View(model);
            }
        }
    }
}