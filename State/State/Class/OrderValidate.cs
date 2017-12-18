using State.Entity;
using State.State.Abstract;
using State.StateMachine;

namespace State.State.Class
{
    public class OrderValidate : OrderState
    {
        public OrderValidate(Order order) : base(order) { }

        public override void AddProduct(Product product) { }

        public override void Delete() => order.Products.Clear();

        public override void DeleteProduct(Product product) { }

        public override OrderState NextOrder() => new OrderDelivery(order);
    }
}
