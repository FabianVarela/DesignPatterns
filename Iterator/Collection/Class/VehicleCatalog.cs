using Iterator.Iterator.Class;
using Iterator.Element.Class;

namespace Iterator.Collection.Class
{
    public class VehicleCatalog : Abstract.Catalog<Vehicle, IteratorVehicle>
    {
        public VehicleCatalog()
        {
            content.Add(new Vehicle("vehiculo economico"));
            content.Add(new Vehicle("pequeño vehiculo economico"));
            content.Add(new Vehicle("vehiculo de gran calidad"));
        }
    }
}
