namespace Creational.Factory.Products;

/// <summary>
/// Product interface.
///
/// Defines the common contract that all concrete
/// notification products must implement.
/// </summary>
public interface INotification
{
    void Send(string message);
}