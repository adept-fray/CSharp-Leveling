namespace LibraryManagerApp;

public abstract class Item
{
    public string Name { get; set; }
    public string Status { get; set; }
    public bool IsAvailable { get; private set; }

    public Item(string name, string status)
    {
        Name = name; 
        Status = status;
        IsAvailable = true;
    }

    public void CheckIn() => IsAvailable = false;
    public void CheckOut() => IsAvailable = true;

    public abstract void DisplayInfo();
}