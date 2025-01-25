namespace day2;

public class Student
{
    public string Name;
    public int RollNumber;

    public string Grade;

    //parameterized constructor
    public Student(string name, int rollNumber, string grade)
    {
        Name = name;
        RollNumber = rollNumber;
        Grade = grade;
    }

    //copy constructor
    public Student(Student student)
    {
        Name = student.Name;
        RollNumber = student.RollNumber;
        Grade = student.Grade;
    }

    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Name: {Name}, Roll Number: {RollNumber}, Grade: {Grade}");
    }
}
