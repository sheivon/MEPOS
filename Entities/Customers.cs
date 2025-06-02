using System;
using System.ComponentModel;

namespace Entities
{
    public class Customers
    {
        //[Browsable(false)] 
        public int id { set; get; }
        public string name { get; set; }
        public string srname { set; get; }
        public string email { get; set; }
        public string mobile { set; get; }
        public string idcard { set; get; }
        public bool active { get; set; }
        public DateTime Created { set; get; }
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
