//private constructor = can't create object of class outside the class, can't inherit the class
// PrivateConstr myCar = new PrivateConstr();
//can't be called outside the class
//used in singleton design pattern to restrict the object creation
// syntax: private classname() { }


namespace day2;

//This code implements a Singleton design pattern in C#. 
//The Singleton pattern ensures that a class has only one instance and provides a global point of access to it.
public class PrivateConstr
{
    //private constructor to restrict the object creation
    private static PrivateConstr Singleton_instance;
    private PrivateConstr()
    {
        Console.WriteLine("Private Constructor created");

    }
    //method to get the instance of the class
    public static PrivateConstr GetInstance()
    {
        if (Singleton_instance == null)
        {
            Singleton_instance = new PrivateConstr();
        }
        return Singleton_instance;
    }

}
