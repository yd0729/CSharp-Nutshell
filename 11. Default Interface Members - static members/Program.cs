ILogger.Prefix = "File log: ";

var logger = new Logger();  
((ILogger)logger).Log ("message");

interface ILogger
{
    void Log (string text) =>
        Console.WriteLine (Prefix + text);

    static string Prefix = "";
}

class Logger : ILogger
{
    // We don't need to implement anything
}

// Practices:
// 1. Use classes and subclasses for types that naturally share an implementation.
// 2. Use interfaces for types that have independent implementations.
// 把能共享实现的部分放到类和子类中，把独立实现的部分放到接口中．