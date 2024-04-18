namespace Tassk_3;

public class ContentBook
{
    private string content;

    public string Content
    {
        set
        {
            content = value;
        }
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(content);
    }
}