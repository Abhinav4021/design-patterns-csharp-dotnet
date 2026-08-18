namespace SOLID.LiskovSubstitution;

public class CheckingAccount : IWithdrawableAccount
{
    public string AccountNumber { get; }
    public decimal Balance { get; private set; }

    public CheckingAccount(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal amount must be positive.");

        if (amount > Balance)
            throw new InvalidOperationException($"Insufficient funds in Checking Account {AccountNumber}.");

        Balance -= amount;
        Console.WriteLine($"[Checking] Withdrew {amount:C}. New Balance: {Balance:C}");
    }

    public void PrintSummary()
    {
        Console.WriteLine($"Checking Account ({AccountNumber}) | Balance: {Balance:C}");
    }
}