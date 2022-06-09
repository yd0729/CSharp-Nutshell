// The content of a value type variable or constant is simply a value. 
// You can define a custom value type with the struct keyword:

using Demo;

var p1 = new Point { X = 7, Y = 8 };
var p2 = p1;             // Assignment causes copy

Console.WriteLine ($"{p1.X} {p1.Y}");  // 7
Console.WriteLine ($"{p2.X} {p2.Y}");  // 7

p1.X = 9;                  // Change p1.X
p1.Y = 10;

Console.WriteLine ($"{p1.X} {p1.Y}");  // 9
Console.WriteLine ($"{p2.X} {p2.Y}");  // 7

namespace Demo
{
    public struct Point {
        public int X;
        public int Y;
    }
}