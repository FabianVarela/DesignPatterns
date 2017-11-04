using Mediator.Element.Abstract;
using Mediator.Element.Class;
using System.Collections.Generic;

namespace Mediator.Mediator.Class
{
    public class Form
    {
        protected IList<Control> controls = new List<Control>();
        protected IList<Control> controlsCo = new List<Control>();

        public PopUpMenu MenuCo { protected get; set; }
        public Button OkButton { protected get; set; }

        protected bool inProgress = true;

        public void AddControl(Control control)
        {
            controls.Add(control);
            control.Director = this;
        }

        public void AddControlCo(Control control)
        {
            controlsCo.Add(control);
            control.Director = this;
        }

        public void ModifiedControl(Control control)
        {
            if (control == MenuCo)
            {
                if (control.Value.Equals("con co-prestario"))
                {
                    foreach (var item in controlsCo)
                        item.Inform();
                }
            }

            if (control == OkButton)
                inProgress = false;
        }

        public void Inform()
        {
            while (true)
            {
                foreach (var item in controls)
                {
                    item.Inform();

                    if (!inProgress) return;
                }
            }
        }
    }
}
