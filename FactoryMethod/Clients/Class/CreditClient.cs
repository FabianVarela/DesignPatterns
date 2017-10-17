using FactoryMethod.Clients.Abstract;
using FactoryMethod.Orders.Abstract;
using FactoryMethod.Orders.Class;

namespace FactoryMethod.Clients.Class
{
    public class CreditClient : Client
    {
        protected override Order CreateOrder(double importe) => new CreditOrder(importe);
    }
}
