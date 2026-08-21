namespace Creational.AbstractFactory.Products;

public sealed class LightButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering Light Button");
    }
}
