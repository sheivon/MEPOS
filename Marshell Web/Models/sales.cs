using System;
using System.Collections.Generic;

namespace Marshell_Web.Models
{
    public class sales
    {
        public int SaleId { get; set; }      
        public string OrderNumber { get; set; }      // Order reference number
        public DateTime SaleDate { get; set; }       // Date the sale was made
        public decimal TotalAmount { get; set; }     // Total amount for the sale (sum of all items)
        public decimal TaxAmount { get; set; }       // Tax applied to the sale
        public decimal ShippingCost { get; set; }    // Shipping cost for the order (if applicable)
        public decimal DiscountAmount { get; set; }  // Any discount applied to the total sale 
        public string PaymentMethod { get; set; }    // Payment method used (e.g., Credit Card, PayPal)
        public decimal AmountPaid { get; set; }               // Amount the                  // Optional: The ID of the customer making the purchase
        public string SaleStatus { get; set; }       // Status of the sale (Completed, Pending, etc.)
        public DateTime CreatedAt { get; set; }      // Timestamp when the sale was created
        public string ShippingAddress { get; set; }  // Shipping address for the order 
        // Navigation property to the CartItems related to this Sale
        public ICollection<CartItem> CartItems { get; set; }  // One-to-many relationship with CartItems
        public Customers Customers { get; set; }
    }


}