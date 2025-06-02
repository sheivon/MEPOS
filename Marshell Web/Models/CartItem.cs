using System;

namespace Marshell_Web.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }       // Unique identifier for the cart item
        public int ProductId { get; set; }         // The ID of the product added to the cart
        public string ProductName { get; set; }    // The name of the product
        public decimal Price { get; set; }         // The price of the product
        public int Quantity { get; set; }          // The quantity of the product in the cart    
        public decimal TotalPrice => Price * Quantity; // Total price (Price * Quantity), automatically calculated
        public string ProductImage { get; set; }     // Optional: URL or path to the product image
        public string ProductDescription { get; set; } // Optional: Description of the product

        // Discount applied to the product (if any)
        public decimal Discount { get; set; }

        // Discounted price after applying the discount
        public decimal DiscountedPrice => Price - Discount;

        // Tax applied to the product
        public decimal TaxAmount { get; set; }

        // Subtotal after discount but before tax
        public decimal Subtotal => DiscountedPrice * Quantity;

        // Final price after applying tax to the discounted price
        public decimal FinalPrice => Subtotal + TaxAmount;

        // Optional: Add a field to track if the product is in stock (if applicable)
        public bool IsAvailable { get; set; }  // Indicates if the product is in stock

        // Foreign Key: SaleId to link the CartItem to a specific Sale
        public int SaleId { get; set; }              // Foreign key to Sale
        public sales Sale { get; set; }               // Navigation property to the related Sale

        public DateTime SaleDate { get; set; }
        public string OrderNumber { get; set; }
    }
}
 