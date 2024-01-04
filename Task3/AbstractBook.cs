
public abstract class AbstractBook : Readable
{
    public string Title;
    public string Author;

    public AbstractBook(string title, string author)
    {
        Title = title;
        Author = author;
    }
    public string GetTitle()
    {
        return Title;
    }
    public void SetTitle(string title)
    {
        Title = title;
    }
    public string GetAuthot()
    {
        return Author;
    }
    public void SetAuthor(string author)
    {
        Author = author;
    }
    public void Read()
    {
        System.Console.WriteLine("Reading");
    }
       
}
