using Prototype.Client.Class;
using Prototype.Prototype.Class;
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            BlankDocumentation blankDocumentation = BlankDocumentation.Instance();

            blankDocumentation.Include(new Order());
            blankDocumentation.Include(new SessionCertificate());
            blankDocumentation.Include(new Matriculation());

            ClientDocumentation client1 = new ClientDocumentation("Fabian");
            ClientDocumentation client2 = new ClientDocumentation("Jorge");

            client1.Show();
            client2.Show();

            client1.Print();
            client2.Print();

            Console.ReadKey();
        }
    }
}
