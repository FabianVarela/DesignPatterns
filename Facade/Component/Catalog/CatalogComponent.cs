using System.Collections.Generic;

namespace Facade.Component.Catalog
{
    public interface ICatalog
    {
        IList<string> SearchVehicles(int minPrice, int maxPrice);
    }

    public class CatalogComponent : ICatalog
    {
        protected object[] vehicleDescription =
        {
            "Berlina 5 puertas", 6000,
            "Compacto 3 puertas", 4000,
            "Espace 5 puertas", 8000,
            "Break 5 puertas", 7000,
            "Coupe 2 puertas", 9000,
            "Utilitario 3 puertas", 5000
        };

        public IList<string> SearchVehicles(int minPrice, int maxPrice)
        {
            int index, size;
            IList<string> result = new List<string>();

            size = vehicleDescription.Length / 2;

            for (index = 0; index < size; index++)
            {
                int precio = (int)vehicleDescription[2 * index + 1];

                if ((precio >= minPrice) && (precio <= maxPrice))
                    result.Add((string)vehicleDescription[2 * index]);
            }

            return result;
        }
    }
}
