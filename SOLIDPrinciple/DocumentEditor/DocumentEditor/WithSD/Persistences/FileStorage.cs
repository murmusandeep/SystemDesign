namespace DocumentEditor.WithSD.Persistences
{
    public class FileStorage : Persistence
    {
        public override void Save(string data)
        {
            try
            {
                string filePath = "documentwithds.txt";
                File.WriteAllText(filePath, data);
                Console.WriteLine("Document saved to document.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
