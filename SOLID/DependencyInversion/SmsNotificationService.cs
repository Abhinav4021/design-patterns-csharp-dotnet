namespace SOLID.DependencyInversion;

// Alternative notification: SMS Service (interchangeable)
public class SmsNotificationService : INotificationService
{
    public void SendNotification(string recipient, string message)
    {
        Console.WriteLine($"[SMS Gateway] Sent alert to '{recipient}': {message}");
    }
}