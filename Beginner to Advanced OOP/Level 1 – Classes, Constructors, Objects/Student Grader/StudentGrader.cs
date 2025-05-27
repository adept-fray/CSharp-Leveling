namespace StudentGraderAPP;

class StudentGrader
{
    private readonly List<Student> students = new List<Student>();

    public void AddStudent(string name, List<int> grades)
    {
        Student student = new Student(name);
        student.Grades.AddRange(grades);
        students.Add(student);
    }

    public void DisplayAllStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return ;
        }

        foreach(var student in students)
        {
            student.Display();
        }
    }
}