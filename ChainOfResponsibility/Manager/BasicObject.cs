namespace ChainOfResponsibility.Manager
{
    public abstract class BasicObject
    {
        public BasicObject Next { protected get; set; }

        private string DefaultDescription() => "descripcion por defecto";

        public abstract string Description { get; }

        public string ReturnDescription()
        {
            string result;
            result = Description;

            if (result != null)
                return result;

            if (Next != null)
                return Next.ReturnDescription();
            else
                return DefaultDescription();
        }
    }
}
