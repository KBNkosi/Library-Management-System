// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices.ComTypes;
using LibrarySystemManagement;

internal class Program
{
    //Initializing readonly filepath variables and library instance
    private static readonly Library LibraryInstance= new Library();
    private static readonly string BookDataFilePath = @"C:\Users\Dell\Documents\CsharpData\books.json";
    private static readonly string UserDataFilePath = @"C:\Users\Dell\Documents\CsharpData\users.json";
    public static void Main(string[] args)
    {
       
        Member member = new Member(1,"John","Member",LibraryInstance);
        Librarian librarian = new Librarian(2,"Mack","Librarian");
        
        LibraryInstance.Users.Add(member);
        LibraryInstance.Users.Add(librarian);
        
        LibraryInstance.DisplayUsers();
        

        Book book1 = new Book(1, "To kill or not to kill", "Harper lee", 12345, 1945);
        Book book2 = new Book(1, "1984", "George Orwell",54321, 9875);
        
       
        
        

    }
}