namespace SOLID.InterfaceSegregation;

// Basic printer only implements printing
public class BasicPrinter : IPrint
{
    public void Print(string document)
    {
        Console.WriteLine($"[BasicPrinter] Printing document: '{document}' in black and white.");
    }
}