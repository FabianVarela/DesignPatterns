using FactoryMethod.Orders.Abstract;
using System;

namespace FactoryMethod.Orders.Class
{
    public class CreditOrder : Order
    {
        public CreditOrder(double import) : base(import) { }

        public override void Pay() => Console.WriteLine($"El pago de pedido a credito de importe: {import} se ha realizado");

        public override bool Validate() => (import >= 1000.0) && (import <= 5000.0);
    }
}
