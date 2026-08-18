using SOLID.DependencyInversion;

Console.WriteLine("=== Dependency Inversion Principle (DIP) Demo ===\n");

var sampleOrder1 = new Order("ORD-9001", "alex@example.com", 249.99m);
var sampleOrder2 = new Order("ORD-9002", "sarah@example.com", 1499.00m);

// Scenario A: Enterprise configuration (SQL Database + Email alerts)
IOrderRepository sqlRepo = new SqlOrderRepository();
INotificationService emailService = new EmailNotificationService();

var standardOrderService = new OrderService(sqlRepo, emailService);
standardOrderService.Checkout(sampleOrder1);

Console.WriteLine(new string('-', 65));

// Scenario B: Cloud-native setup (Cloud CosmosDB + SMS alerts) swapped without altering OrderService
IOrderRepository cloudRepo = new CloudOrderRepository();
INotificationService smsService = new SmsNotificationService();

var cloudOrderService = new OrderService(cloudRepo, smsService);
cloudOrderService.Checkout(sampleOrder2);