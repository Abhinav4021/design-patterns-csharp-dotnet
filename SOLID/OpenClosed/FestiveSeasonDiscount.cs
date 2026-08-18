using SOLID.OpenClosed;

public class FestiveSeasonDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(Order order)
    {
        // Flat $50 off on orders over $200, plus 10% discount
        decimal baseAmount = order.TotalAmount > 200 ? order.TotalAmount - 50 : order.TotalAmount;
        return baseAmount * 0.90m;
    }
}