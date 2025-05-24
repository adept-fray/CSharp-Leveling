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


Dictionary<string, string> extensionAndFolderDict = new();
extensionAndFolderDict.Add(".txt", "TextFiles");
extensionAndFolderDict.Add(".jpg", "Images");
extensionAndFolderDict.Add(".jpeg", "Images");
extensionAndFolderDict.Add(".png", "Images");
extensionAndFolderDict.Add(".cs", "CSharpFiles");

List<string> files = new(Directory.GetFiles(directoryPath));
foreach (string file in files)
{
    Console.WriteLine(file);
    string extension = Path.GetExtension(file).ToLower();
    Console.WriteLine(extension);

    if (!extensions.Contains(extension))
    {
        continue;
    }


    string directoryName = extensionAndFolderDict.GetValueOrDefault(extension);
    if (directoryName is null)
        directoryName = "OtherFiles";

    string currentDirectory = Path.GetDirectoryName(file);
    string newDirectory = Path.Combine(currentDirectory, directoryName);
    Console.WriteLine("newDirectory: " + newDirectory);
    if (!Directory.Exists(newDirectory))
    {
        Directory.CreateDirectory(newDirectory);
    }

    string filename = Path.GetFileName(file);
    Console.WriteLine("filename: " + filename);

    string newFilePath = Path.Combine(newDirectory, filename);
    Console.WriteLine("newFilePath: " + newFilePath);
    File.Move(file, newFilePath);
}

Console.ReadKey();