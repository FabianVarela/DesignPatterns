using ChainOfResponsibility.ConcreteManager;
using ChainOfResponsibility.Manager;
using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicObject vehicle1 = new Vehicle("Auto++ KT500 vehiculo de ocasion en buen estado");
            Console.WriteLine(vehicle1.ReturnDescription());

            BasicObject model1 = new Model("KT400", "vehiculo amplio y confortable");
            BasicObject vehicle2 = new Vehicle(null) { Next = model1 };
            Console.WriteLine(vehicle2.ReturnDescription());

            BasicObject mark1 = new Mark("Auto++", "Marca del automovil", "de gran calidad");
            BasicObject model2 = new Model("KT700", null) { Next = mark1 };
            BasicObject vehicle3 = new Vehicle(null) { Next = model2 };
            Console.WriteLine(vehicle3.ReturnDescription());

            BasicObject vehicle4 = new Vehicle(null);
            Console.WriteLine(vehicle4.ReturnDescription());

            Console.ReadKey();
        }
    }
}
