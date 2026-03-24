using System;

namespace Entities
{
    public class Payments
    {
        public float payed { get; set; }
        public float owed { get; set; }
        public DateTime Date { get; set; }
        public string cashier { get; set; }
        public string Customer { get; set; }
    }
}