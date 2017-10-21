using Command.Receiver;
using Command.Request.Interface;
using System.Collections.Generic;

namespace Command.Request.Class
{
    public class RebateRequest : IRebateRequest
    {
        protected IList<Vehicle> inStockVehicles = new List<Vehicle>();
        protected long today;
        protected long inStockDate;
        protected double discountRate;

        public RebateRequest(long today, long inStockDate, double discountRate)
        {
            this.today = today;
            this.inStockDate = inStockDate;
            this.discountRate = discountRate;
        }

        public void Annul()
        {
            foreach (var vehicle in inStockVehicles)
                vehicle.ModifyPrice(1.0 / (1.0 - discountRate));
        }

        public void Reduce(IList<Vehicle> vehicles)
        {
            inStockVehicles.Clear();

            foreach (var vehicle in vehicles)
                if (vehicle.GetStockTime(today) >= inStockDate)
                    inStockVehicles.Add(vehicle);

            foreach (var vehicle in inStockVehicles)
                vehicle.ModifyPrice(1.0 - discountRate);
        }

        public void Restore()
        {
            foreach (var vehicle in inStockVehicles)
                vehicle.ModifyPrice(1.0 - discountRate);
        }
    }
}
