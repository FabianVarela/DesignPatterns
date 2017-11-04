using Mediator.Mediator.Class;

namespace Mediator.Element.Abstract
{
    public abstract class Control
    {
        public string Value { get; set; }
        public Form Director { get; set; }
        public string Name { get; set; }

        public Control(string name)
        {
            Value = string.Empty;
            Name = name;
        }

        public abstract void Inform();

        protected void Modify() => Director.ModifiedControl(this);
    }
}
