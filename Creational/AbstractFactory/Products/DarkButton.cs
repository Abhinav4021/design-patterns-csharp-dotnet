namespace Creational.AbstractFactory.Products;

public sealed class DarkButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering Dark Button");
    }
}