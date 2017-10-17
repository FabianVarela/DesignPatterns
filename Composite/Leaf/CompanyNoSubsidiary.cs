using Composite.Component;

namespace Composite.Leaf
{
    public class CompanyNoSubsidiary : Company
    {
        public override bool AddSubsidiary(Company subsidiary) => false;

        public override double CalculateMaintenanceCost() => nVehicles * unitaryCostVehicle;
    }
}
