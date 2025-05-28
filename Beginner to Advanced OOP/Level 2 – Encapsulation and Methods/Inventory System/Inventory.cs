namespace InventorySystemApp;

class Inventory
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
        Console.WriteLine("Product added.");
    }

    public void UpdateProduct(int id, string name, decimal price, int quantity)
    {
        var product = products.FirstOrDefault(product => product.Id == id);
        if (product is not null)
        {
            product.Price = price;
            product.Quantity = quantity;
            product.Name = name;
            Console.WriteLine("Product updated.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    public void RemoveProduct(int id)
    {
        var product = products.FirstOrDefault(p => p.Id == id);
        if (product is not null)
        {
            products.Remove(product);
            Console.WriteLine("Product removed.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    public void DisplayProducts()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No products in inventory.");
            return;
        }

        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }

    public void DisplayTotalValue()
    {
        decimal total = products.Sum(p => p.TotalValue);
        Console.WriteLine($"Total inventory value: {total:C}");
    }
}