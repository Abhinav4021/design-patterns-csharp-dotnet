namespace SOLID.OpenClosed;

public class OrderProcessor
{
    public decimal ProcessOrder(Order order, IDiscountStrategy discountStrategy)
    {
        ArgumentNullException.ThrowIfNull(order);
        ArgumentNullException.ThrowIfNull(discountStrategy);

        return discountStrategy.ApplyDiscount(order);
    }
}