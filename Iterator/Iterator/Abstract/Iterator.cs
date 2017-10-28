using System.Collections.Generic;

namespace Iterator.Iterator.Abstract
{
    public abstract class Iterator<TElement> where TElement : Element.Abstract.Element
    {
        protected int index;

        public string QueryKeyWord { protected get; set; }
        public IList<TElement> Content { protected get; set; }

        public void Start()
        {
            index = 0;
            int size = Content.Count;

            while ((index < size) && (!Content[index].ValidateKeyWord(QueryKeyWord)))
                index++;
        }

        public void Next()
        {
            int size = Content.Count;
            index++;

            while ((index < size) && (!Content[index].ValidateKeyWord(QueryKeyWord)))
                index++;
        }

        public TElement Item()
        {
            if (index < Content.Count)
                return Content[index];
            else
                return null;
        }
    }
}
