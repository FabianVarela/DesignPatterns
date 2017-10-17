using Bridge.Implementation;

namespace Bridge.Abstract
{
    public class RegistrationFormatPortugal : RegistrationFormat
    {
        public RegistrationFormatPortugal(IForm implementation) : base(implementation) { }

        protected override bool IsZoneControl(string registration) => registration.Length == 6;
    }
}
