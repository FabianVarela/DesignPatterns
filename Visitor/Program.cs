using System;
using Visitor.Element.Abstract;
using Visitor.Element.Class;
using Visitor.Visitor.Class;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company1 = new CompanyNoSubsidiary("Empresa 1", "info@empresa1.com", "calle de la empresa 1");
            Company company2 = new CompanyNoSubsidiary("Empresa 2", "info@empresa2.com", "calle de la empresa 2");

            Company main1 = new CompanyMain("Group 1", "info@group1.com", "cale del grupo 1");
            main1.AddSubsidiary(company1);
            main1.AddSubsidiary(company2);

            Company company3 = new CompanyNoSubsidiary("Empresa 3", "info@empresa3.com", "calle de la empresa 3");

            Company main2 = new CompanyMain("Group 2", "info@group2.com", "calle del grupo 2");
            main2.AddSubsidiary(main1);
            main2.AddSubsidiary(company3);

            main2.AllowVisitor(new VisitorComercial());

            Console.ReadKey();
        }
    }
}
