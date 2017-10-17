namespace Prototype.Prototype.Abstract
{
    public abstract class Document
    {
        protected string content = string.Empty;

        public Document Duplicate() => (Document)MemberwiseClone();

        public void Fill(string information) => content = information;

        public abstract void Print();
        public abstract void Show();
    }
}
