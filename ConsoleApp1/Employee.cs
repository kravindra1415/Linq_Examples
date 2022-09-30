// See https://aka.ms/new-console-template for more information
class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    //public List<string>? Programming { get; set; }
    //public List<Tech> Programming { get; set; }
}


class Tech
{
    public string Technology { get; set; }
}

class Student
{
    public int StudentId { get; set; }
    public string? Semail { get; set; }
    public string? FullName { get; set; }
}

class StudentInfo
{
    public string Name { get; set; }
    public double Marks { get; set; }

    //public List<Subject> Subjects { get; set; }
}

class Subject
{
    public string SubjectName { get; set; }
    public int SubjectMarks { get; set; }
}