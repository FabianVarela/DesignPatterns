using Bridge.Implementation;

namespace Bridge.Abstract
{
    public abstract class RegistrationFormat
    {
        protected string content;
        protected IForm implementation;

        public RegistrationFormat(IForm implementation) => this.implementation = implementation;

        public void Preview() => implementation.DrawText("número de matricula existente: ");

        public void GenerateDocument()
        {
            implementation.DrawText("Solicitud de matriculación");
            implementation.DrawText($"número de matricula: {content}");
        }

        public bool ManageZone()
        {
            content = implementation.ManageIndicateZone();
            return IsZoneControl(content);
        }

        protected abstract bool IsZoneControl(string registration);
    }
}
