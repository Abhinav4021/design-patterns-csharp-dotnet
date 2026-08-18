using SOLID.LiskovSubstitution;

Console.WriteLine("=== Liskov Substitution Principle (LSP) Demo ===\n");

var checking = new CheckingAccount("CHK-1001", 3000.00m);
var savings = new SavingsAccount("SAV-2002", 5000.00m);
var fixedDeposit = new FixedDepositAccount("FD-9009", 25000.00m, DateTime.Now.AddYears(1));

var processor = new PaymentProcessor();

// 1. LSP in Action: Withdraw from substitutable withdrawable accounts
processor.ProcessDebit(checking, 500.00m);
processor.ProcessDebit(savings, 1200.00m);

// 2. LSP in Action: Generate reports across all accounts uniformly
var allAccounts = new List<IAccount> { checking, savings, fixedDeposit };
processor.GenerateReports(allAccounts);