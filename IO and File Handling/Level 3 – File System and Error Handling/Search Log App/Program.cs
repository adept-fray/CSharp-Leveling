Console.WriteLine("Search Log App");
Console.WriteLine("Search for a keyword in a log file.");

Console.WriteLine("Write absolute file name: ");
string filepath = Console.ReadLine();

Console.WriteLine("Write search keyword: ");
string keyword = Console.ReadLine();


try
{
    using (StreamReader sr = new StreamReader(filepath))
    {
        string line;
        while ((line = sr.ReadLine()) != null)
        {
            if (line.Contains(keyword))
                Console.WriteLine(line);
        }
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Error: The specified file was not found.");
}
catch (UnauthorizedAccessException ex)
{
    Console.WriteLine($"Error: You do not have permission to read this file.");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Error: the directory for this file does not exist.");
}
catch (IOException ex)
{
    Console.WriteLine($"IO Error: {ex.Message}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: The file path format is invalid.");
}
catch (Exception ex)
{
    Console.WriteLine($"Unexpected error: {ex.Message}");
}

Console.ReadKey();