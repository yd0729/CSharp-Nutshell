// Memory can be allocated in a block on the stack explicitly using the stackalloc keyword:

unsafe
{
    var a = stackalloc int[10];
    for (var i = 0; i < 10; ++i)
        Console.WriteLine(a[i]); // Print raw memory
}