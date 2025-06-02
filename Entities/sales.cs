using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{/*SELECT SaleId,OrderNumber,SaleDate,TotalAmount,TaxAmount,ShippingCost,DiscountAmount,CustomerId,PaymentMethod,SaleStatus,CreatedAt,ShippingAddress,CustomerEmail,CustomerPhone FROM `sales`*/
    public class sales
    {
        public int Saleid {  get; set; }
        public string OrderNumber { get; set; }
        public string SaleDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal ShippingCost { get; set; }
        public decimal Discount { get; set; }
        public int CustomerId { get; set; }
        public string PaymentMethod { get; set; }
        public string SaleStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ShippingAddess { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public Customers customers { get; set; }
    }
}
