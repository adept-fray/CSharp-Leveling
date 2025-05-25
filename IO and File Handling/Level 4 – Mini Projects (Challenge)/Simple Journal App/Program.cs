Console.WriteLine("Simple Journal App");
Console.WriteLine("Write daily entries.");


string currentDirectory = Environment.CurrentDirectory;
if(currentDirectory.Contains("Simple Journal App"))
{
    currentDirectory = Directory.GetParent(@"../../../");
}

