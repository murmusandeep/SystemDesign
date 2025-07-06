using AdapterDP.Adaptee;
using AdapterDP.Interfaces;

namespace AdapterDP
{
    public class XmlDataProviderAdapter : IReports
    {
        private readonly XmlDataProvider _xmlProvider;

        public XmlDataProviderAdapter(XmlDataProvider provider)
        {
            _xmlProvider = provider;
        }

        public string GetJsonData(string data)
        {
            // 1. Get XML from the adaptee
            string xml = _xmlProvider.GetXmlData(data);
            Console.WriteLine(xml);
            // 2. Naively parse out <name> and <id> values
            int startName = xml.IndexOf("<name>") + 6;
            int endName = xml.IndexOf("</name>");
            string name = xml.Substring(startName, endName - startName);

            int startId = xml.IndexOf("<id>") + 4;
            int endId = xml.IndexOf("</id>");
            string id = xml.Substring(startId, endId - startId);

            // 3. Build and return JSON
            return $"{{\"name\":\"{name}\", \"id\":{id}}}";
        }
    }
}
