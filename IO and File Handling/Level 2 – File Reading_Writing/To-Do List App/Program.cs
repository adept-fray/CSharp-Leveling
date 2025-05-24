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

void Menu()
{
    Console.WriteLine("(1) Add task");
    Console.WriteLine("(2) Show tasks");
    Console.WriteLine("(3) Delete task");
}

Console.ReadKey();