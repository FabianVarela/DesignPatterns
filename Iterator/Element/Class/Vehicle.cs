using System;

namespace Iterator.Element.Class
{
    public class Vehicle : Abstract.Element
    {
        public Vehicle(string description) : base(description) { }

        public void Preview() => Console.WriteLine($"Descripcion del vehiculo: {description}");
    }
}
