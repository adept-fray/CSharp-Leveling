Console.WriteLine("What is your name?");
string name = Console.ReadLine();

Console.WriteLine("What is your age?");
int age = int.Parse(Console.ReadLine());

Console.WriteLine($"Hello {name}, you are {age} years old.");

Console.ReadKey();