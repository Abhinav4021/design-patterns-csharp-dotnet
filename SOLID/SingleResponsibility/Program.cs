using SOLID.SingleResponsibility;

Console.WriteLine("=== Single Responsibility Principle (SRP) Demo ===\n");

// 1. Create the invoice data model
var invoice = new Invoice("INV-2026-001", "Acme Corporation");
invoice.AddItem("Cloud Hosting (1 Month)", 1, 1200.00m);
invoice.AddItem("SSL Certificate", 2, 150.00m);
invoice.AddItem("Database Backup Storage", 1, 300.00m);

// 2. Compute financial totals via TaxCalculator
var calculator = new TaxCalculator();
const decimal taxRate = 0.18m; // 18% GST/VAT

// 3. Format and print the invoice via InvoicePrinter
var printer = new InvoicePrinter(calculator);
printer.Print(invoice, taxRate);

// 4. Persist data via InvoiceRepository
var repository = new InvoiceRepository();
repository.Save(invoice);