using System;
using TemplateMethod.Template.Abstract;
using TemplateMethod.Template.Class;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Order orderSpain = new OrderSpain();
            orderSpain.SetImportNoIVA(10000);
            orderSpain.CalculatePriceWithIVA();
            orderSpain.Show();

            Order orderLux = new OrderLuxembourg();
            orderLux.SetImportNoIVA(10000);
            orderLux.CalculatePriceWithIVA();
            orderLux.Show();

            Console.ReadKey();
        }
    }
}
