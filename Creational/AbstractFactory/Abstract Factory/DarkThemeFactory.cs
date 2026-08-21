using Creational.AbstractFactory.Products;

namespace Creational.AbstractFactory.Factories;

public sealed class DarkThemeFactory : IUIFactory
{
    public IButton CreateButton()
    {
        return new DarkButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new DarkCheckbox();
    }
}