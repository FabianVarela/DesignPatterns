using Strategy.Context;
using Strategy.Strategy.Class;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            CatalogView catalog1 = new CatalogView(new DrawThreeVehiclesByLine());
            catalog1.Draw();

            CatalogView catalog2 = new CatalogView(new DrawVehicleByLine());
            catalog2.Draw();

            Console.ReadKey();
        }
    }
}
