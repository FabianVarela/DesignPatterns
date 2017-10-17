using Prototype.Client.Abstract;
using Prototype.Prototype.Abstract;
using System.Collections.Generic;

namespace Prototype.Client.Class
{
    public class BlankDocumentation:Documentation
    {
        private static BlankDocumentation _instance = null;

        private BlankDocumentation() => Documents = new List<Document>();

        public static BlankDocumentation Instance()
        {
            if (_instance == null)
                _instance = new BlankDocumentation();

            return _instance;
        }

        public void Include(Document document) => Documents.Add(document);

        public void Exclude(Document document) => Documents.Remove(document);
    }
}
