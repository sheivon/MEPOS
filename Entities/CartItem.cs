using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CartItem
    {
        [DisplayName("#")]//,Browsable(false)]
        public int id { get; set; }
        [DisplayName("DESCRIPTION")]
        public string Name { get; set; }
        [DisplayName("UNIT PRICE")]
        public float price { get; set; }
        [DisplayName("AMOUNT")]
        public int amount { get; set; }
        [DisplayName("SUBTOTAL")]
        public float SubTotal { get { return amount * price; } }

        [DisplayName("MONEY")]
        public string cur { get; set; }
        [DisplayName("TYPE")]
        public bool type { set; get; }
        //{

        //    get {
        //        if (_type == 0)
        //        { return "PRODUCT"; }
        //        else
        //        { return "SERVICE"; }
        //    }

        //    set { _type = (value == "PRODUCT") ? 0 : 1; }
        //}

    }
}
