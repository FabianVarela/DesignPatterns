using Builder.Product.Abstract;

namespace Builder.Builder.Abstract
{
    public abstract class DocumentationVehicleBuilder
    {
        protected Documentation documentation;

        public abstract void BuildOrderRequest(string clientName);
        public abstract void BuildRegistrationRequest(string claimName);

        public Documentation Result() => documentation;
    }
}
