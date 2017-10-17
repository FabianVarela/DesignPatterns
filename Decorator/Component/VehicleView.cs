using System;

namespace Decorator.Component
{
    public class VehicleView : IGraphicVehicleComponent
    {
        public void Preview() => Console.WriteLine("Visualizacion del vehiculo");
    }
}
