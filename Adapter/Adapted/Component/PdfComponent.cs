using System;

namespace Adapter.Adapted.Component
{
    public class PdfComponent
    {
        protected string _content;

        public void PdfKeepContent(string content) => _content = content;

        public void PdfPreparePreview() => Console.WriteLine("Visualiza PDF: Comienzo");

        public void PdfRefresh() => Console.WriteLine($"Visualiza contenido PDF: {_content}");

        public void PdfEndPreview() => Console.WriteLine("Visualiza PDF: Fin");

        public void PdfSendToPrint() => Console.WriteLine($"Impresion PDF: {_content}");
    }
}
