namespace LibraryManagerApp;

public class DVD : Item
{
    public DVD(string name, string status) : base(name, status)
    {

    }


    public override void DisplayInfo()
    {
        Console.WriteLine($"DVD's name: {Name}");
    }
}