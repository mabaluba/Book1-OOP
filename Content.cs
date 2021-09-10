using System;
using System.Collections.Generic;
using System.Text;

namespace Book1
{
    class Content
    {
        readonly string content;
        public Content(string title)
        {
            this.content = title;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{content}");//,ConsoleColor.Red);
            Console.ResetColor();
        }
    }
}
