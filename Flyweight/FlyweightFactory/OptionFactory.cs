using Flyweight.Flyweight;
using System.Collections.Generic;

namespace Flyweight.FlyweightFactory
{
    public class OptionFactory
    {
        protected IDictionary<string, VehicleOption> options = new Dictionary<string, VehicleOption>();

        public VehicleOption GetOption(string name)
        {
            VehicleOption result;

            if (options.ContainsKey(name))
                result = options[name];
            else
            {
                result = new VehicleOption(name);
                options.Add(name, result);
            }

            return result;
        }
    }
}
