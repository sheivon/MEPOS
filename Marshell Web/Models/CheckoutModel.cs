using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marshell_Web.Models
{
    public class CheckoutModel
    {  
        public sales sales { get; set; }      
 
        // Navigation property to the CartItems related to this Sale
        public ICollection<CartItem> CartItems { get; set; }  // One-to-many relationship with CartItems
        // New properties for handling returns

    }

}