using Prototype.Prototype.Abstract;
using System;

namespace Prototype.Prototype.Class
{
    public class SessionCertificate : Document
    {
        public override void Print() => Console.WriteLine($"Imprime el certificado de sesion {content}");

        public override void Show() => Console.WriteLine($"Muestra el certificado de sesion {content}");
    }
}
