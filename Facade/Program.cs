using Facade.Service;
using System;
using System.Collections.Generic;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarWebService carWebService = new CarWebService();

            Console.WriteLine(carWebService.Document(0));
            Console.WriteLine(carWebService.Document(1));

            IList<string> results = carWebService.SearchVehicles(6000, 1000);

            if (results.Count > 0)
            {
                Console.WriteLine("Vehiculo(s) cuyo precio esta comprendido entre 5000 y 7000");

                foreach (string result in results)
                    Console.WriteLine($"   {result}");
            }

            Console.ReadKey();
        }
    }
}
