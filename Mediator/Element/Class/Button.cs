using Mediator.Element.Abstract;
using System;

namespace Mediator.Element.Class
{
    public class Button : Control
    {
        public Button(string name) : base(name) { }

        public override void Inform()
        {
            Console.WriteLine($"Desea activar el boton {Name}?");
            string answer = Console.ReadLine();

            if (answer.Equals("si"))
                Modify();
        }
    }
}
