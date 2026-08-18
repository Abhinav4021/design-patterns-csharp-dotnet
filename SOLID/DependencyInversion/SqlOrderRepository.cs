namespace SOLID.DependencyInversion;

// Concrete SQL Database Repository
public class SqlOrderRepository : IOrderRepository
{
    public void Save(Order order)
    {
        Console.WriteLine($"[SQL Database] Persisting Order #{order.OrderId} ({order.TotalAmount:C}) to Orders table.");
    }
}