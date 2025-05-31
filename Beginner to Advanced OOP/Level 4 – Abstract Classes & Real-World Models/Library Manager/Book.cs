namespace LibraryManagerApp;

public class Book : Item
{
    public Book(string name, string status) : base(name, status)
    {

    }


    public override void DisplayInfo()
    {
        Console.WriteLine($"Book's name: {Name}");
    }
}