using Memento.ManageState;
using Memento.Memento;
using Memento.OriginalObject;
using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            IMemento memento;

            VehicleOption option1 = new VehicleOption("Asientos en cuero");
            VehicleOption option2 = new VehicleOption("Reclinables");
            VehicleOption option3 = new VehicleOption("Asientos deportivos");

            option1.AddIncompatibleOption(option3);
            option2.AddIncompatibleOption(option3);

            OptionsCar optionsCar = new OptionsCar();

            optionsCar.AddOption(option1);
            optionsCar.AddOption(option2);
            optionsCar.Preview();

            memento = optionsCar.AddOption(option3);

            optionsCar.Preview();
            optionsCar.Anulate(memento);
            optionsCar.Preview();

            Console.ReadKey();
        }
    }
}
