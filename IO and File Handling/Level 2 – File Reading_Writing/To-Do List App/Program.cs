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

void AddTask()
{
    Console.WriteLine("Write your task.");
    string task = Console.ReadLine();
    File.AppendAllText(filePath, task);
    File.AppendAllText(filePath, "\n");
}

Menu();

string option = Console.ReadLine();

if (option == "1")
{
    AddTask();
}
if (option == "2")
if (option == "3")
Console.ReadKey();