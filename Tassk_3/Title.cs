namespace Tassk_3;

public class TitleBook
{
    private string title;
    
    public string Title
    {
        set { title = value; }
    }
    
    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(title);
    }
}