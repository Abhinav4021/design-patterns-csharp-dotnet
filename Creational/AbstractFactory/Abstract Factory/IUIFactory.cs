using Creational.AbstractFactory.Products;

namespace Creational.AbstractFactory.Factories;

public interface IUIFactory
{
    IButton CreateButton();

    ICheckbox CreateCheckbox();
}