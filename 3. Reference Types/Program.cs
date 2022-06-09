// A reference type has two parts: an object and the reference to that object.

using Demo;

var p1 = new Point { X = 7, Y = 8 };

var p2 = p1;             // Copies p1 *reference*

Console.WriteLine ($"{p1.X} {p1.Y}");  // 7
Console.WriteLine ($"{p2.X} {p2.Y}");  // 7

p1.X = 9;                  // Change p1.X
p1.Y = 10;

Console.WriteLine ($"{p1.X} {p1.Y}");  // 9
Console.WriteLine ($"{p2.X} {p2.Y}");  // 7

namespace Demo {
    public class Point {
        public int X;
        public int Y;
    }
}