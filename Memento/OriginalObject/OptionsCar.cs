using Memento.ManageState;
using Memento.Memento;
using System;
using System.Collections.Generic;

namespace Memento.OriginalObject
{
    public class OptionsCar
    {
        protected IList<VehicleOption> options = new List<VehicleOption>();

        public IMemento AddOption(VehicleOption option)
        {
            MementoImpl memento = new MementoImpl
            {
                State = options
            };

            IList<VehicleOption> incompatiblesOptions = option.IncompatiblesOptions;

            foreach (var item in incompatiblesOptions)
                options.Remove(item);

            options.Add(option);

            return memento;
        }

        public void Anulate(IMemento memento)
        {
            MementoImpl mementoImpl = memento as MementoImpl;

            if (mementoImpl == null)
                return;

            options = mementoImpl.State;
        }

        public void Preview()
        {
            Console.WriteLine("Contenido del carrito de opciones");
            foreach (var item in options)
                item.Preview();

            Console.WriteLine();
        }
    }
}
