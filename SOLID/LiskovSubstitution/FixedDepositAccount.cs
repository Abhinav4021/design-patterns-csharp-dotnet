using SOLID.LiskovSubstitution;

// FixedDepositAccount is locked until maturity.
// Following LSP, it only implements IAccount — it does NOT inherit a Withdraw() method that would throw NotImplementedException!
public class FixedDepositAccount : IAccount
{
    public string AccountNumber { get; }
    public decimal Balance { get; }
    public DateTime MaturityDate { get; }

    public FixedDepositAccount(string accountNumber, decimal principal, DateTime maturityDate)
    {
        AccountNumber = accountNumber;
        Balance = principal;
        MaturityDate = maturityDate;
    }

    public void PrintSummary()
    {
        Console.WriteLine($"Fixed Deposit    ({AccountNumber}) | Principal: {Balance:C} | Maturity: {MaturityDate:yyyy-MM-dd}");
    }
}