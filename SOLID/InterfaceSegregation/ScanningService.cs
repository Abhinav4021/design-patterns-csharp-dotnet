namespace SOLID.InterfaceSegregation;

public class ScanningService
{
    private readonly IScan _scanner;

    public ScanningService(IScan scanner)
    {
        _scanner = scanner;
    }

    public void ExecuteScanJob(string document)
    {
        _scanner.Scan(document);
    }
}