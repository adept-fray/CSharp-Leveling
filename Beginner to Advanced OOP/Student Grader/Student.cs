namespace StudentGraderAPP;

class Student
{
    public string Name { get; set; }
    public List<int> Grades { get; set; } = new List<int>();

    public Student(string name)
    {
        Name = name;
    }

    public double GetAverageGrade()
    {
        if(Grades.Count == 0)
            return 0;

        return Grades.Average();
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Average Grade: {GetAverageGrade():F2}");
    }
}