using FactoryMethod.Clients.Abstract;
using FactoryMethod.Orders.Abstract;
using FactoryMethod.Orders.Class;

namespace FactoryMethod.Clients.Class
{
    public class CashClient : Client
    {
        protected override Order CreateOrder(double importe) => new CashOrder(importe);
    }
}
