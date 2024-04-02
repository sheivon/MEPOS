using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Users
    { 
        public int Id { set; get; }
        public string Name { set; get; }
        public string Srname { set; get; }
        public string Role { set; get; }
        public bool Fired { set; get; }
        public string IDNumber { set; get; }
        public string Gender { set; get; }
        public string Mobile { set; get; }
        public string Location { set; get; }
        public string RegDate { set; get; }
        public string Nationality { set; get; }
        public string login { set; get; }
        public string pass { set; get; }
    }
}
