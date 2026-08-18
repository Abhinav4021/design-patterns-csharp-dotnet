namespace Creational.Builder;

public class Computer
{
    public string CPU { get; }
    public int RAMInGB { get; }
    public int StorageInGB { get; }
    public string? GPU { get; }
    public bool HasLiquidCooling { get; }
    public bool HasBluetooth { get; }

    // Internal constructor ensures creation only via the Builder
    internal Computer(
        string cpu,
        int ramInGb,
        int storageInGb,
        string? gpu,
        bool hasLiquidCooling,
        bool hasBluetooth)
    {
        CPU = cpu;
        RAMInGB = ramInGb;
        StorageInGB = storageInGb;
        GPU = gpu;
        HasLiquidCooling = hasLiquidCooling;
        HasBluetooth = hasBluetooth;
    }

    public override string ToString()
    {
        return $"""
        Specifications:
          - CPU:             {CPU}
          - RAM:             {RAMInGB} GB
          - Storage:         {StorageInGB} GB SSD
          - GPU:             {GPU ?? "Integrated Graphics"}
          - Liquid Cooling:  {(HasLiquidCooling ? "Yes" : "No")}
          - Bluetooth:       {(HasBluetooth ? "Enabled" : "Disabled")}
        """;
    }
}