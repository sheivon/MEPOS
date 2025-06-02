using System.ComponentModel;

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
