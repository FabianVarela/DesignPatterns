using Strategy.Strategy.Interface;
using System.Collections.Generic;

namespace Strategy.Context
{
    public class CatalogView
    {
        protected IList<VehicleView> content = new List<VehicleView>();
        protected IDrawCatalog draw;

        public CatalogView(IDrawCatalog draw)
        {
            content.Add(new VehicleView("vehiculo economico"));
            content.Add(new VehicleView("vehiculo especial"));
            content.Add(new VehicleView("vehiculo rapido"));
            content.Add(new VehicleView("vehiculo confortable"));
            content.Add(new VehicleView("vehiculo deportivo"));

            this.draw = draw;
        }

        public void Draw() => draw.Draw(content);
    }
}
