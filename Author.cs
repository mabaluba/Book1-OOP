using System;
using System.Collections.Generic;
using System.Text;

namespace Book1
{
    class Author
    {
        readonly string author;
        public Author(string title)
        {
            this.author = title;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{author}");//,ConsoleColor.Red);
        }
    }
}
