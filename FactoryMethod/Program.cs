using FactoryMethod.Clients.Abstract;
using FactoryMethod.Clients.Class;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cliente;

            cliente = new CashClient();
            cliente.NewOrder(2000.0);
            cliente.NewOrder(10000.0);

            cliente = new CreditClient();
            cliente.NewOrder(2000.0);
            cliente.NewOrder(10000.0);

            cliente = new ChequeClient();
            cliente.NewOrder(4500.0);
            cliente.NewOrder(18000.0);

            cliente = new BitcoinClient();
            cliente.NewOrder(2.0);
            cliente.NewOrder(7.0);

            cliente = new TokenClient();
            cliente.NewOrder(23000.0);
            cliente.NewOrder(9000.0);

            Console.ReadKey();
        }
    }
}
