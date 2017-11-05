using Observer.Observer.Interface;
using Observer.Subject.Class;
using System;

namespace Observer.Observer.Class
{
    public class VehicleView : IObserver
    {
        protected Vehicle vehicle;
        protected string text = string.Empty;

        public VehicleView(Vehicle vehicle)
        {
            this.vehicle = vehicle;
            vehicle.Add(this);
            UpdateText();
        }

        protected void UpdateText() => text = $"Descripcion {vehicle.Description} Precio: {vehicle.Price}";

        public void Update()
        {
            UpdateText();
            ReDraw();
        }

        public void ReDraw() => Console.WriteLine(text);
    }
}
