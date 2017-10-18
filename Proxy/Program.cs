using Proxy.Proxy;
using Proxy.Subject;
using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimation animation = new AnimationProxy();
            animation.Draw();
            animation.Clic();
            animation.Draw();

            Console.ReadKey();
        }
    }
}
