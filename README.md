# MEPOS

MEPOS is a point-of-sale (POS) and retail management system built on ASP.NET MVC + MySQL. The system supports cart scanning, checkout, customer management, invoices, reports, and simple inventory workflows. It is intended for small businesses like shops, kiosks, and service points.

## Key features

- Barcode product scan and cart management
- Front-end cart view with quantity update + remove item
- Checkout flow with payment modal and order persistence
- Invoice print support (letter/legal/POS formats)
- Sales and returns tracking
- Product and customer management via separate modules
- RDLC reporting for invoices and sales

## Architecture

- `Marshell Web` (ASP.NET MVC app)
- `Controllers` for web actions: `CartController`, `PrintController`, etc.
- `Models` for domain entities: `sales`, `CartItem`, `CheckoutModel`, etc.
- `Views` are Razor `.cshtml` pages for UI and modals
- `Report/rdlc` for generated invoice and sales reports

## Setup (developer)

1. Rename solution (already done): `MEPOS.sln`
2. Open in Visual Studio 2022+ or Rider
3. Ensure MySQL database is available and update connection string in `Connectionstring` class
4. Run migrations / import provided SQL files (`marshell_*`, `Procedures.sql`, etc.)
5. Start the web project and navigate to the cart page

## New workflow added (by assistant)

- On checkout success, the app now prompts: "Print invoice now (POS view)?"
- If confirmed, opens `Print/InvoiceView` with `size=pos` using response `orderNumber` and `saleId`

## Quick run (test)

- Go to /Cart page
- Add items to cart
- Click Checkout -> enter payment info -> confirm
- Confirm print dialog -> invoice page appears in new tab

## Notes for beginners

- `CartController.Checkout` accepts `CheckoutModel` with `sales` and `CartItems`
- `PrintController.InvoiceView` uses `InvoicePrintViewModel` to pass data to invoice UI
- `InvoicePrintViewModel` properties:
  - `Sale` (sales record)
  - `Items` (List<CartItem>)
  - `PaperSize` (letter/legal/pos)

## Contact

For repo support, change requests or bugs, open an issue in the source repository.
