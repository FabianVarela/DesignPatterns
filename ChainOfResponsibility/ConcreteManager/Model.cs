using ChainOfResponsibility.Manager;

namespace ChainOfResponsibility.ConcreteManager
{
    public class Model : BasicObject
    {
        protected string modelDescription;
        protected string name;

        public Model(string name, string description)
        {
            this.name = name;
            modelDescription = description;
        }

        public override string Description => modelDescription != null ? $"Modelo {name}: {modelDescription}" : null;
    }
}
