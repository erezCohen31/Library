using Library;




class program
{
    static void Main(string[] args)
    {
        // create a list of books
        List<Book> books = new List<Book>();
        // create a list of users
        List<User> users = new List<User>();
        // create a secretary
        Secretary secretary = new Secretary(books, users);
        // create a book
        Book book1 = new Book("book1", "author1", 123456);
        Book book2 = new Book("book2", "author2", 234567);
        Book book3 = new Book("book3", "author3", 345678);
        // add the book to the library
        secretary.AddBook(book1);
        secretary.AddBook(book2);
        secretary.AddBook(book3);
        // create a user
        User user1 = new User("user1", 1);
        User user2 = new User("user2", 2);
        // add the user to the library
        secretary.AddUser(user1);
        secretary.AddUser(user2);
        // borrow a book
        secretary.BorrowBook(user1, book1, 7);
        // print the user status
        Console.WriteLine("user1 num of books: " + user1.getNumOfBook());
        // return a book
        secretary.ReturnBook(book1, user1);
        // print the book status
        Console.WriteLine("book1 status: " + book1.IsAvaiable());

        // print the user status
        Console.WriteLine("user2 num of books: " + user2.getNumOfBook());
        // print the book status
        Console.WriteLine("book2 status: " + book2.IsAvaiable());

    }
}