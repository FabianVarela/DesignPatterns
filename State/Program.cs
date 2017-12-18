using State.Entity;
using State.StateMachine;
using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            order.AddProduct(new Product("Vehiculo 1"));
            order.AddProduct(new Product("Accesorio 2"));
            order.Show();

            order.NextState();
            order.AddProduct(new Product("Accesorio 3"));
            order.Delete();
            order.Show();

            Order order2 = new Order();

            order2.AddProduct(new Product("Vehiculo 11"));
            order2.AddProduct(new Product("Accesorio 21"));
            order2.Show();

            order2.NextState();
            order2.Show();
            order2.NextState();
            order2.Delete();
            order2.Show();

            Console.ReadKey();
        }
    }
}
