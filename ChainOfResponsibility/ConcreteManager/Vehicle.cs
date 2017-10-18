using ChainOfResponsibility.Manager;

namespace ChainOfResponsibility.ConcreteManager
{
    public class Vehicle : BasicObject
    {
        protected string vehicleDescription;

        public Vehicle(string description) => vehicleDescription = description;

        public override string Description => vehicleDescription;
    }
}
