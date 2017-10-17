using FactoryMethod.Orders.Abstract;
using System;

namespace FactoryMethod.Orders.Class
{
    public class BitcoinOrder : Order
    {
        public BitcoinOrder(double import) : base(import) { }

        public override void Pay() => Console.WriteLine($"El pago de pedido a bitcoin de importe: {import} se ha realizado");

        public override bool Validate() => true;
    }
}
