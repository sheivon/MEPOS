using System.ComponentModel;

namespace Entities
{
    public class semiprod
    {
        [DisplayName("PRODUCT NAME")]
        public string Name { get; set; }
        [DisplayName("TOTAL")]
        public float Total { get; set; }
        [DisplayName("SUB TOTAL")]
        public float UPrice { get; set; }

    }
}
