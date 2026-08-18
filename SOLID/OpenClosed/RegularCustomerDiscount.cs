namespace SOLID.OpenClosed;

public class RegularCustomerDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(Order order)
    {
        // 5% discount
        return order.TotalAmount * 0.95m;
    }
}