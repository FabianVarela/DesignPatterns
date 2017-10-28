using Strategy.Strategy.Interface;
using System;
using System.Collections.Generic;
using Strategy.Context;

namespace Strategy.Strategy.Class
{
    public class DrawVehicleByLine : IDrawCatalog
    {
        public void Draw(IList<VehicleView> content)
        {
            Console.WriteLine("Dibuja los vehiculos mostrando un vehiculo por linea.");

            foreach (var item in content)
            {
                item.Draw();
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
