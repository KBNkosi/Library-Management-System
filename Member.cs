namespace LibrarySystemManagement;

public class Member : User
{
    private Library _library;
    public Member(int id, string name, string email, string password, Library library) : base(id, name, email, password)
    {
       _library=library;
    }
    
    //Method to borrow a book
    public bool BorrowBook(Book book)
    {
        if (book.IsBorrowed)
        {
            Console.WriteLine("Book is currently borrowed");
            return false;
        }
        else
        {
            book.IsBorrowed = true;
            _library.BorrowedBooks.Add(book);
            Console.WriteLine($"Book '{book.Title}' has been successfully borrowed");
            return true;
        }
    }
    
    //Method to return a book
    public bool ReturnBook(Book book)
    {
        if (_library.BorrowedBooks.Contains(book))
        {
            book.IsBorrowed = false;
            _library.BorrowedBooks.Remove(book);
            return true;
        }
        else
        {
            Console.WriteLine($"Book '{book.Title}' is not borrowed");
            return false;
        }
    }
}