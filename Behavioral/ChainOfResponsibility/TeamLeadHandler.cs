namespace Behavioral.ChainOfResponsibility;

public class TeamLeadHandler : BaseExpenseHandler
{
    private const decimal Limit = 500m;

    public override void Process(ExpenseReport request)
    {
        if (request.Amount <= Limit)
        {
            Console.WriteLine($"[Approved by Team Lead] Expense #{request.Id} (${request.Amount:N2} for '{request.Purpose}')");
        }
        else
        {
            Console.WriteLine($"[Escalated by Team Lead] Expense #{request.Id} exceeds ${Limit:N2} threshold...");
            base.Process(request);
        }
    }
}