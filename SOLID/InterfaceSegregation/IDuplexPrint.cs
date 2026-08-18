namespace SOLID.InterfaceSegregation;

public interface IDuplexPrint : IPrint
{
    void PrintDoubleSided(string document);
}