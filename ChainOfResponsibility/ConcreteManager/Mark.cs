using ChainOfResponsibility.Manager;

namespace ChainOfResponsibility.ConcreteManager
{
    public class Mark : BasicObject
    {
        protected string markDescription1, markDescription2;
        protected string name;

        public Mark(string name, string description1, string description2)
        {
            this.name = name;
            markDescription1 = description1;
            markDescription2 = description2;
        }

        public override string Description
        {
            get
            {
                if ((markDescription1 != null) && (markDescription2 != null))
                    return $"Marca {name}: {markDescription1} {markDescription2}";
                else if (markDescription1 != null)
                    return $"Marca {name}: {markDescription1}";
                else
                    return null;
            }
        }
    }
}
