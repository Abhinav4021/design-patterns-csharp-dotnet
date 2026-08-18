using SOLID.InterfaceSegregation;

public class PrintService
{
    private readonly IPrint _printer;

    public PrintService(IPrint printer)
    {
        _printer = printer;
    }

    public void ExecutePrintJob(string document)
    {
        _printer.Print(document);
    }
}