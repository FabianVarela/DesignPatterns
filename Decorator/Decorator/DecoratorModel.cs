using System;
using Decorator.Component;

namespace Decorator.Decorator
{
    public class DecoratorModel : Decorator
    {
        public DecoratorModel(IGraphicVehicleComponent component) : base(component) { }

        protected void PreviewTechnicalInformation() => Console.WriteLine("Informacion tecnica del modelo");

        public override void Preview()
        {
            base.Preview();
            PreviewTechnicalInformation();
        }
    }
}
