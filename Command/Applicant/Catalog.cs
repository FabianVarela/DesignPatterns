using Command.Receiver;
using Command.Request.Interface;
using System.Collections.Generic;

namespace Command.Applicant
{
    public class Catalog
    {
        protected IList<Vehicle> inStockVehicles = new List<Vehicle>();
        protected IList<IRebateRequest> requests = new List<IRebateRequest>();

        public void ExecuteRebateRequest(IRebateRequest request)
        {
            requests.Insert(0, request);
            request.Reduce(inStockVehicles);
        }

        public void AnnulRebateRequest(int order) => requests[order].Annul();

        public void RestoreRebateRequest(int order) => requests[order].Restore();

        public void Add(Vehicle vehicle) => inStockVehicles.Add(vehicle);

        public void Preview()
        {
            foreach (var vehicle in inStockVehicles)
                vehicle.Preview();
        }
    }
}
