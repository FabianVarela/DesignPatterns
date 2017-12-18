using Visitor.Element.Class;

namespace Visitor.Visitor.Interface
{
    public interface IVisitor
    {
        void Visit(CompanyNoSubsidiary company);
        void Visit(CompanyMain main);
    }
}
