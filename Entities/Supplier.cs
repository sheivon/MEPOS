using System;
using System.ComponentModel;

namespace Entities
{
    public class Supplier
    {
        [DisplayName("#")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public DateTime Created { get; set; }
    }
}
