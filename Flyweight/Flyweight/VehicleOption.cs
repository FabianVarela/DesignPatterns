using System;

namespace Flyweight.Flyweight
{
    public class VehicleOption
    {
        protected string name;
        protected string description;
        protected int standardPrice;

        public VehicleOption(string name)
        {
            this.name = name;
            description = $"Descripcion de {name}";
            standardPrice = 100;
        }

        public void Preview(int salesPrice)
        {
            Console.WriteLine("Opcion");
            Console.WriteLine($"Nombre: {name}");
            Console.WriteLine(description);
            Console.WriteLine($"Precio estandar: {standardPrice}");
            Console.WriteLine($"Precio de venta: {salesPrice}");
        }
    }
}
