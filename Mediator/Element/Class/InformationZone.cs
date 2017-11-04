using Mediator.Element.Abstract;
using System;

namespace Mediator.Element.Class
{
    public class InformationZone : Control
    {
        public InformationZone(string name) : base(name) { }

        public override void Inform()
        {
            Console.WriteLine($"Informacion de {Name}");
            Value = Console.ReadLine();
            Modify();
        }
    }
}
