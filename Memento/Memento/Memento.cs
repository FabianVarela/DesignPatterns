using Memento.ManageState;
using System.Collections.Generic;

namespace Memento.Memento
{
    public interface IMemento { }

    public class MementoImpl : IMemento
    {
        protected IList<VehicleOption> options = new List<VehicleOption>();

        public IList<VehicleOption> State
        {
            get
            {
                return options;
            }
            set
            {
                options.Clear();
                foreach (var item in value)
                    options.Add(item);
            }
        }
    }
}
