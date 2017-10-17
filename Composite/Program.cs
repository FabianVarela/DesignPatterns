using Composite.Component;
using Composite.Compound;
using Composite.Leaf;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company1 = new CompanyNoSubsidiary();
            company1.AddVehicle();

            Company company2 = new CompanyNoSubsidiary();
            company2.AddVehicle();
            company2.AddVehicle();

            Company group = new MainCompany();
            group.AddSubsidiary(company1);
            group.AddSubsidiary(company2);
            group.AddVehicle();

            Console.WriteLine($"Coste de mantenimiento total del grupo {group.CalculateMaintenanceCost()}");

            Console.ReadKey();
        }
    }
}
