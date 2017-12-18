using TemplateMethod.Template.Abstract;

namespace TemplateMethod.Template.Class
{
    public class OrderSpain : Order
    {
        protected override void CalculateIVA() => importIVA = importNoIVA * 0.18;
    }
}
