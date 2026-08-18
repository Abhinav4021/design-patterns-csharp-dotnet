namespace SOLID.DependencyInversion;

// Abstraction for messaging/notifications (Low-level module contract)
public interface INotificationService
{
    void SendNotification(string recipient, string message);
}