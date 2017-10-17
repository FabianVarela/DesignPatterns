using AbstractFactory.Product.Scooters.Abstract;
using System;

namespace AbstractFactory.Product.Scooters.Class
{
    public class GasolineScooter : Scooter
    {
        public GasolineScooter(string model, string color, int power) :
            base(model, color, power)
        { }

        public override void ShowFeatures() => Console.WriteLine($"Scooter de gasolina \nModelo: {model} \nColor: {color} \nPotencia: {power} \n");
    }
}
