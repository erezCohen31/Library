using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    // this class is used to save the status of the user
    internal class User
    {
        private string name;
        private int id;
        private int numOfBook;
        private List<Book> books;

        public User(string name, int id)
        {
            this.name = name;
            this.id = id;
            numOfBook = 0;
            books = new List<Book>();
        }

        public string GetName()
        {
            return name;
        }
        public int getId()
        {
            return id;
        }
        public int getNumOfBook()
        {
            return numOfBook;
        }
        public void AddBook(Book book)
        {
            books.Add(book);
            numOfBook++; 
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
            numOfBook--;
        }
    }
}
