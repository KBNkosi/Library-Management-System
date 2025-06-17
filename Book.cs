using System.Runtime.InteropServices.JavaScript;

namespace LibrarySystemManagement;

public class Book
{
    //Initialize variables
    public int Id { get; set; }
    public string Title { get; set; } 
    public string Author { get; set; } 
    public int Isbn { get; set; }
    public int PublicationYear { get; set; }
    
    public DateTime BorrowDate { get; set; }
    public bool IsBorrowed { get; set; }

    //Constructor
    public Book(int id,string title,string author,int isbn, int publicationYear)
    {
        Id = id;
        Title=title;
        Author=author;
        Isbn = isbn;
        PublicationYear = publicationYear;
        IsBorrowed = false;
    }
    
    public bool IsOverdue()
    {
        // Assuming a book is overdue if borrowed for more than 14 days
        return IsBorrowed && (DateTime.Now - BorrowDate).TotalDays > 14;
    }
  
}