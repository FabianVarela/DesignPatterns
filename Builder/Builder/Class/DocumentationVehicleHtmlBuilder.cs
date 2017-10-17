using Builder.Builder.Abstract;
using Builder.Product.Class;

namespace Builder.Builder.Class
{
    public class DocumentationVehicleHtmlBuilder : DocumentationVehicleBuilder
    {
        public DocumentationVehicleHtmlBuilder() => documentation = new HtmlDocumentation();

        public override void BuildOrderRequest(string clientName)
        {
            string document = $"<HTML>Solicitud de pedido del cliente {clientName} </HTML>";
            documentation.AddDocument(document);
        }

        public override void BuildRegistrationRequest(string claimName)
        {
            string document = $"<HTML>Solicitud de matriculación del solicitante {claimName} </HTML>";
            documentation.AddDocument(document);
        }
    }
}
