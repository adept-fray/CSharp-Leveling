using InventorySystemApp;

Console.WriteLine("Inventory System App");

Inventory inventory = new Inventory();
bool running = true;

while (running)
{
    Console.WriteLine("\n1. Add Product\n2. Update Product\n3. Remove Product\n4. Display Products\n5. Total Inventory Value\n6. Exit");
    Console.Write("Choose an option: ");
    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            inventory.AddProduct(new Product(id, name, price, quantity));
            break;

        case "2":
            Console.Write("Enter ID of product to update: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Enter New Name: ");
            name = Console.ReadLine();

            Console.Write("Enter New Price: ");
            price = decimal.Parse(Console.ReadLine());

            Console.Write("Enter New Quantity: ");
            quantity = int.Parse(Console.ReadLine());

            inventory.UpdateProduct(id, name, price, quantity);
            break;

        case "3":
            Console.Write("Enter ID of product to remove: ");
            id = int.Parse(Console.ReadLine());
            inventory.RemoveProduct(id);
            break;

        case "4":
            inventory.DisplayProducts();
            break;

        case "5":
            inventory.DisplayTotalValue();
            break;

        case "6":
            running = false;
            break;

        default:
            Console.WriteLine("Invalid option. Try again.");
            break;
    }
}