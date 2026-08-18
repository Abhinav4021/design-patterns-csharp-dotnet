using SOLID.OpenClosed;

public class VipCustomerDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(Order order)
    {
        // 25% discount
        return order.TotalAmount * 0.75m;
    }
}