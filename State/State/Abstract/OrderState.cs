using State.Entity;
using State.StateMachine;

namespace State.State.Abstract
{
    public abstract class OrderState
    {
        protected Order order;

        public OrderState(Order order) => this.order = order;

        public abstract void AddProduct(Product product);
        public abstract void Delete();
        public abstract void DeleteProduct(Product product);
        public abstract OrderState NextOrder();
    }
}
