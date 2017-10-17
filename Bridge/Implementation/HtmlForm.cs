using System;

namespace Bridge.Implementation
{
    public class HtmlForm : IForm
    {
        public void DrawText(string text) => Console.WriteLine($"HTML: {text}");

        public string ManageIndicateZone() => Console.ReadLine();
    }
}
