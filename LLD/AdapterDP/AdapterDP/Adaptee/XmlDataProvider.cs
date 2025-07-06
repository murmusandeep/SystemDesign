namespace AdapterDP.Adaptee
{
    public class XmlDataProvider
    {
        // Expects data in "name:id" format (e.g. "Alice:42")
        public string GetXmlData(string data)
        {
            int sep = data.IndexOf(':');
            string name = data.Substring(0, sep);
            string id = data.Substring(sep + 1);

            return "<user>" +
                        "<name>" + name + "</name>" +
                        "<id>" + id + "</id>" +
                   "</user>";
        }
    }
}
