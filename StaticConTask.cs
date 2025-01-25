namespace day2;

public class Library
{
    public static int TotalBooks;

    // static constructor
    static Library()
    {
        TotalBooks = 0;
        Console.WriteLine("Library initialized");   
    }

    //non static method to add books
    public void AddBooks(int books)
    {
        TotalBooks += books;
    }

    //static method to display total books
    public static void DisplayTotalBooks()
    {
        Console.WriteLine($"Total books in library: {TotalBooks}");
    }


}
