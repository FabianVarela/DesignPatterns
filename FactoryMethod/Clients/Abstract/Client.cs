using FactoryMethod.Orders.Abstract;
using System.Collections.Generic;

namespace FactoryMethod.Clients.Abstract
{
    public abstract class Client
    {
        protected IList<Order> Orders = new List<Order>();

        protected abstract Order CreateOrder(double import);

        public void NewOrder(double import)
        {
            Order order = CreateOrder(import);

            if (order.Validate())
            {
                order.Pay();
                Orders.Add(order);
            }
        }
    }
}
