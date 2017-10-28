using Iterator.Collection.Class;
using Iterator.Element.Class;
using Iterator.Iterator.Class;
using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleCatalog catalog = new VehicleCatalog();

            Console.WriteLine("Escribe una palabra:");
            string keyWord = Console.ReadLine();

            IteratorVehicle iterator = catalog.Search(keyWord);

            Vehicle vehicle;

            iterator.Start();
            vehicle = iterator.Item();

            if (vehicle != null)
            {
                while (vehicle != null)
                {
                    vehicle.Preview();
                    iterator.Next();
                    vehicle = iterator.Item();
                }
            }
            else
                Console.WriteLine("No se encontraron elementos.");

            Console.ReadKey();
        }
    }
}
