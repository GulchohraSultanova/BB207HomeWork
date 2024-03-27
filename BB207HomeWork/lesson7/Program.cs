using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Welcome GLibrary!--------------------");

            Library booksArray = new Library();
            Book book1 = new Book(100, 30, "Harry Potter", "14", "Adventure");
            Book book2 = new Book(50, 15, "Gurur ve Önyargi", "7", "Drama");

            booksArray.AddBook(book1);
            booksArray.AddBook(book2);

            Console.WriteLine();
            Console.WriteLine("-----------------All Books--------------------");
            booksArray.ShowAllBooks();

            Console.WriteLine();
            Console.WriteLine("-----------------Filtered By Genre--------------------");

            Book[] filteredBooksByGenre = booksArray.GetFilteredBooks("Drama");
            foreach (Book book in filteredBooksByGenre)
            {
                book.ShowInfo();
            }

            Console.WriteLine();
            Console.WriteLine("-----------------Filtered By Price--------------------");

            Book[] filteredBooksByPrice = booksArray.GetFilteredBooks(70, 150);
            foreach (Book book in filteredBooksByPrice)
            {
                book.ShowInfo();
            }
        }
    }
}
