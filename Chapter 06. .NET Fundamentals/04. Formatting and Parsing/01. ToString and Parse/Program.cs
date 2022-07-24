using System.Globalization;

// The simplest formatting mechanism is the ToString method.
string s = true.ToString();
Console.WriteLine(s);

// Parse does the reverse:
bool b = bool.Parse(s);
Console.WriteLine(b);

// TryParse avoids a FormatException in case of error:
int.TryParse("qwerty", out var i);
Console.WriteLine(i);
int.TryParse("123", out i);
Console.WriteLine(i);

if (int.TryParse("123", out int j))
{
    Console.WriteLine($"Use j: {j}");
}

bool validInt = int.TryParse("123", out int _);
Console.WriteLine("We don't care about the actual value so use discard.");
Console.WriteLine(validInt);

// Culture trap:
Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("de-DE"); // Germany
Console.WriteLine("Parsing 1.234");
Console.WriteLine(double.Parse("1.234")); // 1234 

// Specifying invariant culture fixes this:
Console.WriteLine("Parsing 1.234 Invariantly");
Console.WriteLine(double.Parse("1.234", CultureInfo.InvariantCulture));

Console.WriteLine("1.234.ToString()"); // Germany
Console.WriteLine(1.234);
Console.WriteLine("1.234.ToString Invariant");
Console.WriteLine(1.234.ToString(CultureInfo.InvariantCulture));