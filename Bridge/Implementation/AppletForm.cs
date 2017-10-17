using System;

namespace Bridge.Implementation
{
    public class AppletForm : IForm
    {
        public void DrawText(string text) => Console.WriteLine($"Applet: {text}");

        public string ManageIndicateZone() => Console.ReadLine();
    }
}
