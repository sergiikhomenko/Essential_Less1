namespace Tassk_3;

public class AuthorBook
{
    private string author;

    public string Author
    {
        set { author = value; }
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(author);
    }
}