// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices.ComTypes;
using LibrarySystemManagement;

internal class Program
{
    public static void Main(string[] args)
    {
        Library library = new Library();
        Member member = new Member(1,"john","john@gmail.com","john123",library);

        Book book1 = new Book(1, "To kill or not to kill", "Harper lee", 12345, 1945);
        Book book2 = new Book(1, "1984", "George Orwell",54321, 9875);

        Console.WriteLine("Member borrows book");
        member.BorrowBook(book1);
        member.BorrowBook(book2);
        member.BorrowBook(book1);
        
        Console.WriteLine("Display borrowed books");
        library.DisplayBorrowedBooks();

        Console.WriteLine("Member returns books");
        member.ReturnBook(book1);
        member.ReturnBook(book1);
        Console.WriteLine("Display borrowed books after returns");
        library.DisplayBorrowedBooks();
    }
}