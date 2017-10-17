using AbstractFactory.Product.Cars.Abstract;
using System;

namespace AbstractFactory.Product.Cars.Class
{
    public class GasolineCar : Car
    {
        public GasolineCar(string model, string color, int power, double space) :
            base(model, color, power, space)
        { }

        public override void ShowFeatures() => Console.WriteLine($"Automovil de gasolina \nModelo: {model} \nColor: {color} \nPotencia: {power} \nEspacio: {space} \n");
    }
}
