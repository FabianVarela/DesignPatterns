using Bridge.Abstract;
using Bridge.Implementation;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistrationFormatPortugal formPort = new RegistrationFormatPortugal(new HtmlForm());
            formPort.Preview();

            if (formPort.ManageZone())
                formPort.GenerateDocument();

            Console.WriteLine();

            RegistrationFormatSpain formEsp = new RegistrationFormatSpain(new AppletForm());
            formEsp.Preview();

            if (formEsp.ManageZone())
                formEsp.GenerateDocument();

            Console.ReadKey();
        }
    }
}
