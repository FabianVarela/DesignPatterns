using Prototype.Prototype.Abstract;
using System.Collections.Generic;

namespace Prototype.Client.Abstract
{
    public abstract class Documentation
    {
        public IList<Document> Documents { get; protected set; }
    }
}
