using Strategy.Strategy.Interface;
using System;
using System.Collections.Generic;
using Strategy.Context;

namespace Strategy.Strategy.Class
{
    public class DrawThreeVehiclesByLine : IDrawCatalog
    {
        public void Draw(IList<VehicleView> content)
        {
            int count = 0;
            Console.WriteLine("Dibuja los vehiculos mostrando tres vehiculos por linea.");

            foreach (var item in content)
            {
                item.Draw();
                count++;

                if (count == 3)
                {
                    Console.WriteLine();
                    count = 0;
                }
                else
                    Console.Write(" ");
            }

            if (count != 0)
                Console.WriteLine();

            Console.WriteLine();
        }
    }
}
