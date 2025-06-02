using System.ComponentModel;

namespace Entities
{
    public class Products
    {
        [DisplayName("ID")]
        public int Id { set; get; }
        [DisplayName("BARCODE")]
        public string Barcode { set; get; }
        [DisplayName("DESCRIPTION")]
        public string Name { set; get; }
        [DisplayName("AVAILABLE")]
        public int Stock { set; get; }
        [DisplayName("SOLD")]
        public decimal Price { set; get; }
        [DisplayName("MONEY")]
        public string Cur { set; get; }
        [DisplayName("IsProduct")]
        public bool type { get; set; }
        [DisplayName("ACTIVE")]
        public bool active { get; set; }
    }
}
