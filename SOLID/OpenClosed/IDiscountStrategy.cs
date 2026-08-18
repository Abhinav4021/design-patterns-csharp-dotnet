namespace SOLID.OpenClosed;

public interface IDiscountStrategy
{
    decimal ApplyDiscount(Order order);
}