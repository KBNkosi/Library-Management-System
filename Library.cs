using Newtonsoft.Json;
using System.Threading;

namespace LibrarySystemManagement;

public class Library
{
    //Initializing variables
    public List<Book> Books { get; set; }
    public List<Book> BorrowedBooks { get; set; }  
    public List<User> Users { get; set; }
    
    //Lock object for thread-safety
    private readonly object _lockObj = new object(); 
   
    
    
    //Constructor
    public Library()
    {
        Books = new List<Book>();
        BorrowedBooks = new List<Book>();
        Users = new List<User>();
       
    }
    // Display books
    public void DisplayBooks()
    {
        if (Books == null)
        {
            Console.WriteLine("There are no books");
            return;
        }
        else
        {
            Console.WriteLine("Books are:");
            foreach (var book in Books)
            {
                Console.WriteLine($"- {book.Title} by {book.Author}");
            }
        }
    }
    
    //Method to display users
    public void DisplayUsers()
    {
        if (Users.Count == 0)
        {
            Console.WriteLine("There are no Users");
            return;
        }
        else
        {
            Console.WriteLine("Users are:");
            foreach (var user in Users)
            {
                Console.WriteLine($"User id: {user.Id} User Name: {user.Name} User Role: {user.Role}");
            }
        }
    }
    
    //Add a new book 
    public void AddBook(Book book)
    {
        Books.Add(book);
    }
    
    //Remove a book
    public void RemoveBook(Book book)
    {
        Books.Remove(book);
    }
 
    //Method for borrowing books
    public bool TryBorrowBook(Book book)
    {
        lock (_lockObj)
        {
            if (book.IsBorrowed)
            {
                Console.WriteLine("Book is already borrowed");
                return false;
            }
            book.IsBorrowed = true;
            BorrowedBooks.Add(book);
            return true;
            
        }
    }
    
    //Method for returning books
    public bool TryReturnBook(Book book)
    {
        lock (_lockObj)
        {
            if (!book.IsBorrowed)
            {
                Console.WriteLine("Book is not borrowed");
                return false;
            }

            book.IsBorrowed = false;
            BorrowedBooks.Remove(book);
            return true;
        }
    }
    
    
    //Save the book data to a file
    public void SaveBookData(string filePath)
    {
        try
        {
            var jsonData = JsonConvert.SerializeObject(Books, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
            Console.WriteLine("Book data saved successfully");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Failed to save book data: {ex.Message}");
        }
        
    }
    
    //Load the book data from a file
    public void LoadBookData(string filePath)
    {
        if (File.Exists(filePath))
        {
            var jsonData = File.ReadAllText(filePath);
            Books = JsonConvert.DeserializeObject<List<Book>>(jsonData) ?? new List<Book>();
        }
    }
    
    //Method to save user Data,
    public void SaveUserData(string filePath)
    {
        try
        {
            var jsonData = JsonConvert.SerializeObject(Users, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
            Console.WriteLine("User saved successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to save user data:{
                ex.Message
            }");
        }

    } //Method to
}