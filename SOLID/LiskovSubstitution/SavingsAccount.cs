using SOLID.LiskovSubstitution;

public class SavingsAccount : IWithdrawableAccount
{
    public string AccountNumber { get; }
    public decimal Balance { get; private set; }
    private const decimal MinimumBalance = 500m;

    public SavingsAccount(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal amount must be positive.");

        if (Balance - amount < MinimumBalance)
            throw new InvalidOperationException($"Cannot withdraw {amount:C}. Minimum balance of {MinimumBalance:C} required.");

        Balance -= amount;
        Console.WriteLine($"[Savings] Withdrew {amount:C}. New Balance: {Balance:C}");
    }

    public void PrintSummary()
    {
        Console.WriteLine($"Savings Account  ({AccountNumber}) | Balance: {Balance:C}");
    }
}