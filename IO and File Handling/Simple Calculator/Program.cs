Console.WriteLine("Simple Calculator");
Console.WriteLine("Write two numbers and one operator");

Console.WriteLine("First number: ");
string fNum = Console.ReadLine();
int firstNumber = int.Parse(fNum);

Console.WriteLine("Second number: ");
string sNum = Console.ReadLine();
int secondNumber = int.Parse(sNum);

Console.WriteLine("Operator: ");
string op = Console.ReadLine();

int result = 0;
if (op == "+")
    result = firstNumber + secondNumber;
if (op == "-")
    result = firstNumber - secondNumber;
if (op == "*")
    result = firstNumber * secondNumber;
if (op == "/")
    result = firstNumber / secondNumber;

string output = $"Result is: {result}";
Console.WriteLine(output);

Console.ReadKey();