using DocumentEditor.WithSD.Elements;
using DocumentEditor.WithSD.Persistences;

namespace DocumentEditor.WithSD
{
    public class DocumentEditorWithDS
    {
        private Document _document;
        private Persistence _persistence;
        private string _renderedDocument;


        public DocumentEditorWithDS(Document document, Persistence persistence)
        {
            _document = document;
            _persistence = persistence;
            _renderedDocument = string.Empty;
        }

        public void AddText(string text)
        {
            _document.AddElement(new TextElement(text));
        }

        public void AddImage(string imagePath)
        {
            _document.AddElement(new ImageElement(imagePath));
        }

        public void AddNewLine()
        {
            _document.AddElement(new NewlineElement());
        }

        public void AddTabSpace()
        {
            _document.AddElement(new TabspaceElement());
        }

        public string RenderDocument()
        {
            if (string.IsNullOrEmpty(_renderedDocument))
            {
                _renderedDocument = _document.Render();
            }

            return _renderedDocument;
        }

        public void Save()
        {
            _persistence.Save(RenderDocument());
        }
    }
}
