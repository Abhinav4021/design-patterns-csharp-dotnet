namespace SOLID.InterfaceSegregation;

// Enterprise all-in-one printer implements multiple targeted interfaces
public class EnterpriseMultiFunctionPrinter : IPrint, IScan, IFax, IDuplexPrint
{
    public void Print(string document)
    {
        Console.WriteLine($"[EnterpriseMFP] Printing document: '{document}'.");
    }

    public void PrintDoubleSided(string document)
    {
        Console.WriteLine($"[EnterpriseMFP] Printing double-sided copy of: '{document}'.");
    }

    public void Scan(string document)
    {
        Console.WriteLine($"[EnterpriseMFP] Scanning and OCR processing for: '{document}'.");
    }

    public void Fax(string document, string phoneNumber)
    {
        Console.WriteLine($"[EnterpriseMFP] Faxing '{document}' to {phoneNumber}...");
    }
}