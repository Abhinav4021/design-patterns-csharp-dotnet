namespace SOLID.InterfaceSegregation;

// Dedicated scanner only implements scanning
public class PhotoScanner : IScan
{
    public void Scan(string document)
    {
        Console.WriteLine($"[PhotoScanner] High-resolution scan completed for: '{document}'.");
    }
}