namespace Creational.Factory.Products;

/// <summary>
/// Concrete Product.
///
/// Represents an email notification.
/// </summary>
public sealed class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"  → Sending Email: {message}");
    }
}