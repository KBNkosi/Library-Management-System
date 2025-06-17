// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata.Ecma335;
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
       //Create user instance
        Member member = new Member(1,"John","Member",LibraryInstance);
        Librarian librarian = new Librarian(2,"Mack","Librarian");
        Admin admin = new Admin(3,"Dan","Admin",LibraryInstance);
        //Add users to library
        //LibraryInstance.Users.Add(member);
        //LibraryInstance.Users.Add(librarian);
        LibraryInstance.Users.Add(admin);
        
        Book book1 = new Book(1, "To kill or not to kill", "Harper lee", 12345, 1945)
            {BorrowDate = DateTime.Now.AddDays(-15), IsBorrowed = true};
        Book book2 = new Book(2, "1984", "George Orwell",54321, 9875)
            { BorrowDate = DateTime.Now.AddDays(-5), IsBorrowed = true };
        LibraryInstance.BorrowedBooks.AddRange(new[] { book1, book2 });

        
        //Start threads for borrowing and returning books
        var memberTasks = new Thread(() => ProcessMemberActions(member, book1, book2));
        
        memberTasks.Start();
        memberTasks.Join();
        
        //Check for overdue books and notify members
        LibraryInstance.CheckForOverdueBooks();
        
    }

    private static void ProcessMemberActions(Member member, Book book1, Book book2)
    {
        //Borrow books
        member.BorrowBook(book1);
        member.BorrowBook(book2);
        
        //Display borrowed books
        member.DisplayBorrowedBooks();
        
        //Return books
        member.ReturnBook(book1);
        member.ReturnBook(book2);
    }
}