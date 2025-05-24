Console.WriteLine("File Organizer App");

Console.WriteLine("Write a directory path to orginize its contents.");
string directoryPath = Console.ReadLine();

if (!Directory.Exists(directoryPath))
{
    Console.WriteLine("Directory does not exists. exiting now.");
    Console.WriteLine("Your directory path: " + directoryPath);
    Console.ReadKey();
    return;
}

Console.ReadKey();