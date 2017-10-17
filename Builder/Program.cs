using Builder.Builder.Abstract;
using Builder.Builder.Class;
using Builder.Director;
using Builder.Product.Abstract;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentationVehicleBuilder builder;

            Console.WriteLine("¿Desea generar documentación? \n1. HTML \n2.PDF");
            string option = Console.ReadLine();

            if (option == "1")
                builder = new DocumentationVehicleHtmlBuilder();
            else
                builder = new DocumentationVehiclePdfBuilder();

            Seller seller = new Seller(builder);
            Documentation documentacion = seller.Build("Fabian");
            documentacion.Print();

            Console.ReadKey();
        }
    }
}
