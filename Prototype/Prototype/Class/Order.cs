using Prototype.Prototype.Abstract;
using System;

namespace Prototype.Prototype.Class
{
    public class Order : Document
    {
        public override void Print() => Console.WriteLine($"Imprime el orden de pedido {content}");

        public override void Show() => Console.WriteLine($"Muestra el orden de pedido {content}");
    }
}
