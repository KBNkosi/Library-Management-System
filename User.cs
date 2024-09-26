using Console = System.Console;

namespace LibrarySystemManagement;

public abstract class User
{
    //Initializing variables
    public int Id{get; set;}
    public string Name{get; set;}
    public string Role{get; set;}
    
    //Constructor
    protected User(int id, string name, string role)
    {
        Id = id;
        Name = name;
        Role=role;
    }

    //Method to display user information
    public virtual void DisplayUserInfo()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}, Role: {Role}");
        
    }
    
    
}