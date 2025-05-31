namespace LibraryManagerApp;

public class LibraryManager
{
    public List<Item> items = new List<Item>()
    {
        new Book("book1", "in"),
        new Book("book2", "in"),
        new Book("book3", "in"),
        new DVD("DVD1", "in"),
        new DVD("DVD2", "in"),
        new DVD("DVD3", "in"),
    };

    public void Display()
    {
        foreach (var item in items)
        {
            item.DisplayInfo();
        }
    }
}