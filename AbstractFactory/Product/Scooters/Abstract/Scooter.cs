namespace AbstractFactory.Product.Scooters.Abstract
{
    public abstract class Scooter
    {
        protected string model;
        protected string color;
        protected int power;

        public Scooter(string model, string color, int power)
        {
            this.model = model;
            this.color = color;
            this.power = power;
        }

        public abstract void ShowFeatures();
    }
}
