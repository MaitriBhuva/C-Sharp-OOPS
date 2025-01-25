//access modifier = determines the visibility of a classes, fields, methods and other members
//public, private, protected, internal, protected internal
//public = accessible from any other class
//private = accessible only within the class where it is declared
//protected = accessible only within the class where it is declared and in derived classes
//internal = accessible only within the same assembly(assembly is a .dll or .exe file)
//protected internal = accessible within the same assembly and from a derived class


//public vs private
namespace day2;

public class AccessModifiers
{
    //public property
    public string Name;

    //private property
    private int Age;

    //method to set the value of private property
    public void SetAge(int age)
    {
        if (age < 0)
        {
            Console.WriteLine("Age cannot be negative");
        }
        else
        {
            Age = age;
        }
    }

    //method to get the value of private property
    public int GetAge()
    {
        return Age;
    }
    
    //method to display details
    public void DisplayDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}
