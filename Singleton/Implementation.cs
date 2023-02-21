namespace DesignPattern;
//Creational design pattern - ensure that the class only has one instance and provide global point of access to it
// Most common for logger
//Not used often since it's violate single responsibility principle (have two responsibility: create object and manage lifecycle)
public class Logger
{
    //with lazy
    private static readonly Lazy<Logger> _lazyLogger = new Lazy<Logger>(() => new Logger());
    //private static Logger? _instance;

    /// <summary>
    /// static instance property
    /// </summary>
    public static Logger Instance => _lazyLogger.Value; //=> _instance ??= new Logger();

    //or
    // get
    // {
    //     if (_instance == null)
    //     {
    //         _instance = new Logger();
    //     }
    //
    //     return _instance;
    // }
    protected Logger()
    {
        
    }

    public void Log(string message)
    {
        Console.WriteLine($"Message to log {message}");
    }
}