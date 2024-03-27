using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEncapsulation
{
    internal class Product
    {
        private double _price;
        private double _count;
        public string No;
        public string Name;

        public double Price 
        {
            get { return _price; }
            
            set
            {
                if(value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Qiymet menfi deyer ala bilmez");
                }
            } 
        }

        public double Count
        {
            get { return _count; }

            set
            {
                if (value > 0)
                {
                    _count = value;
                }
                else
                {
                    Console.WriteLine("Kitab sayi menfi deyer ala bilmez");
                }
            }
        }
    }
}
