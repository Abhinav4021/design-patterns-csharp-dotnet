using System.Xml.Linq;

namespace Structural.Adapter;

// Incompatible legacy service working exclusively with XML
public class LegacyXmlBillingService
{
    public void ProcessLegacyXml(string xmlPayload)
    {
        Console.WriteLine("[LegacyXmlBillingService] Received raw XML stream:");
        Console.WriteLine(xmlPayload);

        var doc = XDocument.Parse(xmlPayload);
        var transactions = doc.Descendants("Transaction");

        Console.WriteLine("\n[LegacyXmlBillingService] Parsed XML records:");
        foreach (var txn in transactions)
        {
            var id = txn.Attribute("id")?.Value;
            var amount = txn.Element("Amount")?.Value;
            var currency = txn.Element("Currency")?.Value;
            Console.WriteLine($"  * ID: {id,-10} | Amount: {amount} {currency}");
        }
    }
}