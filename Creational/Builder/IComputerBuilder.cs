namespace Creational.Builder;

public interface IComputerBuilder
{
    IComputerBuilder SetCPU(string cpu);
    IComputerBuilder SetRAM(int ramInGb);
    IComputerBuilder SetStorage(int storageInGb);
    IComputerBuilder SetGPU(string gpu);
    IComputerBuilder EnableLiquidCooling(bool enable = true);
    IComputerBuilder EnableBluetooth(bool enable = true);
    Computer Build();
}