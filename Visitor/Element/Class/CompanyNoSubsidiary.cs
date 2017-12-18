using Visitor.Element.Abstract;

namespace Visitor.Element.Class
{
    public class CompanyNoSubsidiary : Company
    {
        public CompanyNoSubsidiary(string name, string email, string address) : base(name, email, address) { }

        public override bool AddSubsidiary(Company filial) => false;

        public override void AllowVisitor(Visitor.Interface.IVisitor visitor) => visitor.Visit(this);
    }
}
