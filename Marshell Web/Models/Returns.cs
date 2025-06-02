using System;

namespace Marshell_Web.Models
{
    public class Returns
    {
        public int return_id { get; set; }
        public int sale_id { get; set; }
        public int product_id { get; set; }
        public string product_name { get; set; } = string.Empty;
        public decimal quantity_returned { get; set; }
        public DateTime return_date { get; set; } = DateTime.Now;
    }
}