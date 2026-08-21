namespace Creational.AbstractFactory.Products;

public sealed class DarkCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering Dark Checkbox");
    }
}