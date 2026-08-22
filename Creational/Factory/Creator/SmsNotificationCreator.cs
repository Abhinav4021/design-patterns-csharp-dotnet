using Creational.Factory.Products;

namespace Creational.Factory.Creators;

/// <summary>
/// Concrete Creator.
///
/// Overrides the Factory Method and decides that
/// SmsNotification should be created.
/// </summary>
public sealed class SmsNotificationCreator : NotificationCreator
{
    protected override INotification CreateNotification()
    {
        Console.WriteLine(
            "  → Factory Method: Creating SmsNotification"
        );

        return new SmsNotification();
    }
}