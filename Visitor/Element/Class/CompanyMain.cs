using System.Collections.Generic;
using Visitor.Element.Abstract;
using Visitor.Visitor.Interface;

namespace Visitor.Element.Class
{
    public class CompanyMain : Company
    {
        protected IList<Company> companies = new List<Company>();

        public CompanyMain(string name, string email, string address) : base(name, email, address) { }

        public override bool AddSubsidiary(Company filial)
        {
            companies.Add(filial);
            return true;
        }

        public override void AllowVisitor(IVisitor visitor)
        {
            visitor.Visit(this);

            foreach (var item in companies)
                item.AllowVisitor(visitor);
        }
    }
}
