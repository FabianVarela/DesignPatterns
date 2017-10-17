using Builder.Builder.Abstract;
using Builder.Product.Abstract;

namespace Builder.Director
{
    public class Seller
    {
        protected DocumentationVehicleBuilder builder;

        public Seller(DocumentationVehicleBuilder builder) => this.builder = builder;

        public Documentation Build(string clientName)
        {
            builder.BuildOrderRequest(clientName);
            builder.BuildRegistrationRequest(clientName);

            return builder.Result();
        }
    }
}
