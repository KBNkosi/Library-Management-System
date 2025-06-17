namespace LibrarySystemManagement;

public class Member : User
{
    private readonly Library _library;
    
    public Member(int id, string name, string role, Library library) : base(id, name, role)
    {
       _library=library ?? throw new ArgumentNullException(nameof(library));
       _library.OverdueBooksEvent += HandleOverdueBooksEvent;
    }
    
    private void HandleOverdueBooksEvent(object sender, OverdueBooksEventArgs e)
    {
        Console.WriteLine($"Notification for {Name}: The following books are overdue:");
        foreach (var book in e.OverdueBooks)
        {
            Console.WriteLine($"- {book.Title} by {book.Author}");
        }
    }
    
    //Method to borrow a book
    public bool BorrowBook(Book book)
    {
        if (_library.TryBorrowBook(book))
        {
            Console.WriteLine($"Book '{book.Title}' is successfully borrowed");
            return true;
        }
        else
        {
            Console.WriteLine($"Book '{book.Title}' is already borrowed");
            return false;
        }
       
    }

    //Method to display Borrowed Books
    public void DisplayBorrowedBooks()
    {
        lock (_library)
        {
            if (_library.BorrowedBooks.Count == 0)
            {
                Console.WriteLine("There are no borrowed books");
                return;
            }

            Console.WriteLine($"Borrowed books are:");
            foreach (var book in _library.BorrowedBooks)
            {
                    Console.WriteLine(book.Title);
                }
            
        }
       
    }
    
    //Method to return a book
    public bool ReturnBook(Book book)
    {
        if (_library.TryReturnBook(book))
        {
            Console.WriteLine($"Book '{book.Title}' is successfully returned");
            return true;
        }
        else
        {
            Console.WriteLine($"Book '{book.Title}' is not borrowed by this member");
            return false;
        }
    }
}