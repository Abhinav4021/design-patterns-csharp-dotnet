namespace SOLID.OpenClosed;

public class PremiumCustomerDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(Order order)
    {
        // 15% discount
        return order.TotalAmount * 0.85m;
    }
}