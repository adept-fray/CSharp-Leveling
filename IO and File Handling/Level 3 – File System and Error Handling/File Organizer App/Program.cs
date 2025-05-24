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


    string directoryName = extensionAndFolderDict.GetValueOrDefault(extension);
    if (directoryName is null)
        continue;

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

    try
    {
        if (File.Exists(newFilePath))
        {
            Console.WriteLine($"Skipped (already exists): {newFilePath}");
            continue;
        }
        File.Move(file, newFilePath);
    }
    catch (UnauthorizedAccessException unauthex)
    {
        Console.WriteLine($"Access denied: {newFilePath}");
    }
    catch (DirectoryNotFoundException direx)
    {
        Console.WriteLine($"Directory not found: {newFilePath}, {direx.Message}");
    }
    catch (IOException ioex)
    {
        Console.WriteLine($"IO error for {newFilePath}: {ioex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Unexpected error for {filename}: {ex.Message}");
    }
}

Console.WriteLine("File organization complete.");
Console.ReadKey();