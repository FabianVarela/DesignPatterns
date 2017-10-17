using AbstractFactory.Product.Scooters.Abstract;
using System;

namespace AbstractFactory.Product.Scooters.Class
{
    public class ElectricScooter : Scooter
    {
        public ElectricScooter(string model, string color, int power) :
            base(model, color, power)
        { }

        public override void ShowFeatures() => Console.WriteLine($"Scooter eléctrica \nModelo: {model} \nColor: {color} \nPotencia: {power} \n");
    }
}
