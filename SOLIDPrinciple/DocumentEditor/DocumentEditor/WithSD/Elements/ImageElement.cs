namespace DocumentEditor.WithSD.Elements
{
    public class ImageElement : DocumentElement
    {
        private string _imagePath;
        public ImageElement(string imagePath)
        {
            _imagePath = imagePath;
        }
        public override string Render()
        {
            return "[Image: " + _imagePath + "]";
        }
    }
}
