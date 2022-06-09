﻿// Structs take up as much room as their fields:

namespace Storage_Overhead;

internal static class Program
{
    static unsafe void Main()  // 需要在 csproj 中添加 <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
    {
        Console.WriteLine(sizeof(Point)); // 8 bytes
        Console.WriteLine(sizeof(A)); // 16 bytes
    }
}

struct Point
{
    int x;  // 4 bytes
    int y;  // 4 bytes
}

// However, the CLR requires that fields are offset within the type at an address
// that’s a multiple of their size:
struct A
{
    byte b;  // 1 byte
    long l;  // 8 bytes
}