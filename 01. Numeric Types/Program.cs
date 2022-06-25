// Numeric Types
{
    // The signed integral types are sbyte, short, int, long:
    int i = -1;

    // The unsigned integral types are byte, ushort, uint and ulong:
    byte b = 255;

    // The real types are float, double and decimal:
    double d = 1.23;

    // (See book for a table comparing each of the numeric types)
}

// Numeric Literals
{
    // Integral literals can use decimal or hexadecimal notation; hexadecimal is denoted with the 0x prefix:
    int x = 127;
    long y = 0x7F;

    //From C# 7, you can insert an underscore anywhere inside a numeric literal to make it more readable:
    int million = 1_000_000;

    //C# 7 also lets you specify numbers in binary with the 0b prefix:
    var b = 0b1010_1011_1100_1101_1110_1111;

    //Real literals can use decimal and/or exponential notation. For example:
    double d = 1.5;
    double doubleMillion = 1E06;

    // Numeric literal type inference:
    Console.WriteLine(1.0.GetType());  // Double  (double)
    Console.WriteLine(1E06.GetType());  // Double  (double)
    Console.WriteLine(1.GetType());  // Int32   (int)
    Console.WriteLine(0xF0000000.GetType());  // UInt32  (uint)
    Console.WriteLine(0x100000000.GetType());  // Int64   (long)
}

// Numeric Suffixes
{
    // Numeric literals can be suffixed with a character to indicate their type:
    //   F = float
    //   D = double
    //   M = decimal
    //   U = uint
    //   L = long
    //   UL = ulong

    long i = 5;     // No suffix needed: Implicit lossless conversion from int literal to long

    // The D suffix is redundant in that all literals with a decimal point are inferred to be double:
    double x = 4.0;

    // The F and M suffixes are the most useful:
    float f = 4.5F;         // Will not compile without the F suffix
    decimal d = -1.23M;		// Will not compile without the M suffix.
}