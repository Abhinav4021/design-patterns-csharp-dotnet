namespace SOLID.DependencyInversion;

// Alternative persistence: Cloud NoSQL / Cosmos DB (interchangeable)
public class CloudOrderRepository : IOrderRepository
{
    public void Save(Order order)
    {
        Console.WriteLine($"[Cloud CosmosDB] Storing JSON document for Order #{order.OrderId}.");
    }
}