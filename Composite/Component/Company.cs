namespace Composite.Component
{
    public abstract class Company
    {
        protected static double unitaryCostVehicle = 5.0;
        protected int nVehicles;

        public void AddVehicle() => nVehicles++;

        public abstract double CalculateMaintenanceCost();
        public abstract bool AddSubsidiary(Company subsidiary);
    }
}
