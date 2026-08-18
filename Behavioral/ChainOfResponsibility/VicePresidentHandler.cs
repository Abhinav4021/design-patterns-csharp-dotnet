using Behavioral.ChainOfResponsibility;

public class VicePresidentHandler : BaseExpenseHandler
{
    private const decimal Limit = 50000m;

    public override void Process(ExpenseReport request)
    {
        if (request.Amount <= Limit)
        {
            Console.WriteLine($"[Approved by VP] Expense #{request.Id} (${request.Amount:N2} for '{request.Purpose}')");
        }
        else
        {
            Console.WriteLine($"[Escalated by VP] Expense #{request.Id} exceeds ${Limit:N2} threshold...");
            base.Process(request);
        }
    }
}