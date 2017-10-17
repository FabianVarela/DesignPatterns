using FactoryMethod.Orders.Abstract;
using System;

namespace FactoryMethod.Orders.Class
{
    public class TokenOrder : Order
    {
        public TokenOrder(double import) : base(import) { }

        public override void Pay() => Console.WriteLine($"El pago de pedido a bono de importe: {import} se ha realizado");

        public override bool Validate() => (import >= 10000.0) && (import <= 25000.0);
    }
}
