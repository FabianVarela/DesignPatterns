using FactoryMethod.Orders.Abstract;
using System;

namespace FactoryMethod.Orders.Class
{
    public class CashOrder : Order
    {
        public CashOrder(double import) : base(import) { }

        public override void Pay() => Console.WriteLine($"El pago del pedido por importe de: {import} se ha realizado");

        public override bool Validate() => true;
    }
}
