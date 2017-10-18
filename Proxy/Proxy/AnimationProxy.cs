using Proxy.RealSubject;
using Proxy.Subject;
using System;

namespace Proxy.Proxy
{
    public class AnimationProxy : IAnimation
    {
        protected Video video = null;
        protected string photo = "Mostrar la foto";

        public void Clic()
        {
            if (video == null)
            {
                video = new Video();
                video.Load();
            }

            video.Play();
        }

        public void Draw()
        {
            if (video != null)
                video.Draw();
            else
                Draw(photo);
        }

        public void Draw(string photo) => Console.WriteLine(photo);
    }
}
