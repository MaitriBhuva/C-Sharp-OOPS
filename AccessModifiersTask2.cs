using System.Xml.Serialization;

namespace day2;

public class Employee
{
    //private field
    private int employeeId;

    private double salary;

    //public propert 
    public string Name;

    //public method to set salary 
    public void SetSalary(double salary)
    {
        if (salary < 0)
        {
            Console.WriteLine("Salary Cannot be nagative");
        }
        else
        {
            this.salary = salary;
        }
    }

    //public method to display emploee name and salary amd hide employee id
    public void DisplayEmployeeInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Salary: " + salary);
    }

}
