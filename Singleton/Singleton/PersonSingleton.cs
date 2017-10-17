using System;

namespace Singleton.Singleton
{
    public class PersonSingleton
    {
        private static PersonSingleton _instance = null;

        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        private PersonSingleton() { }

        public static PersonSingleton GetInstance()
        {
            if (_instance == null)
                _instance = new PersonSingleton();

            return _instance;
        }

        public void ShowData()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");

            Console.ReadKey();
        }
    }
}
