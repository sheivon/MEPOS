using System;
using System.ComponentModel;

namespace Marshell_Web.Models
{
    public class Customers
    {
        [DisplayName("#")]
        public int customer_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string cedula { get; set; }
        public string phone { get; set; }
        public bool isdelete { get; set; }
        public DateTime created_at { get; set; }
    }
}