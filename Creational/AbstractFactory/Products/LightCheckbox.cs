namespace Creational.AbstractFactory.Products;

public sealed class LightCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering Light Checkbox");
    }
}