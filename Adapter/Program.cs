using Adapter.Adapter;
using Adapter.Interface;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IDocument document1, document2;

            document1 = new HtmlDocument
            {
                Content = "Hello"
            };
            document1.Draw();

            Console.WriteLine();

            document2 = new PdfDocument
            {
                Content = "Hola"
            };
            document2.Draw();

            Console.ReadKey();
        }
    }
}
