namespace SOLID.LiskovSubstitution;

public class PaymentProcessor
{
    // Any IWithdrawableAccount can be substituted here without runtime errors
    public void ProcessDebit(IWithdrawableAccount account, decimal amount)
    {
        Console.WriteLine($"Initiating transaction of {amount:C} for Account: {account.AccountNumber}...");
        account.Withdraw(amount);
    }

    // Any IAccount can be substituted here for reporting
    public void GenerateReports(IEnumerable<IAccount> accounts)
    {
        Console.WriteLine("\n=== Account Portfolios ===");
        foreach (var account in accounts)
        {
            account.PrintSummary();
        }
        Console.WriteLine(new string('-', 60));
    }
}