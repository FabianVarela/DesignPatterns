using Flyweight.Flyweight;
using Flyweight.FlyweightFactory;
using System;
using System.Collections.Generic;

namespace Flyweight.Client
{
    public class RequestVehicle
    {
        protected IList<VehicleOption> options = new List<VehicleOption>();
        protected IList<int> salesPriceOptions = new List<int>();

        public void AddOptions(string name, int salesPrice, OptionFactory factory)
        {
            options.Add(factory.GetOption(name));
            salesPriceOptions.Add(salesPrice);
        }

        public void ShowOptions()
        {
            int index, size;
            size = options.Count;

            for (index = 0; index < size; index++)
            {
                options[index].Preview(salesPriceOptions[index]);
                Console.WriteLine();
            }
        }
    }
}
