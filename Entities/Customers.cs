using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customers
    {
        //[Browsable(false)]
        public int id { set; get; }
        public string name { get; set; }
        public string srname { set; get; }
        public string mobile { set; get; }
        public string idcard { set; get; }
        public string location { set; get; }
        public string nacionality { set; get; }
        public string gender { set; get; }
        public bool blocked { set; get; }
        public decimal owing { set; get; }
        public string money { set; get; }
        public bool active { get; set; }
        [DisplayName("FULL NAME")]
        public string FullName
        {
            get
            {
                return (name + " " + srname).ToUpper();
            }
        }
    }
}
