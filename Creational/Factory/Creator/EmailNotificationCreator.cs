using Creational.Factory.Products;

namespace Creational.Factory.Creators;

/// <summary>
/// Concrete Creator.
///
/// Overrides the Factory Method and decides that
/// EmailNotification should be created.
/// </summary>
public sealed class EmailNotificationCreator : NotificationCreator
{
    protected override INotification CreateNotification()
    {
        Console.WriteLine(
            "  → Factory Method: Creating EmailNotification"
        );

        return new EmailNotification();
    }
}