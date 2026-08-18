using SOLID.OpenClosed;

Console.WriteLine("=== Open/Closed Principle (OCP) Demo ===\n");

var order1 = new Order("ORD-101", 500.00m);
var processor = new OrderProcessor();

// 1. Regular customer order
IDiscountStrategy regularStrategy = new RegularCustomerDiscount();
decimal regularFinal = processor.ProcessOrder(order1, regularStrategy);
Console.WriteLine($"Order {order1.OrderId} (Original: {order1.TotalAmount:C})");
Console.WriteLine($"  - Regular Customer Final:  {regularFinal:C}");

// 2. Premium customer order
IDiscountStrategy premiumStrategy = new PremiumCustomerDiscount();
decimal premiumFinal = processor.ProcessOrder(order1, premiumStrategy);
Console.WriteLine($"  - Premium Customer Final:  {premiumFinal:C}");

// 3. VIP customer order
IDiscountStrategy vipStrategy = new VipCustomerDiscount();
decimal vipFinal = processor.ProcessOrder(order1, vipStrategy);
Console.WriteLine($"  - VIP Customer Final:      {vipFinal:C}");

// 4. Extended promotional strategy without altering OrderProcessor
IDiscountStrategy festiveStrategy = new FestiveSeasonDiscount();
decimal festiveFinal = processor.ProcessOrder(order1, festiveStrategy);
Console.WriteLine($"  - Festive Promo Final:     {festiveFinal:C}");