// The nint and unint native-sized integer types are sized to match the address space
// of the processor and operating system at runtime (in practice, 32 or 64 bits).

// Native-sized integers behave much like standard integers, with support
// for arithmetic operations, overflow check operators, and so on:

nint x = 123;
nint y = 234;
checked
{
    nint sum = x + y, product = x * y;
    Console.WriteLine(product);
}

// You can implicitly convert between nint/unint and IntPtr/UIntPtr:

IntPtr p = x;
y = p;

// Full arithmetic is supported *only* with nint/unint, so the following does not compile:
// (p * p).Dump();

var ip = IntPtr.MaxValue;

checked
{
    // IntPtr's arithmetic supports allows only adding/substracting an offset.
    // And it's always unchecked!
    Console.WriteLine(ip + 1);

    // Whereas nint/nuint honor checked blocks:
    try
    {
        Console.WriteLine((nint)ip + 1);
    }
    catch (OverflowException)
    {
        Console.WriteLine("Safe");
    }
}