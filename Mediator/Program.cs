using Mediator.Element.Class;
using Mediator.Mediator.Class;
using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();

            form.AddControl(new InformationZone("Name"));
            form.AddControl(new InformationZone("Last Name"));

            PopUpMenu menu = new PopUpMenu("Co-prestario");
            menu.AddOption("sin co-prestario");
            menu.AddOption("con co-prestario");

            form.AddControl(menu);
            form.MenuCo = menu;

            Button button = new Button("OK");

            form.AddControl(button);
            form.OkButton = button;

            form.AddControlCo(new InformationZone("Nombre del co-prestador"));
            form.AddControlCo(new InformationZone("Apellidos del co-prestador"));

            form.Inform();

            Console.ReadKey();
        }
    }
}
