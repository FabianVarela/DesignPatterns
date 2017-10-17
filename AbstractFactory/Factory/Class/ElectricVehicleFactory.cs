using AbstractFactory.Factory.Interface;
using AbstractFactory.Product.Cars.Abstract;
using AbstractFactory.Product.Scooters.Abstract;
using AbstractFactory.Product.Cars.Class;
using AbstractFactory.Product.Scooters.Class;

namespace AbstractFactory.Factory.Class
{
    public class ElectricVehicleFactory : IVehicleFactory
    {
        public Car CreateCar(string model, string color, int power, double space)
        {
            return new ElectricCar(model, color, power, space);
        }

        public Scooter CreateScooter(string model, string color, int power)
        {
            return new ElectricScooter(model, color, power);
        }
    }
}
