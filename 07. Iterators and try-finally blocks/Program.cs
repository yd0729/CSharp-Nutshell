// A yield return statement cannot appear in a try block that has a catch clause.
// You can, however, yield within a try block that has (only) a finally block:

foreach (string s in Foo())
{
    Console.WriteLine(s);
}

Console.WriteLine();

foreach (string s in Foo())
{
    Console.WriteLine("First element is " + s);
    break;
}

IEnumerable<string> Foo()
{
    try
    {
        yield return "One";
        yield return "Two";
        yield return "Three";
    }
    finally
    {
        Console.WriteLine("Finally");
    }
}