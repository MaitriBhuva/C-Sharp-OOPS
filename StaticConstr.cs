//static constructor is used to initialize static data members of a class.
//static data is shared among all the objects of the class.
//static constructor is called only once, when the class is loaded.
//static constructor does not take any access modifier.
//static constructor does not take any parameter.
//it is autoatically called by the runtime before any static members are accessed.
//syntax: static ClassName(){ //initialize static data members }

namespace day2;

public class StaticConstr
{
    public static string CarMake;

    // static constructor
    static StaticConstr()
    {
        CarMake = "Toyota";
    }

    //instance constructor
    public StaticConstr()
    {
        Console.WriteLine("Instance constructor called");
    }

    //method to display the car make
    public void DisplayCarInfo()
    {
        Console.WriteLine($"Car Make: {CarMake}");
    }
}
