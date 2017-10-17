using Builder.Product.Abstract;
using System;

namespace Builder.Product.Class
{
    public class PdfDocumentation : Documentation
    {
        public override void AddDocument(string document)
        {
            if (document.StartsWith("<PDF>"))
                content.Add(document);
        }

        public override void Print()
        {
            Console.WriteLine("Documentacion PDF");

            foreach (var s in content)
                Console.WriteLine(s);
        }
    }
}
