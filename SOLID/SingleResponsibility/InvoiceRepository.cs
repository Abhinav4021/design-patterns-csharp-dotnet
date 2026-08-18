namespace SOLID.SingleResponsibility;

public class InvoiceRepository
{
    public void Save(Invoice invoice)
    {
        // Persistence logic (e.g., Database, Cloud Storage, or File System)
        Console.WriteLine($"[Storage] Invoice '{invoice.Id}' successfully persisted to database.");
    }
}