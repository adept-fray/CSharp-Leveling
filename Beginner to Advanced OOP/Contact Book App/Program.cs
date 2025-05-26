using ContactBookApp;
Console.WriteLine("Contact Book App");
Console.WriteLine("Create a class Contact with Name, Phone, Email.");

var contactBook = new ContactBook();


while (true)
{
    Console.WriteLine("\n--- Contact Book ---");
    Console.WriteLine("1. Add Contact");
    Console.WriteLine("2. View All Contacts");
    Console.WriteLine("3. Search Contact by Name");
    Console.WriteLine("4. Exit");
    Console.Write("Choose an option: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter phone: ");
            string phone = Console.ReadLine();

            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            contactBook.AddContact(name, phone, email);

            Console.WriteLine("Contact added successfully!");
            break;
        case "2":
            contactBook.ViewContacts();
            break;
        case "3":
            Console.Write("Enter name to search: ");
            string nameToSearch = Console.ReadLine();

            var results = contactBook.SearchByName(nameToSearch);
            if (results.Count == 0)
            {
                Console.WriteLine("No contacts found with that name.");
                return;
            }

            foreach (var contact in results)
            {
                contact.Display();
            }
            break;
        case "4":
            return;
        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}