using Behavioral.ChainOfResponsibility;

public class ManagerHandler : BaseExpenseHandler
{
    private const decimal Limit = 5000m;

    public override void Process(ExpenseReport request)
    {
        if (request.Amount <= Limit)
        {
            Console.WriteLine($"[Approved by Manager] Expense #{request.Id} (${request.Amount:N2} for '{request.Purpose}')");
        }
        else
        {
            Console.WriteLine($"[Escalated by Manager] Expense #{request.Id} exceeds ${Limit:N2} threshold...");
            base.Process(request);
        }
    }
}