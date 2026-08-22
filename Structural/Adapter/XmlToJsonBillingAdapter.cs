using System.Text.Json;
using System.Xml.Linq;

namespace Structural.Adapter;

// Object Adapter: Implements modern Target interface while wrapping legacy Adaptee
public class XmlToJsonBillingAdapter : IJsonAnalyticsTarget
{
    private readonly LegacyXmlBillingService _legacyService;

    public XmlToJsonBillingAdapter(LegacyXmlBillingService legacyService)
    {
        _legacyService = legacyService ?? throw new ArgumentNullException(nameof(legacyService));
    }

    public void ProcessTransactions(string jsonPayload)
    {
        Console.WriteLine("[Adapter] Converting incoming JSON payload into legacy XML format...");

        var records = JsonSerializer.Deserialize<List<TransactionRecord>>(jsonPayload, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        }) ?? [];

        // Transform JSON object graph into XML document structure
        var xmlElement = new XElement("Transactions",
            records.Select(r =>
                new XElement("Transaction",
                    new XAttribute("id", r.Id),
                    new XElement("Amount", r.Amount),
                    new XElement("Currency", r.Currency)
                )
            )
        );

        string xmlResult = xmlElement.ToString();

        // Forward adapted payload to the legacy service
        _legacyService.ProcessLegacyXml(xmlResult);
    }
}