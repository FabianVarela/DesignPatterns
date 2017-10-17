using Adapter.Adapted.Component;
using Adapter.Interface;

namespace Adapter.Adapter
{
    public class PdfDocument : IDocument
    {
        protected PdfComponent pdfTool = new PdfComponent();

        public string Content { set => pdfTool.PdfKeepContent(value); }

        public void Draw()
        {
            pdfTool.PdfPreparePreview();
            pdfTool.PdfRefresh();
            pdfTool.PdfEndPreview();
        }

        public void Print() => pdfTool.PdfSendToPrint();
    }
}
