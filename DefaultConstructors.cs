//Constructors are special methods that are called when an object is created.
// They are used to initialize the object's properties.
// A constructor is defined like a method, but it has the same name as the class and no return type.  
// Constructors can be overloaded, which means that you can define multiple constructors with different parameters.
// When you create an object, the appropriate constructor is called based on the arguments you provide.
// If you don't define a constructor in your class, a default constructor is provided automatically.

//types : Default constructor, Parameterized constructor, Copy constructor, Static constructor, Private constructor

// Default constructor
// A default constructor is a constructor that takes no parameters.
// If you don't define a constructor in your class, a default constructor is provided automatically.
// The default constructor initializes the object's properties to their default values.
// For example, if you have a class with a property of type int, the default constructor will initialize that property to 0.
// If you have a property of type string, the default constructor will initialize it to null.
// If you define a constructor with parameters, the default constructor is not provided automatically.

namespace day2;

public class DefaultConstructors
{
    public string CarMake;
    public string CarModel;

    public string Name;
    public int Age;

    // Default constructor
    public DefaultConstructors()
    {

        CarMake = "Toyota";
        CarModel = "Corolla";

        Name = "Maitri";
        Age = 21;
    }
}
