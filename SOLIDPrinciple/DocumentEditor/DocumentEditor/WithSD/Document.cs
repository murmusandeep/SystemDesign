using DocumentEditor.WithSD.Elements;

namespace DocumentEditor.WithSD
{
    public class Document
    {
        private List<DocumentElement> _elements;

        public Document()
        {
            _elements = new List<DocumentElement>();
        }

        public void AddElement(DocumentElement element)
        {
            _elements.Add(element);
        }

        public string Render()
        {
            string result = "";
            foreach (DocumentElement element in _elements)
            {
                result += element.Render();
            }
            return result;
        }
    }
}
