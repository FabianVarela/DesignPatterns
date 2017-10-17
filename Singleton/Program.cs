using Singleton.Singleton;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonSingleton person = PersonSingleton.GetInstance();

            person.Id = "1234567890";
            person.Name = "Fabian Varela Bonett";
            person.Email = "fabian-303@hotmail.com";

            ShowData();
        }

        public static void ShowData()
        {
            PersonSingleton person = PersonSingleton.GetInstance();
            person.ShowData();
        }
    }
}
