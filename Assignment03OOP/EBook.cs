using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    public class EBook : Book
    {
        public double FileSize { get; set; }

        public EBook(string title, string author, string isbn, double fileSize)
            : base(title, author, isbn)
        {
            FileSize = fileSize;
        }

        public override void Display()
        {
            Console.WriteLine($"E-Book - Title: {Title}, Author: {Author}, ISBN: {ISBN}, File Size: {FileSize}MB");
        }

    }
}
