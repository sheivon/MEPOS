using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AnalyticItem
    {
        [DisplayName("Product Name")]
        public string name { get; set; }
        [DisplayName("Total")]
        public float value { get; set; }
    }
}
