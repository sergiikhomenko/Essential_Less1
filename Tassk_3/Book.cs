namespace Tassk_3;

public class Book
{
    private AuthorBook _authorBook = new AuthorBook();
    private ContentBook _contentBook = new ContentBook();
    private TitleBook _titleBook = new TitleBook();

    public Book(string author, string content, string title)
    {
        _authorBook.Author = author;
        _titleBook.Title = title;
        _contentBook.Content = content;
    }

    public void Show()
    {
        _titleBook.Show();
        _authorBook.Show();
        _contentBook.Show();
    }
}