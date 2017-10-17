using System;
using Decorator.Component;

namespace Decorator.Decorator
{
    public class DecoratorMark : Decorator
    {
        public DecoratorMark(IGraphicVehicleComponent component) : base(component) { }

        protected void PreviewLogo() => Console.WriteLine("Logotipo de la marca");

        public override void Preview()
        {
            base.Preview();
            PreviewLogo();
        }
    }
}
