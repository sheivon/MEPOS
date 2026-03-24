namespace Entities
{
    public class Products
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string Cur { get; set; }
        public bool type { get; set; }
        public bool active { get; set; }
    }
}