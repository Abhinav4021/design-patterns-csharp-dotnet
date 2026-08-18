namespace SOLID.LiskovSubstitution;

// Sub-interface: Only accounts that support active debiting/withdrawals implement this
public interface IWithdrawableAccount : IAccount
{
    void Withdraw(decimal amount);
}