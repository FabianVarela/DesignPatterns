namespace Iterator.Element.Abstract
{
    public abstract class Element
    {
        protected string description;

        public Element(string description) => this.description = description;

        public bool ValidateKeyWord(string keyWord) => description.IndexOf(keyWord) != -1;
    }
}
