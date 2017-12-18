using State.Entity;
using State.State.Abstract;
using State.StateMachine;

namespace State.State.Class
{
    public class OrderDelivery : OrderState
    {
        public OrderDelivery(Order order) : base(order) { }

        public override void AddProduct(Product product) { }

        public override void Delete() { }

        public override void DeleteProduct(Product product) { }

        public override OrderState NextOrder() => this;
    }
}
