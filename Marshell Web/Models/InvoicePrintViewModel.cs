using System.Collections.Generic;

namespace Marshell_Web.Models
{
    // ViewModel used to pass data from PrintController.InvoiceView to Invoice view template.
    public class InvoicePrintViewModel
    {
        // The whole sale record (header info, totals, customer, etc.)
        public sales Sale { get; set; }

        // Line items belonging to this sale
        public List<CartItem> Items { get; set; } = new List<CartItem>();

        // Paper size used to render the invoice (letter/legal/pos);
        // PrintController sets this based on URL query param.
        public string PaperSize { get; set; } = string.Empty;

        // QR code image as data URL. Controller generates this using QRCoder.
        public string InvoiceQrDataUrl { get; set; } = string.Empty;
    }
}
