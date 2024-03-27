using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassEncapsulation
{
    internal class Book: Product
    {
        public string Genre;

        public Book(string name, string no, double price, string genre, double count)
        {
            No = no;
            Price = price;
            Name = name;
            Genre = genre;
            Count = count;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name}, {No}, {Price}, {Genre}, {Count}");
        }
    }
}
