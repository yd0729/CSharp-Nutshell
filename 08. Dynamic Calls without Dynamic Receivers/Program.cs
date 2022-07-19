// You can also call statically known functions with dynamic arguments.
// Such calls are subject to dynamic overload resolution:

internal class Program
{
    private static void Foo(int x)
    {
        Console.WriteLine("1");
    }

    private static void Foo(string x)
    {
        Console.WriteLine("2");
    }

    private static void Main()
    {
        dynamic x = 5;
        dynamic y = "watermelon";

        Foo(x); // 1
        Foo(y); // 2
        // Foo(x, x);              // Compiler error - wrong number of parameters
        // Fook(x);                // Compiler error - no such method name
    }
}