Console.WriteLine("Note Taker App");
Console.WriteLine("Save and read notes from a file.");

Console.WriteLine("Write your note:");
string note = Console.ReadLine();
note = note + "\n";

string fileName = "notes.txt";

string folderName = Environment.CurrentDirectory;
folderName = Directory.GetParent(@"../../../").FullName;
folderName = folderName.Replace("\\", "/");

string path = Path.Combine(folderName, fileName);

if (File.Exists(path))
    File.AppendAllText(path, note);
else
{
    Console.WriteLine("File does not exist. " + path);
    File.WriteAllText(path, note);
}

Console.ReadKey();