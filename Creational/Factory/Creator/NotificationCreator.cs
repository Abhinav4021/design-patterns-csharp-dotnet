using Creational.Factory.Products;

namespace Creational.Factory.Creators;

/// <summary>
/// Creator.
///
/// Declares the Factory Method responsible for creating
/// notification products.
///
/// The creator also contains common business logic that
/// works with the abstract product.
/// </summary>
public abstract class NotificationCreator
{
    /// <summary>
    /// Factory Method.
    ///
    /// Concrete creator classes override this method
    /// to decide which notification product to create.
    /// </summary>
    protected abstract INotification CreateNotification();

    /// <summary>
    /// Common operation performed by the Creator.
    ///
    /// Notice that this method does not know whether
    /// an EmailNotification or SmsNotification will be created.
    /// It only works with the INotification abstraction.
    /// </summary>
    public void SendNotification(string message)
    {
        Console.WriteLine(
            $"[{GetType().Name}] Creating notification..."
        );

        // The actual product creation is delegated
        // to the Factory Method.
        INotification notification = CreateNotification();

        Console.WriteLine(
            $"[{GetType().Name}] Sending notification..."
        );

        // Work with the product through its abstraction.
        notification.Send(message);
    }
}