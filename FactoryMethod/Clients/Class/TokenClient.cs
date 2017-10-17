using FactoryMethod.Clients.Abstract;
using FactoryMethod.Orders.Abstract;
using FactoryMethod.Orders.Class;

namespace FactoryMethod.Clients.Class
{
    public class TokenClient : Client
    {
        protected override Order CreateOrder(double import) => new TokenOrder(import);
    }
}
