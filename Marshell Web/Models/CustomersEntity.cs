using System;

namespace Entities
{
    public class Customers
    {
        public int id { get; set; }
        public string name { get; set; }
        public string srname { get; set; }
        public string idcard { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public bool active { get; set; }
        public DateTime Created { get; set; }

        public string FullName => $"{name} {srname}".Trim();
    }
}