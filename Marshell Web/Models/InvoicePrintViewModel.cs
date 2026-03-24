using System.Collections.Generic;

namespace Marshell_Web.Models
{
    public class InvoicePrintViewModel
    {
        public sales Sale { get; set; }
        public List<CartItem> Items { get; set; }
        public string PaperSize { get; set; }
    }
}
