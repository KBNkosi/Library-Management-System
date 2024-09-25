namespace LibrarySystemManagement;

public abstract class User
{
    //Initializing variables
    private int Id{get; set;}
    private string Name{get; set;}
    private string Email{get; set;}
    public string Password{get; set;}
    
    //Constructor
    protected User(int id, string name, string email, string password)
    {
        Id = id;
        Name = name;
        Email= email;
        Password = password;
    }

    //Method to display user information
    public virtual void DisplayUserInfo()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}, Email: {Email}");
    }
}