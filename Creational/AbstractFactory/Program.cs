using Creational.AbstractFactory.Factories;
using Creational.AbstractFactory.Products;

Console.WriteLine("========================================");
Console.WriteLine("       ABSTRACT FACTORY PATTERN");
Console.WriteLine("========================================");


// --------------------------------------------------
// LIGHT THEME PRODUCT FAMILY
// --------------------------------------------------

Console.WriteLine();
Console.WriteLine("========================================");
Console.WriteLine("       LIGHT THEME FACTORY");
Console.WriteLine("========================================");

// The client depends on the Abstract Factory interface,
// not directly on LightThemeFactory.
IUIFactory factory = new LightThemeFactory();

Console.WriteLine();
Console.WriteLine("Creating Light Theme products...");

// The factory creates a family of related products.
IButton lightButton = factory.CreateButton();
ICheckbox lightCheckbox = factory.CreateCheckbox();

Console.WriteLine();
Console.WriteLine("Rendering Light Theme products:");

lightButton.Render();
lightCheckbox.Render();


// --------------------------------------------------
// DARK THEME PRODUCT FAMILY
// --------------------------------------------------

Console.WriteLine();
Console.WriteLine("========================================");
Console.WriteLine("        DARK THEME FACTORY");
Console.WriteLine("========================================");

// We can switch the entire product family
// simply by changing the concrete factory.
//
// The client code still works with IUIFactory,
// IButton and ICheckbox.
factory = new DarkThemeFactory();

Console.WriteLine();
Console.WriteLine("Creating Dark Theme products...");

// The DarkThemeFactory creates products
// belonging to the Dark Theme family.
IButton darkButton = factory.CreateButton();
ICheckbox darkCheckbox = factory.CreateCheckbox();

Console.WriteLine();
Console.WriteLine("Rendering Dark Theme products:");

darkButton.Render();
darkCheckbox.Render();


// --------------------------------------------------
// END
// --------------------------------------------------

Console.WriteLine();
Console.WriteLine("========================================");
Console.WriteLine("       ABSTRACT FACTORY COMPLETE");
Console.WriteLine("========================================");