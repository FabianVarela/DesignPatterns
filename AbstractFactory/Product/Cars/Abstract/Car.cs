namespace AbstractFactory.Product.Cars.Abstract
{
    public abstract class Car
    {
        protected string model;
        protected string color;
        protected int power;
        protected double space;

        public Car(string model, string color, int power, double space)
        {
            this.model = model;
            this.color = color;
            this.power = power;
            this.space = space;
        }

        public abstract void ShowFeatures();
    }
}
