namespace Behavioral.ChainOfResponsibility;

public interface IExpenseHandler
{
    IExpenseHandler SetNext(IExpenseHandler nextHandler);
    void Process(ExpenseReport request);
}