string fileName = "notes.txt";

string folderName = Environment.CurrentDirectory;
folderName = Directory.GetParent(@"../../../").FullName;
folderName = folderName.Replace("\\", "/");

string path = Path.Combine(folderName, fileName);


Console.WriteLine("Note Taker App");
Console.WriteLine("Save and read notes from a file.");


Console.WriteLine("1. for writing note.");
Console.WriteLine("2. for listing all notes.");
string option = Console.ReadLine();
if (option == "1")
{
    Console.WriteLine("Write your note:");
    string note = Console.ReadLine();
    note = note + "\n";

    if (File.Exists(path))
        File.AppendAllText(path, note);
    else
    {
        Console.WriteLine("File does not exist. " + path);
        File.WriteAllText(path, note);
    }
}
else if (option == "2")
{
    if(File.Exists(path))
    {
        foreach(string note in File.ReadAllLines(path))
        {
            Console.WriteLine($"{note}");
        }
    }
    else
    {
        Console.WriteLine("There are not notes.");
    }
}
else
{
    Console.WriteLine("Uknown command / Incorrect option");
}

Console.ReadKey();