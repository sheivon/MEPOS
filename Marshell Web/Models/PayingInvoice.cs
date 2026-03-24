using System;
using System.ComponentModel;

namespace Entities
{
    public class PayingInvoice
    {
        public int id { get; set; }
        [DisplayName("Payed")]
        public float paying { get; set; }
        [DisplayName("OWED")]
        public float owed { get; set; }
        [DisplayName("Date")]
        public DateTime reg { get; set; }
        public string Customer { get; set; }
        public string Cashier { get; set; }
    }
}