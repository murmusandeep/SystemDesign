using AdapterDP.Interfaces;

namespace AdapterDP
{
    public class Client
    {
        public void GetReport(IReports report, string rawData)
        {
            Console.WriteLine("Processed JSON: " + report.GetJsonData(rawData));
        }
    }
}
