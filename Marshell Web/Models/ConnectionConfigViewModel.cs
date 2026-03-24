using System.ComponentModel.DataAnnotations;

namespace Marshell_Web.Models
{
    public class ConnectionConfigViewModel
    {
        [Display(Name = "Connection Name")]
        public string Name { get; set; }

        [Display(Name = "Server")]
        [Required(ErrorMessage = "Server is required.")]
        public string Server { get; set; }

        [Display(Name = "Database")]
        [Required(ErrorMessage = "Database is required.")]
        public string Database { get; set; }

        [Display(Name = "Port")]
        public string Port { get; set; }

        [Display(Name = "User ID")]
        [Required(ErrorMessage = "User ID is required.")]
        public string UserId { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [Display(Name = "Connection String")]
        [Required(ErrorMessage = "Connection string is required.")]
        public string ConnectionString { get; set; }

        [Display(Name = "Provider Name")]
        [Required(ErrorMessage = "Provider name is required.")]
        public string ProviderName { get; set; }

        [Display(Name = "Status")]
        public string StatusMessage { get; set; }
    }
}