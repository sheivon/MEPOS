using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
