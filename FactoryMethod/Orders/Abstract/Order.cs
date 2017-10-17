namespace FactoryMethod.Orders.Abstract
{
    public abstract class Order
    {
        protected double import;

        public Order(double import) => this.import = import;

        public abstract bool Validate();
        public abstract void Pay();
    }
}
