namespace Facade.Component.Document
{
    public interface IManageDocument
    {
        string Document(int index);
    }

    public class ManageDocumentComponent : IManageDocument
    {
        public string Document(int index) => $"Documento numero {index}";
    }
}
