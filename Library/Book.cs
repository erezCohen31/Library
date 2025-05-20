using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    // this class is used to save the status of the book
    internal class Book
    {
        private string title;
        private string author;
        private int isbn;
        private bool isAvailable;
        private DateTime dateOfBorrowed;
        private DateTime dateOfReturn;

        public Book(string title, string author, int isbn)
        {
            this.author = author;
            this.title = title;
            this.isbn = isbn;
            isAvailable = true;
        }


        public string GetTitle()
        {
            return this.title;
        }
        public string getAuthor()
        {
            return this.author;
        }
        public int getIsbn()
        {
            return this.isbn;
        }
        public void SetIsAvailable(bool isAvaiable)
        {
            this.isAvailable = isAvaiable;
        }
        public bool IsAvaiable()
        {
            return this.isAvailable;
        }
        public DateTime GetDateOfBorrowed()
        {
            return this.dateOfBorrowed;
        }
        public DateTime GetDateOfReturn()
        {
            return this.dateOfReturn;
        }
        public void SetDateOfBorrowed()
        {
            this.dateOfBorrowed = DateTime.Now;
        }
        public void SetDateOfReturn(int day)
        {
            this.dateOfReturn = dateOfBorrowed.AddDays(day);
        }

    }
}
