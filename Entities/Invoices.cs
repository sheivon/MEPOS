using System;
using System.ComponentModel;

namespace Entities
{
    public class Invoices
    {
        public int ID { set; get; }
        public string Invoice { set; get; }
        public string Customer { set; get; }
        public int CusId { set; get; }
        public string Seller { set; get; }
        public int usrId { set; get; } /* User id for modding*/
        public DateTime Date { set; get; }
        [DisplayName("Pendind")]
        public bool Stat { set; get; }
        public decimal Total { set; get; }
        public decimal off { set; get; }
        public decimal TotalOw { get { return Total - cashed; } } /* live calcs of owing*/
        public decimal Exchange { set; get; }
        public string Cur { set; get; }
        public bool active { get; set; }
        public decimal cashed { get; set; }

        public Invoices() { }
    }
}
