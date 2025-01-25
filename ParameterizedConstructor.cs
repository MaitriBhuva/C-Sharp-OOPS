//parameterized constructor = A parameterized constructor is a constructor that takes parameters.
// You can define a parameterized constructor in your class to initialize the object's properties with the values you provide.
// When you create an object, you can pass arguments to the constructor to set the object's properties to specific values.
// If you define a parameterized constructor in your class, the default constructor is not provided automatically.
// If you want to provide a default constructor as well, you need to define it explicitly.


namespace day2;

public class ParameterizedConstructor
{
    public string CarMake;
    public string CarModel;

    public int Year;
    public string Color;

    public ParameterizedConstructor(string make, string model, int year, string color)
    {
        CarMake = make;
        CarModel = model;
        Year = year;
        Color = color;
    }

    public void DisplayCarInfo()
    {
        Console.WriteLine($"Car Make: {CarMake}, Car Model: {CarModel}, Year: {Year}, Color: {Color}");
    }
}
