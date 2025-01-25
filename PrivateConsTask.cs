namespace day2;

public class Logger
{
    //private constructor
    private Logger()
    {
        Console.WriteLine("Logger initialized");
    }

    //static field to hold the instance of Logger class
    private static Logger _instance;

    //static method to get the instance of Logger class
    public static Logger GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Logger();
        }
        return _instance;
    }

    //method to log messages
    public void LogMessage(string message)
    {
        Console.WriteLine(message);
    }
    
}
