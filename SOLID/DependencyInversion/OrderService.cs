namespace SOLID.DependencyInversion;

public class OrderService
{
    private readonly IOrderRepository _repository;
    private readonly INotificationService _notificationService;

    // High-level module receives abstractions instead of creating concrete instances
    public OrderService(IOrderRepository repository, INotificationService notificationService)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _notificationService = notificationService ?? throw new ArgumentNullException(nameof(notificationService));
    }

    public void Checkout(Order order)
    {
        Console.WriteLine($"\n--- Processing Checkout for Order: {order.OrderId} ---");
        
        // 1. Save data via abstraction
        _repository.Save(order);

        // 2. Notify customer via abstraction
        string message = $"Your order of {order.TotalAmount:C} has been successfully processed!";
        _notificationService.SendNotification(order.CustomerEmail, message);
        
        Console.WriteLine($"[OrderService] Order #{order.OrderId} completed successfully.");
    }
}