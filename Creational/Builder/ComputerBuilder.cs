namespace Creational.Builder;

public class ComputerBuilder : IComputerBuilder
{
    private string _cpu = "Default Dual-Core";
    private int _ramInGb = 8;
    private int _storageInGb = 256;
    private string? _gpu;
    private bool _hasLiquidCooling;
    private bool _hasBluetooth;

    public IComputerBuilder SetCPU(string cpu)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(cpu);
        _cpu = cpu;
        return this;
    }

    public IComputerBuilder SetRAM(int ramInGb)
    {
        if (ramInGb < 4)
            throw new ArgumentException("RAM must be at least 4 GB.", nameof(ramInGb));
        _ramInGb = ramInGb;
        return this;
    }

    public IComputerBuilder SetStorage(int storageInGb)
    {
        if (storageInGb < 128)
            throw new ArgumentException("Storage must be at least 128 GB.", nameof(storageInGb));
        _storageInGb = storageInGb;
        return this;
    }

    public IComputerBuilder SetGPU(string gpu)
    {
        _gpu = gpu;
        return this;
    }

    public IComputerBuilder EnableLiquidCooling(bool enable = true)
    {
        _hasLiquidCooling = enable;
        return this;
    }

    public IComputerBuilder EnableBluetooth(bool enable = true)
    {
        _hasBluetooth = enable;
        return this;
    }

    public Computer Build()
    {
        // Validation across properties prior to building
        if (_hasLiquidCooling && string.IsNullOrWhiteSpace(_gpu))
        {
            Console.WriteLine("[Warning] Liquid cooling configured without dedicated GPU.");
        }

        return new Computer(
            _cpu,
            _ramInGb,
            _storageInGb,
            _gpu,
            _hasLiquidCooling,
            _hasBluetooth
        );
    }
}