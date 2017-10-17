using FactoryMethod.Orders.Abstract;
using System;

namespace FactoryMethod.Orders.Class
{
    public class ChequeOrder : Order
    {
        public ChequeOrder(double import) : base(import) { }

        public override void Pay() => Console.WriteLine($"El pago de pedido a cheque de importe: {import} se ha realizado");

        public override bool Validate() => (import >= 5000.0) && (import <= 20000.0);
    }
}
