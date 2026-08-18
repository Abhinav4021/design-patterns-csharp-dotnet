namespace Behavioral.ChainOfResponsibility;

public abstract class BaseExpenseHandler : IExpenseHandler
{
    private IExpenseHandler? _nextHandler;

    public IExpenseHandler SetNext(IExpenseHandler nextHandler)
    {
        _nextHandler = nextHandler;
        return nextHandler; // Returning nextHandler enables fluent chaining: a.SetNext(b).SetNext(c)
    }

    public virtual void Process(ExpenseReport request)
    {
        if (_nextHandler != null)
        {
            _nextHandler.Process(request);
        }
        else
        {
            Console.WriteLine($"[Rejected] Expense #{request.Id} (${request.Amount:N2} for '{request.Purpose}') exceeded all approval thresholds.");
        }
    }
}