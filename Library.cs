using Newtonsoft.Json;
namespace LibrarySystemManagement;

public class Library
{
    //Initializing variables
    public List<Book> Books { get; set; }
    public List<Book> BorrowedBooks { get; set; }
    
    
    //Constructor
    public Library()
    {
        Books = new List<Book>();
        BorrowedBooks = new List<Book>();
    }
    //Method to display borrowed books
    public void DisplayBorrowedBooks()
    {
        if (BorrowedBooks == null)
        {
            Console.WriteLine("There are no borrowed books");
            return;
        }
        else
        {
            Console.WriteLine("Books are:");
            foreach (var book in BorrowedBooks)
            {
                Console.WriteLine($"- {book.Title} by {book.Author}");
            }
        }
    }
    
    
    //Save the book data to a file
    public void SaveBookData(string filePath)
    {
        var jsonData = JsonConvert.SerializeObject(Books, Formatting.Indented);
        File.WriteAllText(filePath, jsonData);
    }
    
    //Load the book data from a file
}