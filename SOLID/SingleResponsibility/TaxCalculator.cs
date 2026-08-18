namespace SOLID.SingleResponsibility;

public class TaxCalculator
{
    public decimal CalculateSubtotal(Invoice invoice)
    {
        return invoice.Items.Sum(item => item.Total);
    }

    public decimal CalculateTax(Invoice invoice, decimal taxRate)
    {
        return CalculateSubtotal(invoice) * taxRate;
    }

    public decimal CalculateGrandTotal(Invoice invoice, decimal taxRate)
    {
        return CalculateSubtotal(invoice) + CalculateTax(invoice, taxRate);
    }
}