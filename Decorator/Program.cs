using Decorator.Component;
using Decorator.Decorator;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleView vehicleView = new VehicleView();
            DecoratorModel modeloDecorador = new DecoratorModel(vehicleView);
            DecoratorMark decoratorMark = new DecoratorMark(modeloDecorador);

            decoratorMark.Preview();

            Console.ReadKey();
        }
    }
}
