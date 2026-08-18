namespace SOLID.DependencyInversion;

// Concrete Email Notification Service
public class EmailNotificationService : INotificationService
{
    public void SendNotification(string recipient, string message)
    {
        Console.WriteLine($"[SMTP Email] Sent to '{recipient}': {message}");
    }
}