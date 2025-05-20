using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    // this class is used to manage the library
    internal class Secretary
    {
        private List<Book> books;
        private List<User> users;

        public Secretary(List<Book> books, List<User> users)
        {
            this.books = books;
            this.users = users;
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }
        public void AddUser(User user)
        {
            users.Add(user);
        }
        public void RemoveUser(User user)
        {
            users.Remove(user);
        }
        public List<Book> GetBooks()
        {
            return books;
        }
        public List<User> GetUsers()
        {
            return users;
        }
        public void BorrowBook(User user, Book book,int day)
        {
            if (book.IsAvaiable())
            {

                user.AddBook(book);
                book.SetDateOfBorrowed();
                book.SetDateOfReturn(day);
                book.SetIsAvailable(false);
            }
            else
            {
                Console.WriteLine("book not avalaible");
            }
        }
        public void ReturnBook(Book book, User user)
        {
            user.RemoveBook(book);
            book.SetIsAvailable(true);
            if (book.GetDateOfReturn() < DateTime.Now)
            {
                Console.WriteLine("You are late");
            }
            else
            {
                Console.WriteLine("You are on time");
            }
        }
    }
}
