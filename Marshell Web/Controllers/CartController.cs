using Marshell_Web.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
//using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;
using System.Xml.Linq;


//using other controler
using Marshell_Web.Controllers;

namespace Marshell_Web.Controllers
{
    public class CartController : Controller
    {
        #region Cart
        private string tmpOrder = string.Empty; 
        // GET: Cart
        public ActionResult Index() { return View(); } 

        public JsonResult GetProduct(string bcode)
        {
            var prods = ProductsController.GetProducts().Where( p => p.Barcode == bcode).FirstOrDefault();
            if (prods != null)
            {
                return Json(new { data = prods }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new {data = "Fail Products not found!"}, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpPost]
        // Checkout receives cart data and saves sale + item rows.
        public JsonResult Checkout(CheckoutModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    tmpOrder = GenerateOrderNumber(); // generate the order number before saving
                    DateTime date = DateTime.Now;
                    model.sales.SaleDate = date; // set date before saving
                    model.sales.OrderNumber = tmpOrder; // save the generated order number into sale
                    int SaleId = SaveSale(model.sales);
                    foreach (var cartItem in model.CartItems)
                    {
                        cartItem.SaleDate = date;
                        cartItem.OrderNumber = tmpOrder;
                        cartItem.SaleId = SaleId;
                        SaveSaleItem(cartItem);
                    }
                    // Commit the transaction and return success response (include order/sale IDs)
                    return Json(new { success = true, message = "Checkout successful!", orderNumber = tmpOrder, saleId = SaleId });
                }
                catch (Exception ex)
                {
                    // Handle the error (log it, return a message, etc.)
                    return Json(new { success = false, message = "An error occurred during checkout. Please try again." + Environment.NewLine + ex.Message });
                }
            }
            else
            {
                return Json(new { success = false, message = "Invalid data." });
            }
        } 
        //methods to save the sale and sale items
        private int SaveSale(sales sale)
        {   // Sample connection string - replace with your actual DB connection string
            var x = new Connectionstring();
            int SaleId =-1;
            using (var conn = new MySqlConnection(x.ConnectionString))
            {
                conn.Open();
                string query = @"INSERT INTO Sales 
                (OrderNumber, SaleDate, TotalAmount, TaxAmount, ShippingCost, DiscountAmount, CustomerId, PaymentMethod, SaleStatus, CreatedAt, ShippingAddress, CustomerEmail, CustomerPhone)
                VALUES
                (@OrderNumber, @SaleDate, @TotalAmount, @TaxAmount, @ShippingCost, @DiscountAmount, @CustomerId, @PaymentMethod, @SaleStatus, @CreatedAt, @ShippingAddress, @CustomerEmail, @CustomerPhone);";  // Returns the generated SaleId

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderNumber", tmpOrder); // using tmporder to all sales and sales
                                                                           // itema have the same order number 
                    cmd.Parameters.AddWithValue("@SaleDate", sale.SaleDate);
                    cmd.Parameters.AddWithValue("@TotalAmount", sale.TotalAmount); 
                    cmd.Parameters.AddWithValue("@TaxAmount", sale.TaxAmount);
                    cmd.Parameters.AddWithValue("@ShippingCost", sale.ShippingCost);
                    cmd.Parameters.AddWithValue("@DiscountAmount", sale.DiscountAmount);
                    cmd.Parameters.AddWithValue("@CustomerId", sale.Customers.customer_id);
                    cmd.Parameters.AddWithValue("@PaymentMethod",   sale.PaymentMethod);
                    cmd.Parameters.AddWithValue("@SaleStatus", sale.SaleStatus);
                    cmd.Parameters.AddWithValue("@CreatedAt", DateTime.UtcNow);
                    cmd.Parameters.AddWithValue("@ShippingAddress", sale.ShippingAddress);
                    cmd.Parameters.AddWithValue("@CustomerEmail", sale.Customers.email);
                    cmd.Parameters.AddWithValue("@CustomerPhone", sale.Customers.phone);

                     cmd.ExecuteScalar();
                  
                    // Retrieve the last inserted ID
                    string lastInsertIdQuery = "SELECT LAST_INSERT_ID()";
                    using (MySqlCommand cmdGetId = new MySqlCommand(lastInsertIdQuery, conn))
                    {
                        SaleId = Convert.ToInt32(cmdGetId.ExecuteScalar());
                    }
                    return SaleId;
                    //return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        //SaveSaleItems also known as cartitems
        private void SaveSaleItem(CartItem cartItem)
        { 
            var x = new Connectionstring(); 
            using (var conn = new MySqlConnection(x.ConnectionString))
            {
                conn.Open(); 
                string query = @"
                INSERT INTO CartItems 
                (ProductId, ProductName, Price, Quantity, Discount, TaxAmount, SaleId, Saledate, Ordernumber, ProductImage, ProductDescription)
                VALUES
                (@ProductId, @ProductName, @Price, @Quantity, @Discount, @TaxAmount, @SaleId, @Saldate,@ordn,@ProductImage, @ProductDescription);";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductId", cartItem.ProductId);
                    cmd.Parameters.AddWithValue("@ProductName", cartItem.ProductName);
                    cmd.Parameters.AddWithValue("@Price", cartItem.Price);
                    cmd.Parameters.AddWithValue("@Quantity", cartItem.Quantity);
                    cmd.Parameters.AddWithValue("@Discount", cartItem.Discount);
                    cmd.Parameters.AddWithValue("@TaxAmount", cartItem.TotalPrice - cartItem.Discount); // Example tax   calculation
                    cmd.Parameters.AddWithValue("@SaleId", cartItem.SaleId);
                    cmd.Parameters.AddWithValue("@Saldate", cartItem.SaleDate);
                    cmd.Parameters.AddWithValue("@ordn", cartItem.OrderNumber);
                    cmd.Parameters.AddWithValue("@ProductImage", cartItem.ProductImage ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ProductDescription", cartItem.ProductDescription ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();
                } 
            }
        }
        // Generate a unique Order Number
        private string GenerateOrderNumber()
        {
            return "ORD" + DateTime.UtcNow.ToString("yyyyMMddHHmmss");
        }
        private void SaveReturns(int saleId, List<Returns> returnItems)
        {
            var x = new Connectionstring();
            using (var conn = new MySqlConnection(x.ConnectionString))
            {
                conn.Open();
                foreach (var returnItem in returnItems)
                {
                    string query = @"
                    INSERT INTO Returns
                    (SaleId, CartItemId, ReturnDate, QuantityReturned, ReturnReason, RefundAmount, ReturnStatus, CreatedAt)
                    VALUES
                    (@SaleId, @CartItemId, @ReturnDate, @QuantityReturned, @ReturnReason, @RefundAmount, @ReturnStatus, @CreatedAt);";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        //cmd.Parameters.AddWithValue("@SaleId", saleId);
                        //cmd.Parameters.AddWithValue("@CartItemId", returnItem.CartItemId);
                        //cmd.Parameters.AddWithValue("@ReturnDate", returnItem.ReturnDate);
                        //cmd.Parameters.AddWithValue("@QuantityReturned", returnItem.QuantityReturned);
                        //cmd.Parameters.AddWithValue("@ReturnReason", returnItem.ReturnReason);
                        //cmd.Parameters.AddWithValue("@RefundAmount", returnItem.RefundAmount);
                        //cmd.Parameters.AddWithValue("@ReturnStatus", returnItem.ReturnStatus);
                        cmd.Parameters.AddWithValue("@CreatedAt", DateTime.UtcNow);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        #endregion
    }
}