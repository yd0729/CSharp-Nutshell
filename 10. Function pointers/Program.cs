unsafe
{
    delegate*<string, int> functionPointer = &GetLength;
    int length = functionPointer("Hello, world");
    Console.WriteLine(length);
    Console.WriteLine((IntPtr)functionPointer);

    // Don't try this at home!
    var pointer2 = (delegate*<string, decimal>)(IntPtr)functionPointer;
    Console.WriteLine((IntPtr)pointer2);

    static int GetLength(string s) => s.Length;
}