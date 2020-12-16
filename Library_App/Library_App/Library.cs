using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_App
{
    public class Library
    {
        private string name;

        private List<Book> books;

        public Library(string name)
        {
            this.name = name;
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public bool RemoveBook(int id)
        {
            for (int i = 0; i < books.Count; i++)
            {

                if (books.ElementAt(i).ID == id)
                {
                    books.RemoveAt(i);
                    return true;
                }

            }
            return false;
        }

        public Book GetBookById(int id)
        {
         
            for(int i = 0; i < books.Count; i++)
            {
            
                if (books.ElementAt(i).ID == id)
                {
                    return books.ElementAt(i);
                }
                
            }
            return null;
            
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public List<Book> GetAllAvailableBooks()
        {
            List<Book> result = new List<Book>();
            foreach(Book b in books)
            {
                if (!b.Borrowed)
                {
                    result.Add(b);
                }
            }
            return result;
        }

        public List<Book> GetAllBorrowedBooks()
        {
            List<Book> result = new List<Book>();
            foreach (Book b in books)
            {
                if (b.Borrowed)
                {
                    result.Add(b);
                }
            }
            return result;
        }
    }
}
