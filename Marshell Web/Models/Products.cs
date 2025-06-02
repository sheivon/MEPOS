using System;

namespace Marshell_Web.Models
{
    public class Products
    {
        public int ProductId { get; set; } // Corresponds to product_id
        public string Name { get; set; } // Corresponds to name
        public string Description { get; set; } // Corresponds to description
        public decimal Price { get; set; } // Corresponds to price
        public decimal Cost { get; set; } // Corresponds to cost
        public string Sku { get; set; } // Corresponds to sku
        public int? CategoryId { get; set; } // Corresponds to category_id (nullable)
        public string CategoryName { get; set; } // get only
        public string Barcode { get; set; } // Corresponds to barcode
        public DateTime CreatedAt { get; set; } // Corresponds to created_at
        public DateTime UpdatedAt { get; set; } // Corresponds to updated_at
    }
}