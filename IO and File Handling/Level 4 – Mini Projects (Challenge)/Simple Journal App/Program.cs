Console.WriteLine("Simple Journal App");
Console.WriteLine("Write daily entries.");


string currentDirectory = Environment.CurrentDirectory;
if(currentDirectory.Contains("Simple Journal App"))
{
    currentDirectory = Directory.GetParent(@"../../../").FullName;
}

Console.WriteLine("Write Entry:");
string entry = Console.ReadLine();
if (string.IsNullOrWhiteSpace(entry))
{
    Console.WriteLine("can not save empty. Exiting.");
    Console.ReadKey();
    return;
}
var now = DateTime.UtcNow;
DateOnly date = new DateOnly(now.Year, now.Month, now.Day);

string filePath = Path.Join(currentDirectory,date.ToString() + ".txt");
List<string> contents = new List<string> { entry };
File.AppendAllLines(filePath, contents);


Console.WriteLine("Exiting.");
Console.ReadKey();