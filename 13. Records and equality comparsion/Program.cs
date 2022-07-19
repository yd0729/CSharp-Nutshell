var p1 = new Point(1, 2);
var p2 = new Point(1, 2);
Console.WriteLine(p1.Equals(p2)); // True
Console.WriteLine(p1 == p2); // True

internal record Point(double X, double Y);