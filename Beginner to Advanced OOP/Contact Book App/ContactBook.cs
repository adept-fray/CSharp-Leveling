namespace ContactBookApp;

class ContactBook
{
    private readonly List<Contact> contacts = new List<Contact>();

    public void AddContact(string name, string phone, string email)
    {
        Contact newContact = new Contact(name, phone, email);
        contacts.Add(newContact);
    }

    public void ViewContacts()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts found");
            return;
        }

        foreach (Contact contact in contacts)
        {
            contact.Display();
        }
    }

    public List<Contact> SearchByName(string name)
    {
        return contacts.Where(c => c.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}