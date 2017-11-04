using Mediator.Element.Abstract;
using System;
using System.Collections.Generic;

namespace Mediator.Element.Class
{
    public class PopUpMenu : Control
    {
        protected IList<string> options = new List<string>();

        public PopUpMenu(string name) : base(name) { }

        public override void Inform()
        {
            Console.WriteLine($"Informacion de {Name}");
            Console.WriteLine($"Valor actual: {Value}");

            for (int i = 0; i < options.Count; i++)
                Console.WriteLine($"- {i} ){options[i]}");

            int choice = int.Parse(Console.ReadLine());

            if ((choice >= 0) && (choice < options.Count))
            {
                bool change = Value != options[choice];

                if (change)
                {
                    Value = options[choice];
                    Modify();
                }
            }
        }

        public void AddOption(string option) => options.Add(option);
    }
}
