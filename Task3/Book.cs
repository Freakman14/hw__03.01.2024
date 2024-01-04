public class Book : AbstractBook, Borrowable
{
    public Book(string title, string author) : base(title, author)
    {
    }
    public void Borrow()
    {
        System.Console.WriteLine("Взята в Аренду");
    }
    public void ReturnBook()
    {
        System.Console.WriteLine("Книга возвращена");
    }
}