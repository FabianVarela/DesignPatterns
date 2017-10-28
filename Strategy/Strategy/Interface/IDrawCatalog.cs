using Strategy.Context;
using System.Collections.Generic;

namespace Strategy.Strategy.Interface
{
    public interface IDrawCatalog
    {
        void Draw(IList<VehicleView> content);
    }
}
