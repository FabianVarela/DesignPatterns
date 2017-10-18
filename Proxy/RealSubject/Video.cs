using Proxy.Subject;
using System;

namespace Proxy.RealSubject
{
    public class Video : IAnimation
    {
        public void Clic() { }

        public void Draw() => Console.WriteLine("Mostrar el video");

        public void Load() => Console.WriteLine("Cargar el video");

        public void Play() => Console.WriteLine("Reproduce el video");
    }
}
