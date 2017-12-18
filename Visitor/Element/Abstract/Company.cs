using Visitor.Visitor.Interface;

namespace Visitor.Element.Abstract
{
    public abstract class Company
    {
        public string Name { get; protected set; }
        public string Email { get; protected set; }
        public string Address { get; protected set; }

        public Company(string name, string email, string address)
        {
            Name = name;
            Email = email;
            Address = address;
        }

        public abstract bool AddSubsidiary(Company filial);
        public abstract void AllowVisitor(IVisitor visitor);
    }
}
