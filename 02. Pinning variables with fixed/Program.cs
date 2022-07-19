// Value types declared inline within reference types require the reference type to be pinned:

var test = new Test();
unsafe
{
    fixed (int* p = &test.X) // Pins test
    {
        *p = 9;
    }

    Console.WriteLine(test.X);
}

internal class Test
{
    public int X;
}