namespace Adapter.Interface
{
    public interface IDocument
    {
        string Content { set; }
        void Draw();
        void Print();
    }
}
