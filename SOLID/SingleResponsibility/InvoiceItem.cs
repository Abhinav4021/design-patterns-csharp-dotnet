namespace SOLID.SingleResponsibility;

public record InvoiceItem(string Description, int Quantity, decimal UnitPrice)
{
    public decimal Total => Quantity * UnitPrice;
}