using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson7
{
    public class Library
    {
        Book[] books = new Book[0];

        public void AddBook(Book book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = book;
            Console.WriteLine($"Book {books.Length} is added! (Name: {book.Name})");
        }
        public Book[] GetFilteredBooks(string genre)
        {
            Book[] filterBooks = new Book[0];
            foreach (Book book in books)
            {
                if (book.Genre == genre)
                {
                    Array.Resize(ref filterBooks, filterBooks.Length + 1);
                    filterBooks[filterBooks.Length - 1] = book;
                }
            }
            return filterBooks;
        }
        public Book[] GetFilteredBooks(int minPrice, int maxPrice)
        {
            Book[] filterBooks = new Book[0];
            foreach (Book book in books)
            {
                if (book.Price >= minPrice && book.Price <= maxPrice)
                {
                    Array.Resize(ref filterBooks, filterBooks.Length + 1);
                    filterBooks[filterBooks.Length - 1] = book;
                }
            }
            return filterBooks;
        }
        public void ShowAllBooks()
        {
            foreach (Book book in books)
            {
                book.ShowInfo();
            }
        }
    }
}
