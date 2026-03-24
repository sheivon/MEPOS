using System;
using System.ComponentModel;

namespace Entities
{
    public class InvoiceDetails
    {
        public int ID { get; set; } /*Primary KEY*/
        public string BCODE { get; set; } /*FACN*/
        public int IID { get; set; } /*Product ID*/
        public string ITEM { get; set; } /*Does not save just read db*/
        public int QTY { get; set; }
        [DisplayName("Price")]
        public decimal UNITPRICE { get; set; }
        public decimal TOTAL { get { return UNITPRICE * QTY; } }
        public DateTime CDATE { get; set; }
        public decimal Off { get; set; }
        public bool Active { get; set; }
    }
}