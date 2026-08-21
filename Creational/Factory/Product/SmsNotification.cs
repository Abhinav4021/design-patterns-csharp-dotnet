namespace Creational.Factory.Products;

/// <summary>
/// Concrete Product.
///
/// Represents an SMS notification.
/// </summary>
public sealed class SmsNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"  → Sending SMS: {message}");
    }
}