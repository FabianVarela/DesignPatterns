using Decorator.Component;

namespace Decorator.Decorator
{
    public abstract class Decorator : IGraphicVehicleComponent
    {
        protected IGraphicVehicleComponent component;

        public Decorator(IGraphicVehicleComponent component) => this.component = component;

        public virtual void Preview() => component.Preview();
    }
}
