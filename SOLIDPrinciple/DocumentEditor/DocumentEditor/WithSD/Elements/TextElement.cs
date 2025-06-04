namespace DocumentEditor.WithSD.Elements
{
    public class TextElement : DocumentElement
    {
        private string _text;
        public TextElement(string text)
        {
            _text = text;
        }
        public override string Render()
        {
            return _text;
        }
    }
}
