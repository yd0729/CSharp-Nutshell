// Multiple yield statements are permitted:

foreach (string s in Foo())
{
    Console.WriteLine(s); // Prints "One","Two","Three"
}

IEnumerable<string> Foo()
{
    yield return "One";
    yield return "Two";
    yield return "Three";
}