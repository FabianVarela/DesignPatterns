using Bridge.Implementation;

namespace Bridge.Abstract
{
    public class RegistrationFormatSpain : RegistrationFormat
    {
        public RegistrationFormatSpain(IForm implementation) : base(implementation) { }

        protected override bool IsZoneControl(string registration) => registration.Length == 7;
    }
}
