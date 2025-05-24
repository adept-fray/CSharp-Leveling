Console.WriteLine("To-Do List app");
Console.WriteLine("a file-based task tracker.");

string fileName = "todo.txt";
string folderName = Environment.CurrentDirectory;
if (folderName.Contains("To-Do List App"))
{
    folderName = Directory.GetParent(@"../../../").FullName;
}

folderName = folderName.Replace("\\", "/");
string filePath = Path.Combine(folderName, fileName);

Console.ReadKey();