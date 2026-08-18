namespace Creational.Builder;

public class ComputerDirector
{
    private IComputerBuilder _builder;

    public ComputerDirector(IComputerBuilder builder)
    {
        _builder = builder;
    }

    // Allows swapping the builder instance if needed
    public void ChangeBuilder(IComputerBuilder builder)
    {
        _builder = builder;
    }

    public Computer ConstructOfficePC()
    {
        return _builder
            .SetCPU("Intel Core i5-13400")
            .SetRAM(16)
            .SetStorage(512)
            .EnableBluetooth()
            .Build();
    }

    public Computer ConstructGamingPC()
    {
        return _builder
            .SetCPU("AMD Ryzen 9 7950X")
            .SetRAM(64)
            .SetStorage(2048)
            .SetGPU("NVIDIA GeForce RTX 4090")
            .EnableLiquidCooling()
            .EnableBluetooth()
            .Build();
    }

    public Computer ConstructBudgetWorkstation()
    {
        return _builder
            .SetCPU("Intel Core i3-13100")
            .SetRAM(8)
            .SetStorage(256)
            .Build();
    }
}