using SOLID.InterfaceSegregation;

Console.WriteLine("=== Interface Segregation Principle (ISP) Demo ===\n");

// 1. Basic Printer used strictly for simple print jobs
var basicPrinter = new BasicPrinter();
var simplePrintService = new PrintService(basicPrinter);
simplePrintService.ExecutePrintJob("Quarterly_Report.pdf");

// 2. Dedicated Scanner used for scan tasks
var photoScanner = new PhotoScanner();
var scanningService = new ScanningService(photoScanner);
scanningService.ExecuteScanJob("ID_Proof_Card.png");

Console.WriteLine(new string('-', 55));

// 3. Multi-Function Device substituted seamlessly where print or scan is needed
var enterpriseMFP = new EnterpriseMultiFunctionPrinter();

var enterprisePrintService = new PrintService(enterpriseMFP);
var enterpriseScanService = new ScanningService(enterpriseMFP);

enterprisePrintService.ExecutePrintJob("Employee_Handbook.pdf");
enterpriseScanService.ExecuteScanJob("Signed_Contract.pdf");

// Use direct specialized capabilities
enterpriseMFP.PrintDoubleSided("Annual_Budget.pdf");
enterpriseMFP.Fax("Invoice_1001.pdf", "+91-80-12345678");