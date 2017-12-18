using State.Entity;
using State.State.Abstract;
using State.State.Class;
using System;
using System.Collections.Generic;

namespace State.StateMachine
{
    public class Order
    {
        protected IList<Product> products = new List<Product>();

        public IList<Product> Products { get => products; }

        protected OrderState orderState;

        public Order() => orderState = new OrderInCourse(this);

        public void AddProduct(Product product) => orderState.AddProduct(product);

        public void DeleteProduct(Product product) => orderState.DeleteProduct(product);

        public void Delete() => orderState.Delete();

        public void NextState() => orderState = orderState.NextOrder();

        public void Show()
        {
            Console.WriteLine("Contenido del producto");

            foreach (var item in products)
                item.Show();

            Console.WriteLine();
        }
    }
}
