namespace SOLID.DependencyInversion;

// Abstraction for data persistence (Low-level module contract)
public interface IOrderRepository
{
    void Save(Order order);
}
