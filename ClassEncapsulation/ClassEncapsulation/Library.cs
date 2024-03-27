using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEncapsulation
{
    internal class Library
    {
        public Book[] Books = { };

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }

        public Book[] GetFilteredBooks(string genre)
        {
            Book[] genres = { };

            Console.WriteLine($"{genre} janrinda olan kitablar:");

            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Genre == genre)
                {
                    Array.Resize(ref genres, genres.Length + 1);
                    genres[genres.Length - 1] = Books[i];
                }
            }

            return genres;
        }

        public Book[] GetFilteredBooks(int minPrice, int maxPrice)
        {
            Book[] prices = { };

            Console.WriteLine($"{minPrice}-{maxPrice} qiymet araliginda olan kitablar:");

            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Price >= minPrice && Books[i].Price <= maxPrice)
                {
                    Array.Resize(ref prices, prices.Length + 1);
                    prices[prices.Length - 1] = Books[i];
                }
            }
            return prices;
        }

        public void ShowAllBooks()
        {
            for(int i = 0;i < Books.Length;i++)
            {
                Book book = Books[i];
                Console.WriteLine($"{book.Name}, {book.No}, {book.Genre}, {book.Price}, {book.Count}");          
            }
        }
    }
}
