using System.Collections.Generic;

namespace Builder.Product.Abstract
{
    public abstract class Documentation
    {
        protected IList<string> content = new List<string>();

        public abstract void AddDocument(string document);
        public abstract void Print();
    }
}
