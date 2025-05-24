Console.WriteLine("Search Log App");
Console.WriteLine("Search for a keyword in a log file.");

Console.WriteLine("Write absolute file name: ");
string filepath = Console.ReadLine();

Console.WriteLine("Write search keyword: ");
string keyword = Console.ReadLine();

if (!File.Exists(filepath))
{
    Console.WriteLine($"File does not exist.");
    Console.WriteLine($"filename: {filepath}");
    return;
}
