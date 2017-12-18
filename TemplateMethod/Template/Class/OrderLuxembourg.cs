using TemplateMethod.Template.Abstract;

namespace TemplateMethod.Template.Class
{
    public class OrderLuxembourg : Order
    {
        protected override void CalculateIVA() => importIVA = importNoIVA * 0.15;
    }
}
