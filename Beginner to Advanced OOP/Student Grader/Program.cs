using StudentGraderAPP;

Console.WriteLine("Student Grader");
Console.WriteLine("Track students and their average grades.");

StudentGrader studentGrader = new StudentGrader();

void AddStudent()
{
    Console.Write("Enter name: ");
    string name = Console.ReadLine();

    Console.Write("Enter grades with comma(,) in between: ");
    string grades = Console.ReadLine();
    string[] gradesArray = grades.Split(",");
    List<int> gradesList = gradesArray.Select(g => int.Parse(g)).ToList();

    studentGrader.AddStudent(name, gradesList);
}


while (true)
{
    Console.WriteLine("\n--- Student Grader ---");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. View All Students Average");
    Console.WriteLine("3. Exit");
    Console.Write("Choose an option: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            AddStudent();
            break;
        case "2":
            studentGrader.DisplayAllStudents();
            break;
        case "3":
            return;
        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}