using Builder.Product.Abstract;
using System;

namespace Builder.Product.Class
{
    public class HtmlDocumentation : Documentation
    {
        public override void AddDocument(string document)
        {
            if (document.StartsWith("<HTML>"))
                content.Add(document);
        }

        public override void Print()
        {
            Console.WriteLine("Documentación HTML");

            foreach (var s in content)
                Console.WriteLine(s);
        }
    }
}
