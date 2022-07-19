internal class Program
{
    // Static types are also used — wherever possible — in dynamic binding:
    // Note: the following sometimes throws a RuntimeBinderException in Framework 4.0 beta 2. This is a bug.

    private static void Foo(object x, object y)
    {
        Console.WriteLine("oo");
    }

    private static void Foo(object x, string y)
    {
        Console.WriteLine("os");
    } // ✓

    private static void Foo(string x, object y)
    {
        Console.WriteLine("so");
    }

    private static void Foo(string x, string y)
    {
        Console.WriteLine("ss");
    }

    private static void Main()
    {
        object o = "hello";
        dynamic d = "goodbye";
        Foo(o, d); // os
    }
}