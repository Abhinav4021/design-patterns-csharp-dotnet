namespace SOLID.LiskovSubstitution;

// Base abstraction: All accounts allow checking the balance and generating account statements
public interface IAccount
{
    string AccountNumber { get; }
    decimal Balance { get; }
    void PrintSummary();
}