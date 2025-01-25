namespace day2;

public class Book
{
    public string Title;
    public string Author;
    public int Pages;

    //parameterized constructor to initialize the object's properties with the values you provide
    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    public void DisplayBookInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Pages: {Pages}");
    }
}
