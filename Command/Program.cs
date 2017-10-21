using Command.Applicant;
using Command.Receiver;
using Command.Request.Class;
using Command.Request.Interface;
using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle("A01", 1, 1000.0);
            Vehicle vehicle2 = new Vehicle("A11", 6, 2000.0);
            Vehicle vehicle3 = new Vehicle("z03", 2, 3000.0);

            Catalog catalog = new Catalog();
            catalog.Add(vehicle1);
            catalog.Add(vehicle2);
            catalog.Add(vehicle3);

            Console.WriteLine("Visualizacion inicial del catalogo");
            catalog.Preview();
            Console.WriteLine();

            IRebateRequest request = new RebateRequest(10, 5, 0.1);
            catalog.ExecuteRebateRequest(request);

            Console.WriteLine("Visualizacion del catalogo tras ejecutar la primera solicitud");
            catalog.Preview();
            Console.WriteLine();

            IRebateRequest request2 = new RebateRequest(10, 5, 0.5);
            catalog.ExecuteRebateRequest(request2);

            Console.WriteLine("Visualizacion del catalogo tras ejecutar la segunda solicitud");
            catalog.Preview();
            Console.WriteLine();

            catalog.AnnulRebateRequest(1);

            Console.WriteLine("Visualizacion del catalogo tras anular la primera solicitud");
            catalog.Preview();
            Console.WriteLine();

            catalog.RestoreRebateRequest(1);

            Console.WriteLine("Visualizacion del catalogo tras restablecer la primera solicitud");
            catalog.Preview();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
