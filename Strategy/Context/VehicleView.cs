using System;

namespace Strategy.Context
{
    public class VehicleView
    {
        protected string description;

        public VehicleView(string description) => this.description = description;

        public void Draw() => Console.Write(description);
    }
}
