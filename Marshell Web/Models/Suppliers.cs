using System;

namespace Marshell_Web.Models
{
    public class Suppliers
    {
        public int supplier_id { get; set; }
        public string name { get; set; }
        public string contactinfo { get; set; }
        public DateTime created_at { get; set; }
        public Suppliers() { }
    }
}