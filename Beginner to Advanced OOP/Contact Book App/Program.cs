Console.WriteLine("Contact Book App");
Console.WriteLine("Create a class Contact with Name, Phone, Email.");

class Contact
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public Contact(string name, string phone, string email)
    {
        Name = name;
        Phone = phone;
        Email = email;
    }
    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Phone: {Phone}, Email: {Email}");
    }
}

List<Contact> contacts = new List<Contact>()
{
    new Contact
    {
        Name = "name1",
        Phone = "phone1",
        Email = "email1"
    },
    new Contact {
        Name = "name2",
        Phone = "phone2",
        Email = "email2"
    }
};
