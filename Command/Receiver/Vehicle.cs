using System;

namespace Command.Receiver
{
    public class Vehicle
    {
        protected string name;
        protected long inStockDate;
        protected double salesPrice;

        public Vehicle(string name, long inStockDate, double salesPrice)
        {
            this.name = name;
            this.inStockDate = inStockDate;
            this.salesPrice = salesPrice;
        }

        public long GetStockTime(long today) => today - inStockDate;

        public void ModifyPrice(double coeficient) => salesPrice = 0.01 * Math.Round(coeficient * salesPrice * 100);

        public void Preview() => Console.WriteLine($"{name}; Price: {salesPrice}; In Stock Date: {inStockDate}");
    }
}
