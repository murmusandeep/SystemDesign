using DocumentEditor.WithoutSD;
using DocumentEditor.WithSD;
using DocumentEditor.WithSD.Persistences;

namespace DocumentEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DocumentEditor Without System Design
            DocumentEditorWithoutSD documentEditorWithoutSD = new DocumentEditorWithoutSD();
            documentEditorWithoutSD.AddText("Hello World");
            documentEditorWithoutSD.AddImage("Picture.jpg");
            documentEditorWithoutSD.AddText("This is document editor");
            Console.WriteLine(documentEditorWithoutSD.RenderDocument());
            documentEditorWithoutSD.SaveToFile();
            #endregion

            #region DocumentEditor With System Design
            Document document = new Document();
            Persistence persistence = new FileStorage();
            DocumentEditorWithDS documentEditorWithDS = new DocumentEditorWithDS(document, persistence);
            documentEditorWithDS.AddText("Hello Sandeep");
            documentEditorWithDS.AddNewLine();
            documentEditorWithDS.AddText("I am following System Design");
            documentEditorWithDS.AddNewLine();
            documentEditorWithDS.AddTabSpace();
            documentEditorWithDS.AddText("Adding new Text after adding tab space");
            documentEditorWithDS.AddNewLine();
            documentEditorWithDS.AddImage("Picture.jpg");
            Console.WriteLine(documentEditorWithDS.RenderDocument());
            documentEditorWithDS.Save();
            #endregion
        }
    }
}
