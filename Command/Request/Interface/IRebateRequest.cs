using Command.Receiver;
using System.Collections.Generic;

namespace Command.Request.Interface
{
    public interface IRebateRequest
    {
        void Reduce(IList<Vehicle> vehicles);
        void Annul();
        void Restore();
    }
}
