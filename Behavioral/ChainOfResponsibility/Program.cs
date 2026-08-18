using Behavioral.ChainOfResponsibility;

Console.WriteLine("=== Chain of Responsibility Pattern Demo ===\n");

// 1. Build the processing chain
var lead = new TeamLeadHandler();
var manager = new ManagerHandler();
var director = new DirectorHandler();
var vp = new VicePresidentHandler();

// Fluent chaining: Team Lead -> Manager -> Director -> VP
lead.SetNext(manager)
    .SetNext(director)
    .SetNext(vp);

// 2. Test requests across different budget thresholds
var requests = new List<ExpenseReport>
{
    new(101, "Team Lunch", 180.00m),
    new(102, "Ergonomic Chairs", 2_400.00m),
    new(103, "Annual Cloud Hosting Services", 14_500.00m),
    new(104, "Office Floor Renovation", 35_000.00m),
    new(105, "Company Acquisition Feasibility", 120_000.00m)
};

foreach (var expense in requests)
{
    Console.WriteLine($"\n--- Submitting Request #{expense.Id}: {expense.Purpose} (${expense.Amount:N2}) ---");
    lead.Process(expense);
}