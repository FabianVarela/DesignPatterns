using System;
using System.Collections.Generic;

namespace Memento.ManageState
{
    public class VehicleOption
    {
        protected string name;

        public IList<VehicleOption> IncompatiblesOptions { get; protected set; }

        public VehicleOption(string name)
        {
            IncompatiblesOptions = new List<VehicleOption>();
            this.name = name;
        }

        public void AddIncompatibleOption(VehicleOption incompatibleOption)
        {
            if (!IncompatiblesOptions.Contains(incompatibleOption))
            {
                IncompatiblesOptions.Add(incompatibleOption);
                incompatibleOption.AddIncompatibleOption(this);
            }
        }

        public void Preview() => Console.WriteLine($"opcion {name}");
    }
}
