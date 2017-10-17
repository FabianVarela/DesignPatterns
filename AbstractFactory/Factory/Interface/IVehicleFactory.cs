using AbstractFactory.Product.Cars.Abstract;
using AbstractFactory.Product.Scooters.Abstract;

namespace AbstractFactory.Factory.Interface
{
    public interface IVehicleFactory
    {
        Car CreateCar(string model, string color, int power, double space);
        Scooter CreateScooter(string model, string color, int power);
    }
}
