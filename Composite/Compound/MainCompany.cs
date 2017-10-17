using Composite.Component;
using System.Collections.Generic;

namespace Composite.Compound
{
    public class MainCompany : Company
    {
        protected IList<Company> subsidies = new List<Company>();

        public override bool AddSubsidiary(Company subsidiary)
        {
            subsidies.Add(subsidiary);
            return true;
        }

        public override double CalculateMaintenanceCost()
        {
            double cost = 0.0;
            foreach (var subsidy in subsidies)
                cost = cost + subsidy.CalculateMaintenanceCost();

            return cost + nVehicles * unitaryCostVehicle;
        }
    }
}
