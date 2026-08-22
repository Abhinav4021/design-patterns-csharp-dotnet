using Structural.Adapter;

Console.WriteLine("=== Adapter Pattern Demo ===\n");

// Modern JSON data emitted by the current frontend/API gateway
string jsonPayload = """
[
  { "id": "TXN-8801", "amount": 250.00, "currency": "USD" },
  { "id": "TXN-8802", "amount": 1499.50, "currency": "EUR" },
  { "id": "TXN-8803", "amount": 89.90, "currency": "GBP" }
]
""";

Console.WriteLine(">> Modern Client sending JSON to Analytics Target:");
Console.WriteLine(jsonPayload);
Console.WriteLine(new string('-', 60));

// Instantiate legacy service and wrap it with the adapter
var legacyService = new LegacyXmlBillingService();
IJsonAnalyticsTarget adapter = new XmlToJsonBillingAdapter(legacyService);

// Client interacts strictly with IJsonAnalyticsTarget
adapter.ProcessTransactions(jsonPayload);