using System;

namespace Book1
{
    class Program
    {
        static void Main(string[] args)
        {
            var title1 = "название1";
            var author1 = "автор1";
            var content1 = "содержание1";

            var book1 = new Book(title1, author1, content1);
            var book2 = new Book("название 2","автор2","содержание2");

            book1.Show();
            book2.Show();
        }
    }
}
