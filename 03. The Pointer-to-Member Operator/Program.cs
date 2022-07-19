// In addition to the & and * operators, C# also provides the C++ style -> operator,
// which can be used on structs:

var test = new Test();
unsafe
{
    var p = &test;
    p->X = 9;
    Console.WriteLine(test.X);
}

internal struct Test
{
    public int X;
}