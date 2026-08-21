using Creational.AbstractFactory.Products;

namespace Creational.AbstractFactory.Factories;

public sealed class LightThemeFactory : IUIFactory
{
    public IButton CreateButton()
    {
        return new LightButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new LightCheckbox();
    }
}