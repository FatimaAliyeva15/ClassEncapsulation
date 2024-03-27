namespace ClassEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Library library = new Library();
            

            Book book = new Book("Saranin acari", "01", 15.00, "Dram", 1);
            Book book2 = new Book("İngilis pasiyent", "02", 14.00, "Psixoloji", 1);
            Book book3 = new Book("Yangi", "03", 13.00, "Dedektiv", 2);
            Book book4 = new Book("Sessiz pasiyent", "04", 15.00, "Qorxu-Gerilim", 1);
            Book book5 = new Book("Qaranlıqdakı adam", "05", 6.49, "Psixoloji", 2);
            Book book6 = new Book("Da Vinçi sifresi", "06", 12.99, "Dedektiv", 2);

            library.AddBook(book);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            library.AddBook(book6);

            Console.WriteLine("Butun kitablar");
            library.ShowAllBooks();

            Console.WriteLine("");

            Book[] booksgenre = library.GetFilteredBooks("Psixoloji");

            for (int i = 0; i < booksgenre.Length; i++)
            {
                
                booksgenre[i].ShowInfo();
            }

            Console.WriteLine("");

            Book[] booksprice = library.GetFilteredBooks(12, 14);

            for(int i = 0;i < booksprice.Length;i++)
            {
                booksprice[i].ShowInfo();
            }



        }
    }
}
