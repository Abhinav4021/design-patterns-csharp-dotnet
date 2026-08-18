using Behavioral.ChainOfResponsibility;

public class DirectorHandler : BaseExpenseHandler
{
    private const decimal Limit = 20000m;

    public override void Process(ExpenseReport request)
    {
        if (request.Amount <= Limit)
        {
            Console.WriteLine($"[Approved by Director] Expense #{request.Id} (${request.Amount:N2} for '{request.Purpose}')");
        }
        else
        {
            Console.WriteLine($"[Escalated by Director] Expense #{request.Id} exceeds ${Limit:N2} threshold...");
            base.Process(request);
        }
    }
}