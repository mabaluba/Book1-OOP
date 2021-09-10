using System;
using System.Collections.Generic;
using System.Text;

namespace Book1
{
    class Title
    {
        readonly string title;
        public Title(string title)
        {
            this.title = title;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{title}");//,ConsoleColor.Red);
        }
    }
}
