using AbstractFactory.Factory.Interface;
using AbstractFactory.Product.Cars.Abstract;
using AbstractFactory.Product.Cars.Class;
using AbstractFactory.Product.Scooters.Abstract;
using AbstractFactory.Product.Scooters.Class;

namespace AbstractFactory.Factory.Class
{
    public class GasolineVehicleFactory : IVehicleFactory
    {
        public Car CreateCar(string model, string color, int power, double space)
        {
            return new GasolineCar(model, color, power, space);
        }

        public Scooter CreateScooter(string model, string color, int power)
        {
            return new GasolineScooter(model, color, power);
        }
    }
}
