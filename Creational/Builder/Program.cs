using Creational.Builder;

// Console.WriteLine("=== Builder Pattern (Fluent API) Demo ===\n");

// // 1. Build a basic office workstation
// Computer officePC = new ComputerBuilder()
//     .SetCPU("Intel Core i5-13400")
//     .SetRAM(16)
//     .SetStorage(512)
//     .EnableBluetooth()
//     .Build();

// Console.WriteLine("[Configuration 1: Office Desktop]");
// Console.WriteLine(officePC);
// Console.WriteLine(new string('-', 45));

// // 2. Build a high-end gaming PC with method chaining
// Computer gamingPC = new ComputerBuilder()
//     .SetCPU("AMD Ryzen 9 7950X")
//     .SetRAM(64)
//     .SetStorage(2048)
//     .SetGPU("NVIDIA GeForce RTX 4090")
//     .EnableLiquidCooling()
//     .EnableBluetooth()
//     .Build();

// Console.WriteLine("\n[Configuration 2: High-End Gaming Rig]");
// Console.WriteLine(gamingPC);

Console.WriteLine("=== Builder Pattern with Director Demo ===\n");

// 1. Initialize builder and director
var builder = new ComputerBuilder();
var director = new ComputerDirector(builder);

// 2. Build pre-configured products using Director recipes
Computer officePC = director.ConstructOfficePC();
Console.WriteLine("[Director Preset: Office Desktop]");
Console.WriteLine(officePC);
Console.WriteLine(new string('-', 45));

Computer gamingPC = director.ConstructGamingPC();
Console.WriteLine("\n[Director Preset: High-End Gaming PC]");
Console.WriteLine(gamingPC);
Console.WriteLine(new string('-', 45));

// 3. Client can still use the builder directly for custom configurations
Computer customHomeServer = new ComputerBuilder()
    .SetCPU("AMD EPYC 4124P")
    .SetRAM(128)
    .SetStorage(8192)
    .Build();

Console.WriteLine("\n[Custom Client Build: Home Server]");
Console.WriteLine(customHomeServer);