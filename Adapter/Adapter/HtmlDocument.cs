using Adapter.Interface;
using System;

namespace Adapter.Adapter
{
    public class HtmlDocument : IDocument
    {
        protected string _content;

        public string Content
        {
            protected get => _content;
            set => _content = value;
        }

        public void Draw() => Console.WriteLine($"Dibuja el documento HTML: {Content}");

        public void Print() => Console.WriteLine($"Imprime el documento HTML: {Content}");
    }
}
