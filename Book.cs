namespace LibrarySystemManagement;

public class Book
{
    //Initialize variables
    public int Id { get; set; }
    public string Title { get; set; } 
    public string Author { get; set; } 
    public int Isbn { get; set; }
    public int PublicationYear { get; set; }
    public bool IsBorrowed=false;

    //Constructor
    public Book(int id,string title,string author,int isbn, int publicationYear)
    {
        Id = id;
        Title=title;
        Author=author;
        Isbn = isbn;
        PublicationYear = publicationYear;
    }
  
}