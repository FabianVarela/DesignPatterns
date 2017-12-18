using System;

namespace State.Entity
{
    public class Product
    {
        protected string name;

        public Product(string name) => this.name = name;

        public void Show() => Console.WriteLine($"Producto: {name}");
    }
}
