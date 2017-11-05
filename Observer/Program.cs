using Observer.Observer.Class;
using Observer.Subject.Class;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle
            {
                Description = "Vehiculo economico",
                Price = 5000.0
            };

            VehicleView vehicleView = new VehicleView(vehicle);
            vehicleView.ReDraw();

            vehicle.Price = 4500.0;

            VehicleView vehicleView2 = new VehicleView(vehicle);

            vehicle.Price = 5500.0;

            Console.ReadKey();
        }
    }
}
