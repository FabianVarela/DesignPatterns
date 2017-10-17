using AbstractFactory.Factory.Class;
using AbstractFactory.Factory.Interface;
using AbstractFactory.Product.Cars.Abstract;
using AbstractFactory.Product.Scooters.Abstract;
using System;

namespace AbstractFactory
{
    class Program
    {
        public static int nCars = 3;
        public static int nScooters = 2;

        static void Main(string[] args)
        {
            IVehicleFactory factory;

            Car[] autos = new Car[nCars];
            Scooter[] scooters = new Scooter[nScooters];

            Console.WriteLine("Desea utilizar vehiculos eléctricos (1) o a gasolina (2):");
            string option = Console.ReadLine();

            if (option == "1")
                factory = new ElectricVehicleFactory();
            else
                factory = new GasolineVehicleFactory();

            for (int i = 0; i < nCars; i++)
                autos[i] = factory.CreateCar("Estándar", "Amarillo", 6 + i, 3.2);

            for (int i = 0; i < nScooters; i++)
                scooters[i] = factory.CreateScooter("Clásico", "Rojo", 2 + i);

            foreach (var automovil in autos)
                automovil.ShowFeatures();

            foreach (var scooter in scooters)
                scooter.ShowFeatures();

            Console.ReadKey();
        }
    }
}
