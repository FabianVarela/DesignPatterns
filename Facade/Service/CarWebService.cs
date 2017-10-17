using Facade.Component.Catalog;
using Facade.Component.Document;
using System.Collections.Generic;

namespace Facade.Service
{
    public interface ICarWebService
    {
        string Document(int index);
        IList<string> SearchVehicles(int mediumPrice, int maxDeviation);
    }

    public class CarWebService : ICarWebService
    {
        protected ICatalog catalog = new CatalogComponent();
        protected IManageDocument document = new ManageDocumentComponent();

        public string Document(int index) => document.Document(index);

        public IList<string> SearchVehicles(int mediumPrice, int maxDeviation)
        {
            return catalog.SearchVehicles(mediumPrice - maxDeviation, mediumPrice + maxDeviation);
        }
    }
}
