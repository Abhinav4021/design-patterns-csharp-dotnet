namespace SOLID.SingleResponsibility;

public class Invoice
{
    public string Id { get; }
    public string CustomerName { get; }
    public List<InvoiceItem> Items { get; } = [];

    public Invoice(string id, string customerName)
    {
        Id = id;
        CustomerName = customerName;
    }

    public void AddItem(string description, int quantity, decimal unitPrice)
    {
        Items.Add(new InvoiceItem(description, quantity, unitPrice));
    }
}