using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_8_oop
{
    public class LibraryService
    {
        private List<Book> books;
        public LibraryService()
        {
            books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public List<Book> SearchByTitle(string title)
        {
            List<Book> result = new List<Book>();
            foreach (Book book in books)
            {
                if (book.Title == title)
                {
                    result.Add(book);
                }
            }
            return result;
        }

        public List<Book> SearchByAuthor(string author)
        {
            List<Book> result = new List<Book>();
            foreach (Book book in books)
            {
                if (book.Author == author)
                {
                    result.Add(book);
                }
            }
            return result;
        }
    }
}
