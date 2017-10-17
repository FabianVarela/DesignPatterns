using Prototype.Client.Abstract;
using Prototype.Prototype.Abstract;
using System.Collections.Generic;

namespace Prototype.Client.Class
{
    public class ClientDocumentation : Documentation
    {
        public ClientDocumentation(string information)
        {
            Documents = new List<Document>();

            BlankDocumentation blankDocumentation = BlankDocumentation.Instance();
            IList<Document> blankDocuments = blankDocumentation.Documents;

            foreach (var doc in blankDocuments)
            {
                Document documentCopy = doc.Duplicate();
                documentCopy.Fill(information);

                Documents.Add(documentCopy);
            }
        }

        public void Show()
        {
            foreach (var doc in Documents)
                doc.Show();
        }

        public void Print()
        {
            foreach (var doc in Documents)
                doc.Print();
        }
    }
}
