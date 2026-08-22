namespace Structural.Adapter;

public record TransactionRecord(string Id, decimal Amount, string Currency);

// Target interface expected by modern client systems
public interface IJsonAnalyticsTarget
{
    void ProcessTransactions(string jsonPayload);
}