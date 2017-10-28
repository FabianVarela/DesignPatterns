using System.Collections.Generic;

namespace Iterator.Collection.Abstract
{
    public abstract class Catalog<TElement, TIterator>
        where TElement : Element.Abstract.Element
        where TIterator : Iterator.Abstract.Iterator<TElement>, new()
    {
        protected IList<TElement> content = new List<TElement>();

        public TIterator Search(string queryKeyWord)
        {
            TIterator result = new TIterator
            {
                QueryKeyWord = queryKeyWord,
                Content = content
            };

            return result;
        }
    }
}
