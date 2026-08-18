namespace SOLID.SingleResponsibility;

public class InvoicePrinter
{
    private readonly TaxCalculator _calculator;

    public InvoicePrinter(TaxCalculator calculator)
    {
        _calculator = calculator;
    }

    public void Print(Invoice invoice, decimal taxRate)
    {
        Console.WriteLine($"=== INVOICE: {invoice.Id} ===");
        Console.WriteLine($"Customer: {invoice.CustomerName}\n");
        Console.WriteLine("Items:");

        foreach (var item in invoice.Items)
        {
            Console.WriteLine($"  - {item.Description,-25} x{item.Quantity} @ {item.UnitPrice,8:C} = {item.Total,8:C}");
        }

        Console.WriteLine(new string('-', 50));
        Console.WriteLine($"Subtotal:     {_calculator.CalculateSubtotal(invoice),12:C}");
        Console.WriteLine($"Tax ({taxRate:P0}):     {_calculator.CalculateTax(invoice, taxRate),12:C}");
        Console.WriteLine($"Grand Total:  {_calculator.CalculateGrandTotal(invoice, taxRate),12:C}");
        Console.WriteLine(new string('=', 50) + "\n");
    }
}