// Copy constructor is a special type of constructor which takes an object as a parameter and creates a new object which is a copy of the object passed as a parameter.
// Create new object by copying the values of an existing object.
//C# does not support copy constructors. You can achieve the same functionality by creating a method that takes an object as a parameter and copies its values to a new object.
//Syntax: public ClassName(ClassName other){ // copy values from obj to this }

namespace day2;

public class CopyConstr
{
    public string CarMake;
    public string CarModel;

    public string OwnerName;
    public int Age;

    //parameterized constructor
    
    public CopyConstr(string make, string model, string name, int age)
    {
        CarMake = make;
        CarModel = model;

        OwnerName = name;
        Age = age;
    }
    // Copy constructor
    public CopyConstr(CopyConstr Copy2)
    {
        CarMake = Copy2.CarMake;
        CarModel = Copy2.CarModel;

        OwnerName = Copy2.OwnerName;
        Age = Copy2.Age;
    }

    //method to display the details of the object
    public void DisplayCarInfo()
    {
        Console.WriteLine($"Car Make: {CarMake}, Car Model: {CarModel}, Owner Name: {OwnerName}, Age: {Age}");
    }
}
