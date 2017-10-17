using Builder.Builder.Abstract;
using Builder.Product.Class;

namespace Builder.Builder.Class
{
    public class DocumentationVehiclePdfBuilder : DocumentationVehicleBuilder
    {
        public DocumentationVehiclePdfBuilder() => documentation = new PdfDocumentation();

        public override void BuildOrderRequest(string clientName)
        {
            string document = $"<PDF>Solicitud de pedido del cliente {clientName} </PDF>";
            documentation.AddDocument(document);
        }

        public override void BuildRegistrationRequest(string claimName)
        {
            string document = $"<PDF>Solicitud de matriculación del solicitante {claimName} </PDF>";
            documentation.AddDocument(document);
        }
    }
}
