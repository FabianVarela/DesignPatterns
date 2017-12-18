using State.Entity;
using State.State.Abstract;
using State.StateMachine;

namespace State.State.Class
{
    public class OrderInCourse : OrderState
    {
        public OrderInCourse(Order order) : base(order) { }

        public override void AddProduct(Product product) => order.Products.Add(product);

        public override void Delete() => order.Products.Clear();

        public override void DeleteProduct(Product product) => order.Products.Remove(product);

        public override OrderState NextOrder() => new OrderValidate(order);
    }
}
