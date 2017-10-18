using Flyweight.Client;
using Flyweight.FlyweightFactory;
using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            OptionFactory factory = new OptionFactory();
            RequestVehicle vehicle = new RequestVehicle();

            vehicle.AddOptions("airbag", 80, factory);
            vehicle.AddOptions("direccion asistida", 90, factory);
            vehicle.AddOptions("elevalunas electricos", 85, factory);
            vehicle.ShowOptions();

            Console.ReadKey();
        }
    }
}
