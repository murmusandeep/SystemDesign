namespace DocumentEditor.WithoutSD
{
    public class DocumentEditorWithoutSD
    {
        private List<string> _documentElements;
        string renderedDocument;

        public DocumentEditorWithoutSD()
        {
            _documentElements = new List<string>();
            renderedDocument = string.Empty;
        }

        public void AddText(string text)
        {
            _documentElements.Add(text);
        }

        public void AddImage(string path)
        {
            _documentElements.Add(path);
        }

        public string RenderDocument()
        {
            if (_documentElements.Any())
            {
                string result = "";

                foreach (var element in _documentElements)
                {
                    if (element.Length > 4 &&
                        (element.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                         element.EndsWith(".png", StringComparison.OrdinalIgnoreCase)))
                    {
                        result += "[Image: " + element + "]\n";
                    }
                    else
                    {
                        result += element + "\n";
                    }
                }

                renderedDocument = result;
            }

            return renderedDocument;
        }

        public void SaveToFile()
        {
            try
            {
                string filePath = "documentwithoutds.txt";
                File.WriteAllText(filePath, RenderDocument());
                Console.WriteLine("Document saved to document.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
