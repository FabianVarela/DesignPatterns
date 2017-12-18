using System;

namespace TemplateMethod.Template.Abstract
{
    public abstract class Order
    {
        protected double importNoIVA;
        protected double importIVA;
        protected double importYesIVA;

        protected abstract void CalculateIVA();

        public void CalculatePriceWithIVA()
        {
            CalculateIVA();
            importYesIVA = importNoIVA + importIVA;
        }

        public void SetImportNoIVA(double importNoIVA) => this.importNoIVA = importNoIVA;

        public void Show()
        {
            Console.WriteLine("Pedido");
            Console.WriteLine($"Importe sin IVA {importNoIVA}");
            Console.WriteLine($"Importe con IVA {importYesIVA}");
        }
    }
}
