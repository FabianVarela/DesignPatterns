using System;
using Visitor.Element.Class;
using Visitor.Visitor.Interface;

namespace Visitor.Visitor.Class
{
    public class VisitorComercial : IVisitor
    {
        public void Visit(CompanyNoSubsidiary company)
        {
            Console.WriteLine($"Envia un email a {company.Name} direccion: {company.Email} Propuesta comercial para su empresa.");
        }

        public void Visit(CompanyMain main)
        {
            Console.WriteLine($"Envia un email a {main.Name} direccion: {main.Email} Propuesta comercial para su grupo.");
            Console.WriteLine($"Impresion de un correo electronico para {main.Name} direccion: {main.Address} Propuesta comercial para su grupo.");
        }
    }
}
