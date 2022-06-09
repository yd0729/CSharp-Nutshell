// By default, integral arithmetic operations overflow silently:

var a = int.MinValue;

Console.WriteLine(a);
Console.WriteLine(--a);
Console.WriteLine(a == int.MaxValue);  // True