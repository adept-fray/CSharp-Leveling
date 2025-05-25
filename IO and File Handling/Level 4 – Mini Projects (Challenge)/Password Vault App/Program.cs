using System.Data.Common;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;
using System.Text.Json.Nodes;


Console.WriteLine("Password Vault App");
Console.WriteLine("Store username/password securely.");

string currentDirectory = Environment.CurrentDirectory;
if (currentDirectory.Contains("Password Vault App"))
{
    currentDirectory = Directory.GetParent(@"../../../").FullName;
}

Console.WriteLine("************");
Console.WriteLine("currentDirectory: " + currentDirectory);
Console.WriteLine("************");

const string fileName = "passwordstorage.json";
string filePath = Path.Combine(currentDirectory, fileName);
Console.WriteLine("************");
Console.WriteLine("filePath: " + filePath);
Console.WriteLine("************");


string Base64Encode(string plainText)
{
    var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
    return System.Convert.ToBase64String(plainTextBytes);
}

string Base64Decode(string base64EncodedData)
{
    var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
}

string GetCredentials()
{
    Console.WriteLine("Write your website:");
    string website = Console.ReadLine();

    Console.WriteLine("Write your username:");
    string username = Console.ReadLine();

    Console.WriteLine("Write your password:");
    string password = Console.ReadLine();



    return Base64Encode(JsonSerializer.Serialize(new { website = website, username = username, password = password }));
}

void WriteToFile(string filePath, string jsonString)
{
    using (StreamWriter sw = new StreamWriter(filePath))
    {
        sw.WriteLine(jsonString);
    }
}

Console.WriteLine("1. Write your credentials.");
Console.WriteLine("2. List your credentials.");
Console.WriteLine("3. Search your credentials.");
string choice = Console.ReadLine();
try
{
    if (choice == "1")
    {
        string jsonString = GetCredentials();
        WriteToFile(filePath, jsonString);
    }
    else if (choice == "2")
    {
        int count = 0;
        foreach (var line in File.ReadAllLines(filePath))
        {
            Console.WriteLine($"{count}. {Base64Decode(line)}");
        }
    }
    else if (choice == "3")
    {
        Console.WriteLine("Write your search word:");
        string search = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(search))
        {
            throw new Exception("can not search empty word.");
        }

        foreach (var line in File.ReadAllLines(filePath))
        {
            string decoded = Base64Decode(line);
            if (decoded.Contains(search))
                Console.WriteLine(decoded);
        }

        Console.WriteLine("End of search.");
    }
    else
    {
        Console.WriteLine("Not valid option.");
    }
}
catch (UnauthorizedAccessException ex)
{
    Console.WriteLine($"Error: not authorized: {ex.Message}");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Error: file not found: {ex.Message}");
}
catch (FileLoadException ex)
{
    Console.WriteLine($"Error: could not load file: {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Error: Directory not exist: {ex.Message}");
}
catch (IOException ex)
{
    Console.WriteLine($"Error: IO: {ex.Message}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: file path is in wrong format: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Something went wrong: {ex.Message}");
}
Console.ReadKey();
