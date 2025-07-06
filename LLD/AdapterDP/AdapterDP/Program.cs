using AdapterDP.Adaptee;
using AdapterDP.Interfaces;

namespace AdapterDP
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 1. Create the adaptee
            XmlDataProvider xmlProv = new XmlDataProvider();

            // 2. Create the adapter
            IReports adapter = new XmlDataProviderAdapter(xmlProv);

            // 3. Raw input data
            string rawData = "Alice:42";

            // 4. Use the client
            Client client = new Client();
            client.GetReport(adapter, rawData);
            // Output: Processed JSON: {"name":"Alice", "id":42}
        }
    }
}
