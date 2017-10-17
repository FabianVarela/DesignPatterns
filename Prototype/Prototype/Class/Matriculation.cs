using Prototype.Prototype.Abstract;
using System;

namespace Prototype.Prototype.Class
{
    public class Matriculation : Document
    {
        public override void Print() => Console.WriteLine($"Imprime la solicitud de matriculacion {content}");

        public override void Show() => Console.WriteLine($"Muestra la solicitud de matriculacion {content}");
    }
}
