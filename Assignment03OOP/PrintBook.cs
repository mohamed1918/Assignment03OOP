using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    public class PrintedBook : Book
    {
        public int PageCount { get; set; }

        public PrintedBook(string title, string author, string isbn, int pageCount)
            : base(title, author, isbn)
        {
            PageCount = pageCount;
        }

        public override void Display()
        {
            Console.WriteLine($"Printed Book - Title: {Title}, Author: {Author}, ISBN: {ISBN}, Pages: {PageCount}");
        }

    }
}
